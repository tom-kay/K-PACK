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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
			this.pnlMain.SuspendLayout();
			this.pnlBody.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			this.pnlHeaderBtns.SuspendLayout();
			this.pnlPrint.SuspendLayout();
			this.pnlSave.SuspendLayout();
			this.pnlDelete.SuspendLayout();
			this.pnlClose.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Size = new System.Drawing.Size(800, 541);
			// 
			// pnlBody
			// 
			this.pnlBody.Controls.Add(this.tableLayoutPanel1);
			this.pnlBody.Size = new System.Drawing.Size(800, 506);
			// 
			// pnlPrint
			// 
			this.pnlPrint.Location = new System.Drawing.Point(122, 0);
			// 
			// btnPrint
			// 
			this.btnPrint.FlatAppearance.BorderSize = 0;
			// 
			// pnlSave
			// 
			this.pnlSave.Location = new System.Drawing.Point(284, 0);
			// 
			// btnSave
			// 
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pnlDelete
			// 
			this.pnlDelete.Location = new System.Drawing.Point(365, 0);
			// 
			// btnDelete
			// 
			this.btnDelete.FlatAppearance.BorderSize = 0;
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			// 
			// pnlSearch
			// 
			this.pnlSearch.Location = new System.Drawing.Point(203, 0);
			// 
			// btnSearch
			// 
			this.btnSearch.FlatAppearance.BorderSize = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 154);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Controls.Add(this.rdoN);
			this.panel6.Controls.Add(this.rdoY);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(205, 106);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(591, 44);
			this.panel6.TabIndex = 5;
			// 
			// rdoN
			// 
			this.rdoN.AutoSize = true;
			this.rdoN.CheckedColor = System.Drawing.Color.DarkCyan;
			this.rdoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.rdoN.Location = new System.Drawing.Point(64, 12);
			this.rdoN.MinimumSize = new System.Drawing.Size(0, 21);
			this.rdoN.Name = "rdoN";
			this.rdoN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.rdoN.Size = new System.Drawing.Size(49, 24);
			this.rdoN.TabIndex = 1;
			this.rdoN.Text = "N";
			this.rdoN.UnCheckedColor = System.Drawing.Color.Gray;
			this.rdoN.UseVisualStyleBackColor = true;
			// 
			// rdoY
			// 
			this.rdoY.AutoSize = true;
			this.rdoY.Checked = true;
			this.rdoY.CheckedColor = System.Drawing.Color.DarkCyan;
			this.rdoY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.rdoY.Location = new System.Drawing.Point(9, 12);
			this.rdoY.MinimumSize = new System.Drawing.Size(0, 21);
			this.rdoY.Name = "rdoY";
			this.rdoY.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.rdoY.Size = new System.Drawing.Size(49, 24);
			this.rdoY.TabIndex = 0;
			this.rdoY.TabStop = true;
			this.rdoY.Text = "Y";
			this.rdoY.UnCheckedColor = System.Drawing.Color.Gray;
			this.rdoY.UseVisualStyleBackColor = true;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.DarkCyan;
			this.panel5.Controls.Add(this.label3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(4, 106);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(194, 44);
			this.panel5.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(194, 44);
			this.label3.TabIndex = 1;
			this.label3.Text = "USE Y/N";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.txtName);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(205, 55);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(591, 44);
			this.panel4.TabIndex = 3;
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.SystemColors.Window;
			this.txtName.BorderColor = System.Drawing.Color.White;
			this.txtName.BorderFocusColor = System.Drawing.Color.White;
			this.txtName.BorderRadius = 0;
			this.txtName.BorderSize = 2;
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtName.Location = new System.Drawing.Point(3, 12);
			this.txtName.Multiline = false;
			this.txtName.Name = "txtName";
			this.txtName.PasswordChar = false;
			this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtName.PlaceholderText = "";
			this.txtName.Size = new System.Drawing.Size(585, 21);
			this.txtName.TabIndex = 1;
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
			this.panel1.Size = new System.Drawing.Size(194, 44);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "CODE";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.txtCode);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(205, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(591, 44);
			this.panel2.TabIndex = 1;
			// 
			// txtCode
			// 
			this.txtCode.BackColor = System.Drawing.SystemColors.Window;
			this.txtCode.BorderColor = System.Drawing.Color.White;
			this.txtCode.BorderFocusColor = System.Drawing.Color.White;
			this.txtCode.BorderRadius = 0;
			this.txtCode.BorderSize = 2;
			this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCode.Location = new System.Drawing.Point(3, 12);
			this.txtCode.Multiline = false;
			this.txtCode.Name = "txtCode";
			this.txtCode.PasswordChar = false;
			this.txtCode.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtCode.PlaceholderText = "";
			this.txtCode.Size = new System.Drawing.Size(585, 21);
			this.txtCode.TabIndex = 0;
			this.txtCode.Texts = "";
			this.txtCode.UnderlinedStyle = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkCyan;
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(4, 55);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(194, 44);
			this.panel3.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 44);
			this.label2.TabIndex = 1;
			this.label2.Text = "NAME";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmCodeMasterMng
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.ClientSize = new System.Drawing.Size(800, 541);
			this.Name = "frmCodeMasterMng";
			this.Text = "코드관리";
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
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
	}
}
