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
using TestMakerTaker.Scripts.Forms;
using TestMakerTaker.Scripts.Windows;

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
            ImportWindow newImportWindow = new(JSONHandler.EXAMPLE_TESTS_FILE_PATH, true);

            newImportWindow.ShowDialog();
        }

        private void exportAllTests_Click(object sender, EventArgs e) {
            if (MainWindow.GetTests().Count > 0) {
                ExportWindow newExportWindow = new(MainWindow.GetTests(), true);

                newExportWindow.ShowDialog();
            } else {
                MessageManager.NewWindow("Export View Error", "No tests found", [new MessageWindow.Button("OK", null)]);
            }
            
        }
    }
}
