using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.Common
{
	public static class AccessMain
	{
		public static void ChildFormClose()
		{
			foreach (Form frm in Application.OpenForms)
			{
				if (frm.Name.Equals(GlobalVariables.MdiFormName))
				{
					((frmMain)frm).CloseChildForm();
					return;
				}
			}
		}
	}
}
