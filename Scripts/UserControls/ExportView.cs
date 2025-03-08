using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizForge.Scripts.Forms;

namespace QuizForge.Scripts.UserControls
{
    public partial class ExportView : UserControl {
        public ExportView() {
            this.InitializeComponent();

            ImportExportHandler.OnExport += ImportExportHandler_OnExport;
        }

        private void ImportExportHandler_OnExport(object? sender, EventArgs e) {
            selectList.ChangeSelectedAll(false);
        }

        public void Update(List<Quiz> quizzes) {
            if (quizzes.Count == 0) {
                exportButton.Enabled = false;
            } else {
                exportButton.Enabled = true;
            }
            selectList.Update(quizzes);
        }

        public void SelectAll() {
            selectList.ChangeSelectedAll(true);
        }

        private void exportButton_Click(object sender, EventArgs e) {
            List<Quiz> selectedQuizzes = selectList.GetSelectedQuizzes();

            if (selectedQuizzes.Count == 0) {
                MessageManager.NewWindow("Export View Error", "No quizzes selected", [new MessageWindow.Button("OK", null)]);
            } else {
                ImportExportHandler.ExportQuizzes(selectedQuizzes);
            }
        }
    }
}
