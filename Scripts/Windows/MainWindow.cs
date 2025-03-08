using System.Diagnostics;
using System.Text.Json.Serialization;
using QuizForge.Scripts;
using QuizForge.Scripts.Forms;

namespace QuizForge
{
    public partial class MainWindow : Form
    {
        public delegate void QuizInteractionBtnHandler(Quiz quizRef);
        public delegate void ActionBtnHandler(QuizForm quizForm);

        private static List<Quiz> quizzes = new();

        public MainWindow()
        {
            this.InitializeComponent();

            createQuizForm.Setup(QuizForm.ActionBtnMode.CreateQuiz, CreateQuiz);

            quizList.SolveBtnClickHandler = OpenSolveQuizWindow;
            quizList.EditBtnClickHandler = OpenEditQuizWindow;
            quizList.ExportBtnClickHandler = ImportExportHandler.ExportQuiz;

            ImportExportHandler.OnImport += ImportExportHandler_OnImport;

            // Load quizzes from SavedQuizzes.json
            List<Quiz> loadedQuizzes = JSONHandler.LoadQuizzes(JSONHandler.SAVED_QUIZZES_FILE_PATH);

            if (loadedQuizzes != null) {
                foreach (Quiz quiz in loadedQuizzes) {
                    quizzes.Add(quiz);
                }

                quizList.Update(quizzes);
                exportView.Update(quizzes);
            }
        }

        private void ImportExportHandler_OnImport(object? sender, ImportExportHandler.OnImportEventArgs e) {
            quizzes = e.newQuizzes;

            quizList.Update(quizzes);
            exportView.Update(quizzes);

            JSONHandler.SaveQuizzes(quizzes, JSONHandler.SAVED_QUIZZES_FILE_PATH);
        }

        private void OpenSolveQuizWindow(Quiz quizRef) {
            SolveQuizWindow solveQuizWindow = new SolveQuizWindow(quizRef);

            solveQuizWindow.Show(); 
        }

        private void OpenEditQuizWindow(Quiz quizRef) {
            EditQuizWindow editQuizWindow = new EditQuizWindow(quizRef);

            editQuizWindow.GetQuizForm().Setup(QuizForm.ActionBtnMode.SaveQuiz, SaveQuiz);
            editQuizWindow.DeleteButtonClickedHandler = DeleteQuiz;

            editQuizWindow.Show();
        }

        private void DeleteQuiz(Quiz quizRef) {
            quizzes.Remove(quizRef);

            quizRef = null;

            quizList.Update(quizzes);
            exportView.Update(quizzes);

            MessageManager.NewWindow("Main Window Info", "Quiz deleted", [new MessageWindow.Button("OK", null)]);

            JSONHandler.SaveQuizzes(quizzes, JSONHandler.SAVED_QUIZZES_FILE_PATH);

            EditQuizWindow.Instance.Close();
        }

        private void SaveQuiz(QuizForm editQuizForm) {
            if (editQuizForm.Correct()) {
                Quiz editedQuiz = editQuizForm.GetQuizObj();
                Quiz previousQuiz = EditQuizWindow.Instance.GetQuizRef();

                // Make changes
                previousQuiz.title = editedQuiz.title;
                previousQuiz.description = editedQuiz.description;
                previousQuiz.questions = editedQuiz.questions;

                quizList.Update(quizzes);
                exportView.Update(quizzes);

                MessageManager.NewWindow("Main Window Info", "Quiz saved", [new MessageWindow.Button("OK", null)]);

                JSONHandler.SaveQuizzes(quizzes, JSONHandler.SAVED_QUIZZES_FILE_PATH);
            }
        }

        private void CreateQuiz(QuizForm createQuizForm)
        {
            if (createQuizForm.Correct())
            {
                quizzes.Add(createQuizForm.GetQuizObj());

                createQuizForm.Clear();

                quizList.Update(quizzes);
                exportView.Update(quizzes);

                MessageManager.NewWindow("Main Window Info", "Quiz created", [new MessageWindow.Button("OK", null)]);

                JSONHandler.SaveQuizzes(quizzes, JSONHandler.SAVED_QUIZZES_FILE_PATH);
            }
        }

        public static List<Quiz> GetQuizzes() {
            return quizzes;
        }
    }
    public class Question {
        [JsonPropertyName("Question")]
        public string question { get; set; }
        [JsonPropertyName("Answers")]
        public List<string> answers { get; set; }
        [JsonPropertyName("Correct Answer")]
        public string correctAnswer { get; set; }

        public Question() { }

        public Question(string question, List<string> answers, string correctAnswer) {
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
        }
    }

    public class Quiz {
        [JsonPropertyName("Title")]
        public string title { get; set; }
        [JsonPropertyName("Description")]
        public string description { get; set; }
        [JsonPropertyName("Questions")]
        public List<Question> questions { get; set; }

        public Quiz() { }

        public Quiz(string title, string description, List<Question> questions) {
            this.title = title;
            this.description = description;
            this.questions = questions;
        }
    }
}
