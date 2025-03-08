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
            exportAllTests = new Button();
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
            // importExampleTests
            // 
            importExampleTests.AutoSize = true;
            importExampleTests.BackColor = Color.WhiteSmoke;
            importExampleTests.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            importExampleTests.Location = new Point(3, 8);
            importExampleTests.Name = "importExampleTests";
            importExampleTests.Size = new Size(200, 35);
            importExampleTests.TabIndex = 1;
            importExampleTests.Text = "Import Example Quizzes";
            importExampleTests.UseVisualStyleBackColor = false;
            importExampleTests.Click += importExampleTests_Click;
            // 
            // exportAllTests
            // 
            exportAllTests.AutoSize = true;
            exportAllTests.BackColor = Color.WhiteSmoke;
            exportAllTests.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            exportAllTests.Location = new Point(209, 8);
            exportAllTests.Name = "exportAllTests";
            exportAllTests.Size = new Size(200, 35);
            exportAllTests.TabIndex = 2;
            exportAllTests.Text = "Export All Quizzes";
            exportAllTests.UseVisualStyleBackColor = false;
            exportAllTests.Click += exportAllTests_Click;
            // 
            // btnPanel
            // 
            btnPanel.Controls.Add(importExampleTests);
            btnPanel.Controls.Add(exportAllTests);
            btnPanel.Dock = DockStyle.Bottom;
            btnPanel.Location = new Point(0, 471);
            btnPanel.Margin = new Padding(0);
            btnPanel.Name = "btnPanel";
            btnPanel.Padding = new Padding(0, 5, 0, 5);
            btnPanel.Size = new Size(576, 52);
            btnPanel.TabIndex = 1;
            // 
            // TestList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnPanel);
            Controls.Add(panel);
            Margin = new Padding(0);
            Name = "TestList";
            Size = new Size(576, 523);
            btnPanel.ResumeLayout(false);
            btnPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel panel;
        private Button importExampleTests;
        private Button exportAllTests;
        private FlowLayoutPanel btnPanel;
    }
}
