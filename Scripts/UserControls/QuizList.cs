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
using QuizForge.Scripts.Forms;
using QuizForge.Scripts.Windows;

namespace QuizForge
{
    public partial class QuizList : UserControl {
        public MainWindow.QuizInteractionBtnHandler SolveBtnClickHandler;
        public MainWindow.QuizInteractionBtnHandler ExportBtnClickHandler;
        public MainWindow.QuizInteractionBtnHandler EditBtnClickHandler;

        public QuizList() {
            this.InitializeComponent();
        }
        public void Update(List<Quiz> quizzes) {
            // Clear list
            panel.Controls.Clear();

            foreach (Quiz quiz in quizzes) {
                // Create new element for each quiz
                QuizListElement newElement = new(quiz);

                newElement.EditBtnClickHandler += EditBtnClickHandler;
                newElement.SolveBtnClickHandler += SolveBtnClickHandler;
                newElement.ExportBtnClickHandler += ExportBtnClickHandler;

                panel.Controls.Add(newElement);
            }
        }

        private void importExampleQuizzes_Click(object sender, EventArgs e) {
            ImportWindow newImportWindow = new(Settings.EXAMPLE_QUIZZES_FILE_PATH, true);

            newImportWindow.ShowDialog();
        }

        private void exportAllQuizzes_Click(object sender, EventArgs e) {
            if (MainWindow.GetQuizzes().Count > 0) {
                ExportWindow newExportWindow = new(MainWindow.GetQuizzes(), true);

                newExportWindow.ShowDialog();
            } else {
                MessageManager.NewWindow("Export View Error", "No quizzes found", [new MessageWindow.Button("OK", null)]);
            }

        }
    }
}
