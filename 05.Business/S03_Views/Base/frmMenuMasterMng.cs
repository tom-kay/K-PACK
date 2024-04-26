using P01_K_DESIGN_WIN.Classes;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types.Condition.Types;

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

            CreateMenu();
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
                CreateMenu();
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
                //데이터 검증
                if (string.IsNullOrEmpty(txtParentId.Texts) && string.IsNullOrEmpty(txtParentName.Texts))
                {
                    KMessageBox.Show("등록할 [상위메뉴]를 선택바랍니다.", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cboMenuType.SelectedIndex < 1)
                {
                    KMessageBox.Show("[메뉴타입]을 선택 바랍니다.", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrEmpty(txtMenuName.Texts))
                {
                    KMessageBox.Show("[메뉴명]을 선택 바랍니다.", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrEmpty(txtNamespace.Texts))
                {
                    KMessageBox.Show("[Namespace]를 선택 바랍니다.", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (string.IsNullOrEmpty(txtFormName.Texts))
                {
                    KMessageBox.Show("[화면명]을 선택 바랍니다.", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!rdoUseY.Checked && !rdoUseN.Checked)
                {
                    KMessageBox.Show("[사용유무]를 선택 바랍니다.", "SAVE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //데이터 저장
                ResultCRUD result = this.SaveData();

                //메시지 출력
                if (result == ResultCRUD.SaveSuccessData)
                {
                    MainMessage.Show("저장되었습니다.");
                } 
                else if (result == ResultCRUD.SaveFailData)
                {
                    KMessageBox.Show("저장되지 않았습니다.", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
        
        private void trvMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                //해당 노드의 하위 노드들을 우측 그리드에 바인딩힌다.
                TreeNode node = e.Node;

                string nodeKey = node.Name;

                //하위 노드 조회 호출
                BindChildNodes(nodeKey);
            }
            catch (Exception ex)
            {
                KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (trvMenu.SelectedNode == null)
            {
                KMessageBox.Show("메뉴를 추가할 상위 메뉴를 선택바랍니다.", "신규", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string nodeKey = trvMenu.SelectedNode.Name;
            string nodeText = trvMenu.SelectedNode.Text;
            //root 또는 MenuType = 디렉토리 일 경우에만 하위 메뉴를 추가 할 수 있다.
            if (!string.IsNullOrEmpty(nodeKey))
            {
                MenuMasterDto param = new MenuMasterDto
                {
                    MenuId = nodeKey,
                };

                MenuMasterDto tmp = ctrl.GetMenuMasterSingle(param);

                if (!tmp.MenuType.Equals("D"))
                {
                    KMessageBox.Show("디렉토리 유형만 하위 메뉴를 등록할 수 있습니다.", "신규", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
            }

            //신규 등록시 부모키만 바인딩하고 메뉴키 값은 없는 상태에서 저장시 생성하게 한다.
            dto = new MenuMasterDto()
            {   
                ParentId = nodeKey,
                ParentName = nodeText,
            };

            btnInit.PerformClick();// 컨트롤 초기화

            //컨트롤에 바인딩 하고 그리드 마지막에 신규한 줄 을 추가한다.
            DataHandles.DtoToControls<MenuMasterDto>(this, dto);
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 선택행 데이터 추출
            DataTable dt = GridHelper.GetRowData(dgvList, e.RowIndex);

            // DataTable을 single dto로 변환
            dto = DataHandles.ConvertToData<MenuMasterDto>(dt);

            // dto 값을 control에 바인딩
            DataHandles.DtoToControls<MenuMasterDto>(this, dto);
        }

        private void CreateGrid()
        {
            UserDataGrid.Create(dgvList, DataGridViewAutoSizeColumnsMode.Fill, DataGridViewCellBorderStyle.RaisedHorizontal);
            UserDataGrid.AddTextBoxColumn(dgvList, "ParentId", "상위메뉴", true, false, 1, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddLinkColumn(dgvList, "MenuId", "메뉴ID", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "MenuType", "메뉴유형", true, false, 5, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "MenuTypeName", "메뉴유형", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "MenuName", "메뉴명", true, true, 30, DataGridViewContentAlignment.MiddleLeft);
            UserDataGrid.AddTextBoxColumn(dgvList, "Namespace", "Namespace", true, false, 1, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "FormName", "화면명", true, false, 1, DataGridViewContentAlignment.MiddleCenter);
            UserDataGrid.AddTextBoxColumn(dgvList, "UseYn", "사용유무", true, true, 5, DataGridViewContentAlignment.MiddleCenter);
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

        private void BindChildNodes(string key)
        {
            MenuMasterDto param = new MenuMasterDto { 
                ParentId = key,
            };

            dtoMenus = ctrl.GetMenuMasterChildList(param);

            dgvList.DataSource = null;
            if (dtoMenus.Count > 0)
            {
                DataTable dt = DataHandles.ConvertToDataTable<MenuMasterDto>(dtoMenus);

                dgvList.DataSource = dt;
            }
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

        private void CreateMenu()
        {

            List<MenuMasterDto> menus = ctrl.GetMenuMasterList();

            trvMenu.Nodes.Clear();
            trvMenu.Nodes.Add(string.Empty, "root"); ;

            foreach (var item in menus)
            {

                TreeNode cnode = new TreeNode();
                cnode.Name = item.MenuId;
                cnode.Text = item.MenuName;
                if (!item.MenuType.Equals("D"))
                {
                    cnode.Tag = string.Concat(item.Namespace, ".", item.FormName);
                }

                TreeNode[] pnodes;
                if (item.DepthNo > 1)
                {
                    pnodes = trvMenu.Nodes.Find(item.ParentId, true);
                }
                else
                {
                    pnodes = trvMenu.Nodes.Find(string.Empty, true);
                }
                pnodes[0].Nodes.Add(cnode);
            }

            trvMenu.ExpandAll();
        }

        /// <summary>
        /// 데이터 저장
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private ResultCRUD SaveData()
        {
            MenuMasterDto saveData = DataHandles.ControlsToDto<MenuMasterDto>(this, dto);

            MenuMasterDto param = new MenuMasterDto
            {
                MenuId = saveData.MenuId,
                ParentId = saveData.ParentId,
                MenuName = saveData.MenuName,
                MenuType = saveData.MenuType,
                Namespace = saveData.Namespace,
                FormName = saveData.FormName,
                OrderSeq = dgvList.Rows.Count + 1,
                DepthNo = (txtParentId.Texts.Trim().Length / 3) + 1,
                UseYn = saveData.UseYn,
            };

            //유효성 검사
            //var context = new ValidationContext(param, serviceProvider: null, items: null);
            //Validator.ValidateObject(param, context, validateAllProperties: true);

            bool isSave = ctrl.SaveMenuMaster(param);

            ResultCRUD result = ResultCRUD.None;
            if (isSave)
            {
                result = ResultCRUD.SaveSuccessData;
            }
            else
            {
                result = ResultCRUD.SaveFailData;
            }

            return result;
        }
    }
}

