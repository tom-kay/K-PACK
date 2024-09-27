using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Popup.Common
{
    public partial class frmDetailCodePopup : frmPopupFrame
    {
        #region Member Variables

        public string ResultCode { get; set; }
        public string ResultName { get; set; }

        List<CodeDetailDto> results = null;

        CodeMngController ctrl;

        private object[] _ARGS = null;

        #endregion

        #region Constructor
        public frmDetailCodePopup(string title, object[] args)
        {
            InitializeComponent();

            ctrl = new CodeMngController();

            lblPopupTitle.Text = title;

            _ARGS = args;

            InitControls();

            InitGrid();

        }

        public frmDetailCodePopup(string title, object[] args, string code) : this(title, args)
        {

            string groupCode = args[0].ToString();
            SearchPopup(groupCode, code);

        }


        #endregion

        #region Control Events

        private void frmDetailCodePopup_Load(object sender, EventArgs e)
        {
            if (results != null)
            {
                dgvList.DataSource = results;
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<CodeDetailDto> results = SearchData();

                dgvList.DataSource = results;
            }
            catch (System.Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 사용자가 로우를 더블클릭하면 로우 값을 부모에게 반환
            if (dgvList.CurrentRow != null)
            {
                this.ResultCode = dgvList.CurrentRow.Cells["Code"].Value.ToString();
                this.ResultName = dgvList.CurrentRow.Cells["Name"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #endregion

        #region Custom Mothods

        private void SearchPopup(string groupCode, string code)
        {
            try
            {
                txtMasterCode.Texts = groupCode;
                txtDetailCode.Texts = code;

                //데이터 조회
                results = SearchData();

                if (results.Count == 1)
                {
                    // 조회해서 일치하는 데이터가 1건일 경우 코드와 이름을 반환
                    this.ResultCode = results[0].Code;
                    this.ResultName = results[0].Name;
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

        private List<CodeDetailDto> SearchData()
        {
            // 데이터베이스 조회
            CodeDetailDto param = new CodeDetailDto()
            {
                MasterCode = txtMasterCode.Texts,
                Code = txtDetailCode.Texts,
                Name = txtDetailName.Texts,
                UseYn = "Y",
                DelYn = "N",
            };

            return ctrl.GetCodeDetailList(param);

        }

        private void InitControls()
        {
            txtMasterCode.Texts = _ARGS[0].ToString();

            //마스터코드, 네임은 사용자가 변경할 수 없도록 잠금
            txtMasterCode.Enabled = txtMasterName.Enabled = false;

            dgvList.DataSource = null;

        }

        private void InitGrid()
        {
            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
            UserDataGrid.AddLinkColumn(dgvList, "Code", "D.CODE", true, true, 20, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "Name", "D.NAME", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "MasterCode", "M.CODE", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "MasterName", "M.NAME", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            
            UserDataGrid.End(dgvList);
        }

        #endregion

        
    }
}
