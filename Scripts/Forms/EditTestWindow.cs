using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMakerTaker.Scripts.Forms;

namespace TestMakerTaker
{
    public partial class EditTestWindow : Form {
        public MainWindow.TestInteractionButtonHandler DeleteButtonClickedHandler;

        public static EditTestWindow Instance;
        private Test testRef;

        public EditTestWindow(Test test) {
            if (Instance != null) {
                Instance.Close();
                Instance.Dispose();
                Instance = null;
            }
            Instance = this;

            InitializeComponent();

            testRef = test;

            testForm.FillInputsWithData(test);
        }

        public Test GetTestRef() {
            return testRef;
        }

        public TestForm GetTestForm() {
            return testForm;
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            MessageWindow infoDialog = new MessageWindow(MessageWindow.MessageDialogMode.Error, "Delete Test", "Are you sure you want to delete this test?", "Yes", "No");

            infoDialog.OnYesBtnClick += ProceedDelete;

            infoDialog.ShowDialog();
        }

        private void ProceedDelete(object? sender, EventArgs e) {
            DeleteButtonClickedHandler?.Invoke(testRef);
        }
    }
}
