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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnMenu0 = new P02_K_CONTROL_WIN.KButton();
			this.drm0 = new P02_K_CONTROL_WIN.KDropdownMenu(this.components);
			this.그래프ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.그래프ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlMainContainer.SuspendLayout();
			this.pnlTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
			this.panelSubMenuBar.SuspendLayout();
			this.pnlBottomBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximum)).BeginInit();
			this.pnlHeader.SuspendLayout();
			this.pnlBody.SuspendLayout();
			this.drm0.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSubMenuBar
			// 
			this.panelSubMenuBar.Controls.Add(this.btnMenu0);
			this.panelSubMenuBar.Controls.SetChildIndex(this.btnCloseChildForm, 0);
			this.panelSubMenuBar.Controls.SetChildIndex(this.btnMenu0, 0);
			// 
			// lblTime
			// 
			this.lblTime.Text = "15:56:06";
			// 
			// lblDate
			// 
			this.lblDate.Size = new System.Drawing.Size(147, 20);
			this.lblDate.Text = "2024년 2월 8일 목요일";
			// 
			// btnCloseChildForm
			// 
			this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
			// 
			// btnMenu0
			// 
			this.btnMenu0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
			this.btnMenu0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
			this.btnMenu0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
			this.btnMenu0.BorderRadius = 0;
			this.btnMenu0.BorderSize = 0;
			this.btnMenu0.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnMenu0.FlatAppearance.BorderSize = 0;
			this.btnMenu0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenu0.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnMenu0.ForeColor = System.Drawing.Color.White;
			this.btnMenu0.Location = new System.Drawing.Point(0, 0);
			this.btnMenu0.Name = "btnMenu0";
			this.btnMenu0.Size = new System.Drawing.Size(200, 43);
			this.btnMenu0.TabIndex = 9;
			this.btnMenu0.Text = "DASHBOARD";
			this.btnMenu0.TextColor = System.Drawing.Color.White;
			this.btnMenu0.UseVisualStyleBackColor = false;
			// 
			// drm0
			// 
			this.drm0.IsMainMenu = false;
			this.drm0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그래프ToolStripMenuItem});
			this.drm0.MenuItemHeight = 25;
			this.drm0.MenuItemTextColor = System.Drawing.Color.Empty;
			this.drm0.Name = "drm0";
			this.drm0.PrimaryColor = System.Drawing.Color.Empty;
			this.drm0.Size = new System.Drawing.Size(99, 26);
			// 
			// 그래프ToolStripMenuItem
			// 
			this.그래프ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그래프ToolStripMenuItem1});
			this.그래프ToolStripMenuItem.Name = "그래프ToolStripMenuItem";
			this.그래프ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.그래프ToolStripMenuItem.Text = "막대";
			// 
			// 그래프ToolStripMenuItem1
			// 
			this.그래프ToolStripMenuItem1.Name = "그래프ToolStripMenuItem1";
			this.그래프ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.그래프ToolStripMenuItem1.Text = "그래프";
			this.그래프ToolStripMenuItem1.Click += new System.EventHandler(this.그래프ToolStripMenuItem1_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SOODAL";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.Controls.SetChildIndex(this.pnlMainContainer, 0);
			this.pnlMainContainer.ResumeLayout(false);
			this.pnlMainContainer.PerformLayout();
			this.pnlTitleBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnMinimum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
			this.panelSubMenuBar.ResumeLayout(false);
			this.pnlBottomBar.ResumeLayout(false);
			this.pnlBottomBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximum)).EndInit();
			this.pnlHeader.ResumeLayout(false);
			this.pnlBody.ResumeLayout(false);
			this.drm0.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private KButton btnMenu0;
		private KDropdownMenu drm0;
		private System.Windows.Forms.ToolStripMenuItem 그래프ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 그래프ToolStripMenuItem1;
	}
}

