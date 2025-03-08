using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizForge.Scripts.Forms;

namespace QuizForge.Scripts
{
    public static class ImportExportHandler
    {
        public static event EventHandler<OnImportEventArgs> OnImport;
        public static event EventHandler OnExport;

        public enum ImportMode { 
            Add,
            Override
        }

        public class OnImportEventArgs : EventArgs {
            public List<Quiz> newQuizzes;
        }

        /// <summary>
        /// Adds quizzes from uniqueQuizzes to baseQuizzes if they are not in baseQuizzes
        /// </summary>
        private static List<Quiz> AddUnique(List<Quiz> baseQuizzes, List<Quiz> uniqueQuizzes) {
            List<Quiz> returnedQuizzes = baseQuizzes;

            foreach (Quiz uniqueQuiz in uniqueQuizzes) {
                // If uniqueQuiz not found in baseQuizzes, it is unique and it is added to baseQuizzes
                if (baseQuizzes.Find(baseQuiz => baseQuiz.title == uniqueQuiz.title) == null) {
                    returnedQuizzes.Add(uniqueQuiz);
                }
            }

            return returnedQuizzes;
        }

        public static void ExportQuizzes(List<Quiz> quizzesToExport) {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.FileName = $"quiz_export_{DateTime.Today.ToShortDateString()}.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                JSONHandler.SaveQuizzes(quizzesToExport, saveFileDialog.FileName);

                MessageManager.NewWindow("Import Export Handler Info", "Quizzes exported.", [new("OK", null)]);

                OnExport.Invoke(null, EventArgs.Empty);
            }
        }

        public static bool Collides(List<Quiz> list1, List<Quiz> list2) {
            foreach (Quiz quiz1 in list1) {
                if (list2.Find(quiz2 => quiz2.title == quiz1.title) != null) {
                    return true;
                }
            }

            return false;
        }

        public static void ExportQuiz(Quiz quizRef) {
            ExportQuizzes([quizRef]);
        }

        public static void ImportQuizzes(ImportMode mode, List<Quiz> newQuizzes) {
            try {
                switch (mode) {
                    case ImportMode.Override: {
                            newQuizzes = AddUnique(newQuizzes, MainWindow.GetQuizzes());
                        }
                        break;
                    case ImportMode.Add: {
                            newQuizzes = AddUnique(MainWindow.GetQuizzes(), newQuizzes);
                        }
                        break;
                }

                MessageManager.NewWindow("Import Export Handler Info", "Quizzes imported.", [new MessageWindow.Button("OK", null)]);

                OnImport?.Invoke(null, new OnImportEventArgs() {
                    newQuizzes = newQuizzes,
                });

            } catch (Exception ex) {
                MessageManager.NewWindow("Import Export Handler Error", ex.Message, [new MessageWindow.Button("OK", null)]);
            }
        }
    }
}
