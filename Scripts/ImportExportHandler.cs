using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMakerTaker.Scripts.Forms;

namespace TestMakerTaker.Scripts
{
    public static class ImportExportHandler
    {
        public static event EventHandler<OnImportEventArgs> OnImport;
        public static event EventHandler OnExport;

        public enum ImportMode { 
            /// <summary>
            /// Importing with Add Import Mode returns a list of tests to add to current test list
            /// </summary>
            Add,
            /// <summary>
            /// Importing with Override Import mode returns a list of tests
            /// </summary>
            Override
        }

        public class OnImportEventArgs : EventArgs {
            public List<Test> newTestList;
        }

        public static void ExportTests(List<Test> testsToExport) {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.FileName = "testsExport.json"; // Default filename

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                JSONHandler.SaveTestsToJSON(testsToExport, saveFileDialog.FileName);

                MessageManager.NewWindow("Import Export Handler Info", "Tests exported.", [new MessageWindow.Button("OK", null)]);

                OnExport.Invoke(null, EventArgs.Empty);
            }
        }

        private static List<Test> Override(List<Test> currTests, List<Test> newTests) {
            List<Test> tests = newTests;
            // If newTest collides with currTest then currTest is overriden
            foreach (Test test in currTests) {
                // If test not found in newTests then add otherwise do not
                if (newTests.Find(newTest => newTest.title == test.title) == null) {
                    tests.Add(test);
                }
            }

            return tests;
        }

        private static List<Test> Add(List<Test> currTests, List<Test> newTests) {
            List<Test> tests = currTests;

            foreach (Test test in newTests) {
                // If test not found in currTests then add otherwise do not
                if (currTests.Find(currTest => currTest.title == test.title) == null) {
                    tests.Add(test);
                }
            }

            return tests;
        }

        public static bool Collides(List<Test> list1, List<Test> list2) {
            foreach (Test test1 in list1) {
                if (list2.Find(test2 => test2.title == test1.title) != null) {
                    return true;
                }
            }

            return false;
        }

        public static void ExportTest(Test testRef) {
            ExportTests([testRef]);
        }

        /// <summary>
        /// Imports tests and returns a new list for MainWindow to override current
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="path"></param>
        public static void ImportTests(ImportMode mode, List<Test> newTests) {
            try {
                switch (mode) {
                    case ImportMode.Override: {
                        newTests = Override(MainWindow.GetTests(), newTests);
                    } break;
                    case ImportMode.Add: {
                        newTests = Add(MainWindow.GetTests(), newTests);
                    } break;
                }

                MessageManager.NewWindow("Import Export Handler Info", "Tests imported.", [new MessageWindow.Button("OK", null)]);

                OnImport?.Invoke(null, new OnImportEventArgs() {
                    newTestList = newTests,
                });

            } catch (Exception ex) {
                MessageManager.NewWindow("Import Export Handler Error", ex.Message, [new MessageWindow.Button("OK", null)]);
            }
        }

        /// <summary>
        /// Imports tests and returns a new list for MainWindow to override current
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="path"></param>
        public static void ImportTests(ImportMode mode, string path) {
            try {
                List<Test> newTests = new();
               
                switch (mode) {
                    case ImportMode.Override: {
                        newTests = Override(MainWindow.GetTests(), JSONHandler.LoadTestsFromJSON(path));
                    } break;
                    case ImportMode.Add: {
                        newTests = Add(MainWindow.GetTests(), JSONHandler.LoadTestsFromJSON(path));
                    } break;
                }

                MessageManager.NewWindow("Import Export Handler Info", "Tests imported.", [new MessageWindow.Button("OK", null)]);

                OnImport?.Invoke(null, new OnImportEventArgs() {
                    newTestList = newTests,
                });

            } catch (Exception ex) {
                MessageManager.NewWindow("Import Export Handler Error", ex.Message, [new MessageWindow.Button("OK", null)]);
            }
        }
    }
}
