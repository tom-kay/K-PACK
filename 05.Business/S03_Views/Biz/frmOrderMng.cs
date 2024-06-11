using log4net;
using log4net.Util.TypeConverters;
using Mysqlx.Crud;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Biz;
using P05_Business.S02_Controllers.Biz;
using P05_Business.S03_Views.Popup.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Biz
{
    public partial class frmOrderMng : frmEditContainer
    {
        #region -- Variables
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        SAVE_MODE _MODE = SAVE_MODE.New;

        OrderMngController ctrl;

        OrderMasterDto dtoMaster;
        List<OrderDetailDto> dtoDetails;
        #endregion -- Variables

        #region -- Constructor
        public frmOrderMng()
        {
            InitializeComponent();

            ctrl = new OrderMngController();
            dtoMaster = new OrderMasterDto();
            dtoDetails = new List<OrderDetailDto>();

            Set_Menu_Button(new EditButtonSettings { isPrint = false, isSearch = false });

            _MODE = SAVE_MODE.New;

            InitGrid();

            InitControls();
        }

        public frmOrderMng(string code) : this()
        {
            IS_LINK_OPEN = true;

            _MODE = SAVE_MODE.Update;

            txtOrderNo.Texts = code;

            
        }
        #endregion -- Constructor

        #region -- Control Event
        private void frmOrderMng_Load(object sender, EventArgs e)
        {
            try
            {
             
                if (IS_LINK_OPEN) SearchData();
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
                InitControls();
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
                if (string.IsNullOrEmpty(txtOrderNo.Texts.Trim()))
                {
                    KMessageBox.Show("[발주번호]를 입력 바랍니다.", "조회", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ResultCRUD search = SearchData();

                if (search == ResultCRUD.SearchSuccessData)
                {
                    MainMessage.Show("조회되었습니다.");
                }
                else
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
                //validation
                if (string.IsNullOrEmpty(txtOrderNo.Texts.Trim()))
                {
                    KMessageBox.Show("[발주번호]를 입력 바랍니다.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrEmpty(cnbWorker.CodeValue.Trim()))
                {
                    KMessageBox.Show("[발주처]를 입력 바랍니다.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (KMessageBox.Show("저장 하시겠습니까?", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                ResultCRUD save = SaveData();

                if (save == ResultCRUD.SaveSuccessData)
                {
                    SearchData();   //저장된 데이터 조회

                    MainMessage.Show("저장되었습니다.");
                }
                else
                {
                    MainMessage.Show("저장되지 않았습니다.");
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
                //validation
                if (string.IsNullOrEmpty(txtOrderNo.Texts.Trim()))
                {
                    KMessageBox.Show("[발주번호]를 입력 바랍니다.", "삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (KMessageBox.Show("삭제 하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;


                ResultCRUD delete = DeleteData();

                if (delete == ResultCRUD.DeleteSuccessData)
                {
                    MainMessage.Show("삭제 되었습니다.");
                }
                else
                {
                    MainMessage.Show("삭제되지 않았습니다.");
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmTemplatePopup popup = new frmTemplatePopup("템플릿 조회", null))
                {
                    if (popup.ShowDialog() == DialogResult.OK)
                    {
                        txtTAC.SetValue(popup.ResultName);
                    }
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            isFormChagned = true;

        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                List<ItemDto> addItems = null;

                //기존에 있는 아이템을 팝업으로 넘긴다.
                List<ItemDto> listItems = DataHandles.ConvertToList<ItemDto>(dgvList.DataSource as DataTable);
                object[] param = { listItems };

                using (frmItemFindPopup popup = new frmItemFindPopup("제품 조회", param))
                {
                    if (popup.ShowDialog(this) == DialogResult.OK)
                    {
                        if (popup.ResultItems != null)
                        {
                            addItems = popup.ResultItems;
                        }
                    }
                }

                // 팝업에서 받은 아이템을 그리드에 바인딩한다.
                if (addItems != null)
                {
                    this.SetBindAddItems(addItems);

                    base.isFormChagned = true;
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelRow_Click(object sender, EventArgs e)
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

        #endregion -- Control Event

        #region -- Method

        private ResultCRUD SearchData()
        {
            OrderMasterDto param = new OrderMasterDto
            {
                OrderNo = txtOrderNo.Texts.Trim(),
                CompanyCode = LoginCompany.CompanyCode,
            };

            dtoMaster = ctrl.GetOrderMaster(param);

            ResultCRUD search;
            if (dtoMaster != null && !string.IsNullOrEmpty(dtoMaster.OrderNo))
            {
                search = ResultCRUD.SearchSuccessData;

                isFormChagned = false;

                _MODE = SAVE_MODE.Update;   //수정모드로 변경

                DataHandles.DtoToControls(this, dtoMaster); //바이딩

                txtOrderNo.Enabled = false;

                //그리드 바인딩
                dtoDetails = dtoMaster.Details;

                dgvList.DataSource = dtoDetails;
            }
            else
            {
                search = ResultCRUD.SearchSuccessNoData;
            }

            InitDto();


            return search;
        }

        private ResultCRUD SaveData()
        {
            //Master 정보 수집
            OrderMasterDto saveMaster = DataHandles.ControlsToDto<OrderMasterDto>(this, dtoMaster);

            //Detail 정보 수집
            DataTable dtDetail = UserDataGrid.GetAllData(dgvList);
            List<OrderDetailDto> saveDetails = null;
            if (dtDetail != null)
            {
                saveDetails = DataHandles.ConvertToList<OrderDetailDto>(dtDetail);
            }

            OrderMasterDto param = new OrderMasterDto
            {
                OrderNo = saveMaster.OrderNo,
                OrderDt = saveMaster.OrderDt,
                ExWorkDt = saveMaster.ExWorkDt,
                BuyerCustCode = saveMaster.BuyerCustCode,
                BuyerPoNo = saveMaster.BuyerPoNo,
                DueDt = saveMaster.DueDt,
                WorkCustCode = saveMaster.WorkCustCode,
                Description = saveMaster.Description,
                Remark = saveMaster.Remark,
                TermsAndConditions = saveMaster.TermsAndConditions,
                CompanyCode = LoginCompany.CompanyCode,
                CreateId = LoginUserInfo.UserId,
                UpdateId = LoginUserInfo.UserId,
                DeleteId = LoginUserInfo.UserId,
                Details = saveDetails,
            };

            RequestCRUD request;
            if (_MODE == SAVE_MODE.New)
            {
                request = RequestCRUD.Create;
            }
            else
            {
                request = RequestCRUD.Update;
            }

            bool isSave = ctrl.AddOrderMaster(param, request);

            ResultCRUD result;
            if (isSave)
            {
                result = ResultCRUD.SaveSuccessData;
            }
            else
            {
                result = ResultCRUD.SaveFailData;
            }

            return result;
        }

        private ResultCRUD DeleteData()
        {
            OrderMasterDto param = new OrderMasterDto
            {
                OrderNo = txtOrderNo.Texts.Trim(),
                CompanyCode = LoginCompany.CompanyCode,
            };

            bool isDelete = ctrl.RemoveOrderMaster(param);

            ResultCRUD result;
            if (isDelete)
            {
                result = ResultCRUD.DeleteSuccessData;
            }
            else
            {
                result = ResultCRUD.DeleteFailData;
            }

            return result;
        }

        private void InitControls()
        {
            isFormChagned = false;

            _MODE = SAVE_MODE.New;

            txtOrderNo.Enabled = true;
            tabOptions.SelectedIndex = 0;
            cnbWorker.AddParams = new object[] { "B", "P" };
            cnbBuyer.AddParams = new object[] { "S" };

            dtoMaster = new OrderMasterDto();
            dtoDetails = new List<OrderDetailDto>();

            //그리드 초기화
            dgvList.DataSource = DataHandles.ConvertToDataTable<OrderDetailDto>(dtoDetails);

            InitDto();
        }

        private void InitGrid()
        {
            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill, DataGridViewCellBorderStyle.RaisedHorizontal);
            UserDataGrid.AddTextBoxColumn(dgvList, "OrderNo", "발주번호", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "DetailId", "발주상세코드", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "ItemGroupCode", "제품그룹코드", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "ItemCode", "제품코드", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "SeqNo", "순번", true, true, 50, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "ItemNo", "제품번호", true, true, 100, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 20);
            UserDataGrid.AddTextBoxColumn(dgvList, "SizeName", "사이즈", true, true, 250, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 100);
            UserDataGrid.AddTextBoxColumn(dgvList, "Description", "설명", true, true, 250, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 200);
            UserDataGrid.AddTextBoxColumn(dgvList, "Qty", "수량", false, true, 80, DataGridViewContentAlignment.MiddleRight, maxInputLength: 18);
            UserDataGrid.AddComboBoxColumn(dgvList, "UnitCode", "단위", false, true, 100, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "MarkingColor", "마킹컬러", false, true, 100, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 50);
            UserDataGrid.AddTextBoxColumn(dgvList, "Remark", "비고", false, true, 300, DataGridViewContentAlignment.MiddleLeft, maxInputLength: 255);
            UserDataGrid.End(dgvList);

            //단위 콤보박스 셋팅
            DataGridViewComboBoxColumn combo = dgvList.Columns["UnitCode"] as DataGridViewComboBoxColumn;
            UserDataGrid.BindComboBoxColumnCommonCode(combo, "ITEMUNIT", false, true);

            GridHelper.MergeColumnHeader(dgvList, StringAlignment.Center, "수량", "Qty", 2);
        }

        private void InitDto()
        {

            base.currentData = dtoMaster;         //원본 데이터
            base.isFormChagned = false;
        }

        private void SetBindAddItems(List<ItemDto> addItems)
        {
            List<ItemDto> listItems = dgvList.DataSource as List<ItemDto>;

            if (listItems == null) listItems = new List<ItemDto>();

            foreach (ItemDto item in addItems)
            {
                int index = listItems.FindIndex(i => i.GroupCode == item.GroupCode && i.ItemCode == item.ItemCode);

                if (index >= 0) continue;

                DataRow addDr = DataHandles.ConvertToDataRow<ItemDto>(item);
                DataRow newDr = (dgvList.DataSource as DataTable).NewRow();
                newDr["OrderNo"] = txtOrderNo.Texts;
                newDr["ItemGroupCode"] = addDr["GroupCode"];
                newDr["ItemCode"] = addDr["ItemCode"];
                newDr["ItemNo"] = addDr["ItemNo"];
                newDr["SizeName"] = addDr["Size"];
                newDr["Description"] = addDr["Description"];
                newDr["UnitCode"] = addDr["UnitCode"];
                (dgvList.DataSource as DataTable).Rows.Add(newDr);
            }

            
        }
        #endregion -- Method


    }
}
