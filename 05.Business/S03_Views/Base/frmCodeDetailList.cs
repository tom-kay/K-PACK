using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using P05_Business.S03_Views.Popup.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
    public partial class frmCodeDetailList : P01_K_DESIGN_WIN.frmSearchContainer
	{
		CodeMngController ctrl = new CodeMngController();

		public frmCodeDetailList()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });

			//그리드 생성
			CreateGrid();
		}

		private void CreateGrid()
		{
			UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
			UserDataGrid.AddTextBoxColumn(dgvList, "MasterCode", "M/CODE", true, true, 10, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "MasterName", "M/Name", true, true, 15, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "Code", "CODE", true, true, 10, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "Name", "NAME", true, true, 15, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "UseYn", "사용", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "DelYn", "삭제", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "CreateDt", "생성일자", true, true, 15, DataGridViewContentAlignment.MiddleCenter, UserDataGrid.TextType.DateTime);
			UserDataGrid.AddTextBoxColumn(dgvList, "UpdateDt", "수정일자", true, true, 15, DataGridViewContentAlignment.MiddleCenter, UserDataGrid.TextType.DateTime);
			UserDataGrid.AddTextBoxColumn(dgvList, "DeleteDt", "삭제일자", true, true, 15, DataGridViewContentAlignment.MiddleCenter, UserDataGrid.TextType.DateTime);
			UserDataGrid.End(dgvList);
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			rdoUseA.Checked = true;
			rdoDelA.Checked = true;

			dgvList.DataSource = null;
		}

		private void btnFindMasterCode_Click(object sender, EventArgs e)
		{
			try
			{
				frmMasterCodePopup popup;

				if (sender is KTextBox)
                {
					if (string.IsNullOrEmpty(txtMasterCode.Texts)) return;

					string masterCode = txtMasterCode.Texts;
					popup = new frmMasterCodePopup("FIND MASTER CODE", masterCode);

					if (popup.DialogResult == DialogResult.OK)
					{
						txtMasterCode.SetValue(popup.ResultCode);
						txtMasterName.SetValue(popup.ResultName);
					}
				}
				else
				{
					popup = new frmMasterCodePopup("FIND MASTER CODE");

					if (popup.ShowDialog() == DialogResult.OK)
					{
						txtMasterCode.SetValue(popup.ResultCode);
						txtMasterName.SetValue(popup.ResultName);
					}
				}

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
				SearchData();
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SearchData()
		{
			try
			{
				CodeDetailDto item = new CodeDetailDto()
				{
					MasterCode = txtMasterCode.Texts,
					Code = txtCode.Texts,
					Name = txtName.Texts,
					UseYn = rdoUseA.Checked ? "" : rdoUseY.Checked ? "Y" : "N",
					DelYn = rdoDelA.Checked ? "" : rdoDelY.Checked ? "Y" : "N",
				};

				List<CodeDetailDto> items = ctrl.GetCodeDetailList(item);

				dgvList.DataSource = items;

				MainMessage.Show("조회되었습니다.");
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				string masterCode = dgvList.Rows[e.RowIndex].Cells["MasterCode"].Value.ToString();
				string code = dgvList.Rows[e.RowIndex].Cells["Code"].Value.ToString();

				frmCodeDetailMng frm = new frmCodeDetailMng(masterCode, code);

				AccessMain.OpenChildForm(frm);
			}
		}
	}
}
