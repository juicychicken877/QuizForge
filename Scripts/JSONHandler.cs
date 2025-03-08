using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using QuizForge.Scripts.Forms;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace QuizForge.Scripts
{
    public static class JSONHandler
    {
        public static readonly string SAVED_QUIZZES_FILE_PATH = "../../../Data/SavedQuizzes.json";
        public static readonly string EXAMPLE_QUIZZES_FILE_PATH = "../../../Data/ExampleQuizzes.json";

        public static void SaveQuizzes(List<Quiz> quizzes, string path)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(quizzes, new JsonSerializerOptions() { WriteIndented = true });
                File.WriteAllText(path, jsonString);
            }
            catch (Exception ex)
            {
                MessageManager.NewWindow("JSON Handler Error", ex.Message, [new MessageWindow.Button("OK", null)]);
            }
        }

        public static List<Quiz> LoadQuizzes(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string jsonString = File.ReadAllText(path);
                    List<Quiz> quizzes = JsonSerializer.Deserialize<List<Quiz>>(jsonString);

                    // If found quizzes
                    if (quizzes != null)
                        return quizzes;
                    else
                        return null;
                }
                else
                {
                    MessageManager.NewWindow("JSON Handler Error", $"{Path.GetFullPath(path)} not found.", [new MessageWindow.Button("OK", null)]);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageManager.NewWindow("JSON Handler Error", ex.Message, [new MessageWindow.Button("OK", null)]);

                return null;
            }
        }
    }
}
