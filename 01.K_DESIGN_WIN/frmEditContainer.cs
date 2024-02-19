﻿using P01_K_DESIGN_WIN.Classes;
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
	public partial class frmEditContainer : Form
	{
		#region Member Variable

		#endregion

		#region Constructor
		public frmEditContainer()
		{
			InitializeComponent();
		} 
		#endregion

		#region Form Events
		private void frmEditContainer_Load(object sender, EventArgs e)
		{
			Control_SetEvents(this);    //이벤트 할당
		}
		#endregion

		#region Custom Methods
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

		/// <summary>
		/// 메뉴에 대한 버튼 권한을 설정한다.
		/// </summary>
		protected void Set_Menu_Button(EditButtonSettings settings)
		{	
			this.pnlClose.Visible = settings.isClose;
			this.pnlPrint.Visible = settings.isPrint;
			this.pnlSearch.Visible = settings.isSearch;
			this.pnlInit.Visible = settings.isInit;
			this.pnlDelete.Visible = settings.isDelete;
			this.pnlSave.Visible = settings.isSave;
		}
		#endregion


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