using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizForge.Scripts;
using QuizForge.Scripts.Forms;

namespace QuizForge
{
    public partial class EditQuizWindow : Form {
        public MainWindow.QuizInteractionBtnHandler DeleteButtonClickedHandler;

        public static EditQuizWindow Instance;
        private Quiz quizRef;

        public EditQuizWindow(Quiz quiz) {
            if (Instance != null) {
                Instance.Close();
                Instance.Dispose();
                Instance = null;
            }
            Instance = this;

            this.InitializeComponent();

            quizRef = quiz;

            quizForm.Fill(quiz);
        }

        public Quiz GetQuizRef() {
            return quizRef;
        }

        public QuizForm GetQuizForm() {
            return quizForm;
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            MessageManager.NewWindow("Edit Quiz Window Info", "Are you sure you want to delete this quiz?", [new MessageWindow.Button("Yes", ProceedDelete), new MessageWindow.Button("No", null)]);
        }

        private void ProceedDelete() {
            DeleteButtonClickedHandler?.Invoke(quizRef);
        }
    }
}
