using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMakerTaker.Scripts;
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
            MessageManager.NewWindow("Delete Test", "Are you sure you want to delete this test?", [new MessageWindow.Button("Yes", ProceedDelete), new MessageWindow.Button("No", null)]);
        }

        private void ProceedDelete() {
            DeleteButtonClickedHandler?.Invoke(testRef);
        }
    }
}
