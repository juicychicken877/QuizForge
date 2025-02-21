using System.Diagnostics;
using TestMakerTaker.Scripts;
using TestMakerTaker.Scripts.Forms;

namespace TestMakerTaker
{
    public partial class Form_Main : Form
    {
        private List<Test> tests = new();
        private Form_EditTest currentEditTestForm = null;
        private JSONHandler jsonHandler = new JSONHandler();

        public Form_Main()
        {
            InitializeComponent();

            createTestForm.ChangeActionButtonMode(TestForm.ActionButtonMode.CreateTest);
            createTestForm.OnActionButtonClicked += CreateTest;

            testList.OnEditTest += OpenEditTestForm;
            testList.OnSolveTest += OpenSolveTestForm;

            List<Test> loadedTests = jsonHandler.GetSavedTests();

            if (loadedTests != null) {
                foreach (Test test in loadedTests) {
                    tests.Add(test);
                }

                testList.Update(tests);
            }
        }

        private void OpenSolveTestForm(object? sender, TestList.OnTestInteractionEventArgs e) {
            Form_SolveTest solveTestForm = new Form_SolveTest(e.test);

            solveTestForm.Show();
        }

        private void OpenEditTestForm(object? sender, TestList.OnTestInteractionEventArgs e) {
            Form_EditTest editTestForm = new Form_EditTest(e.test);

            currentEditTestForm = editTestForm;

            editTestForm.testFormObject.OnActionButtonClicked += SaveTest;
            editTestForm.OnDeleteTestButtonClicked += DeleteTest;

            editTestForm.Show();
        }

        private void DeleteTest(object? sender, EventArgs e) {
            Test testToDelete = currentEditTestForm.GetTestReference();

            tests.Remove(testToDelete);

            testToDelete = null;

            testList.Update(tests);

            currentEditTestForm.Close();
            currentEditTestForm = null;

            // Show message
            MessageDialog infoDialog = new MessageDialog(MessageDialog.MessageDialogMode.Info, "Congratulations", "Test successfully has been deleted", "OK", "OK");
            infoDialog.ShowDialog();

            // Save current copy of tests to json
            jsonHandler.SaveTestsToJSON(tests);
        }

        private void SaveTest(object? sender, TestForm.OnActionButtonClickedEventArgs e) {
            TestForm editTestForm = e.form;

            if (editTestForm.AllGoodAndCorrect()) {
                Test editedTest = editTestForm.GetTestObject();

                Test previousTest = currentEditTestForm.GetTestReference();

                // make changes
                previousTest.title = editedTest.title;
                previousTest.description = editedTest.description;
                previousTest.questions = editedTest.questions;

                testList.Update(tests);

                currentEditTestForm.Close();
                currentEditTestForm = null;

                // Show message
                MessageDialog infoDialog = new MessageDialog(MessageDialog.MessageDialogMode.Info, "Congratulations", "A test has been saved!", "OK", "OK");
                infoDialog.ShowDialog();

                // Save current copy of tests to json
                jsonHandler.SaveTestsToJSON(tests);
            }
        }

        private void CreateTest(object sender, TestForm.OnActionButtonClickedEventArgs e)
        {
            TestForm testForm = e.form;
            
            if (testForm.AllGoodAndCorrect())
            {
                tests.Add(testForm.GetTestObject());

                testForm.ClearFields();

                // Update element list
                testList.Update(tests);

                // Show message
                MessageDialog infoDialog = new MessageDialog(MessageDialog.MessageDialogMode.Info, "Congratulations", "A test has been created!", "OK", "OK");
                infoDialog.ShowDialog();

                // Save current copy of tests to json
                jsonHandler.SaveTestsToJSON(tests);
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
