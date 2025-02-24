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
using TestMakerTaker.Scripts;
using TestMakerTaker.Scripts.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TestMakerTaker
{
    public partial class SolveTestWindow : Form {
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

        private Question[] testQuestions;
        private UserAnswer[] userAnswers;
        private Test testRef = null;
        private AnswerButton currSelectedAnswerBtn = null;

        private int currQuestionIndex = 0;
        private string currCorrectAnswer;
        private int questionCount;

        public delegate void AnswerButtonClickedHandler(AnswerButton answerButton);

        private enum NextButtonMode {
            NextQuestion,
            FinishTest
        }

        private NextButtonMode nextButtonMode;

        public SolveTestWindow(Test test) {
            // form can only be opened if test has questions so question list length > 0
            InitializeComponent();

            testRef = test;

            // copy questions to array
            testQuestions = new Question[test.questions.Count];
            for (int i = 0; i < test.questions.Count; i++) {
                testQuestions[i] = test.questions[i];
            }
            // make an array for user answers
            userAnswers = new UserAnswer[test.questions.Count];

            testTitleLabel.Text = test.title;
            questionCount = test.questions.Count;

            currCorrectAnswer = testQuestions[currQuestionIndex].correctAnswer;

            UpdateUI();
            DisplayQuestion(testQuestions[currQuestionIndex]);
        }

        private void UpdateUI() {
            questionCountLabel.Text = $"Question {currQuestionIndex + 1} of {questionCount}";

            // Update next button
            if (currQuestionIndex == questionCount - 1) {
                // last question - button should change its text to "Finish Test"
                nextButton.Text = "Finish";
                nextButtonMode = NextButtonMode.FinishTest;
            } else {
                nextButton.Text = "Next";
                nextButtonMode = NextButtonMode.NextQuestion;
            }
            // Update previous button
            previousQuestionButton.Enabled = currQuestionIndex == 0 ? false : true;
            // Update check answer button
            checkAnswerButton.Enabled = currSelectedAnswerBtn != null ? true : false;
            // Update result label
            resultLabel.Text = "";
        }

        private void DisplayQuestion(Question question) {
            questionLabel.Text = question.question;

            answerPanel.Controls.Clear();

            foreach (string answer in question.answers) {
                AnswerButton newAnswerButton = new AnswerButton(answer);

                newAnswerButton.AnswerButtonClickedHandler = SelectAnswerButton;

                answerPanel.Controls.Add(newAnswerButton);
            }
        }

        private void SelectAnswerButton(AnswerButton answerButton) {
            if (currSelectedAnswerBtn != null) {
                currSelectedAnswerBtn.ChangeAnswerButtonMode(AnswerButton.AnswerButtonMode.Default);
            }

            answerButton.ChangeAnswerButtonMode(AnswerButton.AnswerButtonMode.Selected);

            currSelectedAnswerBtn = answerButton;

            UpdateUI();
        }

        private void LoadQuestion(int questionIndex) {
            currCorrectAnswer = testQuestions[questionIndex].correctAnswer;
            currSelectedAnswerBtn = null;

            UpdateUI();
            DisplayQuestion(testQuestions[questionIndex]);
            IsQuestionAnswered(questionIndex);
        }

        private void IsQuestionAnswered(int questionIndex) {
            UserAnswer userAnswer = userAnswers[questionIndex];

            if (userAnswer != null) {
                // Question answered
                checkAnswerButton.Enabled = false;

                DisplayAnswerResults(userAnswer.answer);
            }
        }

        // Select distinct answer buttons that have specific answer and change their mode
        private void SelectDistinctAnswerButtons(string answer, AnswerButton.AnswerButtonMode mode) {
            foreach (AnswerButton answerButton in answerPanel.Controls) {
                if (answerButton.GetAnswer() == answer) 
                    answerButton.ChangeAnswerButtonMode(mode);
            }
        }

        private void DisplayAnswerResults(string answer) {
            if (answer != currCorrectAnswer) {
                // Incorrect answer
                SelectDistinctAnswerButtons(answer, AnswerButton.AnswerButtonMode.AnswerIncorrect);
                resultLabel.Text = $"Incorrect! Answer is {currCorrectAnswer}";
            } else {
                resultLabel.Text = $"Correct! Answer is {currCorrectAnswer}";
            }

            SelectDistinctAnswerButtons(currCorrectAnswer, AnswerButton.AnswerButtonMode.AnswerCorrect);

            // Disable all answer buttons
            foreach (AnswerButton answerPanelElement in answerPanel.Controls) {
                answerPanelElement.Enabled = false;
            }
            checkAnswerButton.Enabled = false;

            // Add user answer if doesnt exist
            if (userAnswers[currQuestionIndex] == null) 
                userAnswers[currQuestionIndex] = new UserAnswer(testQuestions[currQuestionIndex].question, answer, currCorrectAnswer);
        }

        private void FinishTest() {
            TestResultWindow testResultForm = new TestResultWindow(testRef, userAnswers);

            testResultForm.Show();

            this.Close();
        }

        private void nextButton_Click(object sender, EventArgs e) {
            if (nextButtonMode == NextButtonMode.NextQuestion) {
                currQuestionIndex++;
                LoadQuestion(currQuestionIndex);
            } else {
                bool areAllQuestionsAnswered = true;
                foreach (UserAnswer userAnswer in userAnswers)
                    if (userAnswer == null) { areAllQuestionsAnswered = false; break; }

                if (areAllQuestionsAnswered) {
                    FinishTest();
                } else {
                    // If some questions are still unanswered, show notification
                    MessageManager.NewDecisionWindow("Warning", "Some questions are unanswered! Continue?", FinishTest, null);
                }
            }
        }

        private void previousQuestionButton_Click(object sender, EventArgs e) {
            if (currQuestionIndex != 0) {
                currQuestionIndex--;
                LoadQuestion(currQuestionIndex);
            }
        }

        private void checkAnswerButton_Click(object sender, EventArgs e) {
            DisplayAnswerResults(currSelectedAnswerBtn.GetAnswer());
        }
    }
}
