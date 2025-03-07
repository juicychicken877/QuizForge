using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMakerTaker.Scripts.Forms
{
    public partial class ImportView : UserControl {
        public ImportView() {
            InitializeComponent();

            ImportExportHandler.OnImport += ImportExportHandler_OnImport;
        }

        private void ImportExportHandler_OnImport(object? sender, ImportExportHandler.OnImportEventArgs e) {
            selectList.Clear();
            selectedFileNameLabel.Text = "No file selected";
            importButton.Enabled = false;
        }

        private void Update(List<Test>? detectedTests, string fileName) {
            if (detectedTests != null) {
                importButton.Enabled = true;
            } else {
                MessageManager.NewWindow("Import View Error", "No tests found in selected file", [new MessageWindow.Button("OK", null)]);
                importButton.Enabled = false;
            }

            selectedFileNameLabel.Text = fileName;
            selectList.Update(detectedTests);
        }

        public void SelectAll() {
            selectList.ChangeSelectedAll(true);
        }

        public void SelectFile(string path) {
            List<Test> detectedTests = JSONHandler.LoadTestsFromJSON(path);

            Update(detectedTests, Path.GetFileName(path));
        }

        private void selectFileBtn_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new();

            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1; // Default to JSON filter
            openFileDialog.RestoreDirectory = true; //Remember the last used directory

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    string selectedFilePath = openFileDialog.FileName;

                    SelectFile(selectedFilePath);
                } catch (Exception ex) {
                    MessageManager.NewWindow("Import View Error", ex.Message, [new MessageWindow.Button("OK", null)]);
                }
            }
        }

        private void importButton_Click(object sender, EventArgs e) {
            List<Test> selectedTests = selectList.GetSelectedTests();

            if (selectedTests.Count == 0) {
                MessageManager.NewWindow("Import View Error", "No tests selected", [new MessageWindow.Button("OK", null)]);
            } else {
                if (ImportExportHandler.Collides(MainWindow.GetTests(), selectedTests)) {

                    List<MessageWindow.Button> buttons = [
                        new MessageWindow.Button("Add", () => { ImportExportHandler.ImportTests(ImportExportHandler.ImportMode.Add, selectedTests); }), 
                        new MessageWindow.Button("Override", () => { ImportExportHandler.ImportTests(ImportExportHandler.ImportMode.Override, selectedTests); })
                    ];

                    MessageManager.NewWindow("Import View Decision", "Found collisions with current tests. Choose import mode", buttons);
                } else {
                    // All good
                    ImportExportHandler.ImportTests(ImportExportHandler.ImportMode.Add, selectedTests);
                }
            }
        }
    }
}
