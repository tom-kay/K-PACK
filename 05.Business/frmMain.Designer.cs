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
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("노드2");
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("노드4");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("노드6");
			System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("노드5", new System.Windows.Forms.TreeNode[] {
            treeNode10});
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("노드3", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode11});
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("노드0", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode12});
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("노드1");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.trvMenu = new System.Windows.Forms.TreeView();
			this.imgIconList = new System.Windows.Forms.ImageList(this.components);
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.pnlMainContainer.SuspendLayout();
			this.pnlTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
			this.panelTopMenuBar.SuspendLayout();
			this.panelLogo.SuspendLayout();
			this.panelSubMenuBar.SuspendLayout();
			this.pnlBottomBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximum)).BeginInit();
			this.pnlHeader.SuspendLayout();
			this.pnlBody.SuspendLayout();
			this.pnlDesktop.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.picLogo);
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
			this.lblTime.Text = "13:37:55";
			// 
			// lblDate
			// 
			this.lblDate.Location = new System.Drawing.Point(520, 4);
			this.lblDate.Size = new System.Drawing.Size(156, 20);
			this.lblDate.Text = "2024년 2월 21일 수요일";
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
			treeNode8.Name = "노드2";
			treeNode8.Text = "노드2";
			treeNode9.Name = "노드4";
			treeNode9.Text = "노드4";
			treeNode10.Name = "노드6";
			treeNode10.Text = "노드6";
			treeNode11.Name = "노드5";
			treeNode11.Text = "노드5";
			treeNode12.Name = "노드3";
			treeNode12.Text = "노드3";
			treeNode13.ImageKey = "(기본값)";
			treeNode13.Name = "노드0";
			treeNode13.SelectedImageKey = "(기본값)";
			treeNode13.Text = "노드0";
			treeNode14.Name = "노드1";
			treeNode14.Text = "노드1";
			this.trvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
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
			this.imgIconList.Images.SetKeyName(2, "save_guardar.png");
			this.imgIconList.Images.SetKeyName(3, "notepad_notepad.png");
			this.imgIconList.Images.SetKeyName(4, "print_print.png");
			// 
			// picLogo
			// 
			this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picLogo.Location = new System.Drawing.Point(0, 0);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(200, 60);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLogo.TabIndex = 0;
			this.picLogo.TabStop = false;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.pnlMainContainer.ResumeLayout(false);
			this.pnlMainContainer.PerformLayout();
			this.pnlTitleBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnMinimum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
			this.panelTopMenuBar.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelSubMenuBar.ResumeLayout(false);
			this.pnlBottomBar.ResumeLayout(false);
			this.pnlBottomBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximum)).EndInit();
			this.pnlHeader.ResumeLayout(false);
			this.pnlBody.ResumeLayout(false);
			this.pnlDesktop.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView trvMenu;
		private System.Windows.Forms.ImageList imgIconList;
		private System.Windows.Forms.PictureBox picLogo;
	}
}

