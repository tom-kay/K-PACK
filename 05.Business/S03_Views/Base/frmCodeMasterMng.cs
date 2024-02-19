using P01_K_DESIGN_WIN.Classes;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmCodeMasterMng : P01_K_DESIGN_WIN.frmEditContainer
	{
		public frmCodeMasterMng()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isClose = false, isPrint = false });
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			bool isVal = ValidationData();

			if (isVal)
			{
				SaveData(); 
			}

		}

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
			CodeMasterDto item = new CodeMasterDto()
			{
				Code = txtCode.Texts,
				Name = txtName.Texts,
				UseYn = rdoY.Checked ? "Y" : "N"
			};
			
			CodeMngController ctrl = new CodeMngController();

			CodeMasterDto result = ctrl.AddCodeMaster(item);

		}
	}
}
