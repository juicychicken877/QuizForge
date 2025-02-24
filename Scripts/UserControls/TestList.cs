using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMakerTaker.Scripts;

namespace TestMakerTaker
{
    public partial class TestList : UserControl {
        public MainWindow.TestInteractionButtonHandler SolveButtonClickedHandler;
        public MainWindow.TestInteractionButtonHandler ExportButtonClickedHandler;
        public MainWindow.TestInteractionButtonHandler EditButtonClickedHandler;

        public TestList() {
            InitializeComponent();
        }
        public void Update(List<Test> tests) {
            // Clear list
            panel.Controls.Clear();

            foreach (Test test in tests) {
                // Create new element for each test
                TestListElement newElement = new(test);

                newElement.EditButtonClickedHandler += EditButtonClickedHandler;
                newElement.SolveButtonClickedHandler += SolveButtonClickedHandler;
                newElement.ExportButtonClickedHandler += ExportButtonClickedHandler;

                panel.Controls.Add(newElement);
            }
        }

        private void importExampleTests_Click(object sender, EventArgs e) {
            ImportExportHandler.ImportTests(ImportExportHandler.ImportMode.Override, JSONHandler.EXAMPLE_TESTS_FILE_PATH);
        }
    }
}
