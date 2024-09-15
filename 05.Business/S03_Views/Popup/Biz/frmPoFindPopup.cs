using GrapeCity.Spreadsheet;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Biz;
using P05_Business.S02_Controllers.Biz;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Popup.Biz
{
    public partial class frmPoFindPopup : frmPopupFrame
    {
        #region -- Member Variables

        public string ResultCode { get; set; }
        public string ResultName { get; set; }

        internal List<OrderDetailDto> ResultItems { get; set; }

        OrderMngController ctrl;

        #endregion

        #region -- Constructor

        public frmPoFindPopup(string title, object[] args)
        {
            InitializeComponent();

            ctrl = new OrderMngController();

            this.btnInit.Click += btnInit_Click;
            this.btnSearch.Click += btnSearch_Click;
            this.cboOrderNo.OnSelectedIndexChanged += cboOrderNo_OnSelectedIndexChanged;
            this.cnbBuyer.OnCodeChanged += Cnb_OnCodeChanged;
            this.cnbWorker.OnCodeChanged += Cnb_OnCodeChanged;
            this.txtPoNo.Leave += Txt_Leave;

            lblPopupTitle.Text = title;

            cnbBuyer.AddParams = cnbWorker.AddParams = new object[] { "A" };    //기본값 : 전체

            InitGrid(dgvList);      //좌측 그리드
            InitGrid(dgvChoice);    //우측 그리드

            InitControls(args);
        }

        public frmPoFindPopup(string title, object[] args, string code) : this(title, args)
        {

            SearchPopup(code);
        }

        #endregion -- Constructor

        #region -- Control Events
        private void frmItemFindPopup_Load(object sender, System.EventArgs e)
        {

            //if (results != null)
            //{
            //    dgvList.DataSource = results;
            //}

            InitCombo();

            SetComboOrderItemList();
        }

        private void btnInit_Click(object sender, System.EventArgs e)
        {
            //dgvList.DataSource = null;
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (cboOrderNo.SelectedValue == null) return;

                string ordNo = cboOrderNo.SelectedValue.ToString();
                List<OrderDetailDto> results = SearchData(ordNo);

                dgvList.DataSource = null;
                dgvList.DataSource = results;
            }
            catch (System.Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChoice.Rows.Count < 0)
                {
                    KMessageBox.Show("추가할 자료가 없습니다.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ResultItems = dgvChoice.DataSource as List<OrderDetailDto>;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboOrderNo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {   
                if (cboOrderNo.Items.Count < 1 || cboOrderNo.SelectedValue == null) return;

                if (string.IsNullOrEmpty(cboOrderNo.SelectedText)) return;

                string ordNo = cboOrderNo.SelectedText;
                List<OrderDetailDto> results = SearchData(ordNo);

                dgvList.DataSource = null;
                dgvList.DataSource = results;
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //추가할 아이템을 좌측 그리드에서 추출한다.
                dgvList.EndEdit();

                List<OrderDetailDto> orderDetailList = new List<OrderDetailDto>();   //선택 아이템 수집

                foreach (DataGridViewRow dr in dgvList.Rows)
                {
                    if (dr.Cells["CHK"].Value != null && dr.Cells["CHK"].Value.Equals(true))
                    {
                        orderDetailList.Add(dr.DataBoundItem as OrderDetailDto);
                    }
                }


                //우측 그리드에 추가한다.
                List<OrderDetailDto> choiceItems = dgvChoice.DataSource as List<OrderDetailDto>;     //기존 아이템 수집
                if (choiceItems == null) choiceItems = new List<OrderDetailDto>();
                foreach (OrderDetailDto dr in orderDetailList)
                {
                    //이미 그리드에 존재하는지 체크한다.
                    int index = choiceItems.FindIndex(order => order.OrderNo == dr.OrderNo && order.DetailId == dr.DetailId);
                    if (index >= 0)
                    {
                        string msg = $"({dr.OrderNo}){dr.ItemNo}은(는) 이미 존재합니다.";
                        KMessageBox.Show(msg, "중복", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        continue;
                    }
                    choiceItems.Add(dr);   //기존 데이터에 신규 아이템 추가
                }
                dgvChoice.DataSource = null;
                dgvChoice.DataSource = choiceItems;    //기존 아이템에 신규 아이템 추가.

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dgvChoice.EndEdit();

            List<OrderDetailDto> choiceItems = dgvChoice.DataSource as List<OrderDetailDto>;
            if (choiceItems == null || choiceItems.Count < 1) return;

            for (int i = dgvChoice.Rows.Count - 1; i >= 0; i--)
            {
                var row = dgvChoice.Rows[i];
                if (row.Cells["CHK"].Value != null && (bool)row.Cells["CHK"].Value)
                {   
                    choiceItems.RemoveAt(i);
                }
            }

            dgvChoice.DataSource = null;
            dgvChoice.DataSource = choiceItems;
        }

        private void dgvList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvList.Rows.Count < 1) return;

                //첫번에 행의 체크 상태에 따라서 전체 체크 여부를 판단한다.
                bool isCheck = Convert.ToBoolean(dgvList.Rows[0].Cells["CHK"].Value);
                if (e.ColumnIndex == dgvList.Columns["CHK"].Index)
                {
                    foreach (DataGridViewRow dr in dgvList.Rows)
                    {
                        dr.Cells["CHK"].Value = !isCheck;
                    }

                    dgvList.RefreshEdit();
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChoice_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvChoice.Rows.Count < 1) return;

                bool isCheck = Convert.ToBoolean(dgvChoice.Rows[0].Cells["CHK"].Value);
                if (e.ColumnIndex == dgvChoice.Columns["CHK"].Index)
                {
                    foreach (DataGridViewRow dr in dgvChoice.Rows)
                    {
                        dr.Cells["CHK"].Value = !isCheck;
                    }
                    dgvChoice.RefreshEdit();
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cnb_OnCodeChanged(object sender, EventArgs e)
        {
            try
            {
                this.SetComboOrderItemList();
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Leave(object sender, EventArgs e)
        {
            try
            {
                this.SetComboOrderItemList();
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion -- Control Events

        #region -- Methods

        private void SearchPopup(string code)
        {
            try
            {
                //txtCode.Texts = code;

                ////데이터 조회
                //results = SearchData();

                //if (results.Count == 1)
                //{
                //    // 조회해서 일치하는 데이터가 1건일 경우 코드와 이름을 반환
                //    this.ResultCode = results[0].Code;
                //    this.ResultName = results[0].Name;
                //    this.DialogResult = DialogResult.OK;
                //}
                //else
                //{

                //    this.ShowDialog(); // 팝업 다이얼로그 표시
                //}
            }
            catch (System.Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private List<OrderDetailDto> SearchData(string ordNo)
        {
            // 데이터베이스 조회

            OrderMasterDto param = new OrderMasterDto
            {
                OrderNo = ordNo,
                CompanyCode = LoginCompany.CompanyCode,
                DelYn = "N",
            };

            return ctrl.GetOrderDetailPopupList(param);

        }

        private void InitGrid(DataGridView dgv)
        {
            UserDataGrid.Create(dgv, DataGridViewAutoSizeColumnsMode.None);
            UserDataGrid.AddCheckBoxColumn(dgv, "CHK", "선택", false, true, 50, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgv, "REGYN", "등록여부", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "OrderNo", "발주번호", true, true, 100, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "DetailId", "발주상세코드", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "ItemGroupCode", "G.CODE", true, true, 100, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "ItemCode", "D.CODE", true, true, 100, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "ItemNo", "제품번호", true, true, 120, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "SizeName", "사이즈명", true, true, 150, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "Description", "규격", true, true, 200, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "Qty", "수량", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "UnitName", "단위", true, true, 100, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.End(dgv);

            dgv.Columns["OrderNo"].Frozen = true;
        }

        private void InitCombo()
        {
            cboOrderNo.DataSource = null;
        }

        private void SetComboOrderItemList()
        {
            OrderMasterDto param = new OrderMasterDto
            {
                BuyerCustCode = cnbBuyer.CodeValue,
                WorkCustCode = cnbWorker.CodeValue,
                BuyerPoNo = txtPoNo.Texts,
                CompanyCode = LoginCompany.CompanyCode,
            };
            ComboHelper.InitComboBoxOrderNo(cboOrderNo, param, false);   //아이템 그룹 콤보박스 설정
        }

        private void InitControls(object[] args)
        {
            try
            {
                //부모화면에서 넘어온 buyer를 컨트롤에 바인딩한다.
                cnbBuyer.CodeValue = args[0].ToString();
                cnbBuyer.NameValue = args[1].ToString();

                //부모화면에서 넘어온 ITEM을 dgvChoice 그리드에 바인딩 한다.
                dgvChoice.DataSource = args[2];

                //데이터 바인딩 후 메인화면에 이미 등록되어 있는 Item이기 때문에 REGYN 값을 Y로 부여한다. - 삭제 불가하기 위함.
                foreach (DataGridViewRow dr in dgvChoice.Rows)
                {
                    dr.Cells["REGYN"].Value = "Y";
                    dr.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion -- Methods


    }
}
