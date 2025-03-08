namespace TestMakerTaker.Scripts.UserControls {
    partial class SelectableListElement {
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
            selectCheckBox = new CheckBox();
            titleLabel = new Label();
            descriptionLabel = new Label();
            SuspendLayout();
            // 
            // selectCheckBox
            // 
            selectCheckBox.AutoSize = true;
            selectCheckBox.Dock = DockStyle.Left;
            selectCheckBox.Location = new Point(0, 0);
            selectCheckBox.Margin = new Padding(0);
            selectCheckBox.Name = "selectCheckBox";
            selectCheckBox.Padding = new Padding(10, 0, 10, 0);
            selectCheckBox.Size = new Size(35, 50);
            selectCheckBox.TabIndex = 0;
            selectCheckBox.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Left;
            titleLabel.Location = new Point(35, 0);
            titleLabel.Margin = new Padding(0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(213, 50);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Test Title";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Dock = DockStyle.Left;
            descriptionLabel.Location = new Point(248, 0);
            descriptionLabel.Margin = new Padding(0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Padding = new Padding(5, 0, 0, 0);
            descriptionLabel.Size = new Size(278, 50);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Test Description";
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SelectableListElement
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Controls.Add(selectCheckBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(0, 5, 0, 5);
            Name = "SelectableListElement";
            Size = new Size(526, 50);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox selectCheckBox;
        private Label titleLabel;
        private Label descriptionLabel;
    }
}
