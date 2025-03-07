namespace TestMakerTaker
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            errorProvider = new ErrorProvider(components);
            importTestTab = new TabPage();
            importView1 = new TestMakerTaker.Scripts.Forms.ImportView();
            testsTab = new TabPage();
            testList = new TestList();
            createTestTab = new TabPage();
            createTestForm = new TestForm();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            exportView = new TestMakerTaker.Scripts.UserControls.ExportView();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            importTestTab.SuspendLayout();
            testsTab.SuspendLayout();
            createTestTab.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // importTestTab
            // 
            importTestTab.Controls.Add(importView1);
            importTestTab.Location = new Point(4, 34);
            importTestTab.Margin = new Padding(4);
            importTestTab.Name = "importTestTab";
            importTestTab.Size = new Size(576, 523);
            importTestTab.TabIndex = 2;
            importTestTab.Text = "Import";
            importTestTab.UseVisualStyleBackColor = true;
            // 
            // importView1
            // 
            importView1.Dock = DockStyle.Fill;
            importView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            importView1.Location = new Point(0, 0);
            importView1.Margin = new Padding(0);
            importView1.Name = "importView1";
            importView1.Size = new Size(576, 523);
            importView1.TabIndex = 0;
            // 
            // testsTab
            // 
            testsTab.Controls.Add(testList);
            testsTab.Location = new Point(4, 34);
            testsTab.Name = "testsTab";
            testsTab.Size = new Size(576, 523);
            testsTab.TabIndex = 4;
            testsTab.Text = "Tests";
            testsTab.UseVisualStyleBackColor = true;
            // 
            // testList
            // 
            testList.BackColor = Color.White;
            testList.Location = new Point(0, 3);
            testList.Name = "testList";
            testList.Size = new Size(576, 519);
            testList.TabIndex = 0;
            // 
            // createTestTab
            // 
            createTestTab.Controls.Add(createTestForm);
            createTestTab.Location = new Point(4, 34);
            createTestTab.Margin = new Padding(4);
            createTestTab.Name = "createTestTab";
            createTestTab.Padding = new Padding(4);
            createTestTab.Size = new Size(576, 523);
            createTestTab.TabIndex = 0;
            createTestTab.Text = "Create";
            createTestTab.UseVisualStyleBackColor = true;
            // 
            // createTestForm
            // 
            createTestForm.BackColor = Color.White;
            createTestForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            createTestForm.Location = new Point(0, 0);
            createTestForm.Margin = new Padding(4);
            createTestForm.Name = "createTestForm";
            createTestForm.Size = new Size(576, 523);
            createTestForm.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(createTestTab);
            tabControl1.Controls.Add(testsTab);
            tabControl1.Controls.Add(importTestTab);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(96, 30);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(584, 561);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(exportView);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(576, 523);
            tabPage1.TabIndex = 5;
            tabPage1.Text = "Export";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // exportView
            // 
            exportView.Dock = DockStyle.Fill;
            exportView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            exportView.Location = new Point(0, 0);
            exportView.Margin = new Padding(0);
            exportView.Name = "exportView";
            exportView.Size = new Size(576, 523);
            exportView.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 561);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Margin = new Padding(4);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Maker Taker";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            importTestTab.ResumeLayout(false);
            testsTab.ResumeLayout(false);
            createTestTab.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider;
        private TabControl tabControl1;
        private TabPage createTestTab;
        private TestForm createTestForm;
        private TabPage testsTab;
        private TestList testList;
        private TabPage importTestTab;
        private Scripts.Forms.ImportView importView1;
        private TabPage tabPage1;
        private Scripts.UserControls.ExportView exportView;
    }
}
