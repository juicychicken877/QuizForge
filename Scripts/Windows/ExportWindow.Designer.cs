namespace TestMakerTaker.Scripts.Windows {
    partial class ExportWindow {
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
            exportView = new TestMakerTaker.Scripts.UserControls.ExportView();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // exportView
            // 
            exportView.Dock = DockStyle.Fill;
            exportView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            exportView.Location = new Point(0, 0);
            exportView.Margin = new Padding(0);
            exportView.Name = "exportView";
            exportView.Size = new Size(577, 525);
            exportView.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(217, 475);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(165, 33);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Close";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ExportWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 525);
            Controls.Add(cancelButton);
            Controls.Add(exportView);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "ExportWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ExportWindow";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.ExportView exportView;
        private Button cancelButton;
    }
}