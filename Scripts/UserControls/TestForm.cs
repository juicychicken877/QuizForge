using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMakerTaker
{
    public partial class TestForm : UserControl {
        public MainWindow.ActionButtonHandler ActionButtonClickedHandler;
        private List<QuestionField> questionFields = new();

        private const int TEST_TITLE_MIN_LENGTH = 5;
        private const int TEST_TITLE_MAX_LENGTH = 50;
        private const int TEST_DESCRIPTION_MAX_LENGTH = 200;

        public enum ActionButtonMode { 
            CreateTest,
            SaveTest
        }


        public TestForm() {
            InitializeComponent();

            titleInput.MaxLength = TEST_TITLE_MAX_LENGTH;
            descriptionInput.MaxLength = TEST_DESCRIPTION_MAX_LENGTH;
        }

        public void Setup(ActionButtonMode mode, MainWindow.ActionButtonHandler ActionButtonFunction) {
            switch (mode) {
                case ActionButtonMode.CreateTest: actionButton.Text = "Create Test"; break;
                case ActionButtonMode.SaveTest: actionButton.Text = "Save Test"; break;
            }
            ActionButtonClickedHandler = ActionButtonFunction;
        }

        public bool Correct() {
            // Checks if all information in inputs is correct
            // Check title
            if (titleInput.Text.Length >= TEST_TITLE_MIN_LENGTH) {
                errorProvider.SetError(titleInput, null);
            } else {
                string error = $"Title length must be >= {TEST_TITLE_MIN_LENGTH}";
                errorProvider.SetError(titleInput, error);
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

        public Test GetTestObject() {
            string title = titleInput.Text;
            string description = descriptionInput.Text;

            List<Question> questions = new();

            foreach (QuestionField questionField in questionFields) {
                questions.Add(questionField.GetQuestionObject());
            }

            return new Test(title, description, questions);
        }

        private QuestionField AddQuestionField() {
            QuestionField questionField = new();

            questionPanel.Controls.Add(questionField);
            questionFields.Add(questionField);

            // Listen to delete event
            questionField.OnDeleteQuestionButtonClicked += DeleteQuestionField;

            return questionField;
        }

        private void DeleteQuestionField(object? sender, QuestionField.OnDeleteQuestionEventArgs e) {
            questionFields.Remove(e.questionField);
            this.Controls.Remove(e.questionField);
            e.questionField.Dispose();
            e.questionField = null;
        }

        public void FillInputsWithData(Test test) {
            titleInput.Text = test.title;
            descriptionInput.Text = test.description;

            foreach (Question question in test.questions) {
                QuestionField newQuestionField = AddQuestionField();

                newQuestionField.FillInputsWithData(question);
            }
        }

        public void ClearFields() {
            titleInput.Text = "";
            descriptionInput.Text = "";

            questionFields.Clear();
            questionPanel.Controls.Clear();
        }

        private void actionButton_Click(object sender, EventArgs e) {
            ActionButtonClickedHandler?.Invoke(this);
        }

        private void clearFieldsButton_Click(object sender, EventArgs e) {
            ClearFields();
        }

        private void addQuestionButton_Click(object sender, EventArgs e) {
            QuestionField newQuestionField = AddQuestionField();
            newQuestionField.AddInitialAnswerSets();
        }
    }
}
