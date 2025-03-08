using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizForge
{
    public partial class QuizForm : UserControl {
        public MainWindow.ActionBtnHandler ActionBtnClickHandler;
        private List<QuestionField> questionFields = new();

        private const int QUIZ_TITLE_MIN_LENGTH = 5;
        private const int QUIZ_TITLE_MAX_LENGTH = 50;
        private const int QUIZ_DESCRIPTION_MAX_LENGTH = 200;

        private ActionBtnMode actionBtnMode;

        public enum ActionBtnMode { 
            CreateQuiz,
            SaveQuiz
        }

        public QuizForm() {
            this.InitializeComponent();

            titleInput.MaxLength = QUIZ_TITLE_MAX_LENGTH;
            descriptionInput.MaxLength = QUIZ_DESCRIPTION_MAX_LENGTH;
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
            // Check if title has minimum length
            if (titleInput.Text.Length < QUIZ_TITLE_MIN_LENGTH) {
                errorProvider.SetError(titleInput, $"Title length must be >= {QUIZ_TITLE_MIN_LENGTH}");
                return false;
                
            }
            // Trying to create a quiz with a title that already exists
            else if (actionBtnMode == ActionBtnMode.CreateQuiz && MainWindow.GetQuizzes().Find(quiz => quiz.title == titleInput.Text) != null) {
                errorProvider.SetError(titleInput, "Quiz with this name already exists.");
                return false;
            }
            else {
                errorProvider.SetError(titleInput, null);
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
