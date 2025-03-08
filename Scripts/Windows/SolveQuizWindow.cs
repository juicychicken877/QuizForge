using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizForge.Scripts;
using QuizForge.Scripts.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuizForge
{
    public partial class SolveQuizWindow : Form {
        public class UserAnswer {
            public string question;
            public string answer;
            public string correctAnswer;

            public UserAnswer(string question, string answer, string correctAnswer) {
                this.question = question;
                this.answer = answer;
                this.correctAnswer = correctAnswer;
            }
            public bool IsCorrect() {
                return answer == correctAnswer;
            }
        }

        private List<Question> quizQuestions;
        private UserAnswer[] userAnswers;
        private Quiz quizRef = null;
        private AnswerBtn currSelectedAnswerBtn = null;

        private int currQuestionIndex = 0;
        private string currCorrectAnswer;
        private int questionCount;

        public delegate void AnswerBtnClickHandler(AnswerBtn answerButton);

        private enum NextBtnMode {
            NextQuestion,
            FinishQuiz
        }

        private NextBtnMode nextBtnMode;

        public SolveQuizWindow(Quiz quiz) {
            // The form can only be opened if a quiz has questions
            this.InitializeComponent();

            quizRef = quiz;

            // Randomize questions and answers
            quizQuestions = Support.ShuffleList(quiz.questions);
            foreach (Question question in quizQuestions)
            {
                question.answers = Support.ShuffleList(question.answers);
            }

            userAnswers = new UserAnswer[quiz.questions.Count];

            quizTitleLabel.Text = quiz.title;
            questionCount = quiz.questions.Count;

            currCorrectAnswer = quizQuestions[currQuestionIndex].correctAnswer;

            this.UpdateUI();
            this.DisplayQuestion(quizQuestions[currQuestionIndex]);
        }

        private void UpdateUI() {
            questionCountLabel.Text = $"Question {currQuestionIndex + 1} of {questionCount}";

            // Update next button
            if (currQuestionIndex == questionCount - 1) {
                nextBtn.Text = "Finish";
                nextBtnMode = NextBtnMode.FinishQuiz;
            } else {
                nextBtn.Text = "Next";
                nextBtnMode = NextBtnMode.NextQuestion;
            }
            // Update previous button
            previousQuestionBtn.Enabled = currQuestionIndex == 0 ? false : true;
            // Update check answer button
            checkAnswerBtn.Enabled = currSelectedAnswerBtn != null ? true : false;
            // Update result label
            resultLabel.Text = "";
        }

        private void DisplayQuestion(Question question) {
            questionLabel.Text = question.question;
            answerPanel.Controls.Clear();

            foreach (string answer in question.answers) {
                AnswerBtn newAnswerBtn = new AnswerBtn(answer);

                newAnswerBtn.AnswerBtnClickHandler = SelectAnswerButton;

                answerPanel.Controls.Add(newAnswerBtn);
            }
        }

        private void SelectAnswerButton(AnswerBtn answerBtn) {
            if (currSelectedAnswerBtn != null) {
                currSelectedAnswerBtn.ChangeAnswerBtnMode(AnswerBtn.AnswerBtnMode.Default);
            }

            answerBtn.ChangeAnswerBtnMode(AnswerBtn.AnswerBtnMode.Selected);

            currSelectedAnswerBtn = answerBtn;

            this.UpdateUI();
        }

        private void LoadQuestion(int questionIndex) {
            currCorrectAnswer = quizQuestions[questionIndex].correctAnswer;
            currSelectedAnswerBtn = null;

            this.UpdateUI();
            this.DisplayQuestion(quizQuestions[questionIndex]);
            this.IsQuestionAnswered(questionIndex);
        }

        private void IsQuestionAnswered(int questionIndex) {
            UserAnswer userAnswer = userAnswers[questionIndex];

            if (userAnswer != null) {
                // Question answered
                checkAnswerBtn.Enabled = false;

                this.DisplayAnswerResults(userAnswer.answer);
            }
        }

        // Select distinct answer buttons that have specific answer and change their mode
        private void SelectDistinctAnswerBtns(string answer, AnswerBtn.AnswerBtnMode mode) {
            foreach (AnswerBtn answerBtn in answerPanel.Controls) {
                if (answerBtn.GetAnswer() == answer) 
                    answerBtn.ChangeAnswerBtnMode(mode);
            }
        }

        private void DisplayAnswerResults(string answer) {
            if (answer != currCorrectAnswer) {
                // Incorrect answer
                this.SelectDistinctAnswerBtns(answer, AnswerBtn.AnswerBtnMode.Incorrect);
                resultLabel.Text = $"Incorrect! Answer is {currCorrectAnswer}";
            } else {
                resultLabel.Text = $"Correct! Answer is {currCorrectAnswer}";
            }

            this.SelectDistinctAnswerBtns(currCorrectAnswer, AnswerBtn.AnswerBtnMode.Correct);

            // Disable all answer buttons
            foreach (AnswerBtn answerPanelElement in answerPanel.Controls) {
                answerPanelElement.Enabled = false;
            }
            checkAnswerBtn.Enabled = false;

            // Add user answer if doesnt exist
            if (userAnswers[currQuestionIndex] == null) 
                userAnswers[currQuestionIndex] = new UserAnswer(quizQuestions[currQuestionIndex].question, answer, currCorrectAnswer);
        }

        private void FinishQuiz() {
            QuizResultWindow quizResultForm = new(quizRef, userAnswers);

            quizResultForm.Show();

            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e) {
            if (nextBtnMode == NextBtnMode.NextQuestion) {
                currQuestionIndex++;
                this.LoadQuestion(currQuestionIndex);
            } else {
                bool areAllQuestionsAnswered = true;
                foreach (UserAnswer userAnswer in userAnswers)
                    if (userAnswer == null) { areAllQuestionsAnswered = false; break; }

                if (areAllQuestionsAnswered) {
                    this.FinishQuiz();
                } else {
                    // If some questions are still unanswered, show notification
                    MessageManager.NewWindow("Solve Quiz Window Info", "Some questions are unanswered! Continue?", [new MessageWindow.Button("Yes", this.FinishQuiz), new MessageWindow.Button("No", null)]);
                }
            }
        }

        private void previousQuestionButton_Click(object sender, EventArgs e) {
            if (currQuestionIndex != 0) {
                currQuestionIndex--;
                this.LoadQuestion(currQuestionIndex);
            }
        }

        private void checkAnswerButton_Click(object sender, EventArgs e) {
            this.DisplayAnswerResults(currSelectedAnswerBtn.GetAnswer());
        }
    }
}
