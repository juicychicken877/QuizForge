using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestMakerTaker.Scripts.Forms;

namespace TestMakerTaker.Scripts
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

        //public static void NewInfoWindow(string title, string description, List<MessageWindow.Button> buttons) {
        //    foreach (MessageWindow.Button button in buttons) {
        //        button.ClickHandler += CloseMessageWindow;
        //    }
        //    MessageWindow infoWindow = new(title, description, buttons);
        //    SetMessageWindowInstance(infoWindow);

        //    infoWindow.ShowDialog();
        //}

        //public static void NewErrorWindow(string title, string description, MessageWindowBtnClickedHandler? OkHandler) {
        //    MessageWindow errorWindow = new(MessageWindow.MessageWindowMode.Error, title, description);
        //    SetMessageWindowInstance(errorWindow);

        //    OkHandler += CloseMessageWindow;
        //    errorWindow.OkHandler = OkHandler ?? CloseMessageWindow;

        //    errorWindow.ShowDialog();
        //}

        //public static void NewDecisionWindow(string title, string description, MessageWindowBtnClickedHandler? ConfirmationHandler, MessageWindowBtnClickedHandler? CancellationHandler) {
        //    MessageWindow decisionWindow = new(MessageWindow.MessageWindowMode.Decision, title, description);
        //    SetMessageWindowInstance(decisionWindow);

        //    ConfirmationHandler += CloseMessageWindow;
        //    CancellationHandler += CloseMessageWindow;
        //    decisionWindow.ConfirmationHandler = ConfirmationHandler ?? CloseMessageWindow;
        //    decisionWindow.CancellationHandler = CancellationHandler ?? CloseMessageWindow;

        //    decisionWindow.ShowDialog();
        
    }
}
