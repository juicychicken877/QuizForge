namespace TestMakerTaker {
    partial class SolveTestForm {
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
            nextButton = new Button();
            checkAnswerButton = new Button();
            previousQuestionButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // testTitleLabel
            // 
            testTitleLabel.Location = new Point(0, 0);
            testTitleLabel.Name = "testTitleLabel";
            testTitleLabel.Size = new Size(260, 36);
            testTitleLabel.TabIndex = 0;
            testTitleLabel.Text = "Test Title";
            // 
            // questionCountLabel
            // 
            questionCountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            questionCountLabel.Location = new Point(266, 0);
            questionCountLabel.Name = "questionCountLabel";
            questionCountLabel.Size = new Size(260, 36);
            questionCountLabel.TabIndex = 1;
            questionCountLabel.Text = "Question 0 of 0";
            questionCountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // questionLabel
            // 
            questionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            questionLabel.Location = new Point(0, 36);
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
            answerPanel.Name = "answerPanel";
            answerPanel.Size = new Size(526, 244);
            answerPanel.TabIndex = 3;
            answerPanel.WrapContents = false;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(392, 370);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(121, 33);
            nextButton.TabIndex = 4;
            nextButton.Text = "NextButton";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // checkAnswerButton
            // 
            checkAnswerButton.Location = new Point(265, 370);
            checkAnswerButton.Name = "checkAnswerButton";
            checkAnswerButton.Size = new Size(121, 33);
            checkAnswerButton.TabIndex = 5;
            checkAnswerButton.Text = "Check Answer";
            checkAnswerButton.UseVisualStyleBackColor = true;
            checkAnswerButton.Click += checkAnswerButton_Click;
            // 
            // previousQuestionButton
            // 
            previousQuestionButton.Location = new Point(12, 370);
            previousQuestionButton.Name = "previousQuestionButton";
            previousQuestionButton.Size = new Size(153, 33);
            previousQuestionButton.TabIndex = 6;
            previousQuestionButton.Text = "Previous Question";
            previousQuestionButton.UseVisualStyleBackColor = true;
            previousQuestionButton.Click += previousQuestionButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(0, 323);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(526, 28);
            resultLabel.TabIndex = 7;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SolveTestForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 415);
            Controls.Add(resultLabel);
            Controls.Add(previousQuestionButton);
            Controls.Add(checkAnswerButton);
            Controls.Add(nextButton);
            Controls.Add(answerPanel);
            Controls.Add(questionLabel);
            Controls.Add(questionCountLabel);
            Controls.Add(testTitleLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "SolveTestForm";
            Text = "Test Maker Taker - Solve Test";
            ResumeLayout(false);
        }

        #endregion

        private Label testTitleLabel;
        private Label questionCountLabel;
        private Label questionLabel;
        private FlowLayoutPanel answerPanel;
        private Button nextButton;
        private Button checkAnswerButton;
        private Button previousQuestionButton;
        private Label resultLabel;
    }
}