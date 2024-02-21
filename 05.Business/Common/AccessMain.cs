using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.Common
{
	public class AccessMain
	{
		public static frmMain MdiMain;
        
        public static void ChildFormClose()
		{
			MdiMain.CloseChildForm();
		}

		public static void OpenChildForm(Form form)
		{
			MdiMain.OpenChildForm(form);
		}
	}
}
