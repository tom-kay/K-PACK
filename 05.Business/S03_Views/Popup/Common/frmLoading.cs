using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Popup.Common
{
	public partial class frmLoading : Form
	{
		public frmLoading()
		{
			InitializeComponent();
		}

		private void btnCloseForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
