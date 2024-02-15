namespace P05_Business.S03_Views.Base
{
	partial class frmMenuMasterMng
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
			this.btnDelete = new P02_K_CONTROL_WIN.KButton();
			this.btnSave = new P02_K_CONTROL_WIN.KButton();
			this.pnlMain.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			this.pnlHeaderBtns.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHeaderBtns
			// 
			this.pnlHeaderBtns.Controls.Add(this.btnSave);
			this.pnlHeaderBtns.Controls.Add(this.btnDelete);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
			this.btnDelete.BackgroundColor = System.Drawing.Color.IndianRed;
			this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnDelete.BorderRadius = 0;
			this.btnDelete.BorderSize = 0;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(171, 10);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(70, 30);
			this.btnDelete.TabIndex = 0;
			this.btnDelete.Text = "삭제";
			this.btnDelete.TextColor = System.Drawing.Color.White;
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
			this.btnSave.BackgroundColor = System.Drawing.Color.SeaGreen;
			this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnSave.BorderRadius = 0;
			this.btnSave.BorderSize = 0;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(95, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(70, 30);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "저장";
			this.btnSave.TextColor = System.Drawing.Color.White;
			this.btnSave.UseVisualStyleBackColor = false;
			// 
			// frmMenuMasterMng
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "frmMenuMasterMng";
			this.Text = "메뉴관리";
			this.pnlMain.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeaderBtns.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private P02_K_CONTROL_WIN.KButton btnDelete;
		private P02_K_CONTROL_WIN.KButton btnSave;
	}
}
