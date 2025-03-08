namespace QuizForge.Scripts.UserControls
{
    partial class AnswerCreationSet
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            answerInput = new TextBox();
            correctAnswerInput = new RadioButton();
            deleteAnswerSetBtn = new Label();
            SuspendLayout();
            // 
            // answerInput
            // 
            answerInput.Location = new Point(0, 0);
            answerInput.Margin = new Padding(0);
            answerInput.Name = "answerInput";
            answerInput.PlaceholderText = "Answer";
            answerInput.Size = new Size(268, 29);
            answerInput.TabIndex = 0;
            // 
            // correctAnswerInput
            // 
            correctAnswerInput.AutoSize = true;
            correctAnswerInput.Location = new Point(281, 7);
            correctAnswerInput.Name = "correctAnswerInput";
            correctAnswerInput.Size = new Size(14, 13);
            correctAnswerInput.TabIndex = 1;
            correctAnswerInput.TabStop = true;
            correctAnswerInput.UseVisualStyleBackColor = true;
            correctAnswerInput.CheckedChanged += correctAnswerInput_CheckedChanged;
            // 
            // deleteAnswerSetBtn
            // 
            deleteAnswerSetBtn.Cursor = Cursors.Hand;
            deleteAnswerSetBtn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteAnswerSetBtn.ForeColor = Color.Red;
            deleteAnswerSetBtn.Location = new Point(315, 0);
            deleteAnswerSetBtn.Name = "deleteAnswerSetBtn";
            deleteAnswerSetBtn.Size = new Size(27, 29);
            deleteAnswerSetBtn.TabIndex = 2;
            deleteAnswerSetBtn.Text = "-";
            deleteAnswerSetBtn.TextAlign = ContentAlignment.MiddleCenter;
            deleteAnswerSetBtn.Click += deleteAnswerSetBtn_Click;
            // 
            // AnswerCreationSet
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(deleteAnswerSetBtn);
            Controls.Add(correctAnswerInput);
            Controls.Add(answerInput);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "AnswerCreationSet";
            Size = new Size(342, 29);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox answerInput;
        private RadioButton correctAnswerInput;
        private Label deleteAnswerSetBtn;
    }
}
