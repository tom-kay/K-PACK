using FarPoint.Win.Spread;
using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace P01_K_DESIGN_WIN
{
	public partial class frmEditContainer : Form
	{
		#region Member Variable
		protected bool isFormChagned = false;
		protected object currentData;   //원본 데이터
		protected bool IS_LINK_OPEN = false;


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
			InitControlTag();

			FormSettings.Control_SetDesign(this);
			FormSettings.Control_SetEvents(this);    //이벤트 할당
			FormSettings.SetTabIndexes(this);   // 탭인덱스 할당
			//FormSettings.SetTabIndexesAndHandleEnterKey(this); // EnterKey 입력 시 다음 탭으로 이동 설정
			

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

			this.currentData = null;

			isFormChagned = false;

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
			if (control == null || dto == null) return true;

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
                                    Debug.Print(string.Concat(c.Name, " : 변경됨"));
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
                                    Debug.Print(string.Concat(c.Name, " : 변경됨"));
                                    return false;
								}
							}
						} 
					}
				}
				else
				{
					if (!string.IsNullOrEmpty(Convert.ToString(c.Tag)) && dto.GetType().GetProperty(c.Tag.ToString()) != null)
					{
						if (c is KTextBox)
						{
							if (!Equals((c as KTextBox).Texts, Convert.ToString( dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null))))
							{
								Debug.Print(string.Concat(c.Name, " : 변경됨"));
								return false;
							}
						}
						else if (c is TextBox)
						{
							if (!Equals(c.Text, Convert.ToString(dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null))))
							{
								if (c.GetType() == typeof(KNumberBox)) {
									decimal values;
									decimal.TryParse(c.Text, out values);
									if (values != 0)
									{
                                        Debug.Print(string.Concat(c.Name, " : 변경됨"));
                                        return false;
                                    }
								}
								else
								{
                                    Debug.Print(string.Concat(c.Name, " : 변경됨"));
                                    return false;
                                }
							}
						}
						else if (c is KComboBox)
						{
							if (!Equals((c as KComboBox).SelectedValue, Convert.ToString(dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null))))
							{
                                Debug.Print(string.Concat(c.Name, " : 변경됨"));
                                return false;
							}
						}
						else if (c is ComboBox)
						{
							if (!Equals((c as ComboBox).SelectedValue, Convert.ToString(dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null))))
							{
                                Debug.Print(string.Concat(c.Name, " : 변경됨"));
                                return false;
							}
						}
						else if (c is KToggleButton)
						{
							if (!Equals((c as KToggleButton).Checked, Convert.ToBoolean(dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null))))
							{
                                Debug.Print(string.Concat(c.Name, " : 변경됨"));
                                return false;
							}
						}
						else if (c is CheckBox)
						{
							if (!Equals((c as CheckBox).Checked, Convert.ToBoolean(dto.GetType().GetProperty(c.Tag.ToString()).GetValue(dto, null))))
							{
                                Debug.Print(string.Concat(c.Name, " : 변경됨"));
                                return false;
							}
						}
						else if (c is DataGridView)
						{
							DataTable dt = (c as DataGridView).DataSource as DataTable;

                            DataTable dtChanges = dt.GetChanges();

                            if (dtChanges != null && dtChanges.Rows.Count > 0)
                            {
                                Debug.Print(string.Concat(c.Name, " : 변경됨"));
                                return false;
                            }
                        }
                        else if (c is FpSpread)
                        {   
                            DataTable dt = (c as FpSpread).Sheets[0].DataSource as DataTable;

                            DataTable dtChanges = dt.GetChanges();

                            if (dtChanges != null && dtChanges.Rows.Count > 0)
                            {
                                Debug.Print(string.Concat(c.Name, " : 변경됨"));
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
