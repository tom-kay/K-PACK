using log4net;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using P05_Business.Common;
using P05_Business.S02_Controllers.Base;
using P05_Business.S03_Views.Popup.Common;
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
	public partial class frmCustomerList : frmSearchContainer
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		CustomerMngController ctrl = new CustomerMngController();

		public frmCustomerList()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });

			//그리드 생성
			CreateGrid();
		}

		private void CreateGrid()
		{
			UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
			UserDataGrid.AddTextBoxColumn(dgvList, "CustCode", "거래처코드", true, true, 10, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "CustName", "거래처명", true, true, 15, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "NationName", "국가", true, true, 10, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "DealTypeSale", "매출", true, true, 15, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "DealTypeBuy", "매입", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "DealTypeProc", "임가공", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "DealTypeGeneral", "일반", true, true, 15, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.End(dgvList);
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			rdoDelA.Checked = true;

			dgvList.DataSource = null;
		}

		private void btnFindCustCode_Click(object sender, EventArgs e)
		{
			try
			{
				//frmMasterCodePopup popup;

				//if (sender is KTextBox)
				//{
				//	if (string.IsNullOrEmpty(txtMasterCode.Texts)) return;

				//	string masterCode = txtMasterCode.Texts;
				//	popup = new frmMasterCodePopup("FIND MASTER CODE", masterCode);

				//	if (popup.DialogResult == DialogResult.OK)
				//	{
				//		txtMasterCode.SetValue(popup.ResultCode);
				//		txtMasterName.SetValue(popup.ResultName);
				//	}
				//}
				//else
				//{
				//	popup = new frmMasterCodePopup("FIND MASTER CODE");

				//	if (popup.ShowDialog() == DialogResult.OK)
				//	{
				//		txtMasterCode.SetValue(popup.ResultCode);
				//		txtMasterName.SetValue(popup.ResultName);
				//	}
				//}

			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
