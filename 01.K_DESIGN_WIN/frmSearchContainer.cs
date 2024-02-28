using MetroFramework.Controls;
using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_K_DESIGN_WIN
{
	public partial class frmSearchContainer : Form
	{
		
		public frmSearchContainer()
		{
			InitializeComponent();
		}

		private void frmSearchContainer_Load(object sender, EventArgs e)
		{
			FormSettings.Control_SetDesign(this);
			FormSettings.Control_SetEvents(this);    //이벤트 할당
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			FormSettings.Control_Init(this);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			foreach (Form frm in Application.OpenForms)
			{
				if (frm.GetType().BaseType.Name.Equals("frmMdiContainer"))
				{
					((frmMdiContainer)frm).CloseChildForm();
					return;
				}
			}
		}


		/// <summary>
		/// 메뉴에 대한 버튼 권한을 설정한다.
		/// </summary>
		protected void Set_Menu_Button(EditButtonSettings settings)
		{
			this.pnlClose.Visible = settings.isClose;
			this.pnlPrint.Visible = settings.isPrint;
			this.pnlSearch.Visible = settings.isSearch;
			this.pnlInit.Visible = settings.isInit;
		}

		#region Custom Events

		#endregion


	}
}
