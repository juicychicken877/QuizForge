using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMakerTaker.Scripts.UserControls
{
    public partial class SelectList : UserControl {
        public SelectList() {
            InitializeComponent();
        }
        public void Update(List<Test>? tests) {
            Clear();

            if (tests != null) {
                selectAllCheckBox.Enabled = true;

                foreach (Test test in tests) {
                    SelectableListElement newListElement = new(test);

                    panel.Controls.Add(newListElement);
                }

            }
        }

        public List<Test> GetSelectedTests() {
            List<Test> selectedTests = new();

            foreach (SelectableListElement element in panel.Controls) {
                if (element.IsSelected())
                    selectedTests.Add(element.testRef);
            }

            return selectedTests;
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (selectAllCheckBox.Checked == true) {
                ChangeSelectedAll(true);
            } else {
                ChangeSelectedAll(false);
            }
        }

        public void ChangeSelectedAll(bool selected) {
            selectAllCheckBox.Checked = selected;

            foreach (SelectableListElement element in panel.Controls) {
                element.ChangeSelected(selected);
            }
        }

        public void Clear() {
            panel.Controls.Clear();
            selectAllCheckBox.Checked = false;
            selectAllCheckBox.Enabled = false;
        }
    }
}
