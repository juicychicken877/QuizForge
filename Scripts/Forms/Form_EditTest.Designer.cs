namespace TestMakerTaker {
    partial class Form_EditTest {
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
            testForm = new TestForm();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // testForm
            // 
            testForm.BackColor = Color.White;
            testForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            testForm.Location = new Point(3, 3);
            testForm.Margin = new Padding(4);
            testForm.Name = "testForm";
            testForm.Size = new Size(576, 523);
            testForm.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            deleteButton.ForeColor = Color.Black;
            deleteButton.Location = new Point(460, 374);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(119, 35);
            deleteButton.TabIndex = 13;
            deleteButton.Text = "Delete Test";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // EditTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 529);
            Controls.Add(deleteButton);
            Controls.Add(testForm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EditTestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Maker Taker - Edit Test";
            FormClosed += EditTestForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private TestForm testForm;
        private Button deleteButton;
    }
}