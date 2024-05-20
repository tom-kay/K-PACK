using MySqlX.XDevAPI.Common;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System.Collections.Generic;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Windows.Forms;
using P05_Business.Common;
using System.Xml.Linq;

namespace P05_Business
{
	public partial class frmPopup : frmPopupFrame
    {
        #region Member Variables

        public string ResultCode { get; set; }
        public string ResultName { get; set; }

        //List<CodeMasterDto> results = null;

        //CodeMngController ctrl = new CodeMngController();

        #endregion

        #region -- Constructor
        public frmPopup(string title)
        {
            InitializeComponent();

            this.Load += FrmPopup_Load;
            this.btnInit.Click += btnInit_Click;
            this.btnSearch.Click += btnSearch_Click;

            lblPopupTitle.Text = title;
        }

        public frmPopup(string title, string code) : this(title)
        {

            SearchPopup(code);
        }

        #endregion -- Constructor

        #region -- Control Events
        private void FrmPopup_Load(object sender, System.EventArgs e)
        {
            CreateGrid();

            //if (results != null)
            //{
            //    dgvList.DataSource = results;
            //}
        }

        private void btnInit_Click(object sender, System.EventArgs e)
        {
            //dgvList.DataSource = null;
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                //List<CodeMasterDto> results = SearchData();

                //dgvList.DataSource = results;
            }
            catch (System.Exception ex)
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

        private List<CodeMasterDto> SearchData()
        {
            // 데이터베이스 조회
            //CodeMasterDto param = new CodeMasterDto()
            //{
            //    Code = txtCode.Texts,
            //    Name = txtName.Texts,
            //    UseYn = "Y",
            //    DelYn = "N",
            //};

            //return ctrl.GetCodeMasterList(param);

            return null;

        }

        private void CreateGrid()
        {
            //UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
            //UserDataGrid.AddTextBoxColumn(dgvList, "CODE", "CODE", true, true, 20, DataGridViewContentAlignment.MiddleLeft);
            //UserDataGrid.AddTextBoxColumn(dgvList, "NAME", "NAME", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            //UserDataGrid.End(dgvList);
        }

        #endregion -- Methods
    }
}
