using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P03_Framework.Helpers;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
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
	public partial class frmExchangeRateMng : frmEditContainer
	{
		private ExchangeRateMngController ctrl;
		private ExchangeRateMngDto dto;
		private ExchangeHelper exchange;

		public frmExchangeRateMng()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false, isDelete = false });

			//그리드 생성
			CreateGrid();

			ctrl = new ExchangeRateMngController();
			exchange = new ExchangeHelper();

			SetInit();

		}

		private void SetInit()
		{
			lblExDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

			dto = new ExchangeRateMngDto();
			dgvList.DataSource = null;

			InitDto();
		}

		private void InitDto()
		{

			base.currentData = dto;         //원본 데이터
			base.isFormChagned = false;
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

				BindExchangeRate(dt);
			}
		}

		/// <summary>
		/// 환율을 그리드에 바인딩한다.
		/// </summary>
		/// <param name="dt"></param>
		/// <exception cref="NotImplementedException"></exception>
		private void BindExchangeRate(DataTable dt)
		{
			dgvList.DataSource = dt;
		}

		private void CreateGrid()
		{
			UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill, DataGridViewCellBorderStyle.RaisedHorizontal);
			UserDataGrid.AddTextBoxColumn(dgvList, "ExDate", "고시일자", true, true, 1, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "CurrCode", "통화코드", true, true, 1, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "CurrName", "통화명", true, true, 1, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "CashBuy", "현찰살때", true, true, 1, DataGridViewContentAlignment.MiddleRight, format:"#,0.00");
			UserDataGrid.AddTextBoxColumn(dgvList, "CashBuySpread", "현찰살때\r\n스프레드", true, true, 1, DataGridViewContentAlignment.MiddleRight, format: "#,0.00");
			UserDataGrid.AddTextBoxColumn(dgvList, "CashSale", "현찰팔때", true, true, 1, DataGridViewContentAlignment.MiddleRight, format: "#,0.00");
			UserDataGrid.AddTextBoxColumn(dgvList, "CashSaleSpread", "현찰팔때\r\n스프레드", true, true, 1, DataGridViewContentAlignment.MiddleRight, format: "#,0.00");
			UserDataGrid.AddTextBoxColumn(dgvList, "RemitSend", "송금보낼때", true, true, 1, DataGridViewContentAlignment.MiddleRight, format: "#,0.00");
			UserDataGrid.AddTextBoxColumn(dgvList, "RemitRecv", "송금받을때", true, true, 1, DataGridViewContentAlignment.MiddleRight, format: "#,0.00");
			UserDataGrid.AddTextBoxColumn(dgvList, "TCBuy", "T/C 살때", true, true, 1, DataGridViewContentAlignment.MiddleRight, format: "#,0.00");
			UserDataGrid.AddTextBoxColumn(dgvList, "Check", "외화수표팔때", true, true, 1, DataGridViewContentAlignment.MiddleRight, format: "#,0.00");
			UserDataGrid.AddTextBoxColumn(dgvList, "BasicRate", "매매기준율", true, true, 1, DataGridViewContentAlignment.MiddleRight, format: "#,0.00");
			UserDataGrid.AddTextBoxColumn(dgvList, "Commission", "환가료율", true, true, 1, DataGridViewContentAlignment.MiddleRight, format: "#,0.00000");
			UserDataGrid.AddTextBoxColumn(dgvList, "Convert", "미화환산율", true, true, 1, DataGridViewContentAlignment.MiddleRight, format: "#,0.00");
			UserDataGrid.End(dgvList);

			dgvList.AutoResizeColumnHeadersHeight();

		}

		private void btnAddRow_Click(object sender, EventArgs e)
		{
			try
			{
				GetExchangeRateTask();
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{

		}
	}
}
