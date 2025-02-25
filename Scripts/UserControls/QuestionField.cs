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
using TestMakerTaker.Scripts.UserControls;

namespace TestMakerTaker
{
    public partial class QuestionField : UserControl
    {
        public event EventHandler<OnDeleteQuestionEventArgs> OnDeleteQuestionButtonClicked;

        private List<AnswerCreationSet> answerFields = new();
        private AnswerCreationSet currCorrectAnswerSet = null;

        private const int INITIAL_QUESTION_FIELD_COUNT = 4;
        private const int MINIMUM_ANSWERS = 2;

        public class OnDeleteQuestionEventArgs : EventArgs
        {
            public QuestionField questionField { get; set; }
        }
        public QuestionField()
        {
            InitializeComponent();
        }

        public void AddInitialAnswerSets()
        {
            for (int i = 0; i < INITIAL_QUESTION_FIELD_COUNT; i++)
            {
                AddAnswerSet();
            }
        }

        private AnswerCreationSet AddAnswerSet()
        {
            AnswerCreationSet newSet = new();

            answerFields.Add(newSet);
            answerSetPanel.Controls.Add(newSet);

            newSet.OnCorrectAnswerChanged += SelectCorrectAnswer;
            newSet.OnDeleteAnswerBtnClicked += DeleteAnswerSet;

            return newSet;
        }

        private void DeleteAnswerSet(object? sender, AnswerCreationSet.OnDeleteAnswerBtnClickedEventArgs e)
        {
            AnswerCreationSet answerSet = e.answerSet;

            if (answerSet == currCorrectAnswerSet)
            {
                currCorrectAnswerSet = null;
            }
            answerSetPanel.Controls.Remove(answerSet);
            answerFields.Remove(answerSet);
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

            if (answerFields.Count < MINIMUM_ANSWERS)
            {
                errorProvider.SetError(answerSetPanel, $"There must be atleast {MINIMUM_ANSWERS} answers");
                return false;
            }

            // Check answer sets
            foreach (AnswerCreationSet answer in answerFields)
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

        public Question GetQuestionObject()
        {
            List<string> answerList = new();

            // Create a list of answers
            foreach (AnswerCreationSet answerSet in answerFields)
            {
                answerList.Add(answerSet.answer);
            }

            return new Question(questionInput.Text, answerList, currCorrectAnswerSet.answer);
        }

        public void FillInputsWithData(Question question)
        {
            questionInput.Text = question.question;

            for (int i = 0; i < question.answers.Count; i++)
            {
                AnswerCreationSet newAnswer = AddAnswerSet();
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
            OnDeleteQuestionButtonClicked?.Invoke(this, new OnDeleteQuestionEventArgs()
            {
                questionField = this
            });
        }

        private void addAnswerBtn_Click(object sender, EventArgs e)
        {
            AddAnswerSet();
        }
    }
}
