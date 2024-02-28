namespace P05_Business.S03_Views.Base
{
	partial class frmCodeMasterList
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtCode = new P02_K_CONTROL_WIN.KTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtName = new P02_K_CONTROL_WIN.KTextBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.rdoUseN = new MetroFramework.Controls.MetroRadioButton();
			this.rdoUseY = new MetroFramework.Controls.MetroRadioButton();
			this.rdoUseA = new MetroFramework.Controls.MetroRadioButton();
			this.panel8 = new System.Windows.Forms.Panel();
			this.rdoDelN = new MetroFramework.Controls.MetroRadioButton();
			this.rdoDelY = new MetroFramework.Controls.MetroRadioButton();
			this.rdoDelA = new MetroFramework.Controls.MetroRadioButton();
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.pnlClose.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			this.pnlInit.SuspendLayout();
			this.pnlPrint.SuspendLayout();
			this.pnlBody.SuspendLayout();
			this.pnlSearchMain.SuspendLayout();
			this.pnlSearchButtonBar.SuspendLayout();
			this.pnlButtons.SuspendLayout();
			this.pnlSearchOptional.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.SuspendLayout();
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
			// btnPrint
			// 
			this.btnPrint.FlatAppearance.BorderSize = 0;
			// 
			// pnlBody
			// 
			this.pnlBody.Controls.Add(this.dgvList);
			this.pnlBody.Location = new System.Drawing.Point(0, 90);
			this.pnlBody.Size = new System.Drawing.Size(1008, 639);
			// 
			// pnlSearchOptional
			// 
			this.pnlSearchOptional.AutoSize = true;
			this.pnlSearchOptional.Controls.Add(this.tableLayoutPanel1);
			this.pnlSearchOptional.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
			this.pnlSearchOptional.Size = new System.Drawing.Size(1008, 55);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 8;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel5, 6, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel6, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel7, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel8, 7, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 35);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(114, 29);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "CODE";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.txtCode);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(123, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(126, 29);
			this.panel2.TabIndex = 1;
			// 
			// txtCode
			// 
			this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCode.BackColor = System.Drawing.SystemColors.Window;
			this.txtCode.BorderColor = System.Drawing.SystemColors.Window;
			this.txtCode.BorderFocusColor = System.Drawing.SystemColors.Window;
			this.txtCode.BorderRadius = 0;
			this.txtCode.BorderSize = 2;
			this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCode.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
			this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCode.Location = new System.Drawing.Point(3, 3);
			this.txtCode.Multiline = false;
			this.txtCode.Name = "txtCode";
			this.txtCode.PasswordChar = false;
			this.txtCode.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtCode.PlaceholderText = "";
			this.txtCode.ReadOnly = false;
			this.txtCode.Size = new System.Drawing.Size(120, 22);
			this.txtCode.TabIndex = 0;
			this.txtCode.Texts = "";
			this.txtCode.UnderlinedStyle = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(255, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(114, 29);
			this.panel3.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "NAME";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(507, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(114, 29);
			this.panel4.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 29);
			this.label3.TabIndex = 1;
			this.label3.Text = "USE Y/N";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label4);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(759, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(114, 29);
			this.panel5.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 29);
			this.label4.TabIndex = 1;
			this.label4.Text = "DELETE Y/N";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.Window;
			this.panel6.Controls.Add(this.txtName);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(375, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(126, 29);
			this.panel6.TabIndex = 5;
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.BackColor = System.Drawing.SystemColors.Window;
			this.txtName.BorderColor = System.Drawing.SystemColors.Window;
			this.txtName.BorderFocusColor = System.Drawing.SystemColors.Window;
			this.txtName.BorderRadius = 0;
			this.txtName.BorderSize = 2;
			this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtName.Location = new System.Drawing.Point(3, 3);
			this.txtName.Multiline = false;
			this.txtName.Name = "txtName";
			this.txtName.PasswordChar = false;
			this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtName.PlaceholderText = "";
			this.txtName.ReadOnly = false;
			this.txtName.Size = new System.Drawing.Size(120, 22);
			this.txtName.TabIndex = 1;
			this.txtName.Texts = "";
			this.txtName.UnderlinedStyle = false;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.rdoUseN);
			this.panel7.Controls.Add(this.rdoUseY);
			this.panel7.Controls.Add(this.rdoUseA);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(627, 3);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(126, 29);
			this.panel7.TabIndex = 6;
			// 
			// rdoUseN
			// 
			this.rdoUseN.AutoSize = true;
			this.rdoUseN.BackColor = System.Drawing.Color.Transparent;
			this.rdoUseN.Dock = System.Windows.Forms.DockStyle.Left;
			this.rdoUseN.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.rdoUseN.Location = new System.Drawing.Point(81, 0);
			this.rdoUseN.Name = "rdoUseN";
			this.rdoUseN.Size = new System.Drawing.Size(35, 29);
			this.rdoUseN.TabIndex = 1;
			this.rdoUseN.Text = "N";
			this.rdoUseN.UseCustomBackColor = true;
			this.rdoUseN.UseSelectable = true;
			// 
			// rdoUseY
			// 
			this.rdoUseY.AutoSize = true;
			this.rdoUseY.BackColor = System.Drawing.Color.Transparent;
			this.rdoUseY.Dock = System.Windows.Forms.DockStyle.Left;
			this.rdoUseY.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.rdoUseY.Location = new System.Drawing.Point(48, 0);
			this.rdoUseY.Name = "rdoUseY";
			this.rdoUseY.Size = new System.Drawing.Size(33, 29);
			this.rdoUseY.TabIndex = 0;
			this.rdoUseY.Text = "Y";
			this.rdoUseY.UseCustomBackColor = true;
			this.rdoUseY.UseSelectable = true;
			// 
			// rdoUseA
			// 
			this.rdoUseA.AutoSize = true;
			this.rdoUseA.BackColor = System.Drawing.Color.Transparent;
			this.rdoUseA.Checked = true;
			this.rdoUseA.Dock = System.Windows.Forms.DockStyle.Left;
			this.rdoUseA.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.rdoUseA.Location = new System.Drawing.Point(0, 0);
			this.rdoUseA.Name = "rdoUseA";
			this.rdoUseA.Size = new System.Drawing.Size(48, 29);
			this.rdoUseA.TabIndex = 2;
			this.rdoUseA.TabStop = true;
			this.rdoUseA.Text = "ALL";
			this.rdoUseA.UseCustomBackColor = true;
			this.rdoUseA.UseSelectable = true;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.rdoDelN);
			this.panel8.Controls.Add(this.rdoDelY);
			this.panel8.Controls.Add(this.rdoDelA);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(879, 3);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(126, 29);
			this.panel8.TabIndex = 7;
			// 
			// rdoDelN
			// 
			this.rdoDelN.AutoSize = true;
			this.rdoDelN.BackColor = System.Drawing.Color.Transparent;
			this.rdoDelN.Dock = System.Windows.Forms.DockStyle.Left;
			this.rdoDelN.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.rdoDelN.Location = new System.Drawing.Point(81, 0);
			this.rdoDelN.Name = "rdoDelN";
			this.rdoDelN.Size = new System.Drawing.Size(35, 29);
			this.rdoDelN.TabIndex = 3;
			this.rdoDelN.Text = "N";
			this.rdoDelN.UseCustomBackColor = true;
			this.rdoDelN.UseSelectable = true;
			// 
			// rdoDelY
			// 
			this.rdoDelY.AutoSize = true;
			this.rdoDelY.BackColor = System.Drawing.Color.Transparent;
			this.rdoDelY.Dock = System.Windows.Forms.DockStyle.Left;
			this.rdoDelY.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.rdoDelY.Location = new System.Drawing.Point(48, 0);
			this.rdoDelY.Name = "rdoDelY";
			this.rdoDelY.Size = new System.Drawing.Size(33, 29);
			this.rdoDelY.TabIndex = 2;
			this.rdoDelY.Text = "Y";
			this.rdoDelY.UseCustomBackColor = true;
			this.rdoDelY.UseSelectable = true;
			// 
			// rdoDelA
			// 
			this.rdoDelA.AutoSize = true;
			this.rdoDelA.BackColor = System.Drawing.Color.Transparent;
			this.rdoDelA.Checked = true;
			this.rdoDelA.Dock = System.Windows.Forms.DockStyle.Left;
			this.rdoDelA.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.rdoDelA.Location = new System.Drawing.Point(0, 0);
			this.rdoDelA.Name = "rdoDelA";
			this.rdoDelA.Size = new System.Drawing.Size(48, 29);
			this.rdoDelA.TabIndex = 4;
			this.rdoDelA.TabStop = true;
			this.rdoDelA.Text = "ALL";
			this.rdoDelA.UseCustomBackColor = true;
			this.rdoDelA.UseSelectable = true;
			// 
			// dgvList
			// 
			this.dgvList.AllowUserToOrderColumns = true;
			this.dgvList.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
			this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvList.ColumnHeadersHeight = 35;
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvList.EnableHeadersVisualStyles = false;
			this.dgvList.Location = new System.Drawing.Point(0, 10);
			this.dgvList.MultiSelect = false;
			this.dgvList.Name = "dgvList";
			this.dgvList.ReadOnly = true;
			this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvList.RowHeadersVisible = false;
			this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvList.RowTemplate.Height = 35;
			this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvList.Size = new System.Drawing.Size(1008, 629);
			this.dgvList.TabIndex = 0;
			this.dgvList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseDoubleClick);
			// 
			// frmCodeMasterList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Name = "frmCodeMasterList";
			this.pnlClose.ResumeLayout(false);
			this.pnlSearch.ResumeLayout(false);
			this.pnlInit.ResumeLayout(false);
			this.pnlPrint.ResumeLayout(false);
			this.pnlBody.ResumeLayout(false);
			this.pnlSearchMain.ResumeLayout(false);
			this.pnlSearchMain.PerformLayout();
			this.pnlSearchButtonBar.ResumeLayout(false);
			this.pnlButtons.ResumeLayout(false);
			this.pnlSearchOptional.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private P02_K_CONTROL_WIN.KTextBox txtCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel6;
		private P02_K_CONTROL_WIN.KTextBox txtName;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private MetroFramework.Controls.MetroRadioButton rdoUseY;
		private MetroFramework.Controls.MetroRadioButton rdoUseN;
		private MetroFramework.Controls.MetroRadioButton rdoDelN;
		private MetroFramework.Controls.MetroRadioButton rdoDelY;
		private System.Windows.Forms.DataGridView dgvList;
		private MetroFramework.Controls.MetroRadioButton rdoUseA;
		private MetroFramework.Controls.MetroRadioButton rdoDelA;
	}
}
