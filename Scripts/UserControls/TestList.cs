using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMakerTaker
{
    public partial class TestList : UserControl
    {
        public MainWindow.TestInteractionButtonHandler SolveButtonClickedHandler;
        public MainWindow.TestInteractionButtonHandler EditButtonClickedHandler;

        public TestList()
        {
            InitializeComponent();
        }
        public void Update(List<Test> tests)
        {
            // Clear list
            panel.Controls.Clear();

            foreach(Test test in tests)
            {
                // Create new element for each test
                TestListElement newElement = new(test);

                newElement.EditButtonClickedHandler += EditButtonClickedHandler;
                newElement.SolveButtonClickedHandler += SolveButtonClickedHandler;

                panel.Controls.Add(newElement);
            }
        }
    }
}
