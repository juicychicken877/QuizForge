

namespace QuizForge
{
    partial class QuizListElement
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
            titleLabel = new Label();
            descriptionLabel = new Label();
            editBtn = new Button();
            solveBtn = new Button();
            exportBtn = new Button();
            questionCountLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(405, 23);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Test Title";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Location = new Point(0, 23);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Padding = new Padding(0, 3, 0, 3);
            descriptionLabel.Size = new Size(405, 66);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Test Description";
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(411, 3);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(118, 31);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // solveBtn
            // 
            solveBtn.Location = new Point(411, 40);
            solveBtn.Name = "solveBtn";
            solveBtn.Size = new Size(118, 31);
            solveBtn.TabIndex = 3;
            solveBtn.Text = "Solve";
            solveBtn.UseVisualStyleBackColor = true;
            solveBtn.Click += solveBtn_Click;
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(411, 77);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(118, 31);
            exportBtn.TabIndex = 4;
            exportBtn.Text = "Export";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // questionCountLabel
            // 
            questionCountLabel.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            questionCountLabel.Location = new Point(0, 89);
            questionCountLabel.Name = "questionCountLabel";
            questionCountLabel.Size = new Size(405, 23);
            questionCountLabel.TabIndex = 5;
            questionCountLabel.Text = "Question Count";
            // 
            // QuizListElement
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(titleLabel);
            Controls.Add(questionCountLabel);
            Controls.Add(exportBtn);
            Controls.Add(solveBtn);
            Controls.Add(editBtn);
            Controls.Add(descriptionLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(0, 5, 0, 5);
            Name = "QuizListElement";
            Size = new Size(532, 112);
            ResumeLayout(false);
        }
        #endregion

        private Label titleLabel;
        private Label descriptionLabel;
        private Button editBtn;
        private Button solveBtn;
        private Button exportBtn;
        private Label questionCountLabel;
    }
}
