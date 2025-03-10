using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizForge.Scripts.Forms
{
    public partial class AnswerListElement: UserControl
    {
        public AnswerListElement(string question, SolveQuizWindow.UserAnswer userAnswer)
        {
            this.InitializeComponent();

            questionLabel.Text = question;
            userAnswerLabel.Text = $"Your answer: {userAnswer.answer}";
            correctAnswerLabel.Text = $"Correct answer: {userAnswer.correctAnswer}";

            if (userAnswer.IsCorrect()) {
                this.BackColor = Settings.CORRECT_BUTTON_COLOR;
            } else {
                this.BackColor = Settings.INCORRECT_BUTTON_COLOR;
            }
        }
    }
}
