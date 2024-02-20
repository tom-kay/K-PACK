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
			Control_SetEvents(this);    //이벤트 할당
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			Control_Init(this);
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
		/// 폼컨트롤 이벤트 할당
		/// </summary>
		/// <param name="control"></param>
		private void Control_SetEvents(Control control)
		{
			foreach (Control ctrl in control.Controls)
			{
				if (ctrl is TextBox)
				{
					((TextBox)ctrl).Enter += TextBox_Enter;
					((TextBox)ctrl).Leave += TextBox_Leave;
				}
				else if (ctrl is KTextBox)
				{
					((KTextBox)ctrl).Enter += TextBox_Enter;
					((KTextBox)ctrl).Leave += TextBox_Leave;
				}

				if (ctrl.Controls.Count > 0)
				{
					Control_SetEvents(ctrl);
				}
			}
		}

		private void Control_Init(Control control)
		{
			foreach (Control ctrl in control.Controls)
			{
				if (ctrl is TextBox)
				{
					((TextBox)ctrl).Text = string.Empty;
				}
				else if (ctrl is KTextBox)
				{
					((KTextBox)ctrl).Texts = string.Empty;
				}
				else if (ctrl is CheckBox)
				{
					((CheckBox)ctrl).Checked = false;
				}
				else if (ctrl is MetroCheckBox)
				{
					((MetroCheckBox)ctrl).Checked = false;
				}

				if (ctrl.Controls.Count > 0)
				{
					Control_Init(ctrl);
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

		/// <summary>
		/// 텍스트 박스가 활성화 되었을 때
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void TextBox_Enter(object sender, EventArgs e)
		{
			if (sender is TextBox)
			{
				((TextBox)sender).BackColor = Color.Beige;
				if (((TextBox)sender).Parent is Panel)
				{
					((Panel)((TextBox)sender).Parent).BackColor = Color.Beige;
				}
			}
			else if (sender is KTextBox)
			{
				((KTextBox)sender).BackColor = Color.Beige;
				if (((KTextBox)sender).Parent is Panel)
				{
					((Panel)((KTextBox)sender).Parent).BackColor = Color.Beige;
				}
			}
		}

		/// <summary>
		/// 텍스트 박스가 비활성화 되었을 때
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <exception cref="NotImplementedException"></exception>
		protected void TextBox_Leave(object sender, EventArgs e)
		{
			if (sender is TextBox)
			{
				((TextBox)sender).BackColor = SystemColors.Window;
				if (((TextBox)sender).Parent is Panel)
				{
					((Panel)((TextBox)sender).Parent).BackColor = SystemColors.Window;
				}
			}
			else if (sender is KTextBox)
			{
				((KTextBox)sender).BackColor = SystemColors.Window;
				if (((KTextBox)sender).Parent is Panel)
				{
					((Panel)((KTextBox)sender).Parent).BackColor = SystemColors.Window;
				}
			}

		}


		#endregion

		
	}
}
