using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMakerTaker.Scripts.Forms;

namespace TestMakerTaker.Scripts.UserControls
{
    public partial class ExportView : UserControl {
        public ExportView() {
            InitializeComponent();

            ImportExportHandler.OnExport += ImportExportHandler_OnExport;
        }

        private void ImportExportHandler_OnExport(object? sender, EventArgs e) {
            selectList.ChangeSelectedAll(false);
        }

        public void Update(List<Test> tests) {
            if (tests.Count == 0) {
                exportButton.Enabled = false;
            } else {
                exportButton.Enabled = true;
            }
            selectList.Update(tests);
        }

        public void SelectAll() {
            selectList.ChangeSelectedAll(true);
        }

        private void exportButton_Click(object sender, EventArgs e) {
            List<Test> selectedTests = selectList.GetSelectedTests();

            if (selectedTests.Count == 0) {
                MessageManager.NewWindow("Export View Error", "No tests selected", [new MessageWindow.Button("OK", null)]);
            } else {
                ImportExportHandler.ExportTests(selectedTests);
            }
        }
    }
}
