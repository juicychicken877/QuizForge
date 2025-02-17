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
        public event EventHandler OnAnswerButtonClicked;
        public string text { get { return answer.Text; } set { answer.Text = value; } }

        public enum AnswerButtonMode {
            Default,
            Selected,
            AnswerCorrect,
            AnswerIncorrect,
        }

        private Color defaultBackColor = Color.WhiteSmoke;
        private Color selectedBackColor = Color.LightBlue;
        private Color correctBackColor = Color.LightGreen;
        private Color incorrectBackColor = Color.FromArgb(242, 65, 65);

        public AnswerButton() {
            InitializeComponent();
        }

        public void ChangeAnswerButtonMode(AnswerButtonMode mode) {
            switch (mode) {
                case AnswerButtonMode.Default: this.BackColor = defaultBackColor; break;
                case AnswerButtonMode.Selected: this.BackColor = selectedBackColor; break;
                case AnswerButtonMode.AnswerCorrect: this.BackColor = correctBackColor; break;
                case AnswerButtonMode.AnswerIncorrect: this.BackColor = incorrectBackColor; break;
            }
        }

        private void answer_Click(object sender, EventArgs e) {
            OnAnswerButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
