namespace QuizForge.Scripts.UserControls {
    partial class AIPromptForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIPromptForm));
            label1 = new Label();
            label2 = new Label();
            quizCountInput = new TextBox();
            moreInfoInput = new TextBox();
            copyBtn = new Button();
            noDuplicatesCheckBox = new CheckBox();
            questionCountInput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(5, 5);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(568, 31);
            label1.TabIndex = 2;
            label1.Text = "AI Prompt Generator for generating quizzes";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(5, 36);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(568, 74);
            label2.TabIndex = 3;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // quizCountInput
            // 
            quizCountInput.Location = new Point(5, 131);
            quizCountInput.MaxLength = 3;
            quizCountInput.Name = "quizCountInput";
            quizCountInput.PlaceholderText = "How many quizzes?";
            quizCountInput.Size = new Size(428, 29);
            quizCountInput.TabIndex = 4;
            // 
            // moreInfoInput
            // 
            moreInfoInput.Location = new Point(5, 219);
            moreInfoInput.MaxLength = 300;
            moreInfoInput.Multiline = true;
            moreInfoInput.Name = "moreInfoInput";
            moreInfoInput.PlaceholderText = "More information";
            moreInfoInput.Size = new Size(428, 169);
            moreInfoInput.TabIndex = 5;
            // 
            // copyBtn
            // 
            copyBtn.BackColor = Color.WhiteSmoke;
            copyBtn.Cursor = Cursors.Hand;
            copyBtn.Location = new Point(250, 475);
            copyBtn.Name = "copyBtn";
            copyBtn.Size = new Size(183, 35);
            copyBtn.TabIndex = 12;
            copyBtn.Text = "Copy to clipboard";
            copyBtn.UseVisualStyleBackColor = false;
            copyBtn.Click += copyBtn_Click;
            // 
            // noDuplicatesCheckBox
            // 
            noDuplicatesCheckBox.Checked = true;
            noDuplicatesCheckBox.CheckState = CheckState.Checked;
            noDuplicatesCheckBox.Location = new Point(5, 394);
            noDuplicatesCheckBox.Name = "noDuplicatesCheckBox";
            noDuplicatesCheckBox.Size = new Size(428, 36);
            noDuplicatesCheckBox.TabIndex = 13;
            noDuplicatesCheckBox.Text = "No duplicates";
            noDuplicatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // questionCountInput
            // 
            questionCountInput.Location = new Point(5, 175);
            questionCountInput.MaxLength = 3;
            questionCountInput.Name = "questionCountInput";
            questionCountInput.PlaceholderText = "How many questions per quiz?";
            questionCountInput.Size = new Size(428, 29);
            questionCountInput.TabIndex = 14;
            // 
            // AIPromptForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(questionCountInput);
            Controls.Add(noDuplicatesCheckBox);
            Controls.Add(copyBtn);
            Controls.Add(moreInfoInput);
            Controls.Add(quizCountInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(0);
            Name = "AIPromptForm";
            Size = new Size(576, 523);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox quizCountInput;
        private TextBox moreInfoInput;
        private Button copyBtn;
        private CheckBox noDuplicatesCheckBox;
        private TextBox questionCountInput;
    }
}
