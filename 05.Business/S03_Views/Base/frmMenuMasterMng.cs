using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmMenuMasterMng : P01_K_DESIGN_WIN.frmEditContainer
	{
        MenuMngController ctrl;
        MenuMasterDto dto;
        List<MenuMasterDto> dtoMenus;


		public frmMenuMasterMng()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });

            ctrl = new MenuMngController();
            dtoMenus = new List<MenuMasterDto>();

            //그리드 생성
            CreateGrid();

            SetInit();

        }

        private void frmMenuMasterMng_Load(object sender, EventArgs e)
        {
            InitCombo();
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

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CreateGrid()
        {
            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill, DataGridViewCellBorderStyle.RaisedHorizontal);
            UserDataGrid.AddTextBoxColumn(dgvList, "ParentId", "상위메뉴", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "MenuId", "메뉴ID", true, true, 5, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "MenuType", "메뉴유형", true, true, 5, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "MenuName", "메뉴명", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "Namespace", "Namespace", true, false, 1, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "FormName", "화면명", true, true, 30, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "UseYn", "사용유무", true, true, 5, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.End(dgvList);

        }

        private void SetInit()
        {
            dto = new MenuMasterDto();
            dtoMenus = new List<MenuMasterDto>();

            //그리드 초기화
            dgvList.DataSource = DataHandles.ConvertToDataTable<MenuMasterDto>(dtoMenus);

            InitDto();
        }

        private void InitDto()
        {

            base.currentData = dto;         //원본 데이터
            base.isFormChagned = false;
        }

        /// <summary>
		/// 콤보박스 초기설정
		/// </summary>
		private void InitCombo()
        {
            ComboHelper.InitComboBox(cboMenuType, "MENUTYPE", false, true);
        }

       
    }
}
