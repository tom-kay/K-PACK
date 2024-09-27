namespace P05_Business.S03_Views.Base
{
	partial class frmCodeDetailList
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
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.pnlSearchOptions = new System.Windows.Forms.TableLayoutPanel();
			this.panel12 = new System.Windows.Forms.Panel();
			this.rdoUseN = new MetroFramework.Controls.MetroRadioButton();
			this.rdoUseY = new MetroFramework.Controls.MetroRadioButton();
			this.rdoUseA = new MetroFramework.Controls.MetroRadioButton();
			this.panel11 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.rdoDelN = new MetroFramework.Controls.MetroRadioButton();
			this.rdoDelY = new MetroFramework.Controls.MetroRadioButton();
			this.rdoDelA = new MetroFramework.Controls.MetroRadioButton();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtName = new P02_K_CONTROL_WIN.KTextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtCode = new P02_K_CONTROL_WIN.KTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel33 = new System.Windows.Forms.Panel();
			this.txtMasterName = new P02_K_CONTROL_WIN.KTextBox();
			this.panel32 = new System.Windows.Forms.Panel();
			this.btnFindMasterCode = new System.Windows.Forms.Button();
			this.panel15 = new System.Windows.Forms.Panel();
			this.txtMasterCode = new P02_K_CONTROL_WIN.KTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlClose.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			this.pnlInit.SuspendLayout();
			this.pnlPrint.SuspendLayout();
			this.pnlBody.SuspendLayout();
			this.pnlSearchMain.SuspendLayout();
			this.pnlSearchButtonBar.SuspendLayout();
			this.pnlButtons.SuspendLayout();
			this.pnlSearchOptional.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.pnlSearchOptions.SuspendLayout();
			this.panel12.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel33.SuspendLayout();
			this.panel32.SuspendLayout();
			this.panel15.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.pnlBody.Size = new System.Drawing.Size(1008, 604);
			// 
			// pnlSearchOptional
			// 
			this.pnlSearchOptional.AutoSize = true;
			this.pnlSearchOptional.Controls.Add(this.pnlSearchOptions);
			this.pnlSearchOptional.Size = new System.Drawing.Size(1008, 90);
			// 
			// dgvList
			// 
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvList.Location = new System.Drawing.Point(0, 10);
			this.dgvList.Name = "dgvList";
			this.dgvList.RowTemplate.Height = 23;
			this.dgvList.Size = new System.Drawing.Size(1008, 594);
			this.dgvList.TabIndex = 0;
			this.dgvList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseDoubleClick);
			// 
			// pnlSearchOptions
			// 
			this.pnlSearchOptions.ColumnCount = 6;
			this.pnlSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.pnlSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.pnlSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.pnlSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.pnlSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.pnlSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.pnlSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlSearchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.pnlSearchOptions.Controls.Add(this.panel12, 0, 1);
			this.pnlSearchOptions.Controls.Add(this.panel11, 0, 1);
			this.pnlSearchOptions.Controls.Add(this.panel8, 1, 1);
			this.pnlSearchOptions.Controls.Add(this.panel7, 0, 1);
			this.pnlSearchOptions.Controls.Add(this.panel6, 5, 0);
			this.pnlSearchOptions.Controls.Add(this.panel5, 4, 0);
			this.pnlSearchOptions.Controls.Add(this.panel4, 3, 0);
			this.pnlSearchOptions.Controls.Add(this.panel3, 2, 0);
			this.pnlSearchOptions.Controls.Add(this.panel2, 1, 0);
			this.pnlSearchOptions.Controls.Add(this.panel1, 0, 0);
			this.pnlSearchOptions.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlSearchOptions.Location = new System.Drawing.Point(0, 10);
			this.pnlSearchOptions.Name = "pnlSearchOptions";
			this.pnlSearchOptions.RowCount = 2;
			this.pnlSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.pnlSearchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.pnlSearchOptions.Size = new System.Drawing.Size(1008, 70);
			this.pnlSearchOptions.TabIndex = 0;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.rdoUseN);
			this.panel12.Controls.Add(this.rdoUseY);
			this.panel12.Controls.Add(this.rdoUseA);
			this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel12.Location = new System.Drawing.Point(103, 38);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(230, 29);
			this.panel12.TabIndex = 11;
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
			this.rdoUseN.TabIndex = 5;
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
			this.rdoUseY.TabIndex = 4;
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
			this.rdoUseA.TabIndex = 3;
			this.rdoUseA.TabStop = true;
			this.rdoUseA.Text = "ALL";
			this.rdoUseA.UseCustomBackColor = true;
			this.rdoUseA.UseSelectable = true;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.label4);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel11.Location = new System.Drawing.Point(3, 38);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(94, 29);
			this.panel11.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 29);
			this.label4.TabIndex = 2;
			this.label4.Text = "USE Y/N";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.rdoDelN);
			this.panel8.Controls.Add(this.rdoDelY);
			this.panel8.Controls.Add(this.rdoDelA);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(439, 38);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(230, 29);
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
			this.rdoDelN.TabIndex = 5;
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
			this.rdoDelY.TabIndex = 4;
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
			this.rdoDelA.TabIndex = 3;
			this.rdoDelA.TabStop = true;
			this.rdoDelA.Text = "ALL";
			this.rdoDelA.UseCustomBackColor = true;
			this.rdoDelA.UseSelectable = true;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.label5);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(339, 38);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(94, 29);
			this.panel7.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 29);
			this.label5.TabIndex = 1;
			this.label5.Text = "DEL Y/N";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.txtName);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(775, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(230, 29);
			this.panel6.TabIndex = 5;
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.BackColor = System.Drawing.SystemColors.Window;
			this.txtName.BorderColor = System.Drawing.Color.Empty;
			this.txtName.BorderFocusColor = System.Drawing.Color.Empty;
			this.txtName.BorderRadius = 0;
			this.txtName.BorderSize = 2;
			this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtName.Location = new System.Drawing.Point(3, 3);
			this.txtName.MaxLength = 32767;
			this.txtName.Multiline = false;
			this.txtName.Name = "txtName";
			this.txtName.OnlyNumber = false;
			this.txtName.PasswordChar = false;
			this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtName.PlaceholderText = "";
			this.txtName.ReadOnly = false;
			this.txtName.Size = new System.Drawing.Size(224, 22);
			this.txtName.TabIndex = 0;
			this.txtName.Texts = "";
			this.txtName.UnderlinedStyle = false;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label3);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(675, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(94, 29);
			this.panel5.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 29);
			this.label3.TabIndex = 1;
			this.label3.Text = "NAME";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.txtCode);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(439, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(230, 29);
			this.panel4.TabIndex = 3;
			// 
			// txtCode
			// 
			this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCode.BackColor = System.Drawing.SystemColors.Window;
			this.txtCode.BorderColor = System.Drawing.Color.Empty;
			this.txtCode.BorderFocusColor = System.Drawing.Color.Empty;
			this.txtCode.BorderRadius = 0;
			this.txtCode.BorderSize = 2;
			this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCode.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
			this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCode.Location = new System.Drawing.Point(3, 3);
			this.txtCode.MaxLength = 32767;
			this.txtCode.Multiline = false;
			this.txtCode.Name = "txtCode";
			this.txtCode.OnlyNumber = false;
			this.txtCode.PasswordChar = false;
			this.txtCode.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtCode.PlaceholderText = "";
			this.txtCode.ReadOnly = false;
			this.txtCode.Size = new System.Drawing.Size(224, 22);
			this.txtCode.TabIndex = 0;
			this.txtCode.Texts = "";
			this.txtCode.UnderlinedStyle = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(339, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(94, 29);
			this.panel3.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "CODE";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel33);
			this.panel2.Controls.Add(this.panel32);
			this.panel2.Controls.Add(this.panel15);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(103, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(230, 29);
			this.panel2.TabIndex = 1;
			// 
			// panel33
			// 
			this.panel33.BackColor = System.Drawing.SystemColors.Window;
			this.panel33.Controls.Add(this.txtMasterName);
			this.panel33.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel33.Location = new System.Drawing.Point(129, 0);
			this.panel33.Name = "panel33";
			this.panel33.Size = new System.Drawing.Size(101, 29);
			this.panel33.TabIndex = 102;
			// 
			// txtMasterName
			// 
			this.txtMasterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMasterName.BackColor = System.Drawing.SystemColors.Window;
			this.txtMasterName.BorderColor = System.Drawing.Color.Empty;
			this.txtMasterName.BorderFocusColor = System.Drawing.Color.Empty;
			this.txtMasterName.BorderRadius = 0;
			this.txtMasterName.BorderSize = 2;
			this.txtMasterName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.txtMasterName.Enabled = false;
			this.txtMasterName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMasterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtMasterName.Location = new System.Drawing.Point(3, 3);
			this.txtMasterName.MaxLength = 32767;
			this.txtMasterName.Multiline = false;
			this.txtMasterName.Name = "txtMasterName";
			this.txtMasterName.OnlyNumber = false;
			this.txtMasterName.PasswordChar = false;
			this.txtMasterName.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtMasterName.PlaceholderText = "";
			this.txtMasterName.ReadOnly = false;
			this.txtMasterName.Size = new System.Drawing.Size(95, 22);
			this.txtMasterName.TabIndex = 0;
			this.txtMasterName.Tag = "MasterName";
			this.txtMasterName.Texts = "";
			this.txtMasterName.UnderlinedStyle = false;
			// 
			// panel32
			// 
			this.panel32.Controls.Add(this.btnFindMasterCode);
			this.panel32.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel32.Location = new System.Drawing.Point(100, 0);
			this.panel32.Name = "panel32";
			this.panel32.Size = new System.Drawing.Size(29, 29);
			this.panel32.TabIndex = 101;
			// 
			// btnFindMasterCode
			// 
			this.btnFindMasterCode.BackColor = System.Drawing.Color.PowderBlue;
			this.btnFindMasterCode.BackgroundImage = global::P05_Business.Properties.Resources.search_search;
			this.btnFindMasterCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFindMasterCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnFindMasterCode.Location = new System.Drawing.Point(0, 0);
			this.btnFindMasterCode.Name = "btnFindMasterCode";
			this.btnFindMasterCode.Size = new System.Drawing.Size(29, 29);
			this.btnFindMasterCode.TabIndex = 0;
			this.btnFindMasterCode.Tag = "txtMasterCode";
			this.btnFindMasterCode.UseVisualStyleBackColor = false;
			this.btnFindMasterCode.Click += new System.EventHandler(this.btnFindMasterCode_Click);
			// 
			// panel15
			// 
			this.panel15.BackColor = System.Drawing.SystemColors.Window;
			this.panel15.Controls.Add(this.txtMasterCode);
			this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel15.Location = new System.Drawing.Point(0, 0);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(100, 29);
			this.panel15.TabIndex = 1;
			// 
			// txtMasterCode
			// 
			this.txtMasterCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMasterCode.BackColor = System.Drawing.SystemColors.Window;
			this.txtMasterCode.BorderColor = System.Drawing.Color.Empty;
			this.txtMasterCode.BorderFocusColor = System.Drawing.Color.Empty;
			this.txtMasterCode.BorderRadius = 0;
			this.txtMasterCode.BorderSize = 2;
			this.txtMasterCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtMasterCode.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMasterCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtMasterCode.Location = new System.Drawing.Point(3, 3);
			this.txtMasterCode.MaxLength = 32767;
			this.txtMasterCode.Multiline = false;
			this.txtMasterCode.Name = "txtMasterCode";
			this.txtMasterCode.OnlyNumber = false;
			this.txtMasterCode.PasswordChar = false;
			this.txtMasterCode.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtMasterCode.PlaceholderText = "";
			this.txtMasterCode.ReadOnly = false;
			this.txtMasterCode.Size = new System.Drawing.Size(94, 22);
			this.txtMasterCode.TabIndex = 0;
			this.txtMasterCode.Tag = "MasterCode";
			this.txtMasterCode.Texts = "";
			this.txtMasterCode.UnderlinedStyle = false;
			this.txtMasterCode.Leave += new System.EventHandler(this.btnFindMasterCode_Click);
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
			this.label1.TabIndex = 0;
			this.label1.Text = "M/CODE";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmCodeDetailList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Name = "frmCodeDetailList";
			this.Text = "코드상세조회";
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
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.pnlSearchOptions.ResumeLayout(false);
			this.panel12.ResumeLayout(false);
			this.panel12.PerformLayout();
			this.panel11.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel33.ResumeLayout(false);
			this.panel32.ResumeLayout(false);
			this.panel15.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvList;
		private System.Windows.Forms.TableLayoutPanel pnlSearchOptions;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel15;
		private P02_K_CONTROL_WIN.KTextBox txtMasterCode;
		private System.Windows.Forms.Panel panel32;
		private System.Windows.Forms.Button btnFindMasterCode;
		private System.Windows.Forms.Panel panel33;
		private P02_K_CONTROL_WIN.KTextBox txtMasterName;
		private P02_K_CONTROL_WIN.KTextBox txtName;
		private P02_K_CONTROL_WIN.KTextBox txtCode;
		private MetroFramework.Controls.MetroRadioButton rdoUseN;
		private MetroFramework.Controls.MetroRadioButton rdoUseY;
		private MetroFramework.Controls.MetroRadioButton rdoUseA;
		private MetroFramework.Controls.MetroRadioButton rdoDelN;
		private MetroFramework.Controls.MetroRadioButton rdoDelY;
		private MetroFramework.Controls.MetroRadioButton rdoDelA;
	}
}
