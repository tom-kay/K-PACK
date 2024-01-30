using _01.K_DESIGN_WIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05.Business
{
    public partial class frmMain : frmMdiContainer
    {
        public frmMain()
        {
            InitializeComponent();

            frmLogin login = new frmLogin();
            login.ShowDialog();

            frmPopup popup = new frmPopup();
            popup.ShowDialog();

            base.btnMaximum_Click(null, null);


        }
    }
}
