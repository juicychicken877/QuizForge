using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using QuizForge.Scripts.UserControls;
using QuizForge.Scripts;

namespace QuizForge
{
    public partial class QuestionField : UserControl
    {
        public event EventHandler<OnDeleteQuestionBtnClickEventArgs> OnDeleteQuestionBtnClick;

        private List<AnswerCreationSet> answers = new();
        private AnswerCreationSet currCorrectAnswerSet = null;

        private readonly int INITIAL_QUESTION_COUNT = Settings.QUESTION_FIELD_INITIAL_QUESTION_COUNT;
        private readonly int MINIMUM_ANSWERS = Settings.QUIZ_FORM_MIN_ANSWER_COUNT;
        private readonly int QUESTION_MIN_LENGTH = Settings.QUESTION_FIELD_QUESTION_MIN_LENGTH;
        private readonly int QUESTION_MAX_LENGTH = Settings.QUESTION_FIELD_QUESTION_MAX_LENGTH;

        public class OnDeleteQuestionBtnClickEventArgs : EventArgs
        {
            public QuestionField questionField { get; set; }
        }
        public QuestionField()
        {
            this.InitializeComponent();

            questionInput.MaxLength = QUESTION_MAX_LENGTH;
        }

        public void AddInitialAnswers()
        {
            for (int i = 0; i < INITIAL_QUESTION_COUNT; i++)
            {
                this.AddAnswer();
            }
        }

        private AnswerCreationSet AddAnswer()
        {
            AnswerCreationSet newSet = new();

            answers.Add(newSet);
            answerSetPanel.Controls.Add(newSet);

            newSet.OnCorrectAnswerChange += SelectCorrectAnswer;
            newSet.OnDeleteAnswerBtnClick += DeleteAnswer;

            return newSet;
        }

        private void DeleteAnswer(object? sender, AnswerCreationSet.OnDeleteAnswerBtnClickEventArgs e)
        {
            AnswerCreationSet answerSet = e.answerSet;

            if (answerSet == currCorrectAnswerSet)
            {
                currCorrectAnswerSet = null;
            }
            answerSetPanel.Controls.Remove(answerSet);
            answers.Remove(answerSet);
        }

        private void SelectCorrectAnswer(object? sender, EventArgs e)
        {
            AnswerCreationSet answerCreationSet = sender as AnswerCreationSet;

            // Uncheck previous answer set
            if (currCorrectAnswerSet != null) currCorrectAnswerSet.isCorrect = false;

            currCorrectAnswerSet = answerCreationSet;
        }

        public bool Correct()
        {
            // Question empty
            if (questionInput.Text == "")
            {
                MessageManager.NewWindow("Question Field Error", "Question is empty", [new("OK", null)]);
                return false;
            }
            else if (questionInput.Text.Length < QUESTION_MIN_LENGTH || questionInput.Text.Length > QUESTION_MAX_LENGTH) {
                MessageManager.NewWindow("Question Field Error", $"Required question length: [{QUESTION_MIN_LENGTH}, {QUESTION_MAX_LENGTH}] characters", [new("OK", null)]);
                return false;
            }
            // Not enough answers
            if (answers.Count < MINIMUM_ANSWERS) {
                MessageManager.NewWindow("Question Field Error", $"Required answer count in a question: [{MINIMUM_ANSWERS}, any]", [new("OK", null)]);
                return false;
            }
            // Check answer fields in a question
            foreach (AnswerCreationSet answer in answers)
            {
                // Answers empty
                if (answer.Correct() != true)
                {
                    MessageManager.NewWindow("Question Field Error", $"Answer is empty", [new("OK", null)]);
                    return false;
                }
            }
            // No correct answer
            if (currCorrectAnswerSet == null)
            {
                MessageManager.NewWindow("Question Field Error", $"Correct answer is not defined", [new("OK", null)]);
                return false;
            }

            return true;
        }

        public Question GetQuestionObj()
        {
            List<string> answerList = new();

            // Create a list of answers
            foreach (AnswerCreationSet answer in answers)
            {
                answerList.Add(answer.answer);
            }

            return new Question(questionInput.Text, answerList, currCorrectAnswerSet.answer);
        }
        /// <summary>
        /// Fills inputs with data from question object
        /// </summary>
        public void Fill(Question question)
        {
            questionInput.Text = question.question;

            for (int i = 0; i < question.answers.Count; i++)
            {
                AnswerCreationSet newAnswer = AddAnswer();
                newAnswer.answer = question.answers[i];

                if (newAnswer.answer == question.correctAnswer)
                {
                    newAnswer.isCorrect = true;
                    currCorrectAnswerSet = newAnswer;
                }
            }

        }
        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            OnDeleteQuestionBtnClick?.Invoke(this, new OnDeleteQuestionBtnClickEventArgs()
            {
                questionField = this
            });
        }

        private void addAnswerBtn_Click(object sender, EventArgs e)
        {
            AddAnswer();
        }
    }
}
