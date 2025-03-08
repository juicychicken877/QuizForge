namespace QuizForge {
    partial class SolveQuizWindow {
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
            quizTitleLabel = new Label();
            questionCountLabel = new Label();
            questionLabel = new Label();
            answerPanel = new FlowLayoutPanel();
            previousQuestionBtn = new Button();
            resultLabel = new Label();
            checkAnswerBtn = new Button();
            nextBtn = new Button();
            SuspendLayout();
            // 
            // testTitleLabel
            // 
            quizTitleLabel.Location = new Point(0, 0);
            quizTitleLabel.Margin = new Padding(0);
            quizTitleLabel.Name = "testTitleLabel";
            quizTitleLabel.Size = new Size(263, 36);
            quizTitleLabel.TabIndex = 0;
            quizTitleLabel.Text = "Test Title";
            // 
            // questionCountLabel
            // 
            questionCountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            questionCountLabel.Location = new Point(260, 0);
            questionCountLabel.Margin = new Padding(0);
            questionCountLabel.Name = "questionCountLabel";
            questionCountLabel.Size = new Size(263, 36);
            questionCountLabel.TabIndex = 1;
            questionCountLabel.Text = "Question 0 of 0";
            questionCountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // questionLabel
            // 
            questionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            questionLabel.Location = new Point(0, 36);
            questionLabel.Margin = new Padding(0);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(526, 37);
            questionLabel.TabIndex = 2;
            questionLabel.Text = "Question?";
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerPanel
            // 
            answerPanel.AutoScroll = true;
            answerPanel.FlowDirection = FlowDirection.TopDown;
            answerPanel.Location = new Point(0, 76);
            answerPanel.Margin = new Padding(0);
            answerPanel.Name = "answerPanel";
            answerPanel.Size = new Size(526, 244);
            answerPanel.TabIndex = 3;
            answerPanel.WrapContents = false;
            // 
            // previousQuestionButton
            // 
            previousQuestionBtn.BackColor = Color.WhiteSmoke;
            previousQuestionBtn.Location = new Point(5, 375);
            previousQuestionBtn.Name = "previousQuestionButton";
            previousQuestionBtn.Size = new Size(128, 35);
            previousQuestionBtn.TabIndex = 6;
            previousQuestionBtn.Text = "Previous";
            previousQuestionBtn.UseVisualStyleBackColor = false;
            previousQuestionBtn.Click += previousQuestionButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(0, 323);
            resultLabel.Margin = new Padding(0);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(526, 44);
            resultLabel.TabIndex = 7;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkAnswerButton
            // 
            checkAnswerBtn.BackColor = Color.WhiteSmoke;
            checkAnswerBtn.Location = new Point(260, 375);
            checkAnswerBtn.Name = "checkAnswerButton";
            checkAnswerBtn.Size = new Size(128, 35);
            checkAnswerBtn.TabIndex = 8;
            checkAnswerBtn.Text = "Check Answer";
            checkAnswerBtn.UseVisualStyleBackColor = false;
            checkAnswerBtn.Click += checkAnswerButton_Click;
            // 
            // nextButton
            // 
            nextBtn.BackColor = Color.WhiteSmoke;
            nextBtn.Location = new Point(394, 375);
            nextBtn.Name = "nextButton";
            nextBtn.Size = new Size(128, 35);
            nextBtn.TabIndex = 9;
            nextBtn.Text = "NextBtn";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextButton_Click;
            // 
            // SolveTestWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 415);
            Controls.Add(nextBtn);
            Controls.Add(checkAnswerBtn);
            Controls.Add(resultLabel);
            Controls.Add(previousQuestionBtn);
            Controls.Add(answerPanel);
            Controls.Add(questionLabel);
            Controls.Add(questionCountLabel);
            Controls.Add(quizTitleLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "SolveTestWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Solve Quiz Window";
            ResumeLayout(false);
        }

        #endregion

        private Label quizTitleLabel;
        private Label questionCountLabel;
        private Label questionLabel;
        private FlowLayoutPanel answerPanel;
        private Button previousQuestionBtn;
        private Label resultLabel;
        private Button checkAnswerBtn;
        private Button nextBtn;
    }
}