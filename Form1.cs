namespace TestMakerTaker
{
    public partial class Form1 : Form
    {
        private List<Test> tests = new();
        private EditTestForm currentEditTestForm = null;

        public Form1()
        {
            InitializeComponent();

            createTestForm.ChangeActionButtonMode(TestForm.ActionButtonMode.CreateTest);

            createTestForm.OnActionButtonClicked += CreateTest;

            testList.OnEditTest += OpenEditTestForm;
            testList.OnSolveTest += OpenSolveTestForm;

            CreateExampleTests();
            testList.Update(tests);
        }

        private void CreateExampleTests() {
            // Create tests
            // Test 1
            List<Question> questions1 = new List<Question>()
            {
                new Question("What is the capital of France?", new List<string>{"Berlin", "Paris", "Madrid", "Rome"}, "Paris"),
                new Question("What is the highest mountain in the world?", new List<string>{"K2", "Kangchenjunga", "Mount Everest", "Lhotse"}, "Mount Everest"),
                new Question("What is the largest country in Africa?", new List<string>{"Nigeria", "Algeria", "Democratic Republic of the Congo", "Sudan"}, "Algeria"),
                new Question("Which river runs through London?", new List<string>{"Seine", "Thames", "Danube", "Rhine"}, "Thames"),
            };
            Test test1 = new Test("Geography Quiz", "Test your geography knowledge", questions1);
            tests.Add(test1);

            // Test 2
            List<Question> questions2 = new List<Question>()
            {
                new Question("What is the value of pi?", new List<string>{"3.14", "3.15", "3.16", "3.17"}, "3.14"),
                new Question("What is the speed of light?", new List<string>{"299,792,458 m/s", "300,000 km/s", "100,000 km/s", "500,000 km/s"}, "299,792,458 m/s"),
                new Question("What is the square root of 144?", new List<string>{"10", "12", "14", "16"}, "12"),
                new Question("What is the formula for the area of a circle?", new List<string>{"πr", "2πr", "πr²", "4πr²"}, "πr²"),
            };
            Test test2 = new Test("Math Quiz", "Test your math knowledge", questions2);
            tests.Add(test2);

            // Test 3
            List<Question> questions3 = new List<Question>()
            {
                new Question("Who wrote Hamlet?", new List<string>{"Charles Dickens", "Jane Austen", "William Shakespeare", "Mark Twain"}, "William Shakespeare"),
                new Question("Who painted the Mona Lisa?", new List<string>{"Michelangelo", "Leonardo da Vinci", "Raphael", "Donatello"}, "Leonardo da Vinci"),
                new Question("Who wrote 'Pride and Prejudice'?", new List<string>{"Charlotte Brontë", "Emily Brontë", "Jane Austen", "Virginia Woolf"}, "Jane Austen"),
                new Question("Who sculpted 'The Thinker'?", new List<string>{"Auguste Rodin", "Michelangelo", "Donatello", "Leonardo da Vinci"}, "Auguste Rodin"),
            };
            Test test3 = new Test("Literature & Art Quiz", "Test your knowledge in Literature and Art", questions3);
            tests.Add(test3);


            // Test 4
            List<Question> questions4 = new List<Question>()
            {
                new Question("Which planet is known as the 'Red Planet'?", new List<string>{"Jupiter", "Mars", "Venus", "Saturn"}, "Mars"),
                new Question("What is the largest planet in our solar system?", new List<string>{"Earth", "Mars", "Jupiter", "Saturn"}, "Jupiter"),
                new Question("What is the name of the closest star to Earth?", new List<string>{"Sirius", "Proxima Centauri", "Alpha Centauri A", "The Sun"}, "The Sun"),
                new Question("How many planets are in our solar system?", new List<string>{"7", "8", "9", "10"}, "8"),
            };
            Test test4 = new Test("Space Quiz", "Test your knowledge about space", questions4);
            tests.Add(test4);

            // Test 5
            List<Question> questions5 = new List<Question>()
            {
                new Question("What is the capital of Italy?", new List<string>{"Paris", "Rome", "Madrid", "London"}, "Rome"),
                new Question("What is the currency of Japan?", new List<string>{"Yuan", "Won", "Yen", "Rupee"}, "Yen"),
                new Question("What is the capital of Brazil?", new List<string>{"Buenos Aires", "Rio de Janeiro", "Brasilia", "Sao Paulo"}, "Brasilia"),
                new Question("What is the currency of the United Kingdom?", new List<string>{"Euro", "Dollar", "Pound Sterling", "Franc"}, "Pound Sterling")
            };
            Test test5 = new Test("World Capitals and Currencies", "Test your knowledge of world capitals and currencies", questions5);
            tests.Add(test5);
        }

        private void OpenSolveTestForm(object? sender, TestList.OnTestInteractionEventArgs e) {
            SolveTestForm solveTestForm = new SolveTestForm(e.test);

            solveTestForm.Show();
        }

        private void OpenEditTestForm(object? sender, TestList.OnTestInteractionEventArgs e) {
            EditTestForm editTestForm = new EditTestForm(e.test);

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
