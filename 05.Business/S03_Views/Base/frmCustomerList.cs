using log4net;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
    public partial class frmCustomerList : frmSearchContainer
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		CustomerMngController ctrl = new CustomerMngController();

		public frmCustomerList()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false, isNew = false });

			//그리드 생성
			CreateGrid();
		}

		private void CreateGrid()
		{
			UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
			UserDataGrid.AddLinkColumn(dgvList, "CustCode", "거래처코드", true, true, 10, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "CustName", "거래처명", true, true, 50, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "NationName", "국가", true, true, 10, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddCheckBoxColumn(dgvList, "DealTypeSale", "매출", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddCheckBoxColumn(dgvList, "DealTypeBuy", "매입", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddCheckBoxColumn(dgvList, "DealTypeProc", "임가공", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddCheckBoxColumn(dgvList, "DealTypeGeneral", "일반", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.End(dgvList);
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			rdoDelA.Checked = true;

			chkDealSale.Checked = true;
			chkDealBuy.Checked = true;
			chkDealProc.Checked = true;
			chkDealGeneral.Checked = true;

			dgvList.DataSource = null;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				SearchData();

				MainMessage.Show("조회되었습니다.");
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SearchData()
		{
			CustomerDto param = new CustomerDto() {
				CustCode = txtCustCode.Texts,
				CustName = txtCustName.Texts,
				NationCode = cboNationality.SelectedValue.ToString(),
				DealTypeSale = chkDealSale.Checked,
				DealTypeBuy = chkDealBuy.Checked,
				DealTypeProc = chkDealProc.Checked,
				DealTypeGeneral = chkDealGeneral.Checked,
				DelYn = rdoDelA.Checked ? "" : rdoDelY.Checked ? "Y" : "N",
			};

			List<CustomerDto> list = ctrl.GetCustomerList(param);
			
			dgvList.DataSource = list;
		}

		private void frmCustomerList_Load(object sender, EventArgs e)
		{
			InitCombo();
		}

		private void InitCombo()
		{
			ComboHelper.InitComboBox(cboNationality, "NATIONALITY", true, false);
		}

		private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			string code = dgvList.Rows[e.RowIndex].Cells["CustCode"].Value.ToString();

			frmCustomerMng frm = new frmCustomerMng(code);

			AccessMain.OpenChildForm(frm);
		}
	}
}
