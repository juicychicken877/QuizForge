using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMakerTaker.Scripts;

namespace TestMakerTaker
{
    public partial class AnswerButton : UserControl {
        public SolveTestWindow.AnswerButtonClickedHandler AnswerButtonClickedHandler;

        public enum AnswerButtonMode {
            Default,
            Selected,
            AnswerCorrect,
            AnswerIncorrect,
        }

        public AnswerButton(string ans) {
            InitializeComponent();

            answer.Text = ans;
        }

        public string GetAnswer() {
            return answer.Text;
        }


        public void ChangeAnswerButtonMode(AnswerButtonMode mode) {
            switch (mode) {
                case AnswerButtonMode.Default: this.BackColor = Support.DEFAULT_BUTTON_COLOR; break;
                case AnswerButtonMode.Selected: this.BackColor = Support.SELECTED_BUTTON_COLOR; break;
                case AnswerButtonMode.AnswerCorrect: this.BackColor = Support.CORRECT_BUTTON_COLOR; break;
                case AnswerButtonMode.AnswerIncorrect: this.BackColor = Support.INCORRECT_BUTTON_COLOR; break;
            }
        }

        private void answer_Click(object sender, EventArgs e) {
            AnswerButtonClickedHandler?.Invoke(this);
        }
    }
}
