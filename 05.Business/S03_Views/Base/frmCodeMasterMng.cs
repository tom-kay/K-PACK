﻿using P01_K_DESIGN_WIN.Classes;
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
		CodeMasterDto dto = new CodeMasterDto();  //모델 클래스
		CodeMngController ctrl = new CodeMngController();
		#endregion

		#region Constructor
		public frmCodeMasterMng()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });

			//InitTag();

			InitDto();
		}

		public frmCodeMasterMng(string code) : this()
		{
			txtCode.Texts = code;

			IS_LINK_OPEN = true;
		}
		#endregion

		#region Control Events
		private void frmCodeMasterMng_Load(object sender, EventArgs e)
		{
			//LinkModelControls(this, dto);
			if (IS_LINK_OPEN) SearchData();
		}
		
		private void btnInit_Click(object sender, EventArgs e)
		{
			try
			{
				SetInit();//초기화
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 그리드 조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				//코드 입력 확인
				if (string.IsNullOrEmpty(txtCode.Texts))
				{
					KMessageBox.Show("CODE를 입력 바랍니다.", "조회", MessageBoxButtons.OK);
					txtCode.Focus();
					return;
				}

				SearchData();
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
				bool isVal = ValidationData();

				if (isVal)
				{
					if (KMessageBox.Show("저장하시겠습니까?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						SaveData();
					}
				}
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtCode.Texts))
				{
					KMessageBox.Show("CODE를 입력 바랍니다.", "삭제", MessageBoxButtons.OK);
					txtCode.Focus();
					return;
				}

				DeleteData();   //삭제
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region Custom Methods
		private void SetInit()
		{
			txtCode.Enabled = true;	

			rdoY.Checked = rdoN.Checked = false;

			dto = new CodeMasterDto();
			InitDto();
		}
		
		private bool ValidationData()
		{
			if (string.IsNullOrEmpty(txtCode.Texts))
			{
				KMessageBox.Show("[CODE]를 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCode.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(txtName.Texts))
			{
				KMessageBox.Show("[NAME]을 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCode.Focus();
				return false;
			}

			if (!rdoY.Checked && !rdoN.Checked)
			{
				KMessageBox.Show("[사용유무]를 선택 바랍니다.", "저장", MessageBoxButtons.OK);
				rdoY.Focus();
				return false;
			}

			return true;
		}

		private void SaveData()
		{	
			CodeMasterDto saveData = DataHandles.ControlsToDto(this, dto);

			CodeMasterDto param = new CodeMasterDto() { 
				Code = saveData.Code,
				Name = saveData.Name,
				UseYn = saveData.UseYn,
				Remark = saveData.Remark,
				CreateId = "SYSTEM",
				UpdateId = "SYSTEM",
			};

			dto = ctrl.AddCodeMaster(param);

			if (dto != null)
			{
				txtCode.Enabled = false;
				InitDto();

				MainMessage.Show("저장되었습니다.");
			}
		}

		private void SearchData()
		{
			try
			{
				CodeMasterDto param = new CodeMasterDto()
				{
					Code = txtCode.Texts
				};

				dto = ctrl.GetCodeMaster(param);

				if (dto != null)
				{
					DataHandles.DtoToControls(this, dto);   //데이터 바인딩
					InitDto();

					txtCode.Enabled = false;

					MainMessage.Show("조회되었습니다.");
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

		/// <summary>
		/// 데이터 삭제
		/// </summary>
		private void DeleteData()
		{
			try
			{
				CodeMasterDto param = new CodeMasterDto()
				{
					Code = txtCode.Texts
				};
				int iDelete = ctrl.RemoveCodeMaster(param);

				if (iDelete > -1)
				{
					MainMessage.Show("삭제되었습니다.");
					btnInit.PerformClick();
				}
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//private void InitTag()
		//{
		//	//라디오 버튼 셋팅
		//	rdoY.Tag = new Tuple<string, string>("UseYn", "Y");
		//	rdoN.Tag = new Tuple<string, string>("UseYn", "N");

		//	rdoY.Checked = rdoN.Checked = false;
		//}

		private void InitDto()
		{
			
			base.currentData = dto;			//원본 데이터
			base.isFormChagned = false;
		}
		#endregion

	}
}
