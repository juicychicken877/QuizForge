namespace TestMakerTaker.Scripts.Forms {
    partial class AnswerListElement {
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
            questionLabel = new Label();
            userAnswerLabel = new Label();
            correctAnswerLabel = new Label();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            questionLabel.Location = new Point(0, 0);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(468, 24);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "Question";
            questionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userAnswerLabel
            // 
            userAnswerLabel.Location = new Point(0, 24);
            userAnswerLabel.Name = "userAnswerLabel";
            userAnswerLabel.Size = new Size(468, 24);
            userAnswerLabel.TabIndex = 1;
            userAnswerLabel.Text = "Your Answer: -";
            userAnswerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // correctAnswerLabel
            // 
            correctAnswerLabel.Location = new Point(0, 48);
            correctAnswerLabel.Name = "correctAnswerLabel";
            correctAnswerLabel.Size = new Size(468, 24);
            correctAnswerLabel.TabIndex = 2;
            correctAnswerLabel.Text = "Correct Answer: -";
            correctAnswerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AnswerListElement
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(correctAnswerLabel);
            Controls.Add(userAnswerLabel);
            Controls.Add(questionLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "AnswerListElement";
            Size = new Size(468, 72);
            ResumeLayout(false);
        }

        #endregion

        private Label questionLabel;
        private Label userAnswerLabel;
        private Label correctAnswerLabel;
    }
}
