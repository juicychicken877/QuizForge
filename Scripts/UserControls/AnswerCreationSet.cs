using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizForge.Scripts.UserControls
{
    public partial class AnswerCreationSet : UserControl
    {
        public event EventHandler OnCorrectAnswerChange;
        public event EventHandler<OnDeleteAnswerBtnClickEventArgs> OnDeleteAnswerBtnClick;

        public class OnDeleteAnswerBtnClickEventArgs : EventArgs
        {
            public AnswerCreationSet answerSet;
        }
        public string answer { get { return answerInput.Text; } set { answerInput.Text = value; } }
        public bool isCorrect { get { return correctAnswerInput.Checked; } set { correctAnswerInput.Checked = value; } }

        public AnswerCreationSet()
        {
            this.InitializeComponent();
        }
        public bool Correct()
        {
            return answer != "";
        }

        private void correctAnswerInput_CheckedChanged(object sender, EventArgs e)
        {
            OnCorrectAnswerChange?.Invoke(this, EventArgs.Empty);
        }

        private void deleteAnswerSetBtn_Click(object sender, EventArgs e)
        {
            OnDeleteAnswerBtnClick?.Invoke(this, new OnDeleteAnswerBtnClickEventArgs() { answerSet = this }); ;
        }
    }
}
