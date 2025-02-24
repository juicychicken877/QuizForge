namespace TestMakerTaker
{
    partial class TestList
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
            importExampleTests = new Button();
            SuspendLayout();
            // 
            // panel
            // 
            panel.AutoScroll = true;
            panel.FlowDirection = FlowDirection.TopDown;
            panel.Location = new Point(3, 3);
            panel.Name = "panel";
            panel.Size = new Size(570, 476);
            panel.TabIndex = 0;
            panel.WrapContents = false;
            // 
            // importExampleTests
            // 
            importExampleTests.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            importExampleTests.Location = new Point(3, 484);
            importExampleTests.Name = "importExampleTests";
            importExampleTests.Size = new Size(169, 36);
            importExampleTests.TabIndex = 1;
            importExampleTests.Text = "Import Example Tests";
            importExampleTests.UseVisualStyleBackColor = true;
            importExampleTests.Click += importExampleTests_Click;
            // 
            // TestList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(importExampleTests);
            Controls.Add(panel);
            Name = "TestList";
            Size = new Size(576, 523);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel;
        private Button importExampleTests;
    }
}
