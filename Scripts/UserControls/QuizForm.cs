using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizForge.Scripts;
using QuizForge.Scripts.Forms;

namespace QuizForge
{
    public partial class QuizForm : UserControl {
        public MainWindow.ActionBtnHandler ActionBtnClickHandler;
        private List<QuestionField> questionFields = new();

        private readonly int TITLE_MIN_LENGTH = Settings.QUIZ_FORM_TITLE_MIN_LENGTH;
        private readonly int TITLE_MAX_LENGTH = Settings.QUIZ_FORM_TITLE_MAX_LENGTH;
        private readonly int DESCRIPTION_MIN_LENGTH = Settings.QUIZ_FORM_DESCRIPTION_MIN_LENGTH;
        private readonly int DESCRIPTION_MAX_LENGTH = Settings.QUIZ_FORM_DESCRIPTION_MAX_LENGTH;

        private ActionBtnMode actionBtnMode;

        public enum ActionBtnMode { 
            CreateQuiz,
            SaveQuiz
        }

        public QuizForm() {
            this.InitializeComponent();

            titleInput.MaxLength = TITLE_MAX_LENGTH;
            descriptionInput.MaxLength = DESCRIPTION_MAX_LENGTH;
        }

        public void Setup(ActionBtnMode mode, MainWindow.ActionBtnHandler ActionBtnFunction) {
            switch (mode) {
                case ActionBtnMode.CreateQuiz: actionButton.Text = "Create Quiz"; break;
                case ActionBtnMode.SaveQuiz: actionButton.Text = "Save Quiz"; break;
            }

            ActionBtnClickHandler = ActionBtnFunction;

            actionBtnMode = mode;
        }

        public bool Correct() {
            // Title is too short
            if (titleInput.Text.Length < TITLE_MIN_LENGTH) {
                MessageManager.NewWindow("Quiz Form Error", $"Required title length: [{TITLE_MIN_LENGTH}, {TITLE_MAX_LENGTH}] characters", [new("OK", null)]);
                return false;
                
            }
            // Trying to create a quiz with a title that already exists
            else if (actionBtnMode == ActionBtnMode.CreateQuiz && MainWindow.GetQuizzes().Find(quiz => quiz.title == titleInput.Text) != null) {
                MessageManager.NewWindow("Quiz Form Error", $"Quiz with this name already exists", [new("OK", null)]);
                return false;
            }

            // Description is too short
            if (descriptionInput.Text.Length < DESCRIPTION_MIN_LENGTH) {
                MessageManager.NewWindow("Quiz Form Error", $"Required description length: [{DESCRIPTION_MIN_LENGTH}, {DESCRIPTION_MAX_LENGTH}] characters", [new("OK", null)]);
                return false;
            }

            // Check question fields
            foreach (QuestionField questionField in questionFields) {
                if (!questionField.Correct()) {
                    return false;
                }
            }
            return true;
        }

        public Quiz GetQuizObj() {
            string title = titleInput.Text;
            string description = descriptionInput.Text;

            List<Question> questions = new();

            foreach (QuestionField questionField in questionFields) {
                questions.Add(questionField.GetQuestionObj());
            }

            return new Quiz(title, description, questions);
        }

        private QuestionField AddQuestionField() {
            QuestionField questionField = new();

            questionPanel.Controls.Add(questionField);
            questionFields.Add(questionField);

            // Listen to delete event
            questionField.OnDeleteQuestionBtnClick += DeleteQuestionField;

            return questionField;
        }

        private void DeleteQuestionField(object? sender, QuestionField.OnDeleteQuestionBtnClickEventArgs e) {
            questionFields.Remove(e.questionField);
            this.Controls.Remove(e.questionField);
            e.questionField.Dispose();
            e.questionField = null;
        }

        /// <summary>
        /// Fills inputs with data from quiz object
        /// </summary>
        public void Fill(Quiz quiz) {
            titleInput.Text = quiz.title;
            descriptionInput.Text = quiz.description;

            foreach (Question question in quiz.questions) {
                QuestionField newQuestionField = this.AddQuestionField();

                newQuestionField.Fill(question);
            }
        }

        public void Clear() {
            titleInput.Text = "";
            descriptionInput.Text = "";

            questionFields.Clear();
            questionPanel.Controls.Clear();
        }

        private void actionButton_Click(object sender, EventArgs e) {
            ActionBtnClickHandler?.Invoke(this);
        }

        private void clearFieldsButton_Click(object sender, EventArgs e) {
            this.Clear();
        }

        private void addQuestionButton_Click(object sender, EventArgs e) {
            QuestionField newQuestionField = AddQuestionField();
            newQuestionField.AddInitialAnswers();
        }
    }
}
