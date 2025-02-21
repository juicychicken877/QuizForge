using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TestMakerTaker.Scripts.Forms;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace TestMakerTaker.Scripts
{
    internal class JSONHandler
    {
        public class TestListJSON {
            public class TestJSON
            {
                [JsonPropertyName("title")]
                public string title { get; set; }
                [JsonPropertyName("description")]
                public string description { get; set; }
                [JsonPropertyName("questions")]
                public List<Question> questions { get; set; }

                public TestJSON(string title, string description, List<Question> questions)
                {
                    this.title = title;
                    this.description = description;
                    this.questions = questions;
                }
            }

            public List<TestJSON> testsJSON = new();
            public TestListJSON() { }

            public void CreateJSONTests(List<Test> tests)
            {
                foreach (Test test in tests)
                {
                    TestJSON newTest = new TestJSON(test.title, test.description, test.questions);

                    testsJSON.Add(newTest);
                }
            }
        }

        private const string SAVED_TESTS_FILE_PATH = "../../../Data/SavedTests.json";
        public JSONHandler()
        {

        }

        public void SaveTestsToJson(List<Test> tests)
        {
            try
            {
                TestListJSON testsObject = new TestListJSON();
                testsObject.CreateJSONTests(tests);

                string jsonString = JsonSerializer.Serialize(testsObject);
                File.WriteAllText(SAVED_TESTS_FILE_PATH, jsonString);
            }
            catch (Exception ex)
            {
                MessageDialog newErrorMessage = new MessageDialog(MessageDialog.MessageDialogMode.Error, "Error saving",ex.Message, "OK", "OK");

                newErrorMessage.ShowDialog();
            }
        }

        public TestListJSON GetSavedTests()
        {
            TestListJSON savedTests = null;
            try
            {
                if (File.Exists(SAVED_TESTS_FILE_PATH))
                {
                    string jsonString = File.ReadAllText(SAVED_TESTS_FILE_PATH);
                    savedTests = JsonSerializer.Deserialize<TestListJSON>(jsonString);

                    return savedTests;
                }
                else
                {
                    MessageDialog newErrorMessage = new MessageDialog(MessageDialog.MessageDialogMode.Error, "No File Found", "Path to SavedTests.json is incorrect or file doesn't exist.", "OK", "OK");

                    newErrorMessage.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageDialog newErrorMessage = new MessageDialog(MessageDialog.MessageDialogMode.Error, "No File Found", ex.Message, "OK", "OK");

                newErrorMessage.ShowDialog();
            }

            return savedTests;
        }
    }
}
