using log4net;
using P01_K_DESIGN_WIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmCustomerMng : frmEditContainer
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public frmCustomerMng()
		{
			InitializeComponent();
		}
	}
}
