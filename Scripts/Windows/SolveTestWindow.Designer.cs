namespace TestMakerTaker {
    partial class SolveTestWindow {
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
            testTitleLabel = new Label();
            questionCountLabel = new Label();
            questionLabel = new Label();
            answerPanel = new FlowLayoutPanel();
            previousQuestionButton = new Button();
            resultLabel = new Label();
            checkAnswerButton = new Button();
            nextButton = new Button();
            SuspendLayout();
            // 
            // testTitleLabel
            // 
            testTitleLabel.Location = new Point(0, 0);
            testTitleLabel.Margin = new Padding(0);
            testTitleLabel.Name = "testTitleLabel";
            testTitleLabel.Size = new Size(263, 36);
            testTitleLabel.TabIndex = 0;
            testTitleLabel.Text = "Test Title";
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
            previousQuestionButton.BackColor = Color.WhiteSmoke;
            previousQuestionButton.Location = new Point(5, 375);
            previousQuestionButton.Name = "previousQuestionButton";
            previousQuestionButton.Size = new Size(128, 35);
            previousQuestionButton.TabIndex = 6;
            previousQuestionButton.Text = "Previous";
            previousQuestionButton.UseVisualStyleBackColor = false;
            previousQuestionButton.Click += previousQuestionButton_Click;
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
            checkAnswerButton.BackColor = Color.WhiteSmoke;
            checkAnswerButton.Location = new Point(260, 375);
            checkAnswerButton.Name = "checkAnswerButton";
            checkAnswerButton.Size = new Size(128, 35);
            checkAnswerButton.TabIndex = 8;
            checkAnswerButton.Text = "Check Answer";
            checkAnswerButton.UseVisualStyleBackColor = false;
            checkAnswerButton.Click += checkAnswerButton_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.WhiteSmoke;
            nextButton.Location = new Point(394, 375);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(128, 35);
            nextButton.TabIndex = 9;
            nextButton.Text = "NextBtn";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // SolveTestWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 415);
            Controls.Add(nextButton);
            Controls.Add(checkAnswerButton);
            Controls.Add(resultLabel);
            Controls.Add(previousQuestionButton);
            Controls.Add(answerPanel);
            Controls.Add(questionLabel);
            Controls.Add(questionCountLabel);
            Controls.Add(testTitleLabel);
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

        private Label testTitleLabel;
        private Label questionCountLabel;
        private Label questionLabel;
        private FlowLayoutPanel answerPanel;
        private Button previousQuestionButton;
        private Label resultLabel;
        private Button checkAnswerButton;
        private Button nextButton;
    }
}