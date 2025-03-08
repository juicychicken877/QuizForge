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
            descriptionInput.Location = new Point(5, 45);
            descriptionInput.Margin = new Padding(5, 6, 5, 6);
            descriptionInput.MaxLength = 200;
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.PlaceholderText = "Quiz description e.g \"Test your knowledge about pancakes\"";
            descriptionInput.Size = new Size(428, 147);
            descriptionInput.TabIndex = 7;
            // 
            // titleInput
            // 
            titleInput.Location = new Point(5, 5);
            titleInput.Margin = new Padding(5, 6, 5, 6);
            titleInput.MaxLength = 50;
            titleInput.Name = "titleInput";
            titleInput.PlaceholderText = "Quiz title e.g \"New Quiz\"";
            titleInput.Size = new Size(428, 29);
            titleInput.TabIndex = 4;
            // 
            // addQuestionButton
            // 
            addQuestionButton.BackColor = Color.WhiteSmoke;
            addQuestionButton.BackgroundImageLayout = ImageLayout.None;
            addQuestionButton.Cursor = Cursors.Hand;
            addQuestionButton.Location = new Point(211, 203);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(222, 37);
            addQuestionButton.TabIndex = 9;
            addQuestionButton.Text = "+ Add New Question";
            addQuestionButton.UseVisualStyleBackColor = false;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // questionPanel
            // 
            questionPanel.AutoScroll = true;
            questionPanel.BackColor = Color.WhiteSmoke;
            questionPanel.FlowDirection = FlowDirection.TopDown;
            questionPanel.Location = new Point(5, 246);
            questionPanel.Margin = new Padding(0);
            questionPanel.Name = "questionPanel";
            questionPanel.Size = new Size(428, 256);
            questionPanel.TabIndex = 10;
            questionPanel.WrapContents = false;
            // 
            // actionButton
            // 
            actionButton.BackColor = Color.WhiteSmoke;
            actionButton.Cursor = Cursors.Hand;
            actionButton.Location = new Point(445, 467);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(128, 35);
            actionButton.TabIndex = 11;
            actionButton.Text = "ActionButton";
            actionButton.UseVisualStyleBackColor = false;
            actionButton.Click += actionButton_Click;
            // 
            // clearFieldsButton
            // 
            clearFieldsButton.BackColor = Color.WhiteSmoke;
            clearFieldsButton.Cursor = Cursors.Hand;
            clearFieldsButton.Location = new Point(445, 426);
            clearFieldsButton.Name = "clearFieldsButton";
            clearFieldsButton.Size = new Size(128, 35);
            clearFieldsButton.TabIndex = 12;
            clearFieldsButton.Text = "Clear All";
            clearFieldsButton.UseVisualStyleBackColor = false;
            clearFieldsButton.Click += clearFieldsButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.Location = new Point(5, 203);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 13;
            label1.Text = "Quiz Questions";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            Margin = new Padding(0);
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
