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
using TestMakerTaker.Scripts.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TestMakerTaker
{
    public partial class Form_SolveTest : Form {
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
        private AnswerButton currentSelectedAnswerButton = null;

        private int currentQuestionIndex = 0;
        private string currentCorrectAnswer;
        private int questionCount;

        private enum NextButtonMode {
            NextQuestion,
            FinishTest
        }

        private NextButtonMode nextButtonMode;

        public Form_SolveTest(Test test) {
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

            UpdateUI();
            DisplayQuestion(testQuestions[currentQuestionIndex]);

            currentCorrectAnswer = testQuestions[currentQuestionIndex].correctAnswer;
        }

        private void UpdateUI() {
            questionCountLabel.Text = $"Question {currentQuestionIndex + 1} of {questionCount}";

            // Update next button
            if (currentQuestionIndex == questionCount - 1) {
                // last question - button should change its text to "Finish Test"
                nextButton.Text = "Finish";
                nextButtonMode = NextButtonMode.FinishTest;
            } else {
                nextButton.Text = "Next";
                nextButtonMode = NextButtonMode.NextQuestion;
            }
            // Update previous button
            previousQuestionButton.Enabled = currentQuestionIndex == 0 ? false : true;
            // Update check answer button
            checkAnswerButton.Enabled = currentSelectedAnswerButton != null ? true : false;
            // Update result label
            resultLabel.Text = "";
        }

        private void DisplayQuestion(Question question) {
            questionLabel.Text = question.question;

            answerPanel.Controls.Clear();

            foreach (string answer in question.answers) {
                AnswerButton newAnswerButton = new AnswerButton();

                newAnswerButton.text = answer;
                newAnswerButton.OnAnswerButtonClicked += NewAnswerButton_OnAnswerButtonClicked;

                answerPanel.Controls.Add(newAnswerButton);
            }
        }

        private void NewAnswerButton_OnAnswerButtonClicked(object? sender, EventArgs e) {
            AnswerButton answerButton = sender as AnswerButton;

            if (currentSelectedAnswerButton != null) {
                currentSelectedAnswerButton.ChangeAnswerButtonMode(AnswerButton.AnswerButtonMode.Default);
            }

            answerButton.ChangeAnswerButtonMode(AnswerButton.AnswerButtonMode.Selected);

            currentSelectedAnswerButton = answerButton;

            UpdateUI();
        }

        private void NextQuestion() {
            currentQuestionIndex++;
            currentCorrectAnswer = testQuestions[currentQuestionIndex].correctAnswer;
            currentSelectedAnswerButton = null;

            UpdateUI();
            DisplayQuestion(testQuestions[currentQuestionIndex]);
            CheckIfQuestionAnswered(currentQuestionIndex);
        }

        private void CheckIfQuestionAnswered(int questionIndex) {
            UserAnswer userAnswer = userAnswers[questionIndex];
            if (userAnswer != null) {
                // Question answered
                checkAnswerButton.Enabled = false;

                // Select button with users answer
                AnswerButton selectedAnswerButton = null;
                foreach (AnswerButton answerButton in answerPanel.Controls) {
                    if (answerButton.text == userAnswer.answer) {
                        selectedAnswerButton = answerButton;
                    }
                }

                CheckAnswer(selectedAnswerButton);
            }
        }

        private void PreviousQuestion() {
            currentQuestionIndex--;
            currentCorrectAnswer = testQuestions[currentQuestionIndex].correctAnswer;
            currentSelectedAnswerButton = null;

            UpdateUI();
            DisplayQuestion(testQuestions[currentQuestionIndex]);
            CheckIfQuestionAnswered(currentQuestionIndex);
        }

        private void DisplayCorrectAnswers(string correctAnswer) {
            foreach (AnswerButton answerButton in answerPanel.Controls) {
                if (answerButton.text == correctAnswer) 
                    answerButton.ChangeAnswerButtonMode(AnswerButton.AnswerButtonMode.AnswerCorrect);
            }
        }

        private void CheckAnswer(AnswerButton answerButton) {
            string answer = answerButton.text;

            if (answer != currentCorrectAnswer) {
                // Incorrect answer
                answerButton.ChangeAnswerButtonMode(AnswerButton.AnswerButtonMode.AnswerIncorrect);
                resultLabel.Text = $"Incorrect! Answer is {currentCorrectAnswer}";
            } else {
                resultLabel.Text = $"Correct! Answer is {currentCorrectAnswer}";
            }

            DisplayCorrectAnswers(currentCorrectAnswer);

            // Disable all answer buttons
            foreach (AnswerButton answerPanelElement in answerPanel.Controls) {
                answerPanelElement.Enabled = false;
            }
            checkAnswerButton.Enabled = false;

            // Add user answer 
            if (userAnswers[currentQuestionIndex] == null) 
                userAnswers[currentQuestionIndex] = new UserAnswer(testQuestions[currentQuestionIndex].question, answer, currentCorrectAnswer);
        }

        private void FinishTest() {
            Form_TestResult testResultForm = new Form_TestResult(testRef, userAnswers);

            testResultForm.Show();

            this.Close();
            // Display results;
        }

        private void nextButton_Click(object sender, EventArgs e) {
            if (nextButtonMode == NextButtonMode.NextQuestion) {
                NextQuestion();
            } else {
                bool areAllQuestionsAnswered = true;
                foreach (UserAnswer userAnswer in userAnswers)
                    if (userAnswer == null) { areAllQuestionsAnswered = false; break; }

                if (areAllQuestionsAnswered) {
                    FinishTest();
                } else {
                    // If some questions are still unanswered, show notification
                    MessageDialog newMessageDialog = new MessageDialog(MessageDialog.MessageDialogMode.Error, "Notice", "There are still unanswered questions! Are you sure you want to finish the test?", "Yes", "Cancel");
                    newMessageDialog.OnYesBtnClick += NewMessageDialog_OnYesBtnClick;

                    newMessageDialog.ShowDialog();
                }
            }
        }

        private void NewMessageDialog_OnYesBtnClick(object? sender, EventArgs e) {
            FinishTest();
        }

        private void previousQuestionButton_Click(object sender, EventArgs e) {
            if (currentQuestionIndex != 0) {
                PreviousQuestion();
            }
        }

        private void checkAnswerButton_Click(object sender, EventArgs e) {
            if (currentSelectedAnswerButton != null)
                CheckAnswer(currentSelectedAnswerButton);
        }
    }
}
