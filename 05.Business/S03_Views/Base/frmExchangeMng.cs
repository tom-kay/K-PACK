using P01_K_DESIGN_WIN;
using P03_Framework.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmExchangeMng : frmEditContainer
	{
		private ExchangeHelper exchange;

		public frmExchangeMng()
		{
			InitializeComponent();

			exchange = new ExchangeHelper();

			GetExchangeRateTask();
		}

		async void GetExchangeRateTask()
		{
			string serachDate = DateTime.Now.ToString("yyyyMMdd");

			DataTable result = await exchange.GetExchangeRateHanaBank(serachDate);

			DisplayExchange(result);
		}

		private void DisplayExchange(DataTable result)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action<DataTable>(DisplayExchange), result);
			}
			else
			{
				DataTable dt = result;
			}
		}
	}
}
