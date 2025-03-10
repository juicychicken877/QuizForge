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

namespace QuizForge
{
    public partial class AnswerBtn : UserControl {
        public SolveQuizWindow.AnswerBtnClickHandler AnswerBtnClickHandler;

        public enum AnswerBtnMode {
            Default,
            Selected,
            Correct,
            Incorrect,
        }

        public AnswerBtn(string ans) {
            this.InitializeComponent();

            answer.Text = ans;
        }

        public string GetAnswer() {
            return answer.Text;
        }


        public void ChangeAnswerBtnMode(AnswerBtnMode mode) {
            switch (mode) {
                case AnswerBtnMode.Default: this.BackColor = Settings.DEFAULT_BUTTON_COLOR; break;
                case AnswerBtnMode.Selected: this.BackColor = Settings.SELECTED_BUTTON_COLOR; break;
                case AnswerBtnMode.Correct: this.BackColor = Settings.CORRECT_BUTTON_COLOR; break;
                case AnswerBtnMode.Incorrect: this.BackColor = Settings.INCORRECT_BUTTON_COLOR; break;
            }
        }

        private void answer_Click(object sender, EventArgs e) {
            AnswerBtnClickHandler?.Invoke(this);
        }
    }
}
