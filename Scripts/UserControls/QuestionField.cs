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

namespace QuizForge
{
    public partial class QuestionField : UserControl
    {
        public event EventHandler<OnDeleteQuestionBtnClickEventArgs> OnDeleteQuestionBtnClick;

        private List<AnswerCreationSet> answers = new();
        private AnswerCreationSet currCorrectAnswerSet = null;

        private const int INITIAL_QUESTION_COUNT = 4;
        private const int MINIMUM_ANSWERS = 2;

        public class OnDeleteQuestionBtnClickEventArgs : EventArgs
        {
            public QuestionField questionField { get; set; }
        }
        public QuestionField()
        {
            this.InitializeComponent();
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
            if (questionInput.Text == "")
            {
                errorProvider.SetError(questionInput, "Question can't be empty");
                return false;
            }
            else
            {
                errorProvider.SetError(questionInput, null);
            }

            if (answers.Count < MINIMUM_ANSWERS)
            {
                errorProvider.SetError(answerSetPanel, $"There must be atleast {MINIMUM_ANSWERS} answers");
                return false;
            }

            // Check answer sets
            foreach (AnswerCreationSet answer in answers)
            {
                if (answer.Correct() != true)
                {
                    errorProvider.SetError(answerSetPanel, "Answer Inputs can't be empty!");
                    return false;
                }
            }

            if (currCorrectAnswerSet == null)
            {
                errorProvider.SetError(answerSetPanel, "Select correct answer");
                return false;
            }
            else
            {
                errorProvider.SetError(answerSetPanel, null);
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
