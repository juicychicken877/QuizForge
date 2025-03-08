namespace QuizForge.Scripts.Forms {
    partial class ImportWindow {
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
            importView = new ImportView();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // importView
            // 
            importView.BackColor = Color.White;
            importView.Dock = DockStyle.Fill;
            importView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            importView.Location = new Point(0, 0);
            importView.Margin = new Padding(0);
            importView.Name = "importView";
            importView.Size = new Size(577, 525);
            importView.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.WhiteSmoke;
            cancelButton.Location = new Point(309, 467);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(128, 35);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Close";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // ImportWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 525);
            Controls.Add(cancelButton);
            Controls.Add(importView);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ImportWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import Quiz Window";
            ResumeLayout(false);
        }

        #endregion

        private ImportView importView;
        private Button cancelButton;
    }
}