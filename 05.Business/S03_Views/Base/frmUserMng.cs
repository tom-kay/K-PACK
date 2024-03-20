using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml.XPath;

namespace P05_Business.S03_Views.Base
{
	public partial class frmUserMng : P01_K_DESIGN_WIN.frmEditContainer
	{
		#region Member Variables

		UserMngController ctrl = new UserMngController();
		UserMngDto dto = new UserMngDto();

		#endregion Member Variables

		#region Constructor

		public frmUserMng()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });

			InitDto();
			
		}

		public frmUserMng(string userId) : this()
		{
			IS_LINK_OPEN = true;

			txtUserId.Texts = userId;
		}
		
		#endregion Constructor

		#region Control Events
		private void frmUserMng_Load(object sender, EventArgs e)
		{
			InitCombo();

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

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{	
				//회사코드
				if (string.IsNullOrEmpty(txtUserId.Texts))
				{
					KMessageBox.Show("[USER ID]를 입력 바랍니다.", "조회", MessageBoxButtons.OK);
					txtLoginId.Focus();
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
				if (string.IsNullOrEmpty(txtLoginId.Texts))
				{
					KMessageBox.Show("[로그인 ID]를 입력 바랍니다.", "삭제", MessageBoxButtons.OK);
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

		private void btnShowPw_Click(object sender, EventArgs e)
		{
			txtLoginPw.PasswordChar = !txtLoginPw.PasswordChar;
		}


		#endregion Control Events

		#region Custom Methods
		private void InitDto()
		{
			base.currentData = dto;            //원본 데이터

			base.isFormChagned = false;
		}

		/// <summary>
		/// 콤보박스 초기설정
		/// </summary>
		private void InitCombo()
		{
			ComboHelper.InitComboBox(cboNationality, "NATIONALITY", false, true);	//국적
			ComboHelper.InitComboBox(cboDepartment, "DEPARTMENT", false, true);	//부서목록
			ComboHelper.InitComboBox(cboTeam, "TEAM", false, true);			//팀목록
			ComboHelper.InitComboBox(cboPosition, "POSITION", false, true);		//직위목록
			ComboHelper.InitComboBox(cboJob, "JOBTYPE", false, true);			//직책목록

		}

		private void SetInit()
		{

			dto = new UserMngDto();
			InitDto();
		}

		/// <summary>
		/// 데이터 조회
		/// </summary>
		private void SearchData()
		{
			try
			{
				UserMngDto param = new UserMngDto()
				{
					UserId = txtUserId.Texts,
				};

				dto = ctrl.GetUserInfo(param);

				if (dto != null)
				{
					DataHandles.DtoToControls(this, dto);

					
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
			if (string.IsNullOrEmpty(txtLoginId.Texts))
			{
				KMessageBox.Show("[로그인 ID]를 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtLoginId.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(txtLoginPw.Texts))
			{
				KMessageBox.Show("[비밀번호]를 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtLoginPw.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(txtUserNameK.Texts) && string.IsNullOrEmpty(txtUserNameE.Texts))
			{
				KMessageBox.Show("[사용자명]을 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtUserNameK.Focus();
				return false;
			}

			return true;
		}

		private void SaveData()
		{	
			UserMngDto tmp = DataHandles.ControlsToDto(this, dto);

			UserMngDto param = new UserMngDto()
			{
				UserId = tmp.UserId,
				//CompanyCode = tmp.CompanyCode,
				CompanyCode = "1000",
				UserNameK = tmp.UserNameK,
				UserNameE = tmp.UserNameE,
				Nationality = tmp.Nationality,
				TelNo1 = tmp.TelNo1,
				TelNo2 = tmp.TelNo2,
				Email = tmp.Email,
				Address1 = tmp.Address1,
				Address2 = tmp.Address2,
				EnterDt = tmp.EnterDt,
				LeaveDt = tmp.LeaveDt,
				DepartmentCode = tmp.DepartmentCode,
				TeamCode = tmp.TeamCode,
				PositionCode = tmp.PositionCode,
				JobCode = tmp.JobCode,
				TaskCharge = tmp.TaskCharge,
				LoginId = tmp.LoginId,
				LoginPw = tmp.LoginPw,
				LoginErrorCnt = tmp.LoginErrorCnt,
				UseYn = tmp.UseYn,
				CreateId = tmp.CreateId,
				UpdateId = tmp.UpdateId,
			};

			//유효성 검사
			var context = new ValidationContext(param, serviceProvider: null, items: null);
			Validator.ValidateObject(param, context, validateAllProperties: true);

			string result = ctrl.AddUserInfo(param);

			if (!string.IsNullOrEmpty(result))
			{
				txtUserId.Texts = result;

				SearchData();

				InitDto();

				MainMessage.Show("저장되었습니다.");
			}
		}

		private void DeleteData()
		{
			try
			{
				UserMngDto param = new UserMngDto()
				{
					UserId = txtUserId.Texts,
				};
				int result = ctrl.RemoveUserInfo(param);

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

		#endregion Custom Methods

	}
}
