using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmCodeMasterMng : P01_K_DESIGN_WIN.frmEditContainer
	{
		#region Member Variables
		CodeMngController ctrl = new CodeMngController();
		#endregion

		#region Constructor
		public frmCodeMasterMng()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });
		}
		#endregion

		#region Default Events
		/// <summary>
		/// 그리드 조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			//코드 입력 확인
			if (string.IsNullOrEmpty(txtCode.Texts))
			{
				KMessageBox.Show("CODE를 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCode.Focus();
				return;
			}

			SearchData();
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			SetInit();//초기화
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtCode.Texts))
			{
				KMessageBox.Show("CODE를 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCode.Focus();
				return;
			}

			DeleteData();   //삭제
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			bool isVal = ValidationData();

			if (isVal)
			{
				if (KMessageBox.Show("저장하시겠습니까?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					SaveData();
				}
			}

		}
		#endregion

		#region Custom Methods
		private bool ValidationData()
		{
			if (string.IsNullOrEmpty(txtCode.Texts))
			{
				KMessageBox.Show("CODE를 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCode.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(txtName.Texts))
			{
				KMessageBox.Show("NAME을 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCode.Focus();
				return false;
			}

			return true;
		}

		private void SaveData()
		{
			try
			{
				CodeMasterDto item = new CodeMasterDto()
				{
					Code = txtCode.Texts,
					Name = txtName.Texts,
					UseYn = rdoY.Checked ? "Y" : "N"
				};

				CodeMasterDto result = ctrl.AddCodeMaster(item);

				if (result != null)
				{
					MainMessage.show("저장되었습니다.");
				}
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
				CodeMasterDto item = new CodeMasterDto()
				{
					Code = txtCode.Texts
				};

				CodeMasterDto list = ctrl.GetCodeMaster(item);

				if (list != null)
				{
					txtCode.Texts = list.Code;
					txtName.Texts = list.Name;
					if (list.UseYn == "Y") rdoY.Checked = true;
					else rdoN.Checked = true;

					MainMessage.show("조회되었습니다.");
				}
				else
				{
					KMessageBox.Show("자료가 없습니다.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					btnInit.PerformClick();
				}
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SetInit()
		{
			rdoY.Checked = true;
		}

		/// <summary>
		/// 데이터 삭제
		/// </summary>
		private void DeleteData()
		{
			try
			{
				CodeMasterDto item = new CodeMasterDto()
				{
					Code = txtCode.Texts
				};
				int iDelete = ctrl.RemoveCodeMaster(item);

				if (iDelete > -1)
				{
					MainMessage.show("삭제되었습니다.");
					btnInit.PerformClick();
				}
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		} 
		#endregion
	}
}
