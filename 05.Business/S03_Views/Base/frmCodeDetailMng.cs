using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using P05_Business.S03_Views.Popup.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmCodeDetailMng : P01_K_DESIGN_WIN.frmEditContainer
	{
		#region Member Variables
		CodeDetailDto dto = new CodeDetailDto();
		CodeMngController ctrl = new CodeMngController();
		#endregion

		#region Constructor
		public frmCodeDetailMng()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });

			SetControlTag();

			SetModelBinding(dto);
		}
		#endregion

		#region Control Events
		
		private void frmCodeDetailMng_Load(object sender, EventArgs e)
		{
			BindControls(this, currentData, dto);
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

		/// <summary>
		/// 데이터 조회 버튼 클릭 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				//코드 입력 확인
				if (string.IsNullOrEmpty(txtMasterCode.Texts))
				{
					KMessageBox.Show("MASTER CODE를 입력 바랍니다.", "조회", MessageBoxButtons.OK);
					txtCode.Focus();
					return;
				}

				//코드 입력 확인
				if (string.IsNullOrEmpty(txtCode.Texts))
				{
					KMessageBox.Show("CODE를 입력 바랍니다.", "조회", MessageBoxButtons.OK);
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

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				bool isVal = ValidationData();

				if (isVal)
				{
					if (KMessageBox.Show("저장하시겠습니까?", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(txtMasterCode.Texts))
				{
					KMessageBox.Show("[MASTER CODE]를 입력 바랍니다.", "삭제", MessageBoxButtons.OK);
					return;
				}

				if (string.IsNullOrEmpty(txtCode.Texts))
				{
					KMessageBox.Show("CODE를 입력 바랍니다.", "삭제", MessageBoxButtons.OK);
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

		private void btnFindMasterCode_Click(object sender, EventArgs e)
		{
			try
			{
				string masterCode  = txtMasterCode.Texts;
				frmMasterCodePopup popup = new frmMasterCodePopup("FIND MASTER CODE");

                if (popup.DialogResult == DialogResult.OK)
                {
					txtMasterCode.Texts = popup.ResultCode;
					txtMasterName.Texts = popup.ResultName;
                }
            }
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion

		#region Custom Methods

		private void SetControlTag()
		{
			rdoY.Tag = new Tuple<string, string>("UseYn", "Y");
			rdoN.Tag = new Tuple<string, string>("UseYn", "N");
		}

		private void SetModelBinding(CodeDetailDto item)
		{
			base.originalData = item.Clone();   //원본
			base.currentData = item;            //수정본

			base.isFormChagned = false;
		}

		private void SetInit()
		{
			rdoY.Checked = true;

			SetModelBinding(base.currentData as CodeDetailDto);
		}

		/// <summary>
		/// 데이터 조회
		/// </summary>
		private void SearchData()
		{
			try
			{
				CodeDetailDto param = new CodeDetailDto()
				{
					Code = txtCode.Texts
				};

				CodeDetailDto item = ctrl.GetCodeDetail(param);

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

		private bool ValidationData()
		{
			if (string.IsNullOrEmpty(txtMasterCode.Texts))
			{
				KMessageBox.Show("[MASTER CODE]를 선택 바랍니다.", "저장", MessageBoxButtons.OK);
				txtCode.Focus();
				return false;
			}

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
			CodeDetailDto saveData = base.currentData as CodeDetailDto;

			CodeDetailDto param = new CodeDetailDto()
			{
				MasterCode = saveData.MasterCode,
				Code = saveData.Code,
				Name = saveData.Name,
				Remark = saveData.Remark,
				UseYn = saveData.UseYn,
				Option1 = saveData.Option1,
				Option2 = saveData.Option2,
				Option3 = saveData.Option3,
				Option4 = saveData.Option4,
				Option5 = saveData.Option5,
				Option6 = saveData.Option6,
				Option7 = saveData.Option7,
				Option8 = saveData.Option8,
				Option9 = saveData.Option9,
				Option10 = saveData.Option10,
				CreateId = "SYSTEM",
				UpdateId = "SYSTEM"
			};

			CodeDetailDto result = ctrl.AddCodeDetail(param);

			if (result != null)
			{
				SetModelBinding(base.currentData as CodeDetailDto);

				MainMessage.Show("저장되었습니다.");
			}
		}

		private void DeleteData()
		{
			try
			{
				CodeDetailDto param = new CodeDetailDto()
				{
					MasterCode = txtMasterCode.Texts,
					Code = txtCode.Texts
				};
				int iDelete = ctrl.RemoveCodeDetail(param);

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

		#endregion

		
	}
}
