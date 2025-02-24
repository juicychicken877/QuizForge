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
    public partial class AnswerButton : UserControl {
        public SolveTestWindow.AnswerButtonClickedHandler AnswerButtonClickedHandler;

        private readonly Color DEFAULT_COLOR = Color.WhiteSmoke;
        private readonly Color SELECTED_COLOR = Color.LightBlue;
        private readonly Color CORRECT_COLOR = Color.LightGreen;
        private readonly Color INCORRECT_COLOR = Color.FromArgb(242, 65, 65);

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
                case AnswerButtonMode.Default: this.BackColor = DEFAULT_COLOR; break;
                case AnswerButtonMode.Selected: this.BackColor = SELECTED_COLOR; break;
                case AnswerButtonMode.AnswerCorrect: this.BackColor = CORRECT_COLOR; break;
                case AnswerButtonMode.AnswerIncorrect: this.BackColor = INCORRECT_COLOR; break;
            }
        }

        private void answer_Click(object sender, EventArgs e) {
            AnswerButtonClickedHandler?.Invoke(this);
        }
    }
}
