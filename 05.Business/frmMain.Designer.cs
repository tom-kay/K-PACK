namespace _05.Business
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
            // pnlDesktopPane
            // 
            this.pnlDesktopPane.Size = new System.Drawing.Size(821, 660);
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Size = new System.Drawing.Size(1024, 768);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Size = new System.Drawing.Size(824, 30);
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
            // panelTopMenuBar
            // 
            this.panelTopMenuBar.Size = new System.Drawing.Size(824, 30);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.Location = new System.Drawing.Point(777, 0);
            // 
            // panelSubMenuBar
            // 
            this.panelSubMenuBar.Size = new System.Drawing.Size(200, 708);
            // 
            // pnlBottomBar
            // 
            this.pnlBottomBar.Location = new System.Drawing.Point(203, 684);
            this.pnlBottomBar.Size = new System.Drawing.Size(821, 24);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(725, 4);
            this.lblTime.Text = "16:57:14";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(552, 4);
            this.lblDate.Size = new System.Drawing.Size(156, 20);
            this.lblDate.Text = "2024년 1월 30일 화요일";
            // 
            // btnMaximum
            // 
            this.btnMaximum.Location = new System.Drawing.Point(764, 0);
            // 
            // splMenu
            // 
            this.splMenu.Size = new System.Drawing.Size(3, 708);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Size = new System.Drawing.Size(1024, 60);
            // 
            // pnlBody
            // 
            this.pnlBody.Size = new System.Drawing.Size(1024, 708);
            // 
            // pnlMenuTab
            // 
            this.pnlMenuTab.Location = new System.Drawing.Point(203, 660);
            this.pnlMenuTab.Size = new System.Drawing.Size(821, 24);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOODAL";
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
    }
}

