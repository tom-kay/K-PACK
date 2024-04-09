using log4net;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmCustomerMng : frmEditContainer
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		CustomerDto dto = new CustomerDto();
		List<CustomerEmpDto> dtoEmps = new List<CustomerEmpDto>();
		CustomerMngController ctrl = new CustomerMngController();

		public frmCustomerMng()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });

			//그리드 생성
			CreateGrid();

			SetInit();
		}

        public frmCustomerMng(string code) : this()
        {
			txtCustCode.Texts = code;

			IS_LINK_OPEN = true;
		}

		private void frmCustomerMng_Load(object sender, EventArgs e)
		{
			InitCombo();

			if (IS_LINK_OPEN) SearchData();
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

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				//코드 입력 확인
				if (string.IsNullOrEmpty(txtCustCode.Texts))
				{
					KMessageBox.Show("[거래처코드]를 입력 바랍니다.", "조회", MessageBoxButtons.OK);
					txtCustCode.Focus();
					return;
				}

				var result = SearchData();
				if (result == ResultCRUD.SearchSuccessData)
				{
					MainMessage.Show("조회되었습니다.");
				}
				else if (result == ResultCRUD.SearchSuccessNoData)
				{
					MainMessage.Show("자료가 없습니다.");
				}
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
				if (KMessageBox.Show("저장하시겠습니까?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					var result = SaveData();
					if (result == ResultCRUD.SaveSuccessData)
					{
						MainMessage.Show("저장되었습니다.");
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
				if (string.IsNullOrEmpty(txtCustCode.Texts))
				{
					KMessageBox.Show("CODE를 입력 바랍니다.", "삭제", MessageBoxButtons.OK);
					txtCustCode.Focus();
					return;
				}

				DeleteData();   //삭제
			}
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SetInit()
		{
			txtCustCode.Enabled = true;

			dto = new CustomerDto();
			dtoEmps = new List<CustomerEmpDto>();

			//그리드 초기화
			dgvList.DataSource = DataHandles.ConvertToDataTable<CustomerEmpDto>(dtoEmps);

			InitDto();
		}

		/// <summary>
		/// 데이터 조회
		/// </summary>
		private ResultCRUD SearchData()
		{
			CustomerDto param = new CustomerDto()
			{
				CustCode = txtCustCode.Texts,
				CompanyCode = LoginCompany.CompanyCode,
			};

			dto = ctrl.GetCustomer(param);

			ResultCRUD result;
			if (dto != null)
			{
				DataHandles.DtoToControls(this, dto);   //데이터 바인딩
				dtoEmps = dto.Employees;    //직원정보

				//직원정보 그리드에 바인딩
				dgvList.DataSource = DataHandles.ConvertToDataTable<CustomerEmpDto>(dtoEmps);
				(dgvList.DataSource as DataTable).AcceptChanges();

				InitDto();

				txtCustCode.Enabled = false;

				//MainMessage.Show("조회되었습니다.");
				result = ResultCRUD.SearchSuccessData;
			}
			else
			{
				result = ResultCRUD.SearchSuccessNoData;
				//KMessageBox.Show("자료가 없습니다.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				btnInit.PerformClick();
			}

			return result;
		}


		private ResultCRUD SaveData()
		{
			//그리드 변경 데이터 수집
			DataTable dtChanges = UserDataGrid.GetChangeAll(dgvList);

			List<CustomerEmpDto> saveEmps = null;
			if (dtChanges != null)
			{
				saveEmps = DataHandles.ConvertToList<CustomerEmpDto>(dtChanges);
			}

			CustomerDto saveData = DataHandles.ControlsToDto(this, dto);

			CustomerDto param = new CustomerDto()
			{
				CustCode = saveData.CustCode,
				CustName = saveData.CustName,
				CompanyNo = saveData.CompanyNo,
				NationCode = saveData.NationCode,
				OwnerName = saveData.OwnerName,
				TelNo = saveData.TelNo,
				FaxNo = saveData.FaxNo,
				Email = saveData.Email,
				Address1 = saveData.Address1,
				Address2 = saveData.Address2,
				DealTypeSale = saveData.DealTypeSale,
				DealTypeBuy = saveData.DealTypeBuy,
				DealTypeProc = saveData.DealTypeProc,
				DealTypeGeneral = saveData.DealTypeGeneral,
				Remark = saveData.Remark,
				BankName = saveData.BankName,
				Depositor = saveData.Depositor,
				AccountNo = saveData.AccountNo,
				CompanyCode = LoginCompany.CompanyCode,
				CreateId = LoginUserInfo.UserId,
				UpdateId = LoginUserInfo.UserId,
				Employees = saveEmps,    //직원정보
			};

			//유효성 검사
			var context = new ValidationContext(param, serviceProvider: null, items: null);
			Validator.ValidateObject(param, context, validateAllProperties: true);

			bool isSave = ctrl.AddCustomer(param);

			ResultCRUD result = ResultCRUD.None;
			if (isSave)
			{
				txtCustCode.Enabled = false;

				SearchData();

				//(dgvList.DataSource as DataTable).AcceptChanges();

				//InitDto();

				result = ResultCRUD.SaveSuccessData;
			}

			return result;
		}

		/// <summary>
		/// 데이터 삭제
		/// </summary>
		private void DeleteData()
		{
			try
			{
				CustomerDto param = new CustomerDto()
				{
					CustCode = txtCustCode.Texts
				};
				int iDelete = ctrl.RemoveCustomer(param);

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


		/// <summary>
		/// 콤보박스 초기설정
		/// </summary>
		private void InitCombo()
		{
			ComboHelper.InitComboBox(cboNationality, "NATIONALITY", false, true);
		}

		private void CreateGrid()
		{
			UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill, DataGridViewCellBorderStyle.RaisedHorizontal);
			UserDataGrid.AddTextBoxColumn(dgvList, "CustCode", "거래처코드", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "EmpIdx", "직원코드", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
			UserDataGrid.AddTextBoxColumn(dgvList, "EmpName", "직원명", false, true, 10, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 50);
			UserDataGrid.AddTextBoxColumn(dgvList, "PositionName", "직위명", false, true, 10, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 30);
			UserDataGrid.AddTextBoxColumn(dgvList, "TelNo", "전화번호", false, true, 10, DataGridViewContentAlignment.MiddleCenter, maxInputLength: 30);
			UserDataGrid.AddTextBoxColumn(dgvList, "MobileNo", "모바일", false, true, 10, DataGridViewContentAlignment.MiddleCenter, maxInputLength: 30);
			UserDataGrid.AddTextBoxColumn(dgvList, "Email", "이메일", false, true, 10, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 100);
			UserDataGrid.AddTextBoxColumn(dgvList, "TaskCharge", "담당업무", false, true, 10, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 50);
			UserDataGrid.AddTextBoxColumn(dgvList, "Remark", "비고", false, true, 20, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 255);
			UserDataGrid.End(dgvList);

		}

		private void InitDto()
		{

			base.currentData = dto;         //원본 데이터
			base.isFormChagned = false;
		}

		private void btnAddRow_Click(object sender, EventArgs e)
		{
			DataRow dr = (dgvList.DataSource as DataTable).NewRow();
			dr["CustCode"] = txtCustCode.Texts;
			(dgvList.DataSource as DataTable).Rows.Add(dr);
		}

		private void btnDelRow_Click(object sender, EventArgs e)
		{
			if (dgvList.Rows.Count < 1)
			{
				KMessageBox.Show("삭제할 데이터가 없습니다.", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

            if (dgvList.SelectedRows.Count < 1)
            {
				KMessageBox.Show("삭제할 행을 선택 바랍니다.", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

            if (dgvList.Rows.Count > 0)
			{
				DataGridViewRow row = dgvList.SelectedRows[0];
				dgvList.Rows.RemoveAt(row.Index);
			}
		}

		private void txtAccountNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			// 숫자와 하이픈, 백스페이스 키만 입력되도록 제한
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}
	}
}
