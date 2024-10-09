using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace P05_Business
{
    public partial class frmLogin : frmLoginFrame
    {
        public frmLogin()
        {
            InitializeComponent();

			//파일 경로가 없으면 경로 생성
			FileHelper.CreateDirectoryIfNotExists(GlobalVariables.GetLogoFileImage);

            //회사로고 표시
            picLogo.Image = Image.FromFile(GlobalVariables.GetLogoFileImage);

		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			ComboHelper.InitComboBoxCompany(cboCompany, "N", false, false);

			txtUser.Text = "superadmin";
			txtPass.Text = "admin";
		}

		private void btnlogin_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtUser.Text) || "사용자 계정(User ID)".Equals(txtUser.Text))
				{
					KMessageBox.Show("User ID를 입력 바랍니다.", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					return;
				}

				if (string.IsNullOrEmpty(txtPass.Text) || "비밀번호(Password)".Equals(txtPass.Text))
				{
					KMessageBox.Show("Password를 입력 바랍니다.", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				SignIn();
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void SignIn()
		{
			UserMngDto param = new UserMngDto()
			{
				CompanyCode = cboCompany.SelectedValue.ToString(),
				LoginId = txtUser.Text,
				LoginPw = txtPass.Text,
			};

			UserMngDto userDto = new UserMngController().signInUser(param);

			//접속 정보 확인
			if (userDto != null)
			{//일치
			 //전역 변수에 담기
				LoginUserInfo.UserId = userDto.UserId;
				LoginUserInfo.UserNameK = userDto.UserNameK;
				LoginUserInfo.UserNameE = userDto.UserNameE;
				LoginUserInfo.TelNo1 = userDto.TelNo1;
				LoginUserInfo.TelNo2 = userDto.TelNo2;
				LoginUserInfo.Email = userDto.Email;
				LoginUserInfo.DepartmentCode = userDto.DepartmentCode;
				LoginUserInfo.DepartmentName = userDto.DepartmentName;
				LoginUserInfo.TeamCode = userDto.TeamCode;
				LoginUserInfo.PositionCode = userDto.PositionCode;
				LoginUserInfo.JobCode = userDto.JobCode;
				LoginUserInfo.TaskCharge = userDto.TaskCharge;
				LoginUserInfo.LoginId = userDto.LoginId;

				//회사 정보 가져와서 전역변수에 담기
				CompanyInfoDto paramCom = new CompanyInfoDto()
				{
					CompanyCode = param.CompanyCode
				};
				CompanyInfoDto comDto = new CompanyMngController().GetCompanyInfo(paramCom);

				if (comDto != null)
				{
					LoginCompany.CompanyCode = comDto.CompanyCode;
					LoginCompany.NationalityCode = comDto.Nationality;
					LoginCompany.NationalityName = comDto.NationalityName;
					LoginCompany.CompanyGroup = comDto.CompanyGroup;
					LoginCompany.CompanyNameK = comDto.CompanyNameK;
					LoginCompany.CompanyNameE = comDto.CompanyNameE;
					LoginCompany.TelNo = comDto.TelNo;
					LoginCompany.FaxNo = comDto.FaxNo;
					LoginCompany.AddressK1 = comDto.AddressK1;
					LoginCompany.AddressK2 = comDto.AddressK2;
					LoginCompany.AddressE1 = comDto.AddressE1;
					LoginCompany.AddressE2 = comDto.AddressE2;

				}

				this.Close();
			}
			else
			{//불일치
				KMessageBox.Show("사용자 정보를 확인바랍니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
