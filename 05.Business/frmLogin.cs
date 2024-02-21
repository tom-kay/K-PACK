using P01_K_DESIGN_WIN;
using P05_Business.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace P05_Business
{
    public partial class frmLogin : frmLoginFrame
    {
        public frmLogin()
        {
            InitializeComponent();
			
			//회사로고 표시
			picLogo.Image = Image.FromFile(GlobalVariables.GetLogoFileImage);

		}

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
