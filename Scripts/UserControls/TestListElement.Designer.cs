

namespace TestMakerTaker
{
    partial class TestListElement
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
            title = new Label();
            description = new Label();
            editButton = new Button();
            solveButton = new Button();
            exportButton = new Button();
            questionCountLabel = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(405, 23);
            title.TabIndex = 0;
            title.Text = "Test Title";
            // 
            // description
            // 
            description.Location = new Point(0, 23);
            description.Name = "description";
            description.Padding = new Padding(0, 3, 0, 3);
            description.Size = new Size(405, 66);
            description.TabIndex = 1;
            description.Text = "Test Description";
            description.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editButton
            // 
            editButton.Location = new Point(411, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(118, 31);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // solveButton
            // 
            solveButton.Location = new Point(411, 40);
            solveButton.Name = "solveButton";
            solveButton.Size = new Size(118, 31);
            solveButton.TabIndex = 3;
            solveButton.Text = "Solve";
            solveButton.UseVisualStyleBackColor = true;
            solveButton.Click += solveButton_Click;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(411, 77);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(118, 31);
            exportButton.TabIndex = 4;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
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
            // TestListElement
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(title);
            Controls.Add(questionCountLabel);
            Controls.Add(exportButton);
            Controls.Add(solveButton);
            Controls.Add(editButton);
            Controls.Add(description);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(0, 5, 0, 5);
            Name = "TestListElement";
            Size = new Size(532, 112);
            ResumeLayout(false);
        }
        #endregion

        private Label title;
        private Label description;
        private Button editButton;
        private Button solveButton;
        private Button exportButton;
        private Label questionCountLabel;
    }
}
