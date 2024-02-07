namespace _05.Business
{
    partial class frmPopup
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
			this.pnlContainer.SuspendLayout();
			this.pnlTitleBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlContainer
			// 
			this.pnlContainer.Size = new System.Drawing.Size(819, 515);
			// 
			// pnlTitleBar
			// 
			this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
			this.pnlTitleBar.Size = new System.Drawing.Size(819, 50);
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.Location = new System.Drawing.Point(769, 0);
			// 
			// btnMinimize
			// 
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.Location = new System.Drawing.Point(719, 0);
			// 
			// frmPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.ClientSize = new System.Drawing.Size(823, 519);
			this.Name = "frmPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.pnlContainer.ResumeLayout(false);
			this.pnlTitleBar.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
    }
}
