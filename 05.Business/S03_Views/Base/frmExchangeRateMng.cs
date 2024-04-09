using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P03_Framework.Helpers;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using P05_Business.S03_Views.Popup.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace P05_Business.S03_Views.Base
{
	public partial class frmExchangeRateMng : frmEditContainer
	{
		private ExchangeRateMngController ctrl;
		private List<ExchangeRateMngDto> dto;
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


		private void btnInit_Click(object sender, EventArgs e)
		{
			try
			{
				SetInit();
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				string exDate = lblExDate.Text.Trim();
				DateTime date = new DateTime();
				bool isDate = DateTime.TryParse(exDate, out date);
				if (!isDate)
				{
					KMessageBox.Show("[고시일자]를 선택 바랍니다.", "조회", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}

                ResultCRUD result = SearchData(exDate.Replace("-",""));

                if (result == ResultCRUD.SearchSuccessData)
                {
					MainMessage.Show("조회되었습니다.");
				}
				else if (result == ResultCRUD.SearchSuccessNoData)
				{
					MainMessage.Show("자료가 없습니다.");
				}
				else
				{
					KMessageBox.Show("조회 실패하였습니다.", "조회", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
            }
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{

				if (KMessageBox.Show("저장하시겠습니까?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					var result = SaveData(); 
					if (result == ResultCRUD.SaveSuccessData)
					{
						MainMessage.Show("저장되었습니다.");
					}
				}

			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		

		private void btnDownExchangeRate_Click(object sender, EventArgs e)
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

		private void SetInit()
		{
			lblExDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

			dto = new List<ExchangeRateMngDto>();
			dgvList.DataSource = null;

			InitDto();
		}

		private void InitDto()
		{

			base.currentData = dto;         //원본 데이터
			base.isFormChagned = false;
		}


		private ResultCRUD SearchData(string exDate)
		{
			ExchangeRateMngDto param = new ExchangeRateMngDto()
			{
				ExDate = exDate,
			};

			dto = ctrl.GetExchangeRateList(param);

			dgvList.DataSource = DataHandles.ConvertToDataTable<ExchangeRateMngDto>(dto);
			(dgvList.DataSource as DataTable).AcceptChanges();

			InitDto();

			dgvList.DataSource = dto;
			ResultCRUD result = ResultCRUD.None;
            if (dto == null)
            {	
				result = ResultCRUD.SearchFailData;
            }
			else if (dto.Count < 1)
			{	
				result = ResultCRUD.SearchSuccessNoData;
			}
			else if (dto.Count > 0)
			{
				result = ResultCRUD.SearchSuccessData;
			}

			

			return result;
        }

		private ResultCRUD SaveData()
		{
			DataTable dt = UserDataGrid.GetChangeAll(dgvList);

			if (dt == null || dt.Rows.Count < 1) return ResultCRUD.None;

			List<ExchangeRateMngDto> param = DataHandles.ConvertToList<ExchangeRateMngDto>(dt);

			if (param == null && param.Count < 1) return ResultCRUD.None;

			//유효성 검사
			var context = new ValidationContext(param, serviceProvider: null, items: null);
			Validator.ValidateObject(param, context, validateAllProperties: true);

			//데이터 저장
			bool isSave = ctrl.AddExchangeRate(param);

			//결과 처리
			ResultCRUD result = ResultCRUD.None;
			if (isSave)
			{

				SearchData(lblExDate.Text.Trim());

				result = ResultCRUD.SaveSuccessData;
			}

			return result;

		}

		async void GetExchangeRateTask()
		{
			string serachDate = lblExDate.Text.Replace("-", "");

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

		
	}
}
