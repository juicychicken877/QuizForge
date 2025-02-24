using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMakerTaker.Scripts
{
    public static class ImportExportHandler
    {
        public static event EventHandler<OnImportEventArgs> OnImport;

        public enum ImportMode { 
            Add,
            Override
        }

        public class OnImportEventArgs : EventArgs {
            public List<Test> testsToImport;
            public ImportMode importMode;
        }

        public static void ExportTests(List<Test> testsToExport) {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.FileName = "testsExport.json"; // Default filename

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                JSONHandler.SaveTestsToJSON(testsToExport, saveFileDialog.FileName);
            }
        }

        public static void ExportTest(Test testRef) {
            ExportTests(new List<Test>() { testRef });
        }

        public static void ImportTests(ImportMode mode, string path) {
            try {
                List<Test> newTests = new();
               
                if (mode == ImportMode.Override) {
                    List<Test> currTests = MainWindow.GetTests();
                    newTests = JSONHandler.LoadTestsFromJSON(path);

                    foreach (Test test in currTests) {
                        if (newTests.Find(newTest => newTest.title == test.title) == null) {
                            newTests.Add(test);
                        }
                    }

                } else if (mode == ImportMode.Add) {
                    newTests = JSONHandler.LoadTestsFromJSON(path);
                }

                OnImport?.Invoke(null, new OnImportEventArgs() {
                    testsToImport = newTests,
                    importMode = mode
                });

            } catch (Exception ex) {
                MessageManager.NewErrorWindow("Import Export Handler Error", ex.Message, null);
            }
        }
    }
}
