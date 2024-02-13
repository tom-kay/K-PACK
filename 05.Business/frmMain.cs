using P01_K_DESIGN_WIN;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace P05_Business
{
	public partial class frmMain : frmMdiContainer
	{

		private Rectangle sizeGripRectangle;
		protected override void OnPaint(PaintEventArgs e)
		{

			SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
			e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

			base.OnPaint(e);
			ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);

		}

		public frmMain()
		{
			InitializeComponent();

			//frmLogin login = new frmLogin();
			//login.ShowDialog();

			//base.btnMaximum_Click(null, null);

		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			CreateMenu(); //메뉴가져오기
		}

		private void CreateMenu()
		{

			List<MenuMasterDto> menus = new MenuMngController().GetMenuMasterList();

			trvMenu.Nodes.Clear();
			TreeNode tree = new TreeNode();
			foreach (var item in menus)
			{

				TreeNode cnode = new TreeNode();
				cnode.Name = item.MenuId;
				cnode.Text = item.MenuName;
				cnode.Tag = item.FormName;

				//노드 이미지 설정
				switch (item.MenuType)
				{
					case "D": //Directory
						cnode.ImageIndex = cnode.SelectedImageIndex = imgIconList.Images.IndexOfKey("folder_folder.png");
						break;
					case "E": //Editor
						cnode.ImageIndex = cnode.SelectedImageIndex = imgIconList.Images.IndexOfKey("save_guardar.png");
						break;
					case "S": //Search
						cnode.ImageIndex = cnode.SelectedImageIndex = imgIconList.Images.IndexOfKey("notepad_notepad.png");
						break;
					case "P": //Print
						cnode.ImageIndex = cnode.SelectedImageIndex = imgIconList.Images.IndexOfKey("print_print.png");
						break;
				}

				if (item.DepthNo > 1)
				{
					TreeNode[] pnodes = trvMenu.Nodes.Find(item.ParentId, true);
					pnodes[0].Nodes.Add(cnode);
				}
				else
				{
					trvMenu.Nodes.Add(cnode);
				}
			}

		}

		private void trvMenu_AfterExpand(object sender, TreeViewEventArgs e)
		{
			if (e.Node is TreeNode)
			{
				if (e.Node.ImageIndex.Equals(imgIconList.Images.IndexOfKey("folder_folder.png")))
				{
					e.Node.ImageIndex = e.Node.SelectedImageIndex = imgIconList.Images.IndexOfKey("folder_folder_open_open.png"); 
				}
			}
		}

		private void trvMenu_AfterCollapse(object sender, TreeViewEventArgs e)
		{
			if (e.Node is TreeNode)
			{
				if (e.Node.ImageIndex.Equals(imgIconList.Images.IndexOfKey("folder_folder_open_open.png")))
				{
					e.Node.ImageIndex = e.Node.SelectedImageIndex = imgIconList.Images.IndexOfKey("folder_folder.png"); 
				}
			}
		}

	}
}
