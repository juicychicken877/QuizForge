using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMakerTaker.Scripts.Forms
{
    public partial class AnswerListElement: UserControl
    {
        private readonly Color correctBackColor = Color.LightGreen;
        private readonly Color incorrectBackColor = Color.FromArgb(242, 65, 65);

        public AnswerListElement(string question, SolveTestWindow.UserAnswer userAnswer)
        {
            InitializeComponent();

            questionLabel.Text = question;
            userAnswerLabel.Text = $"Your answer: {userAnswer.answer}";
            correctAnswerLabel.Text = $"Correct answer: {userAnswer.correctAnswer}";

            if (userAnswer.IsCorrect()) {
                this.BackColor = correctBackColor;
            } else {
                this.BackColor = incorrectBackColor;
            }
        }
    }
}
