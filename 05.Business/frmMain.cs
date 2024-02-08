using P01_K_DESIGN_WIN;
using P02_K_CONTROL_WIN;
using P05_Business.S03_Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace P05_Business
{
	public partial class frmMain : frmMdiContainer
	{
		public frmMain()
		{
			InitializeComponent();

			frmLogin login = new frmLogin();
			login.ShowDialog();

			base.btnMaximum_Click(null, null);

		}

		private void frmMain_Load(object sender, EventArgs e)
		{


		}

		private void CreateMenu(object sender, EventArgs e)
		{

		}
	}
}
