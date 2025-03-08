using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizForge.Scripts.UserControls
{
    public partial class SelectableListElement: UserControl
    {
        public Quiz quizRef { get; private set; }

        public SelectableListElement(Quiz quiz)
        {
            InitializeComponent();

            titleLabel.Text = quiz.title;
            descriptionLabel.Text = quiz.description;

            quizRef = quiz;
        }

        public void ChangeSelected(bool selected) {
            selectCheckBox.Checked = selected;
        }

        public bool IsSelected() {
            return selectCheckBox.Checked;
        }
    }
}
