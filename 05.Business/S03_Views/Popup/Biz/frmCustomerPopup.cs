using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Popup.Biz
{
    public partial class frmCustomerPopup : frmPopupFrame
    {
        #region Member Variables

        public string ResultCode { get; set; }
        public string ResultName { get; set; }

        List<CustomerDto> dtos;
        CustomerMngController ctrl;

        private object[] _ARGS = null;

        #endregion

        #region -- Constructor
        public frmCustomerPopup(string title, object[] args)
        {
            InitializeComponent();

            dtos = new List<CustomerDto>();
            ctrl = new CustomerMngController();

            this.Load += FrmPopup_Load;
            this.btnInit.Click += btnInit_Click;
            this.btnSearch.Click += btnSearch_Click;

            lblPopupTitle.Text = title;

            _ARGS = args;

            InitControls();

            InitGrid();
        }

        public frmCustomerPopup(string title, object[] args, string code) : this(title, args)
        {
           
            SearchPopup(code);

        }

        #endregion -- Constructor

        #region -- Control Events
        private void FrmPopup_Load(object sender, System.EventArgs e)
        {
            if (dtos != null)
            {
                dgvList.DataSource = dtos;
            }
        }

        private void btnInit_Click(object sender, System.EventArgs e)
        {   
            InitControls();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                dtos = SearchData();

                dgvList.DataSource = dtos;
            }
            catch (System.Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvList.Columns["CustCode"].Index)
            {
                this.ResultCode = dgvList.Rows[e.RowIndex].Cells["CustCode"].Value.ToString();
                this.ResultName = dgvList.Rows[e.RowIndex].Cells["CustName"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        #endregion -- Control Events

        #region -- Methods

        private void SearchPopup(string code)
        {
            try
            {
                txtCode.Texts = code;

                //데이터 조회
                dtos = SearchData();

                if (dtos.Count == 1)
                {
                    // 조회해서 일치하는 데이터가 1건일 경우 코드와 이름을 반환
                    this.ResultCode = dtos[0].CustCode;
                    this.ResultName = dtos[0].CustName;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {

                    this.ShowDialog(); // 팝업 다이얼로그 표시
                }
            }
            catch (System.Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private List<CustomerDto> SearchData()
        {
            //데이터베이스 조회
            CustomerDto param = new CustomerDto
            {
                CustCode = txtCode.Texts.Trim(),
                CustName = txtName.Texts.Trim(),
                DealTypeSale = chkDealTypeSale.Checked,
                DealTypeBuy = chkDealTypeBuy.Checked,
                DealTypeProc = chkDealTypeProc.Checked,
                DealTypeGeneral = chkDealTypeGeneral.Checked,
                CompanyCode = LoginCompany.CompanyCode,
            };

            return ctrl.GetCustomerPopupList(param);

        }

        private void InitGrid()
        {
            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
            UserDataGrid.AddLinkColumn(dgvList, "CustCode", "CODE", true, true, 20, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "CustName", "NAME", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.End(dgvList);
        }

        private void InitControls()
        {
            dgvList.DataSource = null;

            if (_ARGS != null)
            {
                foreach (string type in _ARGS)
                {
                    switch (type)
                    {
                        case "S":
                            chkDealTypeSale.Checked = true;
                            break;
                        case "B":
                            chkDealTypeBuy.Checked = true;
                            break;
                        case "P":
                            chkDealTypeProc.Checked = true;
                            break;
                        case "G":
                            chkDealTypeGeneral.Checked = true;
                            break;
                    }
                }
            }
        }

        #endregion -- Methods
    }
}
