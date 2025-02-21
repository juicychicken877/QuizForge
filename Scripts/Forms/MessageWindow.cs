using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMakerTaker.Scripts.Forms
{
    public partial class MessageWindow : Form {
        public event EventHandler OnYesBtnClick;

        public static MessageWindow Instance { get; private set; }
        private SystemSound popupSound;

        public enum MessageDialogMode {
            Error,
            Info
        }
        public MessageWindow(MessageDialogMode dialogMode, string dialogTitle, string message, string yesBtnText, string noBtnText) {
            if (Instance != null) {
                Instance.Close();
                Instance.Dispose();
                Instance = null;
            }
            Instance = this;

            InitializeComponent();

            // Play different sound depending on the dialogs' motive
            switch (dialogMode) {
                case MessageDialogMode.Error: popupSound = SystemSounds.Hand; break;
                case MessageDialogMode.Info: popupSound = SystemSounds.Asterisk; break;
                default: popupSound = SystemSounds.Asterisk; break;
            }
            popupSound.Play();
            // Change labels
            this.Text = dialogTitle;
            messageLabel.Text = message;
            yesBtn.Text = yesBtnText;
            noBtn.Text = noBtnText;
        }

        private void yesBtn_Click(object sender, EventArgs e) {
            OnYesBtnClick?.Invoke(this, EventArgs.Empty);

            this.Close();
        }

        private void noBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
