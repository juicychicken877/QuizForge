namespace QuizForge {
    partial class EditQuizWindow {
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
            quizForm = new QuizForm();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // testForm
            // 
            quizForm.BackColor = Color.White;
            quizForm.Dock = DockStyle.Fill;
            quizForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            quizForm.Location = new Point(0, 0);
            quizForm.Margin = new Padding(0);
            quizForm.Name = "testForm";
            quizForm.Size = new Size(582, 529);
            quizForm.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.WhiteSmoke;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            deleteButton.Location = new Point(445, 377);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(128, 35);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete Quiz";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // EditTestWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 529);
            Controls.Add(deleteButton);
            Controls.Add(quizForm);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "EditTestWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Quiz Window";
            ResumeLayout(false);
        }

        #endregion

        private QuizForm quizForm;
        private Button deleteButton;
    }
}