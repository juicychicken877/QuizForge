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
            testFinishedLabel.Dock = DockStyle.Top;
            testFinishedLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            testFinishedLabel.Location = new Point(0, 0);
            testFinishedLabel.Margin = new Padding(0);
            testFinishedLabel.Name = "testFinishedLabel";
            testFinishedLabel.Size = new Size(525, 41);
            testFinishedLabel.TabIndex = 0;
            testFinishedLabel.Text = "TEST FINISHED!";
            testFinishedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(0, 40);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(175, 31);
            label1.TabIndex = 1;
            label1.Text = "Incorrect Answers";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(175, 40);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(175, 31);
            label2.TabIndex = 2;
            label2.Text = "Correct Answers";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(350, 40);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(175, 31);
            label3.TabIndex = 3;
            label3.Text = "Unanswered";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // incorrectCount
            // 
            incorrectCount.Location = new Point(0, 73);
            incorrectCount.Margin = new Padding(0);
            incorrectCount.Name = "incorrectCount";
            incorrectCount.Size = new Size(175, 26);
            incorrectCount.TabIndex = 4;
            incorrectCount.Text = "0";
            incorrectCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // correctCount
            // 
            correctCount.Location = new Point(175, 73);
            correctCount.Margin = new Padding(0);
            correctCount.Name = "correctCount";
            correctCount.Size = new Size(175, 26);
            correctCount.TabIndex = 5;
            correctCount.Text = "0";
            correctCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // unansweredCount
            // 
            unansweredCount.Location = new Point(350, 73);
            unansweredCount.Margin = new Padding(0);
            unansweredCount.Name = "unansweredCount";
            unansweredCount.Size = new Size(175, 26);
            unansweredCount.TabIndex = 6;
            unansweredCount.Text = "0";
            unansweredCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(12, 112);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(501, 27);
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
            closeBtn.BackColor = Color.WhiteSmoke;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            closeBtn.Location = new Point(385, 372);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(128, 35);
            closeBtn.TabIndex = 13;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // TestResultWindow
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
            MaximizeBox = false;
            Name = "TestResultWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quiz Result";
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