using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmCompanyInfo : P01_K_DESIGN_WIN.frmEditContainer
	{
		#region Member Variables
		CompanyMngController ctrl = new CompanyMngController();
		CompanyInfoDto dto = new CompanyInfoDto(); 
		#endregion

		#region Constructor
		public frmCompanyInfo()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });

			InitDto();
		}
		#endregion

		#region Control Events
		private void frmCompanyInfo_Load(object sender, EventArgs e)
		{
			InitCombo();
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

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				//회사코드
				if (string.IsNullOrEmpty(txtCompanyCode.Texts))
				{
					KMessageBox.Show("[회사코드]를 입력 바랍니다.", "조회", MessageBoxButtons.OK);
					txtCompanyCode.Focus();
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
					if (KMessageBox.Show("저장하시겠습니까?", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
				if (string.IsNullOrEmpty(txtCompanyCode.Texts))
				{
					KMessageBox.Show("[회사코드]를 입력 바랍니다.", "삭제", MessageBoxButtons.OK);
					return;
				}

                if (KMessageBox.Show("삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
					DeleteData();   //삭제
				}

			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		#endregion

		#region Custom Methods
		private void InitDto()
		{
			base.currentData = dto;            //원본 데이터

			base.isFormChagned = false;
		}


		private void SetInit()
		{
			txtCompanyCode.Enabled = true;

			dto = new CompanyInfoDto();
			InitDto();
		}

		/// <summary>
		/// 데이터 조회
		/// </summary>
		private void SearchData()
		{
			try
			{
				CompanyInfoDto param = new CompanyInfoDto()
				{
					CompanyCode = txtCompanyCode.Texts,
				};

				dto = ctrl.GetCompanyInfo(param);

				if (dto != null)
				{
					DataHandles.DtoToControls(this, dto);

					txtCompanyCode.Enabled = false;
					InitDto();
					MainMessage.Show("조회되었습니다.");
				}
				else
				{
					KMessageBox.Show("자료가 없습니다.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidationData()
		{
			if (txtCompanyCode.Texts.Length != 4)
			{
				KMessageBox.Show("4자리 [회사코드]를 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCompanyCode.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(txtCompanyGroup.Texts))
			{
				KMessageBox.Show("[회사그룹]을 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCompanyGroup.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(txtCompanyNameK.Texts))
			{
				KMessageBox.Show("[회사명(한글)]을 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCompanyNameK.Focus();
				return false;
			}

			return true;
		}

		private void SaveData()
		{
			CompanyInfoDto tmp = DataHandles.ControlsToDto(this, dto);

			CompanyInfoDto param = new CompanyInfoDto()
			{
				CompanyCode = tmp.CompanyCode,
				CompanyGroup = tmp.CompanyGroup,
				Nationality = tmp.Nationality,
				HeadOffice = tmp.HeadOffice,
				CompanyNameK = tmp.CompanyNameK,
				CompanyNameE = tmp.CompanyNameE,
				TelNo = tmp.TelNo,
				FaxNo = tmp.FaxNo,
				AddressK1 = tmp.AddressK1,
				AddressK2 = tmp.AddressK2,
				AddressE1 = tmp.AddressE1,
				AddressE2 = tmp.AddressE2,
				CreateId = "SYSTEM",
				UpdateId = "SYSTEM"
			};

			int result = ctrl.AddCompanyInfo(param);

			if (result >= 0)
			{
				InitDto();

				MainMessage.Show("저장되었습니다.");
			}
		}

		private void DeleteData()
		{
			try
			{
				CompanyInfoDto param = new CompanyInfoDto()
				{
					CompanyCode = txtCompanyCode.Texts,
				};
				int result = ctrl.RemoveCompanyInfo(param);

				if (result >= 0)
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

		/// <summary>
		/// 콤보박스 초기설정
		/// </summary>
		private void InitCombo()
		{	
			ComboHelper.InitComboBox(cboNationality, "NATIONALITY",false, true);
		}

		
		#endregion


	}
}
