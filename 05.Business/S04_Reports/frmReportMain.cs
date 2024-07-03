using P01_K_DESIGN_WIN;
using System;
using System.Windows.Forms;

namespace P05_Business.S04_Reports
{
    public partial class frmReportMain : frmBlank
    {
        public frmReportMain()
        {
            InitializeComponent();
        }

        private void frmReportMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
        }
    }
}
