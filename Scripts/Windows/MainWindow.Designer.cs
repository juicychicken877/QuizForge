namespace QuizForge
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
            tabPage3 = new TabPage();
            importView = new QuizForge.Scripts.Forms.ImportView();
            tabPage2 = new TabPage();
            quizList = new QuizList();
            tabPage1 = new TabPage();
            createQuizForm = new QuizForm();
            tabControl = new TabControl();
            tabPage4 = new TabPage();
            exportView = new QuizForge.Scripts.UserControls.ExportView();
            tabPage5 = new TabPage();
            aiPromptForm = new QuizForge.Scripts.UserControls.AIPromptForm();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(importView);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(576, 523);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Import";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // importView
            // 
            importView.BackColor = Color.White;
            importView.Dock = DockStyle.Fill;
            importView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            importView.Location = new Point(0, 0);
            importView.Margin = new Padding(0);
            importView.Name = "importView";
            importView.Size = new Size(576, 523);
            importView.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(quizList);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(576, 523);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "Quizzes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // quizList
            // 
            quizList.BackColor = Color.White;
            quizList.Dock = DockStyle.Fill;
            quizList.Location = new Point(0, 0);
            quizList.Margin = new Padding(0);
            quizList.Name = "quizList";
            quizList.Size = new Size(576, 523);
            quizList.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(createQuizForm);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(576, 523);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // createQuizForm
            // 
            createQuizForm.BackColor = Color.White;
            createQuizForm.Dock = DockStyle.Fill;
            createQuizForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            createQuizForm.Location = new Point(0, 0);
            createQuizForm.Margin = new Padding(0);
            createQuizForm.Name = "createQuizForm";
            createQuizForm.Size = new Size(576, 523);
            createQuizForm.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Controls.Add(tabPage5);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ItemSize = new Size(96, 30);
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(0);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(20, 3);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(584, 561);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(exportView);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Margin = new Padding(0);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(576, 523);
            tabPage4.TabIndex = 5;
            tabPage4.Text = "Export";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // exportView
            // 
            exportView.BackColor = Color.White;
            exportView.Dock = DockStyle.Fill;
            exportView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            exportView.Location = new Point(0, 0);
            exportView.Margin = new Padding(0);
            exportView.Name = "exportView";
            exportView.Size = new Size(576, 523);
            exportView.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(aiPromptForm);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Margin = new Padding(0);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(576, 523);
            tabPage5.TabIndex = 6;
            tabPage5.Text = "AI Prompt";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // aiPromptForm
            // 
            aiPromptForm.Dock = DockStyle.Fill;
            aiPromptForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            aiPromptForm.Location = new Point(0, 0);
            aiPromptForm.Margin = new Padding(0);
            aiPromptForm.Name = "aiPromptForm";
            aiPromptForm.Size = new Size(576, 523);
            aiPromptForm.TabIndex = 0;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 561);
            Controls.Add(tabControl);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz Forge";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider;
        private TabControl tabControl;
        private TabPage tabPage1;
        private QuizForm createQuizForm;
        private TabPage tabPage2;
        private QuizList quizList;
        private TabPage tabPage3;
        private Scripts.Forms.ImportView importView;
        private TabPage tabPage4;
        private Scripts.UserControls.ExportView exportView;
        private TabPage tabPage5;
        private Scripts.UserControls.AIPromptForm aiPromptForm;
    }
}
