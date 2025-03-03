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
            importView1 = new ImportView();
            SuspendLayout();
            // 
            // importView1
            // 
            importView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            importView1.Location = new Point(0, -1);
            importView1.Margin = new Padding(0);
            importView1.Name = "importView1";
            importView1.Size = new Size(576, 523);
            importView1.TabIndex = 0;
            // 
            // ImportWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 525);
            Controls.Add(importView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "ImportWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ImportWindow";
            ResumeLayout(false);
        }

        #endregion

        private ImportView importView1;
    }
}