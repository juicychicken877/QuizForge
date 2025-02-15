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
        public event EventHandler<OnTestInteractionEventArgs> OnEditTest;
        public event EventHandler<OnTestInteractionEventArgs> OnSolveTest;

        public class OnTestInteractionEventArgs : EventArgs {
            public Test test { get; set; }
        }


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

                newElement.OnEditButtonClicked += NewElement_OnEditButtonClicked;
                newElement.OnSolveButtonClicked += NewElement_OnSolveButtonClicked;

                panel.Controls.Add(newElement);
            }
        }

        private void NewElement_OnSolveButtonClicked(object? sender, TestListElement.OnInteractionButtonClickedEventArgs e) {
            OnSolveTest?.Invoke(this, new OnTestInteractionEventArgs() { test = e.test });
        }

        private void NewElement_OnEditButtonClicked(object? sender, TestListElement.OnInteractionButtonClickedEventArgs e) {
            OnEditTest?.Invoke(this, new OnTestInteractionEventArgs() { test = e.test });
        }
    }
}
