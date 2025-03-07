namespace TestMakerTaker.Scripts.UserControls {
    partial class SelectList {
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
            panel = new FlowLayoutPanel();
            selectAllCheckBox = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.FlowDirection = FlowDirection.TopDown;
            panel.Location = new Point(0, 37);
            panel.Margin = new Padding(0);
            panel.Name = "panel";
            panel.Size = new Size(552, 269);
            panel.TabIndex = 0;
            panel.WrapContents = false;
            // 
            // selectAllCheckBox
            // 
            selectAllCheckBox.Enabled = false;
            selectAllCheckBox.Location = new Point(0, 0);
            selectAllCheckBox.Margin = new Padding(0);
            selectAllCheckBox.Name = "selectAllCheckBox";
            selectAllCheckBox.Padding = new Padding(10, 0, 10, 0);
            selectAllCheckBox.Size = new Size(35, 37);
            selectAllCheckBox.TabIndex = 1;
            selectAllCheckBox.UseVisualStyleBackColor = true;
            selectAllCheckBox.CheckedChanged += selectAllCheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.Location = new Point(41, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 2;
            label1.Text = "Select all";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SelectList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(label1);
            Controls.Add(selectAllCheckBox);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(0);
            Name = "SelectList";
            Size = new Size(552, 306);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel;
        private CheckBox selectAllCheckBox;
        private Label label1;
    }
}
