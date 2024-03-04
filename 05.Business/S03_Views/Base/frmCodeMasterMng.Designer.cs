namespace P05_Business.S03_Views.Base
{
	partial class frmCodeMasterMng
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
			this.panPart1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.rdoN = new P02_K_CONTROL_WIN.KRadioButton();
			this.rdoY = new P02_K_CONTROL_WIN.KRadioButton();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtName = new P02_K_CONTROL_WIN.KTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtCode = new P02_K_CONTROL_WIN.KTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.txtRemark = new P02_K_CONTROL_WIN.KTextBox();
			this.pnlMain.SuspendLayout();
			this.pnlBody.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			this.pnlHeaderBtns.SuspendLayout();
			this.pnlPrint.SuspendLayout();
			this.pnlSave.SuspendLayout();
			this.pnlDelete.SuspendLayout();
			this.pnlClose.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			this.pnlInit.SuspendLayout();
			this.panPart1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBody
			// 
			this.pnlBody.Controls.Add(this.panPart1);
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
			// panPart1
			// 
			this.panPart1.AutoSize = true;
			this.panPart1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.panPart1.ColumnCount = 2;
			this.panPart1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.panPart1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.panPart1.Controls.Add(this.panel6, 1, 2);
			this.panPart1.Controls.Add(this.panel5, 0, 2);
			this.panPart1.Controls.Add(this.panel4, 1, 1);
			this.panPart1.Controls.Add(this.panel1, 0, 0);
			this.panPart1.Controls.Add(this.panel2, 1, 0);
			this.panPart1.Controls.Add(this.panel3, 0, 1);
			this.panPart1.Controls.Add(this.panel7, 0, 3);
			this.panPart1.Controls.Add(this.panel8, 1, 3);
			this.panPart1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panPart1.Location = new System.Drawing.Point(0, 10);
			this.panPart1.Name = "panPart1";
			this.panPart1.RowCount = 4;
			this.panPart1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.panPart1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.panPart1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.panPart1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.panPart1.Size = new System.Drawing.Size(1008, 145);
			this.panPart1.TabIndex = 0;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Controls.Add(this.rdoN);
			this.panel6.Controls.Add(this.rdoY);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(105, 76);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(899, 29);
			this.panel6.TabIndex = 2;
			// 
			// rdoN
			// 
			this.rdoN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.rdoN.AutoSize = true;
			this.rdoN.CheckedColor = System.Drawing.Color.DarkCyan;
			this.rdoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.rdoN.Location = new System.Drawing.Point(64, 2);
			this.rdoN.MinimumSize = new System.Drawing.Size(0, 21);
			this.rdoN.Name = "rdoN";
			this.rdoN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.rdoN.Size = new System.Drawing.Size(48, 24);
			this.rdoN.TabIndex = 1;
			this.rdoN.TabStop = true;
			this.rdoN.Tag = "UseYn|N";
			this.rdoN.Text = "N";
			this.rdoN.UnCheckedColor = System.Drawing.Color.Gray;
			this.rdoN.UseVisualStyleBackColor = true;
			// 
			// rdoY
			// 
			this.rdoY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.rdoY.AutoSize = true;
			this.rdoY.Checked = true;
			this.rdoY.CheckedColor = System.Drawing.Color.DarkCyan;
			this.rdoY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.rdoY.Location = new System.Drawing.Point(9, 2);
			this.rdoY.MinimumSize = new System.Drawing.Size(0, 21);
			this.rdoY.Name = "rdoY";
			this.rdoY.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.rdoY.Size = new System.Drawing.Size(48, 24);
			this.rdoY.TabIndex = 0;
			this.rdoY.TabStop = true;
			this.rdoY.Tag = "UseYn|Y";
			this.rdoY.Text = "Y";
			this.rdoY.UnCheckedColor = System.Drawing.Color.Gray;
			this.rdoY.UseVisualStyleBackColor = true;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.DarkCyan;
			this.panel5.Controls.Add(this.label3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(4, 76);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(94, 29);
			this.panel5.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 29);
			this.label3.TabIndex = 1;
			this.label3.Text = "USE Y/N";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.txtName);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(105, 40);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(899, 29);
			this.panel4.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.BackColor = System.Drawing.SystemColors.Window;
			this.txtName.BorderColor = System.Drawing.Color.White;
			this.txtName.BorderFocusColor = System.Drawing.Color.White;
			this.txtName.BorderRadius = 0;
			this.txtName.BorderSize = 2;
			this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtName.Location = new System.Drawing.Point(3, 4);
			this.txtName.MaxLength = 32767;
			this.txtName.Multiline = false;
			this.txtName.Name = "txtName";
			this.txtName.PasswordChar = false;
			this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtName.PlaceholderText = "";
			this.txtName.ReadOnly = false;
			this.txtName.Size = new System.Drawing.Size(893, 21);
			this.txtName.TabIndex = 0;
			this.txtName.Tag = "Name";
			this.txtName.Texts = "";
			this.txtName.UnderlinedStyle = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkCyan;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(94, 29);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "CODE";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.txtCode);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(105, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(899, 29);
			this.panel2.TabIndex = 0;
			// 
			// txtCode
			// 
			this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCode.BackColor = System.Drawing.SystemColors.Window;
			this.txtCode.BorderColor = System.Drawing.Color.White;
			this.txtCode.BorderFocusColor = System.Drawing.Color.White;
			this.txtCode.BorderRadius = 0;
			this.txtCode.BorderSize = 2;
			this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCode.Location = new System.Drawing.Point(3, 4);
			this.txtCode.MaxLength = 32767;
			this.txtCode.Multiline = false;
			this.txtCode.Name = "txtCode";
			this.txtCode.PasswordChar = false;
			this.txtCode.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtCode.PlaceholderText = "";
			this.txtCode.ReadOnly = false;
			this.txtCode.Size = new System.Drawing.Size(893, 21);
			this.txtCode.TabIndex = 0;
			this.txtCode.Tag = "Code";
			this.txtCode.Texts = "";
			this.txtCode.UnderlinedStyle = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkCyan;
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(4, 40);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(94, 29);
			this.panel3.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "NAME";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.label4);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(4, 112);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(94, 29);
			this.panel7.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 29);
			this.label4.TabIndex = 2;
			this.label4.Text = "REMARK";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.White;
			this.panel8.Controls.Add(this.txtRemark);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(105, 112);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(899, 29);
			this.panel8.TabIndex = 3;
			// 
			// txtRemark
			// 
			this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRemark.BackColor = System.Drawing.SystemColors.Window;
			this.txtRemark.BorderColor = System.Drawing.Color.White;
			this.txtRemark.BorderFocusColor = System.Drawing.Color.White;
			this.txtRemark.BorderRadius = 0;
			this.txtRemark.BorderSize = 2;
			this.txtRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtRemark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtRemark.Location = new System.Drawing.Point(3, 4);
			this.txtRemark.MaxLength = 32767;
			this.txtRemark.Multiline = false;
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.PasswordChar = false;
			this.txtRemark.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtRemark.PlaceholderText = "";
			this.txtRemark.ReadOnly = false;
			this.txtRemark.Size = new System.Drawing.Size(893, 21);
			this.txtRemark.TabIndex = 0;
			this.txtRemark.Tag = "Remark";
			this.txtRemark.Texts = "";
			this.txtRemark.UnderlinedStyle = false;
			// 
			// frmCodeMasterMng
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Name = "frmCodeMasterMng";
			this.Text = "코드관리";
			this.Load += new System.EventHandler(this.frmCodeMasterMng_Load);
			this.pnlMain.ResumeLayout(false);
			this.pnlBody.ResumeLayout(false);
			this.pnlBody.PerformLayout();
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeaderBtns.ResumeLayout(false);
			this.pnlPrint.ResumeLayout(false);
			this.pnlSave.ResumeLayout(false);
			this.pnlDelete.ResumeLayout(false);
			this.pnlClose.ResumeLayout(false);
			this.pnlSearch.ResumeLayout(false);
			this.pnlInit.ResumeLayout(false);
			this.panPart1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel panPart1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private P02_K_CONTROL_WIN.KTextBox txtCode;
		private P02_K_CONTROL_WIN.KTextBox txtName;
		private P02_K_CONTROL_WIN.KRadioButton rdoN;
		private P02_K_CONTROL_WIN.KRadioButton rdoY;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel8;
		private P02_K_CONTROL_WIN.KTextBox txtRemark;
	}
}
