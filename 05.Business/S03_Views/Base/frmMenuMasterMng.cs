using P01_K_DESIGN_WIN.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmMenuMasterMng : P01_K_DESIGN_WIN.frmEditContainer
	{
		public frmMenuMasterMng()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isClose = false, isPrint = false });
		}
	}
}
