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
        public event EventHandler<OnActionButtonClickedEventArgs> OnActionButtonClicked;

        public class OnActionButtonClickedEventArgs : EventArgs {
            public TestForm form { get; set; }
        }

        private List<QuestionField> questionFields = new();

        public enum ActionButtonMode {
            CreateTest,
            SaveTest
        }

        // Title limits
        private const int TEST_TITLE_MIN_LENGTH = 5;
        private const int TEST_TITLE_MAX_LENGTH = 50;
        // Description limits
        private const int TEST_DESCRIPTION_MAX_LENGTH = 200;

        public TextBox titleInputField {
            get { return titleInput; }
        }
        public TextBox descriptionInputField {
            get { return descriptionInput; }
        }

        public TestForm() {
            InitializeComponent();

            titleInputField.MaxLength = TEST_TITLE_MAX_LENGTH;
            descriptionInputField.MaxLength = TEST_DESCRIPTION_MAX_LENGTH;
        }

        public void ChangeActionButtonMode(ActionButtonMode mode) {
            if (mode == ActionButtonMode.CreateTest) {
                actionButton.Text = "Create Test";
            } else if (mode == ActionButtonMode.SaveTest) {
                actionButton.Text = "Save Test";
            }
        }

        public bool AllGoodAndCorrect() {
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
                if (!questionField.AllGoodAndCorrect()) {
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

        private QuestionField AddNewQuestionField() {
            QuestionField newQuestionField = new();

            questionPanel.Controls.Add(newQuestionField);

            questionFields.Add(newQuestionField);

            // Listen to delete event
            newQuestionField.OnDeleteQuestionButtonClicked += DeleteQuestionField;

            return newQuestionField;
        }

        private void DeleteQuestionField(object? sender, QuestionField.OnDeleteQuestionEventArgs e) {
            questionFields.Remove(e.questionField);
            this.Controls.Remove(e.questionField);
            e.questionField.Dispose();
            e.questionField = null;
        }

        public void FillInputsWithData(Test test) {
            titleInputField.Text = test.title;
            descriptionInput.Text = test.description;

            foreach (Question question in test.questions) {
                QuestionField newQuestionField = AddNewQuestionField();

                newQuestionField.FillInputsWithData(question);
            }
        }

        public void ClearFields() {
            titleInputField.Text = "";
            descriptionInputField.Text = "";

            questionFields.Clear();
            questionPanel.Controls.Clear();
        }

        private void actionButton_Click(object sender, EventArgs e) {
            OnActionButtonClicked?.Invoke(this, new OnActionButtonClickedEventArgs() {
                form = this
            });
        }

        private void clearFieldsButton_Click(object sender, EventArgs e) {
            ClearFields();
        }

        private void addQuestionButton_Click(object sender, EventArgs e) {
            AddNewQuestionField();
        }
    }
}
