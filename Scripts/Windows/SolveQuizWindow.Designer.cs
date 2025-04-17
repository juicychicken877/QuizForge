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
            // quizTitleLabel
            // 
            quizTitleLabel.Dock = DockStyle.Top;
            quizTitleLabel.Location = new Point(0, 0);
            quizTitleLabel.Margin = new Padding(0);
            quizTitleLabel.MaximumSize = new Size(263, 36);
            quizTitleLabel.MinimumSize = new Size(263, 21);
            quizTitleLabel.Name = "quizTitleLabel";
            quizTitleLabel.Size = new Size(263, 21);
            quizTitleLabel.TabIndex = 0;
            quizTitleLabel.Text = "Test Title";
            // 
            // questionCountLabel
            // 
            questionCountLabel.AutoSize = true;
            questionCountLabel.Location = new Point(260, 0);
            questionCountLabel.Margin = new Padding(0);
            questionCountLabel.MaximumSize = new Size(263, 0);
            questionCountLabel.MinimumSize = new Size(263, 21);
            questionCountLabel.Name = "questionCountLabel";
            questionCountLabel.Size = new Size(263, 21);
            questionCountLabel.TabIndex = 1;
            questionCountLabel.Text = "Question 0 of 0";
            questionCountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Dock = DockStyle.Top;
            questionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            questionLabel.Location = new Point(0, 21);
            questionLabel.Margin = new Padding(0);
            questionLabel.MaximumSize = new Size(523, 0);
            questionLabel.MinimumSize = new Size(523, 21);
            questionLabel.Name = "questionLabel";
            questionLabel.Padding = new Padding(0, 10, 0, 10);
            questionLabel.Size = new Size(523, 62);
            questionLabel.TabIndex = 2;
            questionLabel.Text = "dasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdas";
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answerPanel
            // 
            answerPanel.AutoScroll = true;
            answerPanel.Dock = DockStyle.Top;
            answerPanel.FlowDirection = FlowDirection.TopDown;
            answerPanel.Location = new Point(0, 83);
            answerPanel.Margin = new Padding(0);
            answerPanel.Name = "answerPanel";
            answerPanel.Size = new Size(525, 244);
            answerPanel.TabIndex = 3;
            answerPanel.WrapContents = false;
            // 
            // previousQuestionBtn
            // 
            previousQuestionBtn.BackColor = Color.WhiteSmoke;
            previousQuestionBtn.Location = new Point(5, 375);
            previousQuestionBtn.Name = "previousQuestionBtn";
            previousQuestionBtn.Size = new Size(128, 35);
            previousQuestionBtn.TabIndex = 6;
            previousQuestionBtn.Text = "Previous";
            previousQuestionBtn.UseVisualStyleBackColor = false;
            previousQuestionBtn.Click += previousQuestionButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Dock = DockStyle.Top;
            resultLabel.Location = new Point(0, 327);
            resultLabel.Margin = new Padding(0);
            resultLabel.MaximumSize = new Size(525, 21);
            resultLabel.MinimumSize = new Size(525, 21);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(525, 21);
            resultLabel.TabIndex = 7;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkAnswerBtn
            // 
            checkAnswerBtn.BackColor = Color.WhiteSmoke;
            checkAnswerBtn.Location = new Point(260, 375);
            checkAnswerBtn.Name = "checkAnswerBtn";
            checkAnswerBtn.Size = new Size(128, 35);
            checkAnswerBtn.TabIndex = 8;
            checkAnswerBtn.Text = "Check Answer";
            checkAnswerBtn.UseVisualStyleBackColor = false;
            checkAnswerBtn.Click += checkAnswerButton_Click;
            // 
            // nextBtn
            // 
            nextBtn.BackColor = Color.WhiteSmoke;
            nextBtn.Location = new Point(394, 375);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(128, 35);
            nextBtn.TabIndex = 9;
            nextBtn.Text = "NextBtn";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextButton_Click;
            // 
            // SolveQuizWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            Name = "SolveQuizWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Solve Quiz Window";
            Load += SolveQuizWindow_Load;
            ResumeLayout(false);
            PerformLayout();
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