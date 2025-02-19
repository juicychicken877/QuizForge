namespace TestMakerTaker.Scripts.Forms {
    partial class MessageDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            messageLabel = new Label();
            yesBtn = new Button();
            noBtn = new Button();
            SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.Location = new Point(2, 1);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(233, 43);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Message";
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yesBtn
            // 
            yesBtn.Location = new Point(12, 47);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(95, 34);
            yesBtn.TabIndex = 1;
            yesBtn.Text = "Yes";
            yesBtn.UseVisualStyleBackColor = true;
            yesBtn.Click += yesBtn_Click;
            // 
            // noBtn
            // 
            noBtn.Location = new Point(129, 47);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(95, 34);
            noBtn.TabIndex = 2;
            noBtn.Text = "No";
            noBtn.UseVisualStyleBackColor = true;
            noBtn.Click += noBtn_Click;
            // 
            // MessageDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 89);
            Controls.Add(noBtn);
            Controls.Add(yesBtn);
            Controls.Add(messageLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MessageDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Message Title";
            ResumeLayout(false);
        }

        #endregion

        private Label messageLabel;
        private Button yesBtn;
        private Button noBtn;
    }
}