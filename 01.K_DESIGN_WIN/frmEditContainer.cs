﻿using MetroFramework.Controls;
using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_K_DESIGN_WIN
{
	public partial class frmEditContainer : Form
	{
		#region Member Variable
		protected bool isFormChagned = true;
        protected object originalData { get; set; } //원본 데이터
		protected object currentData { get; set; }		//수정 데이터
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

		private void frmEditContainer_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isFormChagned || !EqualsObject())
			{
				var result = KMessageBox.Show("저장되지 않은 데이터가 있습니다. 닫으시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.No)
				{
					e.Cancel = true;
				}
			}
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


		protected void BindControls<T>(Control control, object data, T classObject) where T : class
		{
			foreach (Control childControl in control.Controls)
			{
				if (childControl.Tag != null)
				{
					string propertyName = childControl.Tag.ToString();
					if (childControl is KTextBox)
					{
						childControl.DataBindings.Add("Texts", data, propertyName);
					}
					else if (childControl is TextBox || childControl is ComboBox)
					{
						childControl.DataBindings.Add("Text", data, propertyName);
					}
					else if (childControl is CheckBox)
					{
						childControl.DataBindings.Add("Checked", data, propertyName);
					}
					else if (childControl is KRadioButton)
					{
						((KRadioButton)childControl).CheckedChanged += (s, e) =>
						{
							if (((KRadioButton)s).Checked)
							{
								var tagName = (Tuple<string, string>)((KRadioButton)s).Tag;
								typeof(T).GetProperty(tagName.Item1).SetValue(data, tagName.Item2);
							}
						};
						var tag = (Tuple<string, string>)((KRadioButton)childControl).Tag;
						((KRadioButton)childControl).Checked = tag.Item2.Equals(typeof(T).GetProperty(tag.Item1).GetValue(data));
					}
					else if (childControl is RadioButton)
					{
						((RadioButton)childControl).CheckedChanged += (s, e) =>
						{
							if (((RadioButton)s).Checked)
							{
								var tagName = (Tuple<string, string>)((RadioButton)s).Tag;
								typeof(T).GetProperty(tagName.Item1).SetValue(data, tagName.Item2);
							}
						};
						var tag = (Tuple<string, string>)((RadioButton)childControl).Tag;
						((RadioButton)childControl).Checked = tag.Item2.Equals(typeof(T).GetProperty(tag.Item1).GetValue(data));
					}
				}

				// Recursively bind child controls
				BindControls(childControl, data, classObject);
			}
		}

		private bool EqualsObject()
		{	
			bool isEquals = true;

			Type type1 = originalData.GetType();

			// Get all fields of the type
			FieldInfo[] type1Fields = type1.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

			// Print each field and its value
			foreach (FieldInfo field in type1Fields)
			{
				object value1 = field.GetValue(originalData);
				object value2 = field.GetValue(currentData);

				if (value1 != value2)
				{
                    if (value1 != null && value2 != null)
                    {
						if (value1.ToString() != value2.ToString())
							isEquals = false;
					}
					else
					{
						isEquals = false;
					}
                    
					break;
				}
			}

			return isEquals;
		}
		#endregion


	}
}
