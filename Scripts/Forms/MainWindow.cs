using System.Diagnostics;
using TestMakerTaker.Scripts;
using TestMakerTaker.Scripts.Forms;

namespace TestMakerTaker
{
    public partial class MainWindow : Form
    {
        private List<Test> tests = new();
        private JSONHandler jsonHandler = new JSONHandler();

        // A delegate function handler for every interaction with a test that requires passing down an object
        public delegate void TestInteractionButtonHandler(Test testRef);
        public delegate void ActionButtonHandler(TestForm testForm);

        public MainWindow()
        {
            InitializeComponent();

            createTestForm.Setup(TestForm.ActionButtonMode.CreateTest, CreateTest);

            testList.SolveButtonClickedHandler = OpenSolveTestWindow;
            testList.EditButtonClickedHandler = OpenEditTestWindow;

            // Load tests from SavedTests.json
            List<Test> loadedTests = jsonHandler.GetSavedTests();

            if (loadedTests != null) {
                foreach (Test test in loadedTests) {
                    tests.Add(test);
                }

                testList.Update(tests);
            }
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

            EditTestWindow.Instance.Close();

            // Show message
            MessageWindow infoDialog = new MessageWindow(MessageWindow.MessageDialogMode.Info, "Congratulations", "Test successfully has been deleted", "OK", "OK");
            infoDialog.ShowDialog();

            // Save current copy of tests to json
            jsonHandler.SaveTestsToJSON(tests);
        }

        private void SaveTest(TestForm testForm) {
            if (testForm.Correct()) {
                Test editedTest = testForm.GetTestObject();
                Test previousTest = EditTestWindow.Instance.GetTestRef();

                // make changes
                previousTest.title = editedTest.title;
                previousTest.description = editedTest.description;
                previousTest.questions = editedTest.questions;

                testList.Update(tests);

                EditTestWindow.Instance.Close();

                // Show message
                MessageWindow infoDialog = new MessageWindow(MessageWindow.MessageDialogMode.Info, "Congratulations", "A test has been saved!", "OK", "OK");
                infoDialog.ShowDialog();

                // Save current copy of tests to json
                jsonHandler.SaveTestsToJSON(tests);
            }
        }

        private void CreateTest(TestForm testForm)
        {
            if (testForm.Correct())
            {
                tests.Add(testForm.GetTestObject());

                testList.Update(tests);

                // Show message
                MessageWindow infoDialog = new MessageWindow(MessageWindow.MessageDialogMode.Info, "Congratulations", "A test has been created!", "OK", "OK");
                infoDialog.ShowDialog();

                // Save current copy of tests to json
                jsonHandler.SaveTestsToJSON(tests);

                testForm.ClearFields();
            }
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
