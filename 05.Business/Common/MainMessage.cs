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
		public static void Show(string message)
		{
			AccessMain.MdiMain.lblMainMsg.Text = message;
		}
	}
}
