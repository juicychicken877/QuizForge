﻿namespace QuizForge {
    partial class AnswerBtn {
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
            answer = new Label();
            SuspendLayout();
            // 
            // answer
            // 
            answer.AutoSize = true;
            answer.Dock = DockStyle.Fill;
            answer.Location = new Point(0, 0);
            answer.Margin = new Padding(0);
            answer.MaximumSize = new Size(523, 0);
            answer.MinimumSize = new Size(523, 50);
            answer.Name = "answer";
            answer.Size = new Size(523, 50);
            answer.TabIndex = 0;
            answer.TextAlign = ContentAlignment.MiddleCenter;
            answer.Click += answer_Click;
            // 
            // AnswerBtn
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            Controls.Add(answer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(0, 3, 0, 3);
            MaximumSize = new Size(523, 0);
            MinimumSize = new Size(523, 50);
            Name = "AnswerBtn";
            Size = new Size(523, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label answer;
    }
}
