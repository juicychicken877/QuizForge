namespace TestMakerTaker
{
    partial class TestForm
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
            components = new System.ComponentModel.Container();
            descriptionInput = new TextBox();
            titleInput = new TextBox();
            addQuestionButton = new Button();
            questionPanel = new FlowLayoutPanel();
            actionButton = new Button();
            clearFieldsButton = new Button();
            errorProvider = new ErrorProvider(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // descriptionInput
            // 
            descriptionInput.Location = new Point(5, 47);
            descriptionInput.Margin = new Padding(5, 6, 5, 6);
            descriptionInput.MaxLength = 200;
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.PlaceholderText = "Description";
            descriptionInput.Size = new Size(322, 147);
            descriptionInput.TabIndex = 7;
            // 
            // titleInput
            // 
            titleInput.Location = new Point(5, 6);
            titleInput.Margin = new Padding(5, 6, 5, 6);
            titleInput.MaxLength = 50;
            titleInput.Name = "titleInput";
            titleInput.PlaceholderText = "Title";
            titleInput.Size = new Size(322, 29);
            titleInput.TabIndex = 4;
            // 
            // addQuestionButton
            // 
            addQuestionButton.Location = new Point(146, 211);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(181, 29);
            addQuestionButton.TabIndex = 9;
            addQuestionButton.Text = "+ Add New Question";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // questionPanel
            // 
            questionPanel.AutoScroll = true;
            questionPanel.FlowDirection = FlowDirection.TopDown;
            questionPanel.Location = new Point(5, 246);
            questionPanel.Name = "questionPanel";
            questionPanel.Size = new Size(348, 256);
            questionPanel.TabIndex = 10;
            questionPanel.WrapContents = false;
            // 
            // actionButton
            // 
            actionButton.BackColor = Color.LightGreen;
            actionButton.Location = new Point(457, 467);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(116, 35);
            actionButton.TabIndex = 11;
            actionButton.Text = "ActionButton";
            actionButton.UseVisualStyleBackColor = false;
            actionButton.Click += actionButton_Click;
            // 
            // clearFieldsButton
            // 
            clearFieldsButton.BackColor = Color.PaleTurquoise;
            clearFieldsButton.Location = new Point(457, 426);
            clearFieldsButton.Name = "clearFieldsButton";
            clearFieldsButton.Size = new Size(116, 35);
            clearFieldsButton.TabIndex = 12;
            clearFieldsButton.Text = "Clear Fields";
            clearFieldsButton.UseVisualStyleBackColor = false;
            clearFieldsButton.Click += clearFieldsButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 215);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 13;
            label1.Text = "Questions";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(clearFieldsButton);
            Controls.Add(actionButton);
            Controls.Add(questionPanel);
            Controls.Add(addQuestionButton);
            Controls.Add(descriptionInput);
            Controls.Add(titleInput);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "TestForm";
            Size = new Size(576, 523);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descriptionInput;
        private TextBox titleInput;
        private Button addQuestionButton;
        private FlowLayoutPanel questionPanel;
        private Button actionButton;
        private Button clearFieldsButton;
        private ErrorProvider errorProvider;
        private Label label1;
    }
}
