using P05_Business.S03_Views.Popup.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.Common
{
	public class AccessMain
	{
		public static frmMain MdiMain;
		public static frmLoading loading;

		public static void ChildFormClose()
		{
			MdiMain.CloseChildForm();
		}

		public static void OpenChildForm(Form form)
		{
			MdiMain.OpenChildForm(form);
		}

		public static void ShowLoading()
		{
			loading = new frmLoading();
			loading.Show(AccessMain.MdiMain);
			loading.Refresh();
		}

		public static void HideLoading()
		{
			loading.Close();
		}
	}
}
