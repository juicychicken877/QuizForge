using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizForge.Scripts.Forms
{
    public partial class ImportView : UserControl {
        public ImportView() {
            this.InitializeComponent();

            ImportExportHandler.OnImport += ImportExportHandler_OnImport;
        }

        private void ImportExportHandler_OnImport(object? sender, ImportExportHandler.OnImportEventArgs e) {
            selectList.Clear();
            selectedFileNameLabel.Text = "No file selected";
            importButton.Enabled = false;
        }

        private void Update(List<Quiz>? detectedQuizzes, string selectedFileName) {
            if (detectedQuizzes != null) {
                importButton.Enabled = true;
            } else {
                MessageManager.NewWindow("Import View Error", "No quizzes found in selected file", [new MessageWindow.Button("OK", null)]);
                importButton.Enabled = false;
            }

            selectedFileNameLabel.Text = selectedFileName;
            selectList.Update(detectedQuizzes);
        }

        public void SelectAll() {
            selectList.ChangeSelectedAll(true);
        }

        public void SelectFile(string path) {
            List<Quiz> detectedQuizzes = JSONHandler.LoadQuizzes(path);

            this.Update(detectedQuizzes, Path.GetFileName(path));
        }

        private void selectFileBtn_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new();

            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1; // Default to JSON filter
            openFileDialog.RestoreDirectory = true; //Remember the last used directory

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    string selectedFilePath = openFileDialog.FileName;

                    this.SelectFile(selectedFilePath);
                } catch (Exception ex) {
                    MessageManager.NewWindow("Import View Error", ex.Message, [new MessageWindow.Button("OK", null)]);
                }
            }
        }

        private void importButton_Click(object sender, EventArgs e) {
            List<Quiz> selectedQuizzes = selectList.GetSelectedQuizzes();

            if (selectedQuizzes.Count == 0) {
                MessageManager.NewWindow("Import View Error", "No quizzes selected", [new MessageWindow.Button("OK", null)]);
            } else {
                if (ImportExportHandler.Collides(MainWindow.GetQuizzes(), selectedQuizzes)) {

                    List<MessageWindow.Button> buttons = [
                        new MessageWindow.Button("Add", () => { ImportExportHandler.ImportQuizzes(ImportExportHandler.ImportMode.Add, selectedQuizzes); }), 
                        new MessageWindow.Button("Override", () => { ImportExportHandler.ImportQuizzes(ImportExportHandler.ImportMode.Override, selectedQuizzes); })
                    ];

                    MessageManager.NewWindow("Import View Decision", "Found collisions with current quizzes. Choose import mode", buttons);
                } else {
                    // All good
                    ImportExportHandler.ImportQuizzes(ImportExportHandler.ImportMode.Add, selectedQuizzes);
                }
            }
        }
    }
}
