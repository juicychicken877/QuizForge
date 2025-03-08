using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizForge.Scripts.Forms
{
    public partial class ImportWindow: Form
    {
        public ImportWindow(string? path, bool selectAll)
        {
            this.InitializeComponent();

            if (path != null) importView.SelectFile(path);

            if (selectAll) importView.SelectAll();

            ImportExportHandler.OnImport += ImportExportHandler_OnImport;
        }

        private void ImportExportHandler_OnImport(object? sender, ImportExportHandler.OnImportEventArgs e) {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
