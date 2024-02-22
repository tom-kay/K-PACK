using P01_K_DESIGN_WIN.Classes;
using P02_K_CONTROL_WIN;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmCodeMasterMng : P01_K_DESIGN_WIN.frmEditContainer
	{
		#region Member Variables
		CodeMasterDto dto = new CodeMasterDto();  //모델 클래스
		CodeMngController ctrl = new CodeMngController();
		#endregion

		#region Constructor
		public frmCodeMasterMng()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });

			SetControlTag();

			SetModelBinding(dto);
		}

		public frmCodeMasterMng(string code) : this()
		{
			txtCode.Texts = code;

			SearchData();
		}
		#endregion

		#region Control Events
		private void frmCodeMasterMng_Load(object sender, EventArgs e)
		{
			BindControls(this, currentData, dto);
		}

		/// <summary>
		/// 그리드 조회
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				//코드 입력 확인
				if (string.IsNullOrEmpty(txtCode.Texts))
				{
					KMessageBox.Show("CODE를 입력 바랍니다.", "저장", MessageBoxButtons.OK);
					txtCode.Focus();
					return;
				}

				SearchData();
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtCode.Texts))
				{
					KMessageBox.Show("CODE를 입력 바랍니다.", "저장", MessageBoxButtons.OK);
					txtCode.Focus();
					return;
				}

				DeleteData();   //삭제
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
					if (KMessageBox.Show("저장하시겠습니까?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
		#endregion

		#region Custom Methods
		private void SetInit()
		{
			rdoY.Checked = true;
		}
		
		private bool ValidationData()
		{
			if (string.IsNullOrEmpty(txtCode.Texts))
			{
				KMessageBox.Show("[CODE]를 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCode.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(txtName.Texts))
			{
				KMessageBox.Show("[NAME]을 입력 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCode.Focus();
				return false;
			}

			if (!rdoY.Checked && !rdoN.Checked)
			{
				KMessageBox.Show("[사용유무]를 선택 바랍니다.", "저장", MessageBoxButtons.OK);
				rdoY.Focus();
				return false;
			}

			return true;
		}

		private void SaveData()
		{
			CodeMasterDto result = ctrl.AddCodeMaster(base.currentData as CodeMasterDto);

			if (result != null)
			{
				SetModelBinding(base.currentData as CodeMasterDto);

				MainMessage.Show("저장되었습니다.");
			}
		}

		private void SearchData()
		{
			try
			{
				CodeMasterDto param = new CodeMasterDto()
				{
					Code = txtCode.Texts
				};

				CodeMasterDto item = ctrl.GetCodeMaster(param);

				if (item != null)
				{
					SetModelBinding(item);

					MainMessage.Show("조회되었습니다.");
				}
				else
				{
					KMessageBox.Show("자료가 없습니다.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					btnInit.PerformClick();
				}
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// 데이터 삭제
		/// </summary>
		private void DeleteData()
		{
			try
			{
				CodeMasterDto param = new CodeMasterDto()
				{
					Code = txtCode.Texts
				};
				int iDelete = ctrl.RemoveCodeMaster(param);

				if (iDelete > -1)
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

		private void SetControlTag()
		{
			rdoY.Tag = new Tuple<string, string>("UseYn", "Y");
			rdoN.Tag = new Tuple<string, string>("UseYn", "N");
		}

		private void SetModelBinding(CodeMasterDto item)
		{
			base.isFormChagned = true;

			base.originalData = item.Clone();   //원본
			base.currentData = item;			//수정본
		}
		#endregion

		#region 사용하지 않음 (주석)
		/*
		private void BindControls(Control control, object data)
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
								typeof(CodeMasterDto).GetProperty(tagName.Item1).SetValue(data, tagName.Item2);
							}
						};
						var tag = (Tuple<string, string>)((KRadioButton)childControl).Tag;
						((KRadioButton)childControl).Checked = tag.Item2.Equals(typeof(CodeMasterDto).GetProperty(tag.Item1).GetValue(data));
					}
					else if (childControl is RadioButton)
					{
						((RadioButton)childControl).CheckedChanged += (s, e) =>
						{
							if (((RadioButton)s).Checked)
							{
								var tagName = (Tuple<string, string>)((RadioButton)s).Tag;
								typeof(CodeMasterDto).GetProperty(tagName.Item1).SetValue(data, tagName.Item2);
							}
						};
						var tag = (Tuple<string, string>)((RadioButton)childControl).Tag;
						((RadioButton)childControl).Checked = tag.Item2.Equals(typeof(CodeMasterDto).GetProperty(tag.Item1).GetValue(data));
					}
				}

				// Recursively bind child controls
				BindControls(childControl, data);
			}
		}
		*/
		#endregion
	}
}
