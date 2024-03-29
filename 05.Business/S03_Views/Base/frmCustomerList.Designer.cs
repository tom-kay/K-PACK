namespace P05_Business.S03_Views.Base
{
	partial class frmCustomerList
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtCustCode = new P02_K_CONTROL_WIN.KTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cboNationality = new P02_K_CONTROL_WIN.KComboBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.chkDealGeneral = new MetroFramework.Controls.MetroCheckBox();
			this.chkDealProc = new MetroFramework.Controls.MetroCheckBox();
			this.chkDealBuy = new MetroFramework.Controls.MetroCheckBox();
			this.chkDealSale = new MetroFramework.Controls.MetroCheckBox();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel10 = new System.Windows.Forms.Panel();
			this.txtCustName = new P02_K_CONTROL_WIN.KTextBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel12 = new System.Windows.Forms.Panel();
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
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel12.SuspendLayout();
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
			this.pnlBody.Location = new System.Drawing.Point(0, 125);
			this.pnlBody.Size = new System.Drawing.Size(891, 436);
			// 
			// pnlSearchMain
			// 
			this.pnlSearchMain.Size = new System.Drawing.Size(891, 561);
			// 
			// pnlSearchButtonBar
			// 
			this.pnlSearchButtonBar.Size = new System.Drawing.Size(891, 35);
			// 
			// pnlButtons
			// 
			this.pnlButtons.Location = new System.Drawing.Point(497, 0);
			// 
			// pnlSearchOptional
			// 
			this.pnlSearchOptional.AutoSize = true;
			this.pnlSearchOptional.Controls.Add(this.tableLayoutPanel1);
			this.pnlSearchOptional.Size = new System.Drawing.Size(891, 90);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.81633F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel9, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel10, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel11, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel12, 3, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 70);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(94, 29);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "거래처코드";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtCustCode);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(103, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(255, 29);
			this.panel2.TabIndex = 1;
			// 
			// txtCustCode
			// 
			this.txtCustCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCustCode.BackColor = System.Drawing.SystemColors.Window;
			this.txtCustCode.BorderColor = System.Drawing.Color.Empty;
			this.txtCustCode.BorderFocusColor = System.Drawing.Color.Empty;
			this.txtCustCode.BorderRadius = 0;
			this.txtCustCode.BorderSize = 2;
			this.txtCustCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCustCode.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCustCode.Location = new System.Drawing.Point(3, 3);
			this.txtCustCode.MaxLength = 32767;
			this.txtCustCode.Multiline = false;
			this.txtCustCode.Name = "txtCustCode";
			this.txtCustCode.OnlyNumber = false;
			this.txtCustCode.PasswordChar = false;
			this.txtCustCode.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtCustCode.PlaceholderText = "";
			this.txtCustCode.ReadOnly = false;
			this.txtCustCode.Size = new System.Drawing.Size(249, 22);
			this.txtCustCode.TabIndex = 0;
			this.txtCustCode.Tag = "CustCode";
			this.txtCustCode.Texts = "";
			this.txtCustCode.UnderlinedStyle = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(725, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(44, 29);
			this.panel3.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "국가";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.cboNationality);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(775, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(113, 29);
			this.panel4.TabIndex = 5;
			// 
			// cboNationality
			// 
			this.cboNationality.BackColor = System.Drawing.Color.PowderBlue;
			this.cboNationality.BorderColor = System.Drawing.Color.Transparent;
			this.cboNationality.BorderSize = 1;
			this.cboNationality.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
			this.cboNationality.Font = new System.Drawing.Font("굴림", 10F);
			this.cboNationality.ForeColor = System.Drawing.Color.DimGray;
			this.cboNationality.IconColor = System.Drawing.Color.Navy;
			this.cboNationality.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
			this.cboNationality.ListTextColor = System.Drawing.Color.DimGray;
			this.cboNationality.Location = new System.Drawing.Point(0, 0);
			this.cboNationality.Name = "cboNationality";
			this.cboNationality.Padding = new System.Windows.Forms.Padding(1);
			this.cboNationality.Size = new System.Drawing.Size(113, 29);
			this.cboNationality.TabIndex = 0;
			this.cboNationality.Tag = "Nationality";
			this.cboNationality.Texts = "";
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.label4);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(3, 38);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(94, 29);
			this.panel7.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 29);
			this.label4.TabIndex = 2;
			this.label4.Text = "거래구분";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.chkDealGeneral);
			this.panel8.Controls.Add(this.chkDealProc);
			this.panel8.Controls.Add(this.chkDealBuy);
			this.panel8.Controls.Add(this.chkDealSale);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(103, 38);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(255, 29);
			this.panel8.TabIndex = 7;
			// 
			// chkDealGeneral
			// 
			this.chkDealGeneral.AutoSize = true;
			this.chkDealGeneral.BackColor = System.Drawing.Color.Transparent;
			this.chkDealGeneral.Checked = true;
			this.chkDealGeneral.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDealGeneral.Dock = System.Windows.Forms.DockStyle.Left;
			this.chkDealGeneral.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.chkDealGeneral.Location = new System.Drawing.Point(173, 0);
			this.chkDealGeneral.Name = "chkDealGeneral";
			this.chkDealGeneral.Size = new System.Drawing.Size(53, 29);
			this.chkDealGeneral.TabIndex = 3;
			this.chkDealGeneral.Text = "일반";
			this.chkDealGeneral.UseCustomBackColor = true;
			this.chkDealGeneral.UseSelectable = true;
			// 
			// chkDealProc
			// 
			this.chkDealProc.AutoSize = true;
			this.chkDealProc.BackColor = System.Drawing.Color.Transparent;
			this.chkDealProc.Checked = true;
			this.chkDealProc.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDealProc.Dock = System.Windows.Forms.DockStyle.Left;
			this.chkDealProc.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.chkDealProc.Location = new System.Drawing.Point(106, 0);
			this.chkDealProc.Name = "chkDealProc";
			this.chkDealProc.Size = new System.Drawing.Size(67, 29);
			this.chkDealProc.TabIndex = 2;
			this.chkDealProc.Text = "임가공";
			this.chkDealProc.UseCustomBackColor = true;
			this.chkDealProc.UseSelectable = true;
			// 
			// chkDealBuy
			// 
			this.chkDealBuy.AutoSize = true;
			this.chkDealBuy.BackColor = System.Drawing.Color.Transparent;
			this.chkDealBuy.Checked = true;
			this.chkDealBuy.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDealBuy.Dock = System.Windows.Forms.DockStyle.Left;
			this.chkDealBuy.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.chkDealBuy.Location = new System.Drawing.Point(53, 0);
			this.chkDealBuy.Name = "chkDealBuy";
			this.chkDealBuy.Size = new System.Drawing.Size(53, 29);
			this.chkDealBuy.TabIndex = 1;
			this.chkDealBuy.Text = "매입";
			this.chkDealBuy.UseCustomBackColor = true;
			this.chkDealBuy.UseSelectable = true;
			// 
			// chkDealSale
			// 
			this.chkDealSale.AutoSize = true;
			this.chkDealSale.BackColor = System.Drawing.Color.Transparent;
			this.chkDealSale.Checked = true;
			this.chkDealSale.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDealSale.Dock = System.Windows.Forms.DockStyle.Left;
			this.chkDealSale.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
			this.chkDealSale.Location = new System.Drawing.Point(0, 0);
			this.chkDealSale.Name = "chkDealSale";
			this.chkDealSale.Size = new System.Drawing.Size(53, 29);
			this.chkDealSale.TabIndex = 0;
			this.chkDealSale.Text = "매출";
			this.chkDealSale.UseCustomBackColor = true;
			this.chkDealSale.UseSelectable = true;
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.label5);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(364, 3);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(94, 29);
			this.panel9.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 29);
			this.label5.TabIndex = 2;
			this.label5.Text = "거래처명";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.Transparent;
			this.panel10.Controls.Add(this.txtCustName);
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(464, 3);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(255, 29);
			this.panel10.TabIndex = 3;
			// 
			// txtCustName
			// 
			this.txtCustName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCustName.BackColor = System.Drawing.SystemColors.Window;
			this.txtCustName.BorderColor = System.Drawing.Color.Empty;
			this.txtCustName.BorderFocusColor = System.Drawing.Color.Empty;
			this.txtCustName.BorderRadius = 0;
			this.txtCustName.BorderSize = 2;
			this.txtCustName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtCustName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCustName.Location = new System.Drawing.Point(3, 3);
			this.txtCustName.MaxLength = 32767;
			this.txtCustName.Multiline = false;
			this.txtCustName.Name = "txtCustName";
			this.txtCustName.OnlyNumber = false;
			this.txtCustName.PasswordChar = false;
			this.txtCustName.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtCustName.PlaceholderText = "";
			this.txtCustName.ReadOnly = false;
			this.txtCustName.Size = new System.Drawing.Size(249, 22);
			this.txtCustName.TabIndex = 0;
			this.txtCustName.Tag = "CustName";
			this.txtCustName.Texts = "";
			this.txtCustName.UnderlinedStyle = false;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.label3);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel11.Location = new System.Drawing.Point(364, 38);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(94, 29);
			this.panel11.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "DEL Y/N";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.rdoDelN);
			this.panel12.Controls.Add(this.rdoDelY);
			this.panel12.Controls.Add(this.rdoDelA);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel12.Location = new System.Drawing.Point(464, 38);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(255, 29);
			this.panel12.TabIndex = 9;
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
			this.rdoDelN.TabIndex = 2;
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
			this.rdoDelY.TabIndex = 1;
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
			this.rdoDelA.TabIndex = 0;
			this.rdoDelA.TabStop = true;
			this.rdoDelA.Text = "ALL";
			this.rdoDelA.UseCustomBackColor = true;
			this.rdoDelA.UseSelectable = true;
			// 
			// dgvList
			// 
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvList.Location = new System.Drawing.Point(0, 10);
			this.dgvList.Name = "dgvList";
			this.dgvList.RowTemplate.Height = 23;
			this.dgvList.Size = new System.Drawing.Size(891, 426);
			this.dgvList.TabIndex = 0;
			this.dgvList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseDoubleClick);
			// 
			// frmCustomerList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 561);
			this.Name = "frmCustomerList";
			this.Text = "거래처조회";
			this.Load += new System.EventHandler(this.frmCustomerList_Load);
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
			this.pnlSearchOptional.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.panel12.ResumeLayout(false);
			this.panel12.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private P02_K_CONTROL_WIN.KComboBox cboNationality;
		private System.Windows.Forms.DataGridView dgvList;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel8;
		private MetroFramework.Controls.MetroCheckBox chkDealGeneral;
		private MetroFramework.Controls.MetroCheckBox chkDealProc;
		private MetroFramework.Controls.MetroCheckBox chkDealBuy;
		private MetroFramework.Controls.MetroCheckBox chkDealSale;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel10;
		private P02_K_CONTROL_WIN.KTextBox txtCustName;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel12;
		private MetroFramework.Controls.MetroRadioButton rdoDelN;
		private MetroFramework.Controls.MetroRadioButton rdoDelY;
		private MetroFramework.Controls.MetroRadioButton rdoDelA;
		private P02_K_CONTROL_WIN.KTextBox txtCustCode;
	}
}