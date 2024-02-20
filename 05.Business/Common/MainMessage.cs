using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.Common
{
	public static class MainMessage
	{
		public static void show(string message)
		{
			foreach(Form frm in Application.OpenForms)
			{
				if (frm.Name.Equals(GlobalVariables.MdiFormName))
				{
					((frmMain)frm).lblMainMsg.Text = message;
					return;
				}
			}
		}
	}
}
