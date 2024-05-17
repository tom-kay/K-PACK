using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using P05_Business.S02_Controllers.Base;
using P05_Business.Common.Helpers;

namespace P05_Business.S03_Views.Base
{
	public partial class frmUserList : P01_K_DESIGN_WIN.frmSearchContainer
	{
		UserMngController ctrl = new UserMngController();

		public frmUserList()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false, isNew = false });

			//그리드 생성
			CreateGrid();
		}

		private void frmUserList_Load(object sender, EventArgs e)
		{
			//콤보박스 초기화
			InitComboBox();
		}

		private void InitComboBox()
		{	
			ComboHelper.InitComboBox(cboDepartment, "DEPARTMENT", true, false); //부서목록
			ComboHelper.InitComboBox(cboTeam, "TEAM", true, false);         //팀목록
			ComboHelper.InitComboBox(cboPosition, "POSITION", true, false);     //직위목록
			ComboHelper.InitComboBox(cboJobType, "JOBTYPE", true, false);           //직책목록
		}

		private void CreateGrid()
		{
			UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
			UserDataGrid.AddTextBoxColumn(dgvList, "UserId", "사용자ID", true, false, 11, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "CompanyCode", "회사코드", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "CompanyNameK", "회사명", true, true, 10, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "LoginId", "로그인 ID", true, true, 10, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "UserNameK", "사용자명", true, true, 10, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "DepartmentName", "부서", true, true, 10, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "TeamName", "팀", true, true, 10, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "PositionName", "직위", true, true, 10, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "JobName", "직책", true, true, 10, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.AddTextBoxColumn(dgvList, "UseYn", "사용 Y/N", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
			UserDataGrid.End(dgvList);
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			rdoUseA.Checked = true;

			dgvList.DataSource = null;
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
			UserMngDto item = new UserMngDto()
			{
				CompanyCode = txtCompanyCode.Texts,
				LoginId = txtLoginId.Texts,
				UserNameK = txtUserNameK.Texts,
				UseYn = rdoUseA.Checked ? "" : rdoUseY.Checked ? "Y" : "N",
				DepartmentCode = cboDepartment.SelectedValue.ToString(),
				TeamCode = cboTeam.SelectedValue.ToString(),
				PositionCode = cboPosition.SelectedValue.ToString(),
				JobCode = cboJobType.SelectedValue.ToString(),
			};

			List<UserMngDto> items = ctrl.GetUserInfoList(item);

			dgvList.DataSource = items;

			MainMessage.Show("조회되었습니다.");
		}

		private void dgvList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				string userId = dgvList.Rows[e.RowIndex].Cells["UserId"].Value.ToString();

				frmUserMng frm = new frmUserMng(userId);

				AccessMain.OpenChildForm(frm);
			}
		}
	}
}
