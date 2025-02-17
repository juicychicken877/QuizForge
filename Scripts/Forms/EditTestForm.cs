using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMakerTaker
{
    public partial class EditTestForm : Form {
        public event EventHandler OnDeleteTestButtonClicked;

        public Test testReference = null;
        public TestForm testFormObject { get { return testForm; } }

        public EditTestForm(Test test) {
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
            OnDeleteTestButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
