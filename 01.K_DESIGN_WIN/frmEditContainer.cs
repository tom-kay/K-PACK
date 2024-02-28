﻿using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using System;
using System.Windows.Forms;

namespace P01_K_DESIGN_WIN
{
	public partial class frmEditContainer : Form
	{
		#region Member Variable
		protected bool isFormChagned = false;
		protected object currentData;   //원본 데이터

		//private const string FORM_FONT_NAME = "Microsoft New Tai Lue";
		//private const float FORM_FONT_SIZE = 12f;

		//private static string DISABLE_COLOR_HEX = "#F0F0F0";
		//Color TEXTBOX_DISABLE_COLOR = ColorTranslator.FromHtml(DISABLE_COLOR_HEX);
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
			FormSettings.Control_SetDesign(this);
			FormSettings.Control_SetEvents(this);    //이벤트 할당

			InitControlTag();
		}

		private void InitControlTag()
		{
			SetRadioButtonTag(this);
		}

		private void SetRadioButtonTag(Control control) 
		{
			foreach (Control c in control.Controls)
			{
				if (c.Tag != null)
				{
					if (c is KRadioButton)
					{
						string[] tags = c.Tag.ToString().Split('|');
						c.Tag = new Tuple<string, string>(tags[0], tags[1]);
						(c as KRadioButton).Checked = false;
					} 
					else if (c is RadioButton)
                    {
						string[] tags = c.Tag.ToString().Split('|');
						c.Tag = new Tuple<string, string>(tags[0], tags[1]);
						(c as RadioButton).Checked = false;
					}
                }
                SetRadioButtonTag(c);
			}
		}

		private void frmEditContainer_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (isFormChagned || !EqualsObject(this, currentData))
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
			FormSettings.Control_Init(this);

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			foreach (Form frm in System.Windows.Forms.Application.OpenForms)
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
		

		private bool EqualsObject(Control control, object dto)
		{
			foreach (Control c in control.Controls)
			{
				if (c is KRadioButton || c is RadioButton)
				{
					if (c.Tag != null)
					{
						if (c is KRadioButton)
						{
							var tuple = c.Tag as Tuple<string, string>;
							if (tuple != null && dto.GetType().GetProperty(tuple.Item1) != null)
							{
								if ((c as KRadioButton).Checked && !Equals(dto.GetType().GetProperty(tuple.Item1).GetValue(dto, null), tuple.Item2))
								{
									return false;
								}
							}
						}
						else if (c is RadioButton)
						{
							var tuple = c.Tag as Tuple<string, string>;
							if (tuple != null && dto.GetType().GetProperty(tuple.Item1) != null)
							{
								if ((c as RadioButton).Checked && !Equals(dto.GetType().GetProperty(tuple.Item1).GetValue(dto, null), tuple.Item2))
								{
									return false;
								}
							}
						} 
					}
				}
				else
				{
					if (c.Tag != null && dto.GetType().GetProperty(c.Tag.ToString()) != null)
					{
						if (c is KTextBox)
						{
							if (!Equals((c as KTextBox).Texts, Convert.ToString( dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null))))
							{
								return false;
							}
						}
						else if (c is TextBox)
						{
							if (!Equals(c.Text, Convert.ToString(dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null))))
							{
								return false;
							}
						}
						else if (c is KComboBox)
						{
							if (!Equals((c as KComboBox).SelectedItem, dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null)))
							{
								return false;
							}
						}
						else if (c is ComboBox)
						{
							if (!Equals((c as ComboBox).SelectedItem, dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null)))
							{
								return false;
							}
						}
						else if (c is CheckBox)
						{
							if (!Equals((c as CheckBox).Checked, (bool)dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null)))
							{
								return false;
							}
						}
						
					}
				}

				
				if (!EqualsObject(c, dto))
				{
					return false;
				}

			}

			return true;

		}
		#endregion


	}
}
