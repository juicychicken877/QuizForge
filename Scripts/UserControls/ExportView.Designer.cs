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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(552, 31);
            label1.TabIndex = 1;
            label1.Text = "Export tests into JSON";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // exportButton
            // 
            exportButton.Enabled = false;
            exportButton.Location = new Point(397, 475);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(165, 33);
            exportButton.TabIndex = 8;
            exportButton.Text = "Confirm Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // selectList
            // 
            selectList.AutoSize = true;
            selectList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            selectList.Location = new Point(10, 64);
            selectList.Margin = new Padding(0);
            selectList.Name = "selectList";
            selectList.Size = new Size(552, 306);
            selectList.TabIndex = 9;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(10, 444);
            label2.Name = "label2";
            label2.Size = new Size(552, 31);
            label2.TabIndex = 10;
            label2.Text = "Select tests you want to export";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ExportView
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
