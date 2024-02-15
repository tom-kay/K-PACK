using P02_K_CONTROL_WIN;

namespace P05_Business
{
	partial class frmMain
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("노드2");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("노드4");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("노드6");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("노드5", new System.Windows.Forms.TreeNode[] {
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("노드3", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("노드0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5});
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("노드1");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.trvMenu = new System.Windows.Forms.TreeView();
			this.imgIconList = new System.Windows.Forms.ImageList(this.components);
			this.pnlMainContainer.SuspendLayout();
			this.pnlTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
			this.panelTopMenuBar.SuspendLayout();
			this.panelSubMenuBar.SuspendLayout();
			this.pnlBottomBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximum)).BeginInit();
			this.pnlHeader.SuspendLayout();
			this.pnlBody.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnMinimum
			// 
			this.btnMinimum.Location = new System.Drawing.Point(734, 0);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(794, 0);
			// 
			// btnNormal
			// 
			this.btnNormal.Location = new System.Drawing.Point(764, 0);
			// 
			// panelSubMenuBar
			// 
			this.panelSubMenuBar.Controls.Add(this.trvMenu);
			this.panelSubMenuBar.Controls.SetChildIndex(this.btnCloseChildForm, 0);
			this.panelSubMenuBar.Controls.SetChildIndex(this.trvMenu, 0);
			// 
			// lblTime
			// 
			this.lblTime.Location = new System.Drawing.Point(693, 4);
			this.lblTime.Text = "09:53:22";
			// 
			// lblDate
			// 
			this.lblDate.Location = new System.Drawing.Point(520, 4);
			this.lblDate.Size = new System.Drawing.Size(156, 20);
			this.lblDate.Text = "2024년 2월 15일 목요일";
			// 
			// btnMaximum
			// 
			this.btnMaximum.Location = new System.Drawing.Point(764, 0);
			// 
			// btnCloseChildForm
			// 
			this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
			// 
			// trvMenu
			// 
			this.trvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
			this.trvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.trvMenu.Cursor = System.Windows.Forms.Cursors.Default;
			this.trvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trvMenu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.trvMenu.ForeColor = System.Drawing.Color.White;
			this.trvMenu.ImageKey = "folder_folder.png";
			this.trvMenu.ImageList = this.imgIconList;
			this.trvMenu.Location = new System.Drawing.Point(0, 0);
			this.trvMenu.Name = "trvMenu";
			treeNode1.Name = "노드2";
			treeNode1.Text = "노드2";
			treeNode2.Name = "노드4";
			treeNode2.Text = "노드4";
			treeNode3.Name = "노드6";
			treeNode3.Text = "노드6";
			treeNode4.Name = "노드5";
			treeNode4.Text = "노드5";
			treeNode5.Name = "노드3";
			treeNode5.Text = "노드3";
			treeNode6.ImageKey = "(기본값)";
			treeNode6.Name = "노드0";
			treeNode6.SelectedImageKey = "(기본값)";
			treeNode6.Text = "노드0";
			treeNode7.Name = "노드1";
			treeNode7.Text = "노드1";
			this.trvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
			this.trvMenu.SelectedImageKey = "folder_folder.png";
			this.trvMenu.ShowLines = false;
			this.trvMenu.ShowPlusMinus = false;
			this.trvMenu.ShowRootLines = false;
			this.trvMenu.Size = new System.Drawing.Size(200, 664);
			this.trvMenu.TabIndex = 9;
			this.trvMenu.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.trvMenu_AfterCollapse);
			this.trvMenu.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvMenu_AfterExpand);
			this.trvMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvMenu_NodeMouseDoubleClick);
			// 
			// imgIconList
			// 
			this.imgIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIconList.ImageStream")));
			this.imgIconList.TransparentColor = System.Drawing.Color.Transparent;
			this.imgIconList.Images.SetKeyName(0, "folder_folder.png");
			this.imgIconList.Images.SetKeyName(1, "folder_folder_open_open.png");
			this.imgIconList.Images.SetKeyName(2, "notepad_notepad.png");
			this.imgIconList.Images.SetKeyName(3, "print_print.png");
			this.imgIconList.Images.SetKeyName(4, "save_guardar.png");
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "frmMain";
			this.ShowIcon = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.pnlMainContainer.ResumeLayout(false);
			this.pnlMainContainer.PerformLayout();
			this.pnlTitleBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnMinimum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
			this.panelTopMenuBar.ResumeLayout(false);
			this.panelSubMenuBar.ResumeLayout(false);
			this.pnlBottomBar.ResumeLayout(false);
			this.pnlBottomBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximum)).EndInit();
			this.pnlHeader.ResumeLayout(false);
			this.pnlBody.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView trvMenu;
		private System.Windows.Forms.ImageList imgIconList;
	}
}

