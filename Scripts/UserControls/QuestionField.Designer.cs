namespace TestMakerTaker
{
    partial class QuestionField
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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            questionInput = new TextBox();
            deleteQuestionButton = new Label();
            errorProvider = new ErrorProvider(components);
            answerSetPanel = new FlowLayoutPanel();
            addAnswerBtn = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // questionInput
            // 
            questionInput.Location = new Point(3, 3);
            questionInput.Name = "questionInput";
            questionInput.PlaceholderText = "Question";
            questionInput.Size = new Size(369, 29);
            questionInput.TabIndex = 0;
            // 
            // deleteQuestionButton
            // 
            deleteQuestionButton.Cursor = Cursors.Hand;
            deleteQuestionButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            deleteQuestionButton.ForeColor = Color.Red;
            deleteQuestionButton.Location = new Point(375, 0);
            deleteQuestionButton.Margin = new Padding(0);
            deleteQuestionButton.Name = "deleteQuestionButton";
            deleteQuestionButton.Size = new Size(35, 32);
            deleteQuestionButton.TabIndex = 5;
            deleteQuestionButton.Text = "X";
            deleteQuestionButton.TextAlign = ContentAlignment.MiddleCenter;
            deleteQuestionButton.Click += deleteQuestionButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // answerSetPanel
            // 
            answerSetPanel.AutoScroll = true;
            answerSetPanel.FlowDirection = FlowDirection.TopDown;
            answerSetPanel.Location = new Point(3, 38);
            answerSetPanel.Name = "answerSetPanel";
            answerSetPanel.Size = new Size(369, 141);
            answerSetPanel.TabIndex = 6;
            answerSetPanel.WrapContents = false;
            // 
            // addAnswerBtn
            // 
            addAnswerBtn.Cursor = Cursors.Hand;
            addAnswerBtn.Font = new Font("Wide Latin", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addAnswerBtn.ForeColor = Color.Lime;
            addAnswerBtn.Location = new Point(375, 38);
            addAnswerBtn.Margin = new Padding(0);
            addAnswerBtn.Name = "addAnswerBtn";
            addAnswerBtn.Size = new Size(35, 32);
            addAnswerBtn.TabIndex = 7;
            addAnswerBtn.Text = "+";
            addAnswerBtn.TextAlign = ContentAlignment.MiddleCenter;
            addAnswerBtn.Click += addAnswerBtn_Click;
            // 
            // QuestionField
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            Controls.Add(addAnswerBtn);
            Controls.Add(answerSetPanel);
            Controls.Add(deleteQuestionButton);
            Controls.Add(questionInput);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(0, 5, 0, 5);
            Name = "QuestionField";
            Size = new Size(410, 179);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox questionInput;
        private Label deleteQuestionButton;
        private ErrorProvider errorProvider;
        private FlowLayoutPanel answerSetPanel;
        private Label addAnswerBtn;
    }
}
