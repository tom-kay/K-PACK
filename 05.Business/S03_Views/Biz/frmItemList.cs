using log4net;
using P01_K_DESIGN_WIN;
using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S01_Models.Dto.Biz;
using P05_Business.S02_Controllers.Biz;
using P05_Business.S03_Views.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Biz
{
    public partial class frmItemList : frmSearchContainer
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        ItemMngController ctrl;

        public frmItemList()
        {
            InitializeComponent();

            ctrl = new ItemMngController();

            Set_Menu_Button(new EditButtonSettings { isPrint = false, isNew = false });

            //그리드 생성
            CreateGrid();
        }

        private void frmItemList_Load(object sender, EventArgs e)
        {

        }

        private void btnInit_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, System.EventArgs e)
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

        private void dgvList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.ColumnIndex == dgvList.Columns["GroupCode"].Index)
                {
                    string code = dgvList.Rows[e.RowIndex].Cells["GroupCode"].Value.ToString();

                    frmItemMng frm = new frmItemMng(code);

                    AccessMain.OpenChildForm(frm);
                } 
            }
            else if (e.Button == MouseButtons.Right)
            {
                ToolStripMenuItem copyItem = new ToolStripMenuItem("Cell Copy");
                copyItem.Click += (s, ev) =>
                {
                    Clipboard.SetText(dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                };

                ContextMenuStrip m = new ContextMenuStrip();
                m.Items.Add(copyItem);

                m.Show(Cursor.Position);

            }
        }

        private void CreateGrid()
        {
            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill);
            UserDataGrid.AddLinkColumn(dgvList, "GroupCode", "제품군코드", true, true, 20, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "GroupName", "제품군명", true, true, 50, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "AliasName", "제품군약어", true, true, 30, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "DefaultEachUnitName", "제품단위", true, true, 10, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "DefaultPackingUnitName", "포장단위", true, true, 10, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "DelYn", "삭제", true, true, 10, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.End(dgvList);
        }

        private void SearchData()
        {
            ItemGroupDto param = new ItemGroupDto
            {
                GroupCode = txtGroupCode.Texts.Trim(),
                GroupName = txtGroupName.Texts.Trim(),
                AliasName = txtAliasName.Texts.Trim(),
            };

            List<ItemGroupDto> list = ctrl.GetItemGroupList(param);

            dgvList.DataSource = list;
        }
    }
}
