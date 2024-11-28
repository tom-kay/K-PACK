using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Biz;
using P05_Business.S02_Controllers.Biz;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Popup.Biz
{
    public partial class frmItemFindPopup : frmPopupFrame
    {
        #region Member Variables

        public string ResultCode { get; set; }
        public string ResultName { get; set; }

        internal List<ItemDto> ResultItems { get; set; }

        ItemMngController ctrl;

        #endregion

        #region -- Constructor
        public frmItemFindPopup(string title, object[] args)
        {
            InitializeComponent();

            ctrl = new ItemMngController();

            this.btnInit.Click += btnInit_Click;
            this.btnSearch.Click += btnSearch_Click;
            this.cboItemGroup.OnSelectedIndexChanged += cboItemGroup_OnSelectedIndexChanged;

            lblPopupTitle.Text = title;


            InitGrid(dgvList);      //좌측 그리드
            InitGrid(dgvChoice);    //우측 그리드

            //부모화면에서 넘어온 ITEM을 dgvChoice 그리드에 바인딩 한다.
            dgvChoice.DataSource = args[0];
        }

        public frmItemFindPopup(string title, object[] args, string code) : this(title, args)
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
        }


        private void btnInit_Click(object sender, System.EventArgs e)
        {
            //dgvList.DataSource = null;
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                string code = cboItemGroup.SelectedValue.ToString();
                List<ItemDto> results = SearchData(code);

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

                ResultItems = dgvChoice.DataSource as List<ItemDto>;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboItemGroup_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string code = cboItemGroup.SelectedValue.ToString();
                List<ItemDto> results = SearchData(code);

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

                List<ItemDto> listItems = new List<ItemDto>();   //선택 아이템 수집

                foreach (DataGridViewRow dr in dgvList.Rows)
                {
                    if (dr.Cells["CHK"].Value != null && dr.Cells["CHK"].Value.Equals(true))
                    {
                        listItems.Add(dr.DataBoundItem as ItemDto);
                    }
                }


                //우측 그리드에 추가한다.
                List<ItemDto> choiceItems = dgvChoice.DataSource as List<ItemDto>;     //기존 아이템 수집
                if (choiceItems == null) choiceItems = new List<ItemDto>();
                foreach (ItemDto dr in listItems)
                {
                    //이미 그리드에 존재하는지 체크한다.
                    int index = choiceItems.FindIndex(item => item.GroupCode == dr.GroupCode && item.ItemCode == dr.ItemCode);
                    if (index >= 0)
                    {
                        string msg = $"({dr.ItemNo}){dr.ItemName}은(는) 이미 존재합니다.";
                        KMessageBox.Show(msg, "중복", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        continue;
                    }
                    dr.Remark = ""; //비고란은 비우기
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

            List<ItemDto> choiceItems = dgvChoice.DataSource as List<ItemDto>;
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

        private List<ItemDto> SearchData(string code)
        {
            // 데이터베이스 조회

            ItemDto param = new ItemDto
            {
                GroupCode = code,
                CompanyCode = LoginCompany.CompanyCode,
                DelYn = "N",
            };

            return ctrl.GetItemList(param);

        }

        private void InitGrid(DataGridView dgv)
        {
            UserDataGrid.Create(dgv, DataGridViewAutoSizeColumnsMode.None);
            UserDataGrid.AddCheckBoxColumn(dgv, "CHK", "선택", false, true, 50, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgv, "GroupCode", "제품군코드", true, false, 20, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "ItemCode", "제품코드", true, false, 20, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "ItemNo", "제품번호", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "ItemName", "제품명", true, true, 100, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "SIze", "사이즈명", true, true, 120, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "Description", "사이즈", true, true, 160, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgv, "UnitCode", "단위", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.End(dgv);

            dgv.Columns["ItemNo"].Frozen = true;
        }

        private void InitCombo()
        {
            ComboHelper.InitComboBoxItemGroup(cboItemGroup, false, false);   //아이템 그룹 콤보박스 설정
        }



        #endregion -- Methods

        
    }
}
