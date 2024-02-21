using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmCodeMasterList : P01_K_DESIGN_WIN.frmSearchContainer
	{
		#region Member Variables
		CodeMngController ctrl = new CodeMngController();
		#endregion

		#region Constructor
		public frmCodeMasterList()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });

			//그리드 생성
			CreateGrid();

		}
		#endregion

		#region Control Events
		private void btnInit_Click(object sender, EventArgs e)
		{
			rdoUseY.Checked = true;
			rdoDelY.Checked = true;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			SearchData();
		}

		private void dgvList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				string code = dgvList.Rows[e.RowIndex].Cells["CODE"].Value.ToString();

				frmCodeMasterMng frm = new frmCodeMasterMng(code);

				AccessMain.OpenChildForm(frm);
			}
		}
		#endregion

		#region Custom Methods
		private void SearchData()
		{
			try
			{
				CodeMasterDto item = new CodeMasterDto()
				{
					Code = txtCode.Texts,
					Name = txtName.Text,
					UseYn = rdoUseY.Checked ? "Y" : "N",
					DelYn = rdoDelY.Checked ? "Y" : "N",
				};

				List<CodeMasterDto> codeMasters = ctrl.GetCodeMasterList(item);

				dgvList.DataSource = codeMasters;

				MainMessage.Show("조회되었습니다.");
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void CreateGrid()
		{
			UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
			UserDataGrid.AddTextBoxColumn(dgvList, "CODE", "CODE", true, true, 10, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "NAME", "NAME", true, true, 10, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "UseYn", "사용", true, true, 10, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "DelYn", "삭제", true, true, 10, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "CreateDt", "생성일자", true, true, 10, DataGridViewContentAlignment.MiddleCenter, UserDataGrid.TextType.DateTime);
			UserDataGrid.AddTextBoxColumn(dgvList, "UpdateDt", "수정일자", true, true, 10, DataGridViewContentAlignment.MiddleCenter, UserDataGrid.TextType.DateTime);
			UserDataGrid.AddTextBoxColumn(dgvList, "DeleteDt", "삭제일자", true, true, 10, DataGridViewContentAlignment.MiddleCenter, UserDataGrid.TextType.DateTime);
			UserDataGrid.End(dgvList);
		} 
		#endregion


	}
}
