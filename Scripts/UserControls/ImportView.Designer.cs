namespace TestMakerTaker.Scripts.Forms {
    partial class ImportView {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            selectFileBtn = new Button();
            selectedFileNameLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            importButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(33, 14);
            label1.Name = "label1";
            label1.Size = new Size(285, 31);
            label1.TabIndex = 0;
            label1.Text = "Select JSON file to import";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectFileBtn
            // 
            selectFileBtn.Location = new Point(33, 57);
            selectFileBtn.Name = "selectFileBtn";
            selectFileBtn.Size = new Size(98, 31);
            selectFileBtn.TabIndex = 1;
            selectFileBtn.Text = "Browse";
            selectFileBtn.UseVisualStyleBackColor = true;
            // 
            // selectedFileNameLabel
            // 
            selectedFileNameLabel.Location = new Point(137, 57);
            selectedFileNameLabel.Name = "selectedFileNameLabel";
            selectedFileNameLabel.Size = new Size(129, 31);
            selectedFileNameLabel.TabIndex = 2;
            selectedFileNameLabel.Text = "No file selected";
            selectedFileNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(33, 137);
            label2.Name = "label2";
            label2.Size = new Size(285, 31);
            label2.TabIndex = 3;
            label2.Text = "Detected tests:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new Point(33, 179);
            label3.Name = "label3";
            label3.Size = new Size(158, 31);
            label3.TabIndex = 4;
            label3.Text = "No tests detected";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 269);
            label4.Name = "label4";
            label4.Size = new Size(276, 21);
            label4.TabIndex = 5;
            label4.Text = "// A custom user control SelectableList";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(33, 407);
            label5.Name = "label5";
            label5.Size = new Size(285, 31);
            label5.TabIndex = 6;
            label5.Text = "Select tests you want to import";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // importButton
            // 
            importButton.Location = new Point(397, 475);
            importButton.Name = "importButton";
            importButton.Size = new Size(165, 33);
            importButton.TabIndex = 7;
            importButton.Text = "Confirm Import";
            importButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(272, 475);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(119, 33);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // ImportView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cancelButton);
            Controls.Add(importButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(selectedFileNameLabel);
            Controls.Add(selectFileBtn);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(0);
            Name = "ImportView";
            Size = new Size(576, 523);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button selectFileBtn;
        private Label selectedFileNameLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button importButton;
        private Button cancelButton;
    }
}
