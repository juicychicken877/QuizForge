using QuizForge.Scripts.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizForge.Scripts
{
    public static class Support
    {
        public static List<T> ShuffleList<T>(List<T> list)
        {
            List<T> randomizedList = list;

            Random random = new();
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T temp = randomizedList[k];
                randomizedList[k] = randomizedList[n];
                randomizedList[n] = temp;
            }

            return randomizedList;
        }

        public static string GenerateAIPrompt(int quizCount, int questionCount, bool noDuplicates, string moreInfo) {
            try {
                string basePrompt = File.ReadAllText(Settings.BASE_AI_PROMPT_PATH);

                string noDuplicatesPartialPrompt = "";
                if (noDuplicates) {
                    List<Quiz> quizzes = MainWindow.GetQuizzes();

                    foreach (Quiz quiz in quizzes) {
                        noDuplicatesPartialPrompt += quiz.title + ", ";
                    }
                }

                string[] settingsInstructions = [
                    $"Number of questions per quiz: [{Settings.AI_PROMPT_FORM_MIN_QUESTION_COUNT}, {Settings.AI_PROMPT_FORM_MAX_QUESTION_COUNT}]. ",
                    $"Number of answers per question: [{Settings.QUIZ_FORM_MIN_ANSWER_COUNT}, {Settings.AI_PROMPT_MAX_ANSWER_COUNT}]. ",
                    $"Number of quizzes: [{Settings.AI_PROMPT_FORM_MIN_QUIZ_COUNT}, {Settings.AI_PROMPT_FORM_MAX_QUIZ_COUNT}]. "
                ];

                string settingsPartialPrompt = "";

                foreach (string setting in settingsInstructions) {
                    settingsPartialPrompt += setting;
                }

                string prompt = $"{basePrompt}.Settings: {settingsPartialPrompt}.No quizzes that are named:[{noDuplicatesPartialPrompt}].Instructions set by a user (MOST IMPORTANT): Number of quizzes in a list: {quizCount}.Number of questions in a quiz: {questionCount}. More information about the quizzes: {moreInfo}.";

                return prompt;
            } catch (Exception ex) {
                MessageManager.NewWindow("AI Prompt Generator Error", ex.Message, [new MessageWindow.Button("OK", null)]);
                return "";
            }
        }

    }
}
