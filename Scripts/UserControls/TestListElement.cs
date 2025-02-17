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
    public partial class TestListElement : UserControl {
        public event EventHandler<OnInteractionButtonClickedEventArgs> OnEditButtonClicked;
        public event EventHandler<OnInteractionButtonClickedEventArgs> OnSolveButtonClicked;

        public class OnInteractionButtonClickedEventArgs : EventArgs {
            public Test test { get; set; }
        }

        private Test testObject;
        public string testTitle {
            get {
                return this.title.Text;
            }
            set {
                this.title.Text = value;
            }
        }

        public string testDescription {
            get {
                return this.description.Text;
            }
            set {
                this.description.Text = value;
            }
        }

        public TestListElement(Test test) {
            InitializeComponent();

            testObject = test;

            testDescription = test.description;
            testTitle = test.title;

            int questionListLength = test.questions.Count;
            questionCountLabel.Text = questionListLength == 1 ? "1 question" : $"{questionListLength} questions";

            // disable solve button if test has 0 questions
            if (questionListLength == 0) {
                solveButton.Enabled = false;
            }
        }

        private void editButton_Click(object sender, EventArgs e) {
            OnEditButtonClicked?.Invoke(this, new OnInteractionButtonClickedEventArgs() {
                test = testObject
            });
        }

        private void solveButton_Click(object sender, EventArgs e) {
            OnSolveButtonClicked?.Invoke(this, new OnInteractionButtonClickedEventArgs() {
                test = testObject
            });
        }
    }
}
