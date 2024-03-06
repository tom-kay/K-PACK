using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmUserMng : P01_K_DESIGN_WIN.frmEditContainer
	{
		#region Member Variables

		UserMngController ctrl = new UserMngController();
		UserMngDto dto = new UserMngDto();

		MonthCalendar calendar = new MonthCalendar();

		#endregion Member Variables

		#region Constructor

		public frmUserMng()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });

			InitDto();

			this.Controls.Add(calendar);
		}
		
		#endregion Constructor

		#region Control Events
		private void frmUserMng_Load(object sender, EventArgs e)
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
				if (string.IsNullOrEmpty(txtUserId.Texts))
				{
					KMessageBox.Show("[로그인 ID]를 입력 바랍니다.", "조회", MessageBoxButtons.OK);
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

		private void btnCalendar_Click(object sender, EventArgs e)
		{
			// sender를 Button으로 캐스팅
			KButton button = sender as KButton;

			// 버튼의 위치를 화면 좌표로 변환
			Point screenLocation = button.PointToScreen(Point.Empty);

			// 화면 좌표를 폼의 클라이언트 좌표로 변환
			Point buttonLocation = this.PointToClient(screenLocation);

			int X, Y;
			// 버튼이 폼의 오른쪽에 가까운지 확인
			if (buttonLocation.X + button.Width + calendar.Width > this.Width)
			{
				// 버튼이 폼의 오른쪽에 가까우면 MonthCalendar를 버튼의 왼쪽에 표시
				//calendar.Location = new Point(buttonLocation.X - calendar.Width, buttonLocation.Y);
				X = buttonLocation.X + button.Width - calendar.Width;
			}
			else
			{
				// 그렇지 않으면 MonthCalendar를 버튼의 오른쪽에 표시
				//calendar.Location = new Point(buttonLocation.X + button.Width, buttonLocation.Y);
				X = buttonLocation.X;
			}

			// 버튼이 폼의 하단에 가까운지 확인
			if (buttonLocation.Y + button.Height + calendar.Height > this.Height)
			{
				// 버튼이 폼의 하단에 가까우면 MonthCalendar를 버튼의 위에 표시
				//calendar.Location = new Point(buttonLocation.X, buttonLocation.Y - calendar.Height);
				Y = buttonLocation.Y - calendar.Height;
			}
			else
			{
				// 그렇지 않으면 MonthCalendar를 버튼의 아래에 표시
				//calendar.Location = new Point(buttonLocation.X, buttonLocation.Y + button.Height);
				Y = buttonLocation.Y + button.Height;
			}

			calendar.Location = new Point(X, Y);

			calendar.Show();

			calendar.BringToFront();
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

			ComboHelper.InitComboBox(cboDepartment, "NATIONALITY", false, true);	//부서목록
			ComboHelper.InitComboBox(cboTeam, "NATIONALITY", false, true);			//팀목록
			ComboHelper.InitComboBox(cboPosition, "NATIONALITY", false, true);		//직위목록
			ComboHelper.InitComboBox(cboJob, "NATIONALITY", false, true);			//직책목록

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

			int result = ctrl.AddUserInfo(param);

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
