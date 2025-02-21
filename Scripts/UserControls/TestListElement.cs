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

        public MainWindow.TestInteractionButtonHandler SolveButtonClickedHandler;
        public MainWindow.TestInteractionButtonHandler EditButtonClickedHandler;

        private Test testRef;

        public TestListElement(Test test) {
            InitializeComponent();

            testRef = test;
          
            title.Text = test.title;
            description.Text = test.description;
            questionCountLabel.Text = test.questions.Count.ToString();

            questionCountLabel.Text = test.questions.Count == 1 ? "1 question" : $"{test.questions.Count} questions";

            // disable solve button if test has 0 questions
            if (test.questions.Count == 0) {
                solveButton.Enabled = false;
            }
        }

        private void editButton_Click(object sender, EventArgs e) {
            EditButtonClickedHandler?.Invoke(testRef);
        }

        private void solveButton_Click(object sender, EventArgs e) {
            SolveButtonClickedHandler?.Invoke(testRef);
        }
    }
}
