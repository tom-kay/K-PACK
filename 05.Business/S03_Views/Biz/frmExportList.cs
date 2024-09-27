using log4net;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common.Helpers;
using P05_Business.Common;
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

namespace P05_Business.S03_Views.Biz
{
    public partial class frmExportList : frmSearchContainer
    {
        #region Member Variables
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        ExportMngController ctrl;

        List<ExportMasterDto> dtos;
        #endregion

        #region Constructor
        public frmExportList()
        {
            InitializeComponent();

            ctrl = new ExportMngController();

            Set_Menu_Button(new EditButtonSettings { isPrint = false });

            //그리드 생성
            CreateGrid();

            //일자 조회 조건 설정
            InitDateType();

            
        }

        #endregion

        #region Events
        private void frmExportList_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {   
            try
            {
                frmExportMng frm = new frmExportMng();

                AccessMain.OpenChildForm(frm);
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
                SearchData();
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvList.Columns["InvoiceNo"].Index)
            {
                string code = dgvList.Rows[e.RowIndex].Cells["InvoiceNo"].Value.ToString();

                frmExportMng frm = new frmExportMng(code);

                AccessMain.OpenChildForm(frm);
            }
        }
        #endregion

        #region Custom Methods

        /// <summary>
        /// 데이터 조회
        /// </summary>
        private void SearchData()
        {
            ExportMasterDto param = new ExportMasterDto
            {
                CompanyCode = LoginCompany.CompanyCode,
                DatePeriodType = ((KeyValuePair<string, string>)cboPeriodType.SelectedItem).Key,
                PeriodFromDt = pdbDate.DateFromValue,
                PeriodToDt = pdbDate.DateToValue,
                InvoiceNo = txtInvoiceNo.Texts.Trim(),
                BuyerCode = cnbBuyer.CodeValue,
            };

            AccessMain.ShowLoading();

            List<ExportMasterDto> list = ctrl.GetExportMasterList(param);
            
            dgvList.DataSource = list;

            AccessMain.HideLoading();
            
        }

        /// <summary>
        /// Date Type 초기화
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void InitDateType()
        {
            //조회 일자 조건 설정
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("I", "INV.DATE");

            cboPeriodType.DisplayMember = "Value";
            cboPeriodType.ValueMember = "Key";
            cboPeriodType.DataSource = new BindingSource(items, null);

            cboPeriodType.SelectedIndex = 0;
        }


        /// <summary>
        /// 그리드 초기화
        /// </summary>
        private void CreateGrid()
        {
            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
            UserDataGrid.AddCheckBoxColumn(dgvList, "CHK", "선택", false, false, 20, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddLinkColumn(dgvList, "InvoiceNo", "INV.NO", true, true, 80, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "InvoiceDate", "INV.DATE", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "BuyerName", "BUYER.NAME", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "ShipperName", "SHIPPER.NAME", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "ConsigneeName", "CONSIGNEE.NAME", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "NotifyName", "NOTIFY.NAME", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "DepartureDate", "DEPARTURE DATE", true, true, 80, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.End(dgvList);
        }

        private void InitControl()
        {
            pdbDate.DateFromValue = DateTime.Now.AddYears(-1).ToString("yyyy-MM-dd");

            cnbBuyer.AddParams = new object[] { "A" };
        }
        #endregion

        
    }
}
