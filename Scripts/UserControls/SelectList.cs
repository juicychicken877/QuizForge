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
    public partial class SelectList : UserControl {
        public SelectList() {
            this.InitializeComponent();
        }
        public void Update(List<Quiz>? quizzes) {
            this.Clear();

            if (quizzes != null) {
                selectAllCheckBox.Enabled = true;

                foreach (Quiz quiz in quizzes) {
                    SelectableListElement newListElement = new(quiz);

                    panel.Controls.Add(newListElement);
                }

            }
        }

        public List<Quiz> GetSelectedQuizzes() {
            List<Quiz> selectedQuizzes = new();

            foreach (SelectableListElement element in panel.Controls) {
                if (element.IsSelected())
                    selectedQuizzes.Add(element.quizRef);
            }

            return selectedQuizzes;
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (selectAllCheckBox.Checked == true) {
                this.ChangeSelectedAll(true);
            } else {
                this.ChangeSelectedAll(false);
            }
        }

        public void ChangeSelectedAll(bool selected) {
            selectAllCheckBox.Checked = selected;

            foreach (SelectableListElement element in panel.Controls) {
                element.ChangeSelected(selected);
            }
        }

        public void Clear() {
            panel.Controls.Clear();
            selectAllCheckBox.Checked = false;
            selectAllCheckBox.Enabled = false;
        }
    }
}
