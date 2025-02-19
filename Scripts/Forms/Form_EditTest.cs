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
    public partial class Form_EditTest : Form {
        public event EventHandler OnDeleteTestButtonClicked;

        public Test testReference = null;
        public TestForm testFormObject { get { return testForm; } }

        public Form_EditTest(Test test) {
            InitializeComponent();

            testFormObject.ChangeActionButtonMode(TestForm.ActionButtonMode.SaveTest);

            testFormObject.FillInputsWithData(test);

            testReference = test;
        }

        private void EditTestForm_FormClosed(object sender, FormClosedEventArgs e) {
            testFormObject.ClearFields();
        }

        public Test GetTestReference() {
            return testReference;
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            MessageDialog infoDialog = new MessageDialog(MessageDialog.MessageDialogMode.Error, "Delete Test", "Are you sure you want to delete this test?", "Yes", "No");

            infoDialog.OnYesBtnClick += ProceedDelete;

            infoDialog.ShowDialog();
        }

        private void ProceedDelete(object? sender, EventArgs e) {
            OnDeleteTestButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
