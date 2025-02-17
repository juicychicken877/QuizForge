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
            answer1Input = new TextBox();
            answer2Input = new TextBox();
            answer3Input = new TextBox();
            answer4Input = new TextBox();
            deleteQuestionButton = new Label();
            errorProvider = new ErrorProvider(components);
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
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
            // answer1Input
            // 
            answer1Input.Location = new Point(3, 38);
            answer1Input.Name = "answer1Input";
            answer1Input.PlaceholderText = "Answer 1";
            answer1Input.Size = new Size(329, 29);
            answer1Input.TabIndex = 1;
            // 
            // answer2Input
            // 
            answer2Input.Location = new Point(3, 73);
            answer2Input.Name = "answer2Input";
            answer2Input.PlaceholderText = "Answer 2";
            answer2Input.Size = new Size(329, 29);
            answer2Input.TabIndex = 2;
            // 
            // answer3Input
            // 
            answer3Input.Location = new Point(3, 108);
            answer3Input.Name = "answer3Input";
            answer3Input.PlaceholderText = "Answer 3";
            answer3Input.Size = new Size(329, 29);
            answer3Input.TabIndex = 3;
            // 
            // answer4Input
            // 
            answer4Input.Location = new Point(3, 143);
            answer4Input.Name = "answer4Input";
            answer4Input.PlaceholderText = "Answer 4";
            answer4Input.Size = new Size(329, 29);
            answer4Input.TabIndex = 4;
            // 
            // deleteQuestionButton
            // 
            deleteQuestionButton.Cursor = Cursors.Hand;
            deleteQuestionButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            deleteQuestionButton.ForeColor = Color.Red;
            deleteQuestionButton.Location = new Point(378, -1);
            deleteQuestionButton.Name = "deleteQuestionButton";
            deleteQuestionButton.Size = new Size(29, 29);
            deleteQuestionButton.TabIndex = 5;
            deleteQuestionButton.Text = "X";
            deleteQuestionButton.Click += deleteQuestionButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButton1.Location = new Point(352, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Padding = new Padding(3);
            radioButton1.Size = new Size(20, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButton2.Location = new Point(352, 75);
            radioButton2.Name = "radioButton2";
            radioButton2.Padding = new Padding(3);
            radioButton2.Size = new Size(20, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButton3.Location = new Point(352, 110);
            radioButton3.Name = "radioButton3";
            radioButton3.Padding = new Padding(3);
            radioButton3.Size = new Size(20, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButton4.Location = new Point(352, 145);
            radioButton4.Name = "radioButton4";
            radioButton4.Padding = new Padding(3);
            radioButton4.Size = new Size(20, 19);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // QuestionField
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(deleteQuestionButton);
            Controls.Add(answer4Input);
            Controls.Add(answer3Input);
            Controls.Add(answer2Input);
            Controls.Add(answer1Input);
            Controls.Add(questionInput);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4, 8, 4, 8);
            Name = "QuestionField";
            Size = new Size(410, 179);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox questionInput;
        private TextBox answer1Input;
        private TextBox answer2Input;
        private TextBox answer3Input;
        private TextBox answer4Input;
        private Label deleteQuestionButton;
        private ErrorProvider errorProvider;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
