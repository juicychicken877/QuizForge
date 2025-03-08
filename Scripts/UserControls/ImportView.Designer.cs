namespace QuizForge.Scripts.Forms {
    partial class ImportView {
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
            label1 = new Label();
            selectFileBtn = new Button();
            selectedFileNameLabel = new Label();
            label2 = new Label();
            label5 = new Label();
            importButton = new Button();
            selectList = new QuizForge.Scripts.UserControls.SelectList();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(5, 5);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(568, 31);
            label1.TabIndex = 0;
            label1.Text = "Select  a JSON file with saved quizzes to import";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectFileBtn
            // 
            selectFileBtn.Location = new Point(5, 39);
            selectFileBtn.Margin = new Padding(0);
            selectFileBtn.Name = "selectFileBtn";
            selectFileBtn.Size = new Size(140, 31);
            selectFileBtn.TabIndex = 1;
            selectFileBtn.Text = "Browse Files";
            selectFileBtn.UseVisualStyleBackColor = true;
            selectFileBtn.Click += selectFileBtn_Click;
            // 
            // selectedFileNameLabel
            // 
            selectedFileNameLabel.Location = new Point(157, 39);
            selectedFileNameLabel.Margin = new Padding(0);
            selectedFileNameLabel.Name = "selectedFileNameLabel";
            selectedFileNameLabel.Size = new Size(416, 31);
            selectedFileNameLabel.TabIndex = 2;
            selectedFileNameLabel.Text = "No file selected";
            selectedFileNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(5, 82);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(568, 31);
            label2.TabIndex = 3;
            label2.Text = "Detected quizzes:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(5, 419);
            label5.Name = "label5";
            label5.Size = new Size(568, 45);
            label5.TabIndex = 6;
            label5.Text = "Select quizzes you want to import";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // importButton
            // 
            importButton.BackColor = Color.WhiteSmoke;
            importButton.Enabled = false;
            importButton.Location = new Point(445, 467);
            importButton.Name = "importButton";
            importButton.Size = new Size(128, 35);
            importButton.TabIndex = 7;
            importButton.Text = "Import";
            importButton.UseVisualStyleBackColor = false;
            importButton.Click += importButton_Click;
            // 
            // selectList
            // 
            selectList.AutoSize = true;
            selectList.BackColor = Color.WhiteSmoke;
            selectList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            selectList.Location = new Point(5, 113);
            selectList.Margin = new Padding(0);
            selectList.Name = "selectList";
            selectList.Size = new Size(568, 306);
            selectList.TabIndex = 8;
            // 
            // ImportView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(selectList);
            Controls.Add(importButton);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(selectedFileNameLabel);
            Controls.Add(selectFileBtn);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(0);
            Name = "ImportView";
            Size = new Size(576, 523);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button selectFileBtn;
        private Label selectedFileNameLabel;
        private Label label2;
        private Label label5;
        private Button importButton;
        private UserControls.SelectList selectList;
    }
}
