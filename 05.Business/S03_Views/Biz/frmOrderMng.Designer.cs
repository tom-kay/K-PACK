namespace P05_Business.S03_Views.Biz
{
    partial class frmOrderMng
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderBtns.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.pnlDelete.SuspendLayout();
            this.pnlClose.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlInit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(800, 561);
            // 
            // pnlBody
            // 
            this.pnlBody.Size = new System.Drawing.Size(800, 526);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Size = new System.Drawing.Size(800, 35);
            // 
            // pnlHeaderBtns
            // 
            this.pnlHeaderBtns.Location = new System.Drawing.Point(263, 0);
            // 
            // pnlHeaderBlank
            // 
            this.pnlHeaderBlank.Size = new System.Drawing.Size(263, 35);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 0;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInit
            // 
            this.btnInit.FlatAppearance.BorderSize = 0;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // frmOrderMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Name = "frmOrderMng";
            this.Text = "발주등록";
            this.Load += new System.EventHandler(this.frmOrderMng_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeaderBtns.ResumeLayout(false);
            this.pnlPrint.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.pnlDelete.ResumeLayout(false);
            this.pnlClose.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlInit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}