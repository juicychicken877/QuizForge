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
    public partial class SelectableListElement: UserControl
    {
        public Test testRef { get; private set; }

        public SelectableListElement(Test test)
        {
            InitializeComponent();

            titleLabel.Text = test.title;
            descriptionLabel.Text = test.description;

            testRef = test;
        }

        public void ChangeSelected(bool selected) {
            selectCheckBox.Checked = selected;
        }

        public bool IsSelected() {
            return selectCheckBox.Checked;
        }
    }
}
