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
    public partial class QuizListElement : UserControl {

        public MainWindow.QuizInteractionBtnHandler SolveBtnClickHandler;
        public MainWindow.QuizInteractionBtnHandler ExportBtnClickHandler;
        public MainWindow.QuizInteractionBtnHandler EditBtnClickHandler;

        private Quiz quizRef;

        public QuizListElement(Quiz quiz) {
            this.InitializeComponent();

            quizRef = quiz;

            titleLabel.Text = quiz.title;
            descriptionLabel.Text = quiz.description;
            questionCountLabel.Text = quiz.questions.Count == 1 ? "1 question" : $"{quiz.questions.Count} questions";

            // Disable solve button if quiz has 0 questions
            if (quiz.questions.Count == 0) {
                solveBtn.Enabled = false;
            }
        }

        private void editBtn_Click(object sender, EventArgs e) {
            EditBtnClickHandler?.Invoke(quizRef);
        }

        private void solveBtn_Click(object sender, EventArgs e) {
            SolveBtnClickHandler?.Invoke(quizRef);
        }

        private void exportBtn_Click(object sender, EventArgs e) {
            ExportBtnClickHandler?.Invoke(quizRef);
        }
    }
}
