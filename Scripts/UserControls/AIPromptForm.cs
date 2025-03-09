using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizForge.Scripts.Forms;

namespace QuizForge.Scripts.UserControls
{
    public partial class AIPromptForm : UserControl {
        private readonly int minQuizCount = Settings.AI_PROMPT_FORM_MIN_QUIZ_COUNT;
        private readonly int maxQuizCount = Settings.AI_PROMPT_FORM_MAX_QUIZ_COUNT;

        private readonly int minQuestionCount = Settings.AI_PROMPT_FORM_MIN_QUESTION_COUNT;
        private readonly int maxQuestionCount = Settings.AI_PROMPT_FORM_MAX_QUESTION_COUNT;
        public AIPromptForm() {
            this.InitializeComponent();

            // Set limits
            quizCountInput.PlaceholderText = $"How many quizzes? [{minQuizCount}, {maxQuizCount}]";
            quizCountInput.MaxLength = maxQuizCount.ToString().Length;

            questionCountInput.PlaceholderText = $"How many questions per quiz? [{minQuestionCount}, {maxQuestionCount}]";
            questionCountInput.MaxLength = maxQuestionCount.ToString().Length;
        }

        private bool Correct() {
            // Check quiz count
            if (quizCountInput.Text == "" || Convert.ToInt32(quizCountInput.Text) < minQuizCount || Convert.ToInt32(quizCountInput.Text) > maxQuizCount) {
                MessageManager.NewWindow("AI Prompt Form Error", $"Incorrect quiz count. Should be [{minQuizCount}, {maxQuizCount}]", [new MessageWindow.Button("OK", null)]);
                return false;
            }
            // Check question count
            if (questionCountInput.Text == "" || Convert.ToInt32(questionCountInput.Text) < minQuestionCount || Convert.ToInt32(questionCountInput.Text) > maxQuestionCount) {
                MessageManager.NewWindow("AI Prompt Form Error", $"Incorrect question count. Should be [{minQuestionCount}, {maxQuestionCount}]", [new MessageWindow.Button("OK", null)]);
                return false;
            }
            return true;
        }

        private void Clear() {
            quizCountInput.Text = "";
            questionCountInput.Text = "";
            moreInfoInput.Text = "";
        }

        private void copyBtn_Click(object sender, EventArgs e) {
            // Check if provided data is correct
            if (this.Correct()) {
                try {
                    int quizCount = Convert.ToInt32(quizCountInput.Text);
                    int questionCount = Convert.ToInt32(questionCountInput.Text);

                    string prompt = Support.GenerateAIPrompt(quizCount, questionCount, noDuplicatesCheckBox.Checked, moreInfoInput.Text);

                    Clipboard.SetText(prompt);

                    MessageManager.NewWindow("AI Prompt Form Info", $"Prompt copied to clipboard. Total length of prompt: {prompt.Length} characters", [new MessageWindow.Button("Ok", null)]);

                    this.Clear();
                } catch(Exception ex) {
                    MessageManager.NewWindow("AI Prompt Form Error", ex.Message, [new MessageWindow.Button("Ok", null)]);
                }
            }
        }
    }
}
