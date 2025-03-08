using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using QuizForge.Scripts.Forms;

namespace QuizForge.Scripts
{
    public static class MessageManager
    {
        public delegate void MessageWindowBtnClickedHandler();

        private static MessageWindow MessageWindowInstance;

        private static void SetMessageWindowInstance(MessageWindow newWindow) {
            if (MessageWindowInstance != null) {
                MessageWindowInstance.Close();
                MessageWindowInstance.Dispose();
                MessageWindowInstance = null;
            }
            MessageWindowInstance = newWindow;
        }

        private static void CloseMessageWindow() {
            if (MessageWindowInstance != null)
                MessageWindowInstance.Close();
        }

        public static void NewWindow(string title, string description, List<MessageWindow.Button> buttons) {
            // Assign a closing function to delegate
            foreach (MessageWindow.Button button in buttons) {
                if (button.ClickHandler == null) {
                    button.ClickHandler = CloseMessageWindow;
                } else {
                    button.ClickHandler += CloseMessageWindow;
                }
            }

            MessageWindow newWindow = new(title, description, buttons);

            SetMessageWindowInstance(newWindow);

            newWindow.ShowDialog();
        }
    }
}
