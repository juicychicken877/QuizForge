using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMakerTaker.Scripts.Forms
{
    public partial class MessageWindow : Form {
        public MessageManager.MessageWindowBtnClickedHandler OkHandler;
        public MessageManager.MessageWindowBtnClickedHandler ConfirmationHandler;
        public MessageManager.MessageWindowBtnClickedHandler CancellationHandler;

        private SystemSound popupSound;

        public enum MessageWindowMode {
            Decision,
            Error,
            Info
        }
        public MessageWindow(MessageWindowMode windowMode, string title, string message) {
            InitializeComponent();
            SetButtons(windowMode);
            // Play different sound depending on the dialogs' motive
            switch (windowMode) {
                case MessageWindowMode.Decision: popupSound = SystemSounds.Beep; break;
                case MessageWindowMode.Error: popupSound = SystemSounds.Hand; break;
                case MessageWindowMode.Info: popupSound = SystemSounds.Asterisk; break;
            }
            popupSound.Play();

            this.Text = title;
            messageLabel.Text = message;
        }
        private void SetButtons(MessageWindowMode mode) {
            if (mode == MessageWindowMode.Decision) {
                Button confirmBtn = new();
                Button cancelBtn = new();

                confirmBtn.Text = "Confirm";
                confirmBtn.Click += ConfirmDecision;

                cancelBtn.Text = "Cancel";
                cancelBtn.Click += CancelDecision;

                btnPanel.Controls.AddRange([confirmBtn, cancelBtn]);
            } else {
                Button okBtn = new();

                okBtn.Text = "OK";
                okBtn.Click += OkBtn_Click;

                btnPanel.Controls.Add(okBtn);
            }
        }

        private void OkBtn_Click(object? sender, EventArgs e) {
            OkHandler?.Invoke();
        }

        private void ConfirmDecision(object? sender, EventArgs e) {
            ConfirmationHandler?.Invoke();
        }

        private void CancelDecision(object? sender, EventArgs e) {
            CancellationHandler?.Invoke();
        }
    }
}
