using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizForge.Scripts
{
    public static class Settings
    {
        // AI Prompt Form Settings
        public static int AI_PROMPT_FORM_MIN_QUIZ_COUNT = 1;
        public static int AI_PROMPT_FORM_MAX_QUIZ_COUNT = 10;
        public static int AI_PROMPT_FORM_MIN_QUESTION_COUNT = 1;
        public static int AI_PROMPT_FORM_MAX_QUESTION_COUNT = 20;

        // Quiz Form
        public static int QUIZ_FORM_MIN_ANSWER_COUNT = 2;
        public static int QUIZ_FORM_MAX_ANSWER_COUNT = 12;
    }
}
