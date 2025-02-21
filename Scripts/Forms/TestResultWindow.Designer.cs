namespace TestMakerTaker.Scripts.Forms {
    partial class TestResultWindow {
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
            testFinishedLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            incorrectCount = new Label();
            correctCount = new Label();
            unansweredCount = new Label();
            label4 = new Label();
            userAnswersPanel = new FlowLayoutPanel();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // testFinishedLabel
            // 
            testFinishedLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            testFinishedLabel.Location = new Point(1, -1);
            testFinishedLabel.Margin = new Padding(4, 0, 4, 0);
            testFinishedLabel.Name = "testFinishedLabel";
            testFinishedLabel.Size = new Size(521, 41);
            testFinishedLabel.TabIndex = 0;
            testFinishedLabel.Text = "TEST FINISHED!";
            testFinishedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(1, 40);
            label1.Name = "label1";
            label1.Size = new Size(167, 36);
            label1.TabIndex = 1;
            label1.Text = "Incorrect";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(174, 40);
            label2.Name = "label2";
            label2.Size = new Size(177, 31);
            label2.TabIndex = 2;
            label2.Text = "Correct";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(357, 37);
            label3.Name = "label3";
            label3.Size = new Size(165, 36);
            label3.TabIndex = 3;
            label3.Text = "Unanswered";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // incorrectCount
            // 
            incorrectCount.Location = new Point(1, 76);
            incorrectCount.Name = "incorrectCount";
            incorrectCount.Size = new Size(167, 36);
            incorrectCount.TabIndex = 4;
            incorrectCount.Text = "-";
            incorrectCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // correctCount
            // 
            correctCount.Location = new Point(174, 71);
            correctCount.Name = "correctCount";
            correctCount.Size = new Size(177, 36);
            correctCount.TabIndex = 5;
            correctCount.Text = "-";
            correctCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // unansweredCount
            // 
            unansweredCount.Location = new Point(357, 73);
            unansweredCount.Name = "unansweredCount";
            unansweredCount.Size = new Size(165, 36);
            unansweredCount.TabIndex = 6;
            unansweredCount.Text = "-";
            unansweredCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(156, 27);
            label4.TabIndex = 7;
            label4.Text = "Your answers";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userAnswersPanel
            // 
            userAnswersPanel.AutoScroll = true;
            userAnswersPanel.FlowDirection = FlowDirection.TopDown;
            userAnswersPanel.Location = new Point(12, 142);
            userAnswersPanel.Name = "userAnswersPanel";
            userAnswersPanel.Size = new Size(501, 224);
            userAnswersPanel.TabIndex = 8;
            userAnswersPanel.WrapContents = false;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(403, 372);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(110, 39);
            closeBtn.TabIndex = 10;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // Form_TestResult
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 415);
            Controls.Add(closeBtn);
            Controls.Add(userAnswersPanel);
            Controls.Add(label4);
            Controls.Add(unansweredCount);
            Controls.Add(correctCount);
            Controls.Add(incorrectCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(testFinishedLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "Form_TestResult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Result";
            ResumeLayout(false);
        }

        #endregion

        private Label testFinishedLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label incorrectCount;
        private Label correctCount;
        private Label unansweredCount;
        private Label label4;
        private FlowLayoutPanel userAnswersPanel;
        private Button closeBtn;
    }
}