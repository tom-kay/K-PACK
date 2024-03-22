using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Popup.Common
{
	public partial class frmUserSetting : frmPopupFrame
	{
		public frmUserSetting()
		{
			InitializeComponent();
		}

		private void frmUserSetting_Load(object sender, EventArgs e)
		{
			txtUserId.Texts = LoginUserInfo.UserId;
			txtLoginId.Texts = LoginUserInfo.LoginId;
			txtCompanyName.Texts = LoginCompany.CompanyNameK;
			txtUserNameK.Texts = LoginUserInfo.UserNameK;

			SearchData();
		}

		private void SearchData()
		{
			try
			{
				UserMngDto param = new UserMngDto()
				{
					UserId = LoginUserInfo.UserId,
				};

				UserMngDto dto = new UserMngController().GetUserInfo(param);

				if (dto != null)
				{
					DataHandles.DtoToControls(this, dto);

					MainMessage.Show("조회되었습니다.");
				}

			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				
			}
		}

		/// <summary>
		/// 데이터 저장 버튼으로 사용
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				if (KMessageBox.Show("저장하시겠습니까?", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return; 

				UserMngDto userMng = new UserMngDto();
				UserMngDto tmp = DataHandles.ControlsToDto(this, userMng);

				UserMngDto param = new UserMngDto()
				{
					UserId = tmp.UserId,
					UserNameE = tmp.UserNameE,
					TelNo1 = tmp.TelNo1,
					TelNo2 = tmp.TelNo2,
					Email = tmp.Email,
					Address1 = tmp.Address1,
					Address2 = tmp.Address2,
					UpdateId = LoginUserInfo.UserId
				};

				int result = new UserMngController().ModifyLoginUserInfo(param);

				if (result >= 0)
				{
					//변경된 사용자 정보를 전역변수에 재적용한다.
					LoginUserInfo.UserNameE = tmp.UserNameE;
					LoginUserInfo.TelNo1 = tmp.TelNo1;
					LoginUserInfo.TelNo2 = tmp.TelNo2;
					LoginUserInfo.Email = tmp.Email;

					MainMessage.Show("저장되었습니다.");
				}

			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtLoginPw.Texts))
				{
					KMessageBox.Show("[현재비밀번호]를 입력 바랍니다.", "비밀번호 변경", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				if (string.IsNullOrEmpty(txtLoginPwNew.Texts))
				{
					KMessageBox.Show("[새비밀번호]를 입력 바랍니다.", "비밀번호 변경", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				if (string.IsNullOrEmpty(txtLoginPwConfirm.Texts))
				{
					KMessageBox.Show("[비밀번호확인]을 입력 바랍니다.", "비밀번호 변경", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				if (!txtLoginPwNew.Texts.Trim().Equals(txtLoginPwConfirm.Texts.Trim()))
				{
					KMessageBox.Show("[비밀번호확인]과 일치하지 않습니다.", "비밀번호 변경", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				//현재 비밀번호 일치 여부확인


				if (KMessageBox.Show("비밀번호를 변경 하시겠습니까?", "비밀번호 변경", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;



			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
