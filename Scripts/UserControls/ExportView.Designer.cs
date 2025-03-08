namespace TestMakerTaker.Scripts.UserControls {
    partial class ExportView {
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
            exportButton = new Button();
            selectList = new SelectList();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(5, 5);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(568, 31);
            label1.TabIndex = 1;
            label1.Text = "Export quizzes into JSON file";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.WhiteSmoke;
            exportButton.Enabled = false;
            exportButton.Location = new Point(445, 467);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(128, 35);
            exportButton.TabIndex = 8;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
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
            selectList.TabIndex = 9;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(5, 419);
            label2.Name = "label2";
            label2.Size = new Size(568, 45);
            label2.TabIndex = 10;
            label2.Text = "Select quizzes you want to export";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(5, 82);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(568, 31);
            label3.TabIndex = 11;
            label3.Text = "Current list of quizzes:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ExportView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(selectList);
            Controls.Add(exportButton);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(0);
            Name = "ExportView";
            Size = new Size(576, 523);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button exportButton;
        private SelectList selectList;
        private Label label2;
        private Label label3;
    }
}
