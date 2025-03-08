namespace QuizForge
{
    partial class QuizList
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
            panel = new FlowLayoutPanel();
            importExampleQuizzes = new Button();
            exportAllQuizzes = new Button();
            btnPanel = new FlowLayoutPanel();
            btnPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.Dock = DockStyle.Top;
            panel.FlowDirection = FlowDirection.TopDown;
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(0);
            panel.Name = "panel";
            panel.Size = new Size(576, 471);
            panel.TabIndex = 0;
            panel.WrapContents = false;
            // 
            // importExampleQuizzes
            // 
            importExampleQuizzes.AutoSize = true;
            importExampleQuizzes.BackColor = Color.WhiteSmoke;
            importExampleQuizzes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            importExampleQuizzes.Location = new Point(3, 8);
            importExampleQuizzes.Name = "importExampleQuizzes";
            importExampleQuizzes.Size = new Size(200, 35);
            importExampleQuizzes.TabIndex = 1;
            importExampleQuizzes.Text = "Import Example Quizzes";
            importExampleQuizzes.UseVisualStyleBackColor = false;
            importExampleQuizzes.Click += importExampleQuizzes_Click;
            // 
            // exportAllQuizzes
            // 
            exportAllQuizzes.AutoSize = true;
            exportAllQuizzes.BackColor = Color.WhiteSmoke;
            exportAllQuizzes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            exportAllQuizzes.Location = new Point(209, 8);
            exportAllQuizzes.Name = "exportAllQuizzes";
            exportAllQuizzes.Size = new Size(200, 35);
            exportAllQuizzes.TabIndex = 2;
            exportAllQuizzes.Text = "Export All Quizzes";
            exportAllQuizzes.UseVisualStyleBackColor = false;
            exportAllQuizzes.Click += exportAllQuizzes_Click;
            // 
            // btnPanel
            // 
            btnPanel.Controls.Add(importExampleQuizzes);
            btnPanel.Controls.Add(exportAllQuizzes);
            btnPanel.Dock = DockStyle.Bottom;
            btnPanel.Location = new Point(0, 471);
            btnPanel.Margin = new Padding(0);
            btnPanel.Name = "btnPanel";
            btnPanel.Padding = new Padding(0, 5, 0, 5);
            btnPanel.Size = new Size(576, 52);
            btnPanel.TabIndex = 1;
            // 
            // QuizList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnPanel);
            Controls.Add(panel);
            Margin = new Padding(0);
            Name = "QuizList";
            Size = new Size(576, 523);
            btnPanel.ResumeLayout(false);
            btnPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel;
        private Button importExampleQuizzes;
        private Button exportAllQuizzes;
        private FlowLayoutPanel btnPanel;
    }
}
