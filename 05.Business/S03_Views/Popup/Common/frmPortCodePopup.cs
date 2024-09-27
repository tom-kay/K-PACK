using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Popup.Common
{
    public partial class frmPortCodePopup : frmPopupFrame
    {   

        #region Member Variables

        public string ResultCode { get; set; }
        public string ResultName { get; set; }

        List<ShipportCodeDto> dtoShips;
        List<AirportCodeDto> dtoAirs;

        CodeMngController ctrl;
        
        private object[] _ARGS = null;
        private string _TRANS = null;

        #endregion

        #region -- Constructor
        public frmPortCodePopup(string title, object[] args)
        {
            InitializeComponent();

            dtoShips = new List<ShipportCodeDto>();
            dtoAirs = new List<AirportCodeDto>();

            ctrl = new CodeMngController();

            lblPopupTitle.Text = title;

            _ARGS = args;

            InitEvents();

            InitControls();

            InitGrid();
        }

        public frmPortCodePopup(string title, object[] args, string code) : this(title, args)
        {
            SearchPopup(_TRANS, code);
        }

        #endregion -- Constructor

        #region -- Control Events
        private void FrmPopup_Load(object sender, System.EventArgs e)
        {   
            if (this._TRANS.Equals("S"))
            {//해운
                if (dtoShips != null)
                {
                    dgvList.DataSource = dtoShips;
                } 
            }
            else
            {//항공
                if (dtoAirs != null)
                {
                    dgvList.DataSource = dtoAirs;
                }
            }
        }

        private void btnInit_Click(object sender, System.EventArgs e)
        {
            rdoTransS.Checked = true;
            dgvList.DataSource = null;
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                string tramsType = rdoTransS.Checked ? "S" : "A";

                object dtoPortList = SearchData(tramsType);

                dgvList.DataSource = dtoPortList;
            }
            catch (System.Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.ColumnIndex == 0)
            {
                if (dgvList.DataSource is List<ShipportCodeDto> shipportList)
                {
                    this.ResultCode = dgvList.Rows[e.RowIndex].Cells["PortCode"].Value.ToString();
                    this.ResultName = dgvList.Rows[e.RowIndex].Cells["PortName"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (dgvList.DataSource is List<AirportCodeDto> airportList)
                {
                    this.ResultCode = dgvList.Rows[e.RowIndex].Cells["IataCode"].Value.ToString();
                    this.ResultName = dgvList.Rows[e.RowIndex].Cells["NameE"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        #endregion -- Control Events

        #region -- Methods

        private void SearchPopup(string transType, string code)
        {
            try
            {   
                txtCode.Texts = code;

                //데이터 조회
                object dtoList = SearchData(this._TRANS);

                if (dtoList is List<ShipportCodeDto> shipportList)
                {//해운
                    if (shipportList.Count == 1)
                    {
                        // 조회해서 일치하는 데이터가 1건일 경우 코드와 이름을 반환
                        this.ResultCode = shipportList[0].PortCode;
                        this.ResultName = shipportList[0].PortName;
                        this.DialogResult = DialogResult.OK;
                    } 
                }
                else if (dtoList is List<AirportCodeDto> airportList)
                {//항공
                    if (airportList.Count == 1)
                    {
                        // 조회해서 일치하는 데이터가 1건일 경우 코드와 이름을 반환
                        this.ResultCode = airportList[0].IataCode;
                        this.ResultName = airportList[0].NameE;
                        this.DialogResult = DialogResult.OK;
                    }
                }

                // 팝업 다이얼로그 표시
                if (this.DialogResult != DialogResult.OK)
                {
                    this.ShowDialog(); 
                }
            }
            catch (System.Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private object SearchData(string trans)
        {
            object portList;
            // 데이터베이스 조회
            if (trans.Equals("S"))
            {//해운
                ShipportCodeDto param = new ShipportCodeDto
                {
                    PortCode = txtCode.Texts.Trim(),
                    PortName = txtName.Texts.Trim()
                };

                portList = ctrl.GetShipportList(param);
            }
            else
            {//항공
                AirportCodeDto param = new AirportCodeDto
                {
                    IataCode = txtCode.Texts.Trim(),
                    NameE = txtName.Texts.Trim()
                };
                portList = ctrl.GetAirportList(param);
            }

            return portList;
        }

        private void InitControls()
        {
            this._TRANS = _ARGS[0].ToString();

            //해운, 항공 구분
            if (this._TRANS.Equals("S"))
            {//해운
                rdoTransS.Checked = true;
            }
            else
            {//항공
                rdoTransA.Checked = true;
            }

            dgvList.DataSource = null;

        }

        private void InitGrid()
        {
            dgvList.Columns.Clear();

            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
            //운송수단에 따라 그리드를 다르게 그려준다.
            if (this._TRANS.Equals("S"))
            { //해운
                UserDataGrid.AddLinkColumn(dgvList, "PortCode", "CODE", true, true, 30, DataGridViewContentAlignment.MiddleCenter);
                UserDataGrid.AddTextBoxColumn(dgvList, "PortName", "NAME", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
                UserDataGrid.AddTextBoxColumn(dgvList, "CountryCode", "국가코드", true, true, 30, DataGridViewContentAlignment.MiddleCenter);
                UserDataGrid.AddTextBoxColumn(dgvList, "CountryName", "국가명", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
                UserDataGrid.AddTextBoxColumn(dgvList, "PortClass", "항구구분자", true, true, 30, DataGridViewContentAlignment.MiddleCenter);
            }
            else
            {//항공
                UserDataGrid.AddLinkColumn(dgvList, "IataCode", "CODE", true, true, 30, DataGridViewContentAlignment.MiddleCenter);
                UserDataGrid.AddTextBoxColumn(dgvList, "NameE", "E.NAME", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
                UserDataGrid.AddTextBoxColumn(dgvList, "NameK", "K.NAME", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
                UserDataGrid.AddTextBoxColumn(dgvList, "IcaoCode", "ICAO CODE", true, true, 30, DataGridViewContentAlignment.MiddleCenter);
                UserDataGrid.AddTextBoxColumn(dgvList, "StatusName", "공항운영상태", true, true, 50, DataGridViewContentAlignment.MiddleCenter);
            }
            UserDataGrid.End(dgvList);
        }

        private void InitEvents()
        {
            rdoTransA.CheckedChanged += RdoTrans_CheckedChanged;
            rdoTransS.CheckedChanged += RdoTrans_CheckedChanged;
        }

        private void RdoTrans_CheckedChanged(object sender, EventArgs e)
        {
            this._TRANS = rdoTransS.Checked ? "S" : "A";
            InitGrid();
        }

        #endregion -- Methods

    }
}
