﻿namespace P05_Business
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
            this.pnlPopupButtonBar.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlInit.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPopupOptional
            // 
            this.pnlPopupOptional.Size = new System.Drawing.Size(565, 50);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(565, 400);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Size = new System.Drawing.Size(565, 35);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(515, 0);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(465, 0);
            // 
            // pnlBody
            // 
            this.pnlBody.Location = new System.Drawing.Point(0, 120);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBody.Size = new System.Drawing.Size(565, 280);
            // 
            // lblPopupTitle
            // 
            this.lblPopupTitle.Size = new System.Drawing.Size(465, 35);
            // 
            // pnlPopupButtonBar
            // 
            this.pnlPopupButtonBar.Size = new System.Drawing.Size(565, 35);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(158, 0);
            this.pnlButtons.Size = new System.Drawing.Size(407, 35);
            // 
            // pnlInit
            // 
            this.pnlInit.Location = new System.Drawing.Point(245, 0);
            // 
            // btnInit
            // 
            this.btnInit.FlatAppearance.BorderSize = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Location = new System.Drawing.Point(326, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            // 
            // frmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(569, 404);
            this.Name = "frmPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlContainer.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlPopupButtonBar.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlInit.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
