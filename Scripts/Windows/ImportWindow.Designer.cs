namespace TestMakerTaker.Scripts.Forms {
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
            importView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            importView.Location = new Point(0, -1);
            importView.Margin = new Padding(0);
            importView.Name = "importView";
            importView.Size = new Size(576, 523);
            importView.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(217, 475);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(165, 33);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Close";
            cancelButton.UseVisualStyleBackColor = true;
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
            Name = "ImportWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ImportWindow";
            ResumeLayout(false);
        }

        #endregion

        private ImportView importView;
        private Button cancelButton;
    }
}