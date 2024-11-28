using log4net;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
    public partial class frmMemoList : frmSearchContainer
    {
        #region -- Member Variable

        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        MemoMngController ctrl;
        List<MemoTemplateDto> dto;

        #endregion -- Member Variable

        #region -- Constructor
        public frmMemoList()
        {
            InitializeComponent();

            ctrl = new MemoMngController();
            dto = new List<MemoTemplateDto>();

            Set_Menu_Button(new EditButtonSettings { isPrint = false, isNew = false });

            //그리드 생성
            CreateGrid();
        }
        #endregion -- Constructor

        #region -- Controls Events
        private void frmMemoList_Load(object sender, EventArgs e)
        {

        }

        private void btnInit_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchData() == ResultCRUD.SearchSuccessData)
                {
                    MainMessage.Show("조회 되었습니다."); 
                }
                else
                {
                    MainMessage.Show("자료가 없습니다.");
                }
            }
            catch (Exception ex)
            {

                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvList.Columns["Title"].Index)
                {
                    string code = dgvList.Rows[e.RowIndex].Cells["MemoIdx"].Value.ToString();

                    frmMemoMng frm = new frmMemoMng(code);

                    AccessMain.OpenChildForm(frm); 
                }
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region -- Methods
        
        private void CreateGrid()
        {
            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
            UserDataGrid.AddTextBoxColumn(dgvList, "MemoIdx", "메모코드", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddLinkColumn(dgvList, "Title", "제목", true, true, 10, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "Contents", "내용", true, true, 50, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.End(dgvList);
        } 

        private ResultCRUD SearchData()
        {
            MemoTemplateDto param = new MemoTemplateDto
            {
                Title = txtTitle.Texts,
                Contents = txtContents.Texts,
                CompanyCode = LoginCompany.CompanyCode,
            };

            List<MemoTemplateDto> list = ctrl.GetMemoList(param);

            dgvList.DataSource = list;

            ResultCRUD result;
            if (list.Count > 0)
            {
                result = ResultCRUD.SearchSuccessData;
            }
            else
            {
                result = ResultCRUD.SearchSuccessNoData;
            }

            return result;

        }


        #endregion -- Methods

    }
}
