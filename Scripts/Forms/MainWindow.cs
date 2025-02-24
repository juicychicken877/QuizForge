using System.Diagnostics;
using TestMakerTaker.Scripts;
using TestMakerTaker.Scripts.Forms;

namespace TestMakerTaker
{
    public partial class MainWindow : Form
    {
        public delegate void TestInteractionButtonHandler(Test testRef);
        public delegate void ActionButtonHandler(TestForm testForm);

        private static List<Test> tests = new();

        public MainWindow()
        {
            InitializeComponent();

            createTestForm.Setup(TestForm.ActionButtonMode.CreateTest, CreateTest);

            testList.SolveButtonClickedHandler = OpenSolveTestWindow;
            testList.EditButtonClickedHandler = OpenEditTestWindow;
            testList.ExportButtonClickedHandler = ImportExportHandler.ExportTest;

            ImportExportHandler.OnImport += ImportExportHandler_OnImport;

            // Load tests from SavedTests.json
            List<Test> loadedTests = JSONHandler.LoadTestsFromJSON(JSONHandler.SAVED_TESTS_FILE_PATH);

            if (loadedTests != null) {
                foreach (Test test in loadedTests) {
                    tests.Add(test);
                }

                testList.Update(tests);
            }
        }

        private void ImportExportHandler_OnImport(object? sender, ImportExportHandler.OnImportEventArgs e) {
            List<Test> testsToImport = e.testsToImport;

            if (e.importMode == ImportExportHandler.ImportMode.Add) {
                foreach (Test test in testsToImport) tests.Add(test);
            } else if (e.importMode == ImportExportHandler.ImportMode.Override) {
                tests = testsToImport;
            }

            testList.Update(tests);

            // Show message
            MessageManager.NewInfoWindow("Import Export Handler Info", $"{testsToImport.Count} tests imported.", null);

            JSONHandler.SaveTestsToJSON(tests, JSONHandler.SAVED_TESTS_FILE_PATH);
        }

        private void OpenSolveTestWindow(Test testRef) {
            SolveTestWindow solveTestWindow = new SolveTestWindow(testRef);

            solveTestWindow.Show(); 
        }

        private void OpenEditTestWindow(Test testRef) {
            EditTestWindow editTestWindow = new EditTestWindow(testRef);

            editTestWindow.GetTestForm().Setup(TestForm.ActionButtonMode.SaveTest, SaveTest);
            editTestWindow.DeleteButtonClickedHandler = DeleteTest;

            editTestWindow.Show();
        }

        private void DeleteTest(Test testRef) {
            tests.Remove(testRef);

            testRef = null;

            testList.Update(tests);

            // Show message
            MessageManager.NewInfoWindow("Info Window", "Test deleted.", null);
            // Save current copy of tests to json
            JSONHandler.SaveTestsToJSON(tests, JSONHandler.SAVED_TESTS_FILE_PATH);

            EditTestWindow.Instance.Close();
        }

        private void SaveTest(TestForm editTestForm) {
            if (editTestForm.Correct()) {
                Test editedTest = editTestForm.GetTestObject();
                Test previousTest = EditTestWindow.Instance.GetTestRef();

                // make changes
                previousTest.title = editedTest.title;
                previousTest.description = editedTest.description;
                previousTest.questions = editedTest.questions;

                testList.Update(tests);

                // Show message
                MessageManager.NewInfoWindow("Info Window", "Test saved.", null);
                // Save current copy of tests to json
                JSONHandler.SaveTestsToJSON(tests, JSONHandler.SAVED_TESTS_FILE_PATH);
            }
        }

        private void CreateTest(TestForm testForm)
        {
            if (testForm.Correct())
            {
                tests.Add(testForm.GetTestObject());

                testList.Update(tests);

                MessageManager.NewInfoWindow("Info Window", "Test created.", null);
                // Save current copy of tests to json
                JSONHandler.SaveTestsToJSON(tests, JSONHandler.SAVED_TESTS_FILE_PATH);

                testForm.ClearFields();
            }
        }

        public static List<Test> GetTests() {
            return tests;
        }
    }
    public class Question(string q, List<string> ans, string correct)
    { 
        public string question = q;
        public List<string> answers = ans;
        public string correctAnswer = correct;
    }

    public class Test(string title, string description, List<Question> questions)
    {
        public string title = title;
        public string description = description;
        public List<Question> questions = questions;
    }
}
