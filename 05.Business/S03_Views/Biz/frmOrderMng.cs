using log4net;
using Microsoft.VisualBasic;
using Mysqlx.Crud;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Biz;
using P05_Business.S02_Controllers.Biz;
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
using static log4net.Appender.RollingFileAppender;
using static SmartSql.SqlMap.Tags.Switch;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        }

        public frmOrderMng(string code) : this()
        {
            IS_LINK_OPEN = true;

            _MODE = SAVE_MODE.Update;
        }
        #endregion -- Constructor

        #region -- Control Event
        private void frmOrderMng_Load(object sender, EventArgs e)
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
                ResultCRUD search = SearchData();
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
                ResultCRUD save = SaveData();
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
                ResultCRUD delete =  DeleteData();
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


        #endregion -- Control Event

        #region -- Method

        private ResultCRUD SearchData()
        {
            //Master 정보 수집
            OrderMasterDto saveMaster = DataHandles.ControlsToDto<OrderMasterDto>(this, dtoMaster);

            //Detail 정보 수집
            DataTable dtDetail = UserDataGrid.GetChangeAll(dgvList);
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
            };

        }

        private ResultCRUD SaveData()
        {
            throw new NotImplementedException();
        }

        private ResultCRUD DeleteData()
        {
            throw new NotImplementedException();
        }

        private void InitControls()
        {
            isFormChagned = false;

            _MODE = SAVE_MODE.New;

            txtOrderNo.Enabled = true;
            tabOptions.SelectedIndex = 0;

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
        #endregion -- Method

    }
}
