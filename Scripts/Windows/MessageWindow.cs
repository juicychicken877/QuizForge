﻿using System;
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

namespace QuizForge.Scripts.Forms
{
    public partial class MessageWindow : Form {
        public class Button {
            public string text;
            public MessageManager.MessageWindowBtnClickedHandler? ClickHandler;

            public Button(string text, MessageManager.MessageWindowBtnClickedHandler? ClickHandler) {
                this.text = text;
                this.ClickHandler = ClickHandler;
            }
        }

        private SystemSound popupSound = SystemSounds.Hand;

        public MessageWindow(string title, string message, List<MessageWindow.Button> buttons) {
            this.InitializeComponent();

            this.SetButtons(buttons);

            popupSound.Play();
            this.Text = title;
            messageLabel.Text = message;
        }
        private void SetButtons(List<MessageWindow.Button> buttons) {
            foreach (MessageWindow.Button button in buttons) {
                System.Windows.Forms.Button newButton = new();

                newButton.Text = button.text;
                newButton.Click += (sender, e) => button.ClickHandler?.Invoke();

                btnPanel.Controls.Add(newButton);
            }

            this.CenterButtons();
        }

        // Function generated by my dear friend Gemini Google
        private void CenterButtons() {
            // Calculate the total width of the buttons.
            int totalButtonsWidth = 0;
            foreach (System.Windows.Forms.Button control in btnPanel.Controls) {
                totalButtonsWidth += control.Width + btnPanel.Margin.Horizontal; // Add margin to total width
            }

            // Calculate the available space in the FlowLayoutPanel.
            int availableSpace = btnPanel.ClientSize.Width;

            // Calculate the left padding needed to center the buttons.
            int leftPadding = (availableSpace - totalButtonsWidth) / 2;

            // Apply the padding to the FlowLayoutPanel.
            if (leftPadding > 0) {
                btnPanel.Padding = new Padding(leftPadding, btnPanel.Padding.Top, 0, btnPanel.Padding.Bottom);
            } else {
                btnPanel.Padding = new Padding(0, btnPanel.Padding.Top, 0, btnPanel.Padding.Bottom); //Reset padding if the buttons take up more space then the panel
            }

            btnPanel.PerformLayout(); // Force the panel to recalculate the layout.
        }
    }
}
