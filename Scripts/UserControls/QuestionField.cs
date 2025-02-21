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

namespace TestMakerTaker
{
    public partial class QuestionField : UserControl
    {
        public event EventHandler<OnDeleteQuestionEventArgs> OnDeleteQuestionButtonClicked;

        public class OnDeleteQuestionEventArgs : EventArgs
        {
            public QuestionField questionField { get; set; }
        }
        public QuestionField()
        {
            InitializeComponent();
        }

        public bool Correct()
        {
            if (questionInput.Text == "")
            {
                errorProvider.SetError(questionInput, "Question can't be empty");
                return false;
            } else {
                errorProvider.SetError(questionInput, null);
            }

            if (answer1Input.Text == "" || answer2Input.Text == "" || answer3Input.Text == "" || answer4Input.Text == "") {
                errorProvider.SetError(answer1Input, "Answers can't be empty");
                return false;
            } else {
                errorProvider.SetError(answer1Input, null);
            }

                // if correct answer is "" that means no radio buttons is checked
                string correcto = GetCorrectAnswer();

            if (correcto == "") {
                errorProvider.SetError(radioButton1, "Select correct answer");    
                return false; 
            } else {
                errorProvider.SetError(radioButton1, null);
            }

            return true;
        }

        private string GetCorrectAnswer() {
            string correctAnswer = "";

            if (radioButton1.Checked) correctAnswer = answer1Input.Text;
            if(radioButton2.Checked) correctAnswer = answer2Input.Text;
            if(radioButton3.Checked) correctAnswer = answer3Input.Text;
            if(radioButton4.Checked) correctAnswer = answer4Input.Text;

            return correctAnswer;
        }

        public Question GetQuestionObject()
        {
            List<string> answerList = new() { answer1Input.Text, answer2Input.Text, answer3Input.Text, answer4Input.Text };
            return new Question(questionInput.Text, answerList, GetCorrectAnswer());
        }

        public void FillInputsWithData(Question question) {
            bool isCorrectAnswerChecked = false;
            questionInput.Text = question.question;

            // fill answer inputs with answers from question object
            TextBox[] answerInputArray = new TextBox[4] { answer1Input, answer2Input, answer3Input, answer4Input };
            RadioButton[] radioButtonArray = new RadioButton[4] { radioButton1, radioButton2, radioButton3, radioButton4 };

            for (int i=0; i<4; i++) {
                answerInputArray[i].Text = question.answers[i];

                // if the answer from an input equals correct answer, check the radio button next to that input
                if (answerInputArray[i].Text == question.correctAnswer && !isCorrectAnswerChecked) {
                    radioButtonArray[i].Checked = true;
                    isCorrectAnswerChecked = true;
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
   
    }
}
