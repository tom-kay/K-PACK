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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtParentId = new P02_K_CONTROL_WIN.KTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMenuId = new P02_K_CONTROL_WIN.KTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cboMenuType = new P02_K_CONTROL_WIN.KComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtMenuName = new P02_K_CONTROL_WIN.KTextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtNamespace = new P02_K_CONTROL_WIN.KTextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtFormName = new P02_K_CONTROL_WIN.KTextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.rdoUseN = new P02_K_CONTROL_WIN.KRadioButton();
            this.rdoUseY = new P02_K_CONTROL_WIN.KRadioButton();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnNew = new P02_K_CONTROL_WIN.KButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrderDown = new P02_K_CONTROL_WIN.KButton();
            this.btnOrderUp = new P02_K_CONTROL_WIN.KButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tableLayoutPanel1);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 684);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trvMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(502, 682);
            this.panel1.TabIndex = 0;
            // 
            // trvMenu
            // 
            this.trvMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMenu.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvMenu.Location = new System.Drawing.Point(0, 0);
            this.trvMenu.Margin = new System.Windows.Forms.Padding(0);
            this.trvMenu.Name = "trvMenu";
            this.trvMenu.Size = new System.Drawing.Size(502, 682);
            this.trvMenu.TabIndex = 0;
            this.trvMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvMenu_NodeMouseClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel11, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel12, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel13, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel14, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.panel15, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.panel16, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.panel17, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.panel18, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(504, 1);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(503, 253);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 29);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "상위메뉴";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtParentId);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(122, 1);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(277, 35);
            this.panel5.TabIndex = 1;
            // 
            // txtParentId
            // 
            this.txtParentId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentId.BackColor = System.Drawing.SystemColors.Window;
            this.txtParentId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtParentId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtParentId.BorderRadius = 0;
            this.txtParentId.BorderSize = 2;
            this.txtParentId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtParentId.Enabled = false;
            this.txtParentId.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtParentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtParentId.Location = new System.Drawing.Point(3, 6);
            this.txtParentId.MaxLength = 32767;
            this.txtParentId.Multiline = false;
            this.txtParentId.Name = "txtParentId";
            this.txtParentId.OnlyNumber = false;
            this.txtParentId.PasswordChar = false;
            this.txtParentId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtParentId.PlaceholderText = "";
            this.txtParentId.ReadOnly = false;
            this.txtParentId.Size = new System.Drawing.Size(271, 22);
            this.txtParentId.TabIndex = 0;
            this.txtParentId.Tag = "ParentId";
            this.txtParentId.Texts = "";
            this.txtParentId.UnderlinedStyle = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(4, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(114, 29);
            this.panel6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "메뉴코드";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel7, 2);
            this.panel7.Controls.Add(this.txtMenuId);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(122, 37);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(380, 35);
            this.panel7.TabIndex = 3;
            // 
            // txtMenuId
            // 
            this.txtMenuId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMenuId.BackColor = System.Drawing.SystemColors.Window;
            this.txtMenuId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMenuId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMenuId.BorderRadius = 0;
            this.txtMenuId.BorderSize = 2;
            this.txtMenuId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMenuId.Enabled = false;
            this.txtMenuId.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtMenuId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMenuId.Location = new System.Drawing.Point(3, 6);
            this.txtMenuId.MaxLength = 32767;
            this.txtMenuId.Multiline = false;
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.OnlyNumber = false;
            this.txtMenuId.PasswordChar = false;
            this.txtMenuId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMenuId.PlaceholderText = "";
            this.txtMenuId.ReadOnly = false;
            this.txtMenuId.Size = new System.Drawing.Size(374, 22);
            this.txtMenuId.TabIndex = 0;
            this.txtMenuId.Tag = "MenuId";
            this.txtMenuId.Texts = "";
            this.txtMenuId.UnderlinedStyle = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(4, 76);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(114, 29);
            this.panel8.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "메뉴타입";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel9, 2);
            this.panel9.Controls.Add(this.cboMenuType);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(122, 73);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(380, 35);
            this.panel9.TabIndex = 5;
            // 
            // cboMenuType
            // 
            this.cboMenuType.BackColor = System.Drawing.Color.PowderBlue;
            this.cboMenuType.BorderColor = System.Drawing.Color.Transparent;
            this.cboMenuType.BorderSize = 1;
            this.cboMenuType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMenuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMenuType.Font = new System.Drawing.Font("굴림", 10F);
            this.cboMenuType.ForeColor = System.Drawing.Color.DimGray;
            this.cboMenuType.IconColor = System.Drawing.Color.Navy;
            this.cboMenuType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboMenuType.ListTextColor = System.Drawing.Color.DimGray;
            this.cboMenuType.Location = new System.Drawing.Point(0, 0);
            this.cboMenuType.Name = "cboMenuType";
            this.cboMenuType.Padding = new System.Windows.Forms.Padding(3);
            this.cboMenuType.Size = new System.Drawing.Size(380, 35);
            this.cboMenuType.TabIndex = 0;
            this.cboMenuType.Tag = "MenuType";
            this.cboMenuType.Texts = "";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(4, 112);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(114, 29);
            this.panel10.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "메뉴명";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel11, 2);
            this.panel11.Controls.Add(this.txtMenuName);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(122, 109);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(380, 35);
            this.panel11.TabIndex = 7;
            // 
            // txtMenuName
            // 
            this.txtMenuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMenuName.BackColor = System.Drawing.SystemColors.Window;
            this.txtMenuName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMenuName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMenuName.BorderRadius = 0;
            this.txtMenuName.BorderSize = 2;
            this.txtMenuName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMenuName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtMenuName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMenuName.Location = new System.Drawing.Point(3, 6);
            this.txtMenuName.MaxLength = 32767;
            this.txtMenuName.Multiline = false;
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.OnlyNumber = false;
            this.txtMenuName.PasswordChar = false;
            this.txtMenuName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMenuName.PlaceholderText = "";
            this.txtMenuName.ReadOnly = false;
            this.txtMenuName.Size = new System.Drawing.Size(374, 22);
            this.txtMenuName.TabIndex = 0;
            this.txtMenuName.Tag = "MenuName";
            this.txtMenuName.Texts = "";
            this.txtMenuName.UnderlinedStyle = false;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label5);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(4, 148);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(114, 29);
            this.panel12.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Namespace";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel13, 2);
            this.panel13.Controls.Add(this.txtNamespace);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(122, 145);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(380, 35);
            this.panel13.TabIndex = 9;
            // 
            // txtNamespace
            // 
            this.txtNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamespace.BackColor = System.Drawing.SystemColors.Window;
            this.txtNamespace.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNamespace.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNamespace.BorderRadius = 0;
            this.txtNamespace.BorderSize = 2;
            this.txtNamespace.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNamespace.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtNamespace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNamespace.Location = new System.Drawing.Point(3, 6);
            this.txtNamespace.MaxLength = 32767;
            this.txtNamespace.Multiline = false;
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.OnlyNumber = false;
            this.txtNamespace.PasswordChar = false;
            this.txtNamespace.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNamespace.PlaceholderText = "";
            this.txtNamespace.ReadOnly = false;
            this.txtNamespace.Size = new System.Drawing.Size(374, 22);
            this.txtNamespace.TabIndex = 0;
            this.txtNamespace.Tag = "Namespace";
            this.txtNamespace.Texts = "";
            this.txtNamespace.UnderlinedStyle = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label6);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(4, 184);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(114, 29);
            this.panel14.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "화면명";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel15, 2);
            this.panel15.Controls.Add(this.txtFormName);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(122, 181);
            this.panel15.Margin = new System.Windows.Forms.Padding(0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(380, 35);
            this.panel15.TabIndex = 11;
            // 
            // txtFormName
            // 
            this.txtFormName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFormName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFormName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFormName.BorderRadius = 0;
            this.txtFormName.BorderSize = 2;
            this.txtFormName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFormName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFormName.Location = new System.Drawing.Point(3, 6);
            this.txtFormName.MaxLength = 32767;
            this.txtFormName.Multiline = false;
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.OnlyNumber = false;
            this.txtFormName.PasswordChar = false;
            this.txtFormName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFormName.PlaceholderText = "";
            this.txtFormName.ReadOnly = false;
            this.txtFormName.Size = new System.Drawing.Size(374, 22);
            this.txtFormName.TabIndex = 0;
            this.txtFormName.Tag = "FormName";
            this.txtFormName.Texts = "";
            this.txtFormName.UnderlinedStyle = false;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label7);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(4, 220);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(114, 29);
            this.panel16.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "사용유무";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel17, 2);
            this.panel17.Controls.Add(this.rdoUseN);
            this.panel17.Controls.Add(this.rdoUseY);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(122, 217);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(380, 35);
            this.panel17.TabIndex = 13;
            // 
            // rdoUseN
            // 
            this.rdoUseN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoUseN.AutoSize = true;
            this.rdoUseN.CheckedColor = System.Drawing.Color.DarkCyan;
            this.rdoUseN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoUseN.Location = new System.Drawing.Point(62, 5);
            this.rdoUseN.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdoUseN.Name = "rdoUseN";
            this.rdoUseN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdoUseN.Size = new System.Drawing.Size(48, 24);
            this.rdoUseN.TabIndex = 1;
            this.rdoUseN.TabStop = true;
            this.rdoUseN.Tag = "UseYn|N";
            this.rdoUseN.Text = "N";
            this.rdoUseN.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdoUseN.UseVisualStyleBackColor = true;
            // 
            // rdoUseY
            // 
            this.rdoUseY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoUseY.AutoSize = true;
            this.rdoUseY.Checked = true;
            this.rdoUseY.CheckedColor = System.Drawing.Color.DarkCyan;
            this.rdoUseY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoUseY.Location = new System.Drawing.Point(7, 5);
            this.rdoUseY.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdoUseY.Name = "rdoUseY";
            this.rdoUseY.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdoUseY.Size = new System.Drawing.Size(48, 24);
            this.rdoUseY.TabIndex = 0;
            this.rdoUseY.TabStop = true;
            this.rdoUseY.Tag = "UseYn|Y";
            this.rdoUseY.Text = "Y";
            this.rdoUseY.UnCheckedColor = System.Drawing.Color.Gray;
            this.rdoUseY.UseVisualStyleBackColor = true;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnNew);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(403, 4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(96, 29);
            this.panel18.TabIndex = 14;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNew.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.btnNew.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnNew.BorderRadius = 0;
            this.btnNew.BorderSize = 0;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(96, 29);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "신규";
            this.btnNew.TextColor = System.Drawing.Color.White;
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(504, 255);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(503, 428);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOrderDown);
            this.panel2.Controls.Add(this.btnOrderUp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 35);
            this.panel2.TabIndex = 0;
            // 
            // btnOrderDown
            // 
            this.btnOrderDown.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderDown.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOrderDown.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnOrderDown.BorderRadius = 0;
            this.btnOrderDown.BorderSize = 0;
            this.btnOrderDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOrderDown.FlatAppearance.BorderSize = 0;
            this.btnOrderDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrderDown.ForeColor = System.Drawing.Color.White;
            this.btnOrderDown.Image = global::P05_Business.Properties.Resources._58460_down_arrow_arrow_down;
            this.btnOrderDown.Location = new System.Drawing.Point(433, 0);
            this.btnOrderDown.Name = "btnOrderDown";
            this.btnOrderDown.Size = new System.Drawing.Size(35, 35);
            this.btnOrderDown.TabIndex = 1;
            this.btnOrderDown.TextColor = System.Drawing.Color.White;
            this.btnOrderDown.UseVisualStyleBackColor = false;
            // 
            // btnOrderUp
            // 
            this.btnOrderUp.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderUp.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOrderUp.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnOrderUp.BorderRadius = 0;
            this.btnOrderUp.BorderSize = 0;
            this.btnOrderUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOrderUp.FlatAppearance.BorderSize = 0;
            this.btnOrderUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrderUp.ForeColor = System.Drawing.Color.White;
            this.btnOrderUp.Image = global::P05_Business.Properties.Resources._58463_up_up_arrow_arrow;
            this.btnOrderUp.Location = new System.Drawing.Point(468, 0);
            this.btnOrderUp.Name = "btnOrderUp";
            this.btnOrderUp.Size = new System.Drawing.Size(35, 35);
            this.btnOrderUp.TabIndex = 0;
            this.btnOrderUp.TextColor = System.Drawing.Color.White;
            this.btnOrderUp.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 393);
            this.panel3.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(503, 393);
            this.dgvList.TabIndex = 0;
            // 
            // frmMenuMasterMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Name = "frmMenuMasterMng";
            this.Text = "메뉴관리";
            this.Load += new System.EventHandler(this.frmMenuMasterMng_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeaderBtns.ResumeLayout(false);
            this.pnlPrint.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.pnlDelete.ResumeLayout(false);
            this.pnlClose.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlInit.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private P02_K_CONTROL_WIN.KButton btnOrderDown;
        private P02_K_CONTROL_WIN.KButton btnOrderUp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private P02_K_CONTROL_WIN.KButton btnNew;
        private P02_K_CONTROL_WIN.KTextBox txtParentId;
        private P02_K_CONTROL_WIN.KTextBox txtMenuId;
        private P02_K_CONTROL_WIN.KTextBox txtMenuName;
        private P02_K_CONTROL_WIN.KTextBox txtNamespace;
        private P02_K_CONTROL_WIN.KTextBox txtFormName;
        private P02_K_CONTROL_WIN.KComboBox cboMenuType;
        private P02_K_CONTROL_WIN.KRadioButton rdoUseN;
        private P02_K_CONTROL_WIN.KRadioButton rdoUseY;
    }
}
