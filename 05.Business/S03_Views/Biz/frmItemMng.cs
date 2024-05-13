using log4net;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Biz;
using P05_Business.S02_Controllers.Biz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Biz
{
    public partial class frmItemMng : frmEditContainer
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        ItemMngController ctrl;
        ItemGroupDto dtoGroup;
        List<ItemDto> dtoItems;

        public frmItemMng()
        {
            InitializeComponent();

            ctrl = new ItemMngController();
            dtoGroup = new ItemGroupDto();
            dtoItems = new List<ItemDto>();

            Set_Menu_Button(new EditButtonSettings { isPrint = false });

            //그리드 생성
            CreateGrid();

            SetInit();
        }

        public frmItemMng(string code) : this()
        {
            txtGroupCode.Texts = code;

            IS_LINK_OPEN = true;
        }

        private void frmItemMng_Load(object sender, System.EventArgs e)
        {
            InitCombo();

            if (IS_LINK_OPEN) SearchData();
        }

        private void btnInit_Click(object sender, System.EventArgs e)
        {
            dgvList.DataSource = null;  //그리드 초기화

            txtGroupCode.Enabled = true;

            btnDuplicate.Visible = true;

        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtGroupCode.Texts))
                {
                    KMessageBox.Show("[제품군코드]를 입력 바랍니다.", "조회", MessageBoxButtons.OK);
                    txtGroupCode.Focus();
                    return;
                }

                ResultCRUD result = SearchData();
                if (result.Equals(ResultCRUD.SearchSuccessData))
                {
                    MainMessage.Show("조회되었습니다");
                }
                else if (result.Equals(ResultCRUD.SearchSuccessNoData))
                {
                    MainMessage.Show("자료가 없습니다.");
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                //validation
                if (btnDuplicate.Visible)
                {
                    KMessageBox.Show("[중복체크]바랍니다.", "SAVE", MessageBoxButtons.OK);
                    return;
                }

                if (string.IsNullOrEmpty(txtGroupCode.Texts))
                {
                    KMessageBox.Show("[제품군코드]를 입력 바랍니다.", "SAVE", MessageBoxButtons.OK);
                    return; 
                }

                if (KMessageBox.Show("저장하시겠습니까?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                ResultCRUD result = SaveData();
                if (result.Equals(ResultCRUD.SaveSuccessData))
                {
                    MainMessage.Show("저장되었습니다.");
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            try
            {
                //validation
                if (string.IsNullOrEmpty(txtGroupCode.Texts))
                {
                    KMessageBox.Show("[제품군코드]를 입력 바랍니다.", "삭제", MessageBoxButtons.OK);
                    return;
                }

                if (KMessageBox.Show("저장하시겠습니까?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                ResultCRUD result = DeleteData();   //삭제

                if (result.Equals(ResultCRUD.DeleteSuccessData))
                {
                    MainMessage.Show("삭제되었습니다.");
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddRow_Click(object sender, System.EventArgs e)
        {
            try
            {
                DataRow dr = (dgvList.DataSource as DataTable).NewRow();
                dr["GroupCode"] = txtGroupCode.Texts;
                (dgvList.DataSource as DataTable).Rows.Add(dr);

                base.isFormChagned = true;
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelRow_Click(object sender, System.EventArgs e)
        {
            try
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

                    base.isFormChagned = true;
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtGroupCode.Texts))
                {
                    KMessageBox.Show("[제품군코드]를 입력 바랍니다.", "삭제", MessageBoxButtons.OK);
                    return;
                }

                if (CheckDuplication() == false)
                {
                    lblDuplicateMsg.Text = "사용 가능합니다.";
                    lblDuplicateMsg.ForeColor = Color.Black;

                    btnDuplicate.Visible = false;   //중복체크 버튼 숨김
                }
                else
                {
                    lblDuplicateMsg.Text = "이미 사용 중입니다.";
                    lblDuplicateMsg.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGroupCode__TextChanged(object sender, EventArgs e)
        {
            btnDuplicate.Visible = true;
            lblDuplicateMsg.Text = string.Empty;
        }

        /// <summary>
        /// 그리드 데이터 변경 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            base.isFormChagned = true;
        }

        private ResultCRUD SearchData()
        {
            ItemGroupDto param = new ItemGroupDto
            {
                GroupCode = txtGroupCode.Texts.Trim(),
                CompanyCode = LoginCompany.CompanyCode,
            };

            dtoGroup = ctrl.GetItemGroup(param);

            ResultCRUD result;
            if (dtoGroup != null)
            {
                DataHandles.DtoToControls(this, dtoGroup);   //제품군 데이터 바인딩
                dtoItems = dtoGroup.Items;  //제품정보

                //제품정보 그리드에 바인딩
                if (dtoItems != null)
                {
                    dgvList.DataSource = DataHandles.ConvertToDataTable<ItemDto>(dtoItems);
                    (dgvList.DataSource as DataTable).AcceptChanges();
                }

                base.isFormChagned = false;

                InitDto();

                txtGroupCode.Enabled = false;

                btnDuplicate.Visible = false;

                result = ResultCRUD.SearchSuccessData;
            }
            else
            {
                result = ResultCRUD.SearchSuccessNoData;
            }

            return result;
            
        }

        private ResultCRUD SaveData()
        {
            //제품 변경된 데이터 토글
            DataTable dtItemChanges = UserDataGrid.GetChangeAll(dgvList);

            List<ItemDto> saveItems = null;
            if (dtItemChanges != null)
            {
                saveItems = DataHandles.ConvertToList<ItemDto>(dtItemChanges);
            }

            ItemGroupDto saveGroup = DataHandles.ControlsToDto(this, dtoGroup);

            ItemGroupDto param = new ItemGroupDto
            {
                GroupCode = saveGroup.GroupCode,
                GroupName = saveGroup.GroupName,
                AliasName = saveGroup.AliasName,
                DefaultEachUnitCode = saveGroup.DefaultEachUnitCode,
                DefaultPackingUnitCode = saveGroup.DefaultPackingUnitCode,
                Remark = saveGroup.Remark,
                CompanyCode = LoginCompany.CompanyCode,
                CreateId = LoginUserInfo.UserId,
                UpdateId = LoginUserInfo.UserId,
                Items = saveItems,      //제품정보
            };

            //유효성 검사
            //var context = new ValidationContext(param, serviceProvider: null, items: null);
            //Validator.ValidateObject(param, context, validateAllProperties: true);

            int iSave = ctrl.AddItemGroup(param);

            ResultCRUD result;
            if (iSave > -1)
            {//저장성공
                txtGroupCode.Enabled = false;

                SearchData();

                result = ResultCRUD.SaveSuccessData;
            }
            else
            {//저장실패
                result = ResultCRUD.SaveFailData;
            }

            return result;
        }

        private ResultCRUD DeleteData()
        {
            ItemGroupDto param = new ItemGroupDto
            {
                GroupCode = txtGroupCode.Texts,
                CompanyCode = LoginCompany.CompanyCode,
                DeleteId = LoginUserInfo.UserId,
            };

            int iDelete = ctrl.RemoveItemGroup(param);

            ResultCRUD result;
            if (iDelete > -1)
            {//삭제성공
                MainMessage.Show("삭제되었습니다.");
                btnInit.PerformClick();

                result = ResultCRUD.DeleteSuccessData;
            }
            else 
            {//삭제실패
                result = ResultCRUD.SaveFailData;
            }

            return result;
        }

        private bool CheckDuplication()
        {
            ItemGroupDto param = new ItemGroupDto
            {
                GroupCode = txtGroupCode.Texts.Trim(),
                CompanyCode = LoginCompany.CompanyCode,
            };

            ItemGroupDto data = ctrl.GetItemGroup(param);

            bool isDuplicastion = false;
            if (data != null && !string.IsNullOrEmpty(data.GroupCode))
            {
                isDuplicastion = true;
            }
            else
            {
                isDuplicastion = false;
            }

            return isDuplicastion;
        }

        private void CreateGrid()
        {
            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.None, DataGridViewCellBorderStyle.RaisedHorizontal);
            UserDataGrid.AddTextBoxColumn(dgvList, "GroupCode", "제품군코드", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "ItemCode", "제품코드", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "ItemNo", "제품번호", false, true, 100, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 20);
            UserDataGrid.AddTextBoxColumn(dgvList, "ItemName", "제품명", false, true, 250, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 200);
            UserDataGrid.AddTextBoxColumn(dgvList, "AliasName", "제품명약어", false, true, 150, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 100);
            UserDataGrid.AddTextBoxColumn(dgvList, "Size", "사이즈", false, true, 250, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 100);
            UserDataGrid.AddTextBoxColumn(dgvList, "AliasSize", "사이즈약어", false, true, 150, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 50);
            UserDataGrid.AddTextBoxColumn(dgvList, "Description", "설명", false, true, 250, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 200);
            UserDataGrid.AddTextBoxColumn(dgvList, "AliasDescription", "설명약어", false, true, 150, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 100);
            UserDataGrid.AddComboBoxColumn(dgvList, "UnitCode", "단위", false, true,  100, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "Remark", "비고", false, true, 300, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 255);
            UserDataGrid.AddTextBoxColumn(dgvList, "DelYn", "삭제여부", true, true, 100, DataGridViewContentAlignment.MiddleCenter);

            UserDataGrid.End(dgvList);

            //단위 콤보박스 셋팅
            DataGridViewComboBoxColumn combo = dgvList.Columns["UnitCode"] as DataGridViewComboBoxColumn;
            UserDataGrid.BindComboBoxColumnCommonCode(combo, "ITEMUNIT", false, true);

        }

        private void SetInit()
        {
            txtGroupCode.Enabled = true;

            dtoGroup = new ItemGroupDto();
            dtoItems = new List<ItemDto>();

            //그리드 초기화
            dgvList.DataSource = DataHandles.ConvertToDataTable<ItemDto>(dtoItems);

            InitDto();
        }

        private void InitDto()
        {

            base.currentData = dtoGroup;         //원본 데이터
            base.isFormChagned = false;
        }

        /// <summary>
		/// 콤보박스 초기설정
		/// </summary>
		private void InitCombo()
        {
            ComboHelper.InitComboBox(cboDefaultEachUnitCode, "ITEMUNIT", false, true);
            ComboHelper.InitComboBox(cboDefaultPackingUnitCode, "PACKINGUNIT", false, true);
        }

    }
} 
