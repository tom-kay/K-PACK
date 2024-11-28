using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Popup.Common
{
    public partial class frmTemplatePopup : frmPopupFrame
    {   

        #region Member Variables

        public string ResultCode { get; set; }
        public string ResultName { get; set; }

        List<MemoTemplateDto> dtos;
        MemoMngController ctrl;

        #endregion

        #region -- Constructor
        public frmTemplatePopup(string title, object[] args)
        {
            InitializeComponent();

            dtos = new List<MemoTemplateDto>();
            ctrl = new MemoMngController();

            this.Load += FrmPopup_Load;
            this.btnInit.Click += btnInit_Click;
            this.btnSearch.Click += btnSearch_Click;

            lblPopupTitle.Text = title;

            InitGrid();
        }

        public frmTemplatePopup(string title, object[] args, string code) : this(title, args)
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
            dgvList.DataSource = null;
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

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.ColumnIndex == dgvList.Columns["Title"].Index)
                {
                    this.ResultCode = dgvList.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                    this.ResultName = dgvList.Rows[e.RowIndex].Cells["Contents"].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        #endregion -- Control Events

        #region -- Methods

        private void SearchPopup(string code)
        {
            try
            {
                txtTitle.Texts = code;

                //데이터 조회
                dtos = SearchData();

                if (dtos.Count == 1)
                {
                    // 조회해서 일치하는 데이터가 1건일 경우 코드와 이름을 반환
                    this.ResultCode = dtos[0].Title;
                    this.ResultName = dtos[0].Contents;
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

        private List<MemoTemplateDto> SearchData()
        {
            // 데이터베이스 조회
            MemoTemplateDto param = new MemoTemplateDto
            {
                Title = txtTitle.Texts.Trim(),
                Contents = txtContents.Texts.Trim(),
                CompanyCode = LoginCompany.CompanyCode,
            };

            return ctrl.GetTemplatePopup(param);

        }

        private void InitGrid()
        {
            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
            UserDataGrid.AddLinkColumn(dgvList, "Title", "TITLE", true, true, 20, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "Contents", "CONTENTS", true, true, 80, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.End(dgvList);
        }


        #endregion -- Methods
   
    }
}
