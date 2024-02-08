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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.treeView1 = new System.Windows.Forms.TreeView();
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
			this.SuspendLayout();
			// 
			// panelSubMenuBar
			// 
			this.panelSubMenuBar.Controls.Add(this.treeView1);
			this.panelSubMenuBar.Controls.SetChildIndex(this.btnCloseChildForm, 0);
			this.panelSubMenuBar.Controls.SetChildIndex(this.treeView1, 0);
			// 
			// lblTime
			// 
			this.lblTime.Text = "16:58:20";
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
			// treeView1
			// 
			this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
			this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(200, 664);
			this.treeView1.TabIndex = 9;
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
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
	}
}

