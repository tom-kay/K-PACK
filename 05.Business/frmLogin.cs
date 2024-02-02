using _01.K_DESIGN_WIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _05.Business
{
    public partial class frmLogin : frmLoginFrame
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
