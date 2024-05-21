using log4net;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Biz;
using P05_Business.S02_Controllers.Biz;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Biz
{
    public partial class frmOrderList : frmSearchContainer
    {
        #region  -- Variable
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        OrderMngController ctrl;
        #endregion -- Variables

        #region -- Constructor
        public frmOrderList()
        {
            InitializeComponent();

            ctrl = new OrderMngController();

            Set_Menu_Button(new EditButtonSettings { isPrint = false });

            //그리드 생성
            CreateGrid();

            dgvList.Paint += DgvList_Paint;

            //Date Type 초기화
            InitDateType();
        }

        private void DgvList_Paint(object sender, PaintEventArgs e)
        {   
            
        }

        #endregion -- Constructor

        #region -- Control Events
        private void frmOrderList_Load(object sender, System.EventArgs e)
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

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInit_Click(object sender, System.EventArgs e)
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

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                SearchData();
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion -- Control Events

        #region -- Methods
        /// <summary>
        /// 데이터 조회
        /// </summary>
        private void SearchData()
        {
            OrderMasterDto param = new OrderMasterDto
            {
                CompanyCode = LoginCompany.CompanyCode,
                DatePeriodType = ((KeyValuePair<string, string>)cboPeriodType.SelectedItem).Key,
                PeriodFromDt = pdbDate.DateFromValue,
                PeriodToDt = pdbDate.DateToValue,
                OrderNo = txtOrderNo.Texts,
                BuyerPoNo = txtPoNo.Texts,
                BuyerCustCode = cnbBuyer.CodeValue,
                WorkCustCode = cnbWork.CodeValue,
            };

            AccessMain.ShowLoading();

            List<OrderMasterDto> list = ctrl.GetOrderMasterList(param);

            dgvList.DataSource = list;

            AccessMain.HideLoading();
        }

        /// <summary>
        /// 그리드 초기화
        /// </summary>
        private void CreateGrid()
        {
            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
            UserDataGrid.AddCheckBoxColumn(dgvList, "CHK", "선택", false, true, 20, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddLinkColumn(dgvList, "OrderNo", "발주번호", true, true, 50, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "RegDt", "등록일자", true, true, 30, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "ExWorkDt", "출고일자", true, true, 30, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "BuyerCustCode", "Buyer", true, true, 30, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "BuyerCustName", "Buyer", true, true, 50, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "BuyerPoNo", "P/O NO", true, true, 50, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "DueDt", "납기일자", true, true, 30, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "WorkCustCode", "발주처", true, true, 30, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "WorkCustName", "발주처", true, true, 50, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "OrderDt", "발주일자", true, true, 30, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.End(dgvList);
            
            GridHelper.MergeColumnHeader(dgvList, System.Drawing.StringAlignment.Center, "BUYER", "BuyerCustCode", 2);
            GridHelper.MergeColumnHeader(dgvList, System.Drawing.StringAlignment.Center, "발주처", "WorkCustCode", 2);


        }

        /// <summary>
        /// Date Type 초기화
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void InitDateType()
        {

            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("R", "등록일자");
            items.Add("W", "출고일자");
            items.Add("O", "요청일자");
            items.Add("D", "납기일자");

            cboPeriodType.DisplayMember = "Value";
            cboPeriodType.ValueMember = "Key";
            cboPeriodType.DataSource = new BindingSource(items, null);


            cboPeriodType.SelectedIndex = 0;
        }

        private void InitControls()
        {
            dgvList.DataSource = null;
        }
        #endregion -- Methods


    }
}
