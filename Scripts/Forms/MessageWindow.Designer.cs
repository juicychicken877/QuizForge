namespace TestMakerTaker.Scripts.Forms {
    partial class MessageWindow {
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
            btnPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(2, 1);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(299, 43);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Message";
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPanel
            // 
            btnPanel.Location = new Point(2, 47);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(299, 42);
            btnPanel.TabIndex = 1;
            // 
            // MessageWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 89);
            Controls.Add(btnPanel);
            Controls.Add(messageLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MessageWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Message Title";
            ResumeLayout(false);
        }

        #endregion

        private Label messageLabel;
        private FlowLayoutPanel btnPanel;
    }
}