using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizForge.Scripts
{
    public static class Settings
    {
        /* 
         * File Paths
         * (Relative paths - assuming your executable is in {ProjectFolder}\bin\Debug\net{Version}-windows\{Name}.exe)
         * If paths don't work and if you're brave enough - change it
        */
        public static readonly string BASE_AI_PROMPT_PATH = "../../../Data/BaseAIPrompt.txt";
        public static readonly string SAVED_QUIZZES_FILE_PATH = "../../../Data/SavedQuizzes.json";
        public static readonly string EXAMPLE_QUIZZES_FILE_PATH = "../../../Data/ExampleQuizzes.json";

        // AI Prompt Form Settings
        public static readonly int AI_PROMPT_FORM_MIN_QUIZ_COUNT = 1;
        public static readonly int AI_PROMPT_FORM_MAX_QUIZ_COUNT = 10;
        public static readonly int AI_PROMPT_FORM_MIN_QUESTION_COUNT = 1;
        public static readonly int AI_PROMPT_FORM_MAX_QUESTION_COUNT = 10;
        public static readonly int AI_PROMPT_MAX_ANSWER_COUNT = 6;

        // Quiz Form
        public static readonly int QUIZ_FORM_MIN_ANSWER_COUNT = 2;
        public static readonly int QUIZ_FORM_TITLE_MIN_LENGTH = 5;
        public static readonly int QUIZ_FORM_TITLE_MAX_LENGTH = 100;
        public static readonly int QUIZ_FORM_DESCRIPTION_MIN_LENGTH = 0;
        public static readonly int QUIZ_FORM_DESCRIPTION_MAX_LENGTH = 200;
        // Question Field in Quiz Form
        public static readonly int QUESTION_FIELD_INITIAL_QUESTION_COUNT = 4;
        public static readonly int QUESTION_FIELD_QUESTION_MIN_LENGTH = 0;
        public static readonly int QUESTION_FIELD_QUESTION_MAX_LENGTH = 200;

        // Button Colors
        public static readonly Color DEFAULT_BUTTON_COLOR = Color.WhiteSmoke;
        public static readonly Color SELECTED_BUTTON_COLOR = Color.FromArgb(130, 183, 209);
        public static readonly Color CORRECT_BUTTON_COLOR = Color.FromArgb(108, 212, 83);
        public static readonly Color INCORRECT_BUTTON_COLOR = Color.FromArgb(209, 67, 67);
    }
}
