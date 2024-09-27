namespace P05_Business.S03_Views.Biz
{
    partial class frmItemMng
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtGroupCode = new P02_K_CONTROL_WIN.KTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtGroupName = new P02_K_CONTROL_WIN.KTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtAliasName = new P02_K_CONTROL_WIN.KTextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cboDefaultEachUnitCode = new P02_K_CONTROL_WIN.KComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.cboDefaultPackingUnitCode = new P02_K_CONTROL_WIN.KComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtRemark = new P02_K_CONTROL_WIN.KTextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnDuplicate = new P02_K_CONTROL_WIN.KButton();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblDuplicateMsg = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel42 = new System.Windows.Forms.Panel();
            this.btnAddRow = new P02_K_CONTROL_WIN.KButton();
            this.btnDelRow = new P02_K_CONTROL_WIN.KButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel42.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Size = new System.Drawing.Size(800, 561);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tableLayoutPanel2);
            this.pnlBody.Controls.Add(this.tableLayoutPanel1);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel13, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel15, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel16, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 145);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 29);
            this.panel3.TabIndex = 0;
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
            this.label3.Text = "제품군코드";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtGroupCode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(122, 1);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 35);
            this.panel4.TabIndex = 1;
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupCode.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGroupCode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGroupCode.BorderRadius = 0;
            this.txtGroupCode.BorderSize = 2;
            this.txtGroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGroupCode.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtGroupCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGroupCode.Location = new System.Drawing.Point(3, 6);
            this.txtGroupCode.MaxLength = 50;
            this.txtGroupCode.Multiline = false;
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.OnlyNumber = false;
            this.txtGroupCode.PasswordChar = false;
            this.txtGroupCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGroupCode.PlaceholderText = "";
            this.txtGroupCode.ReadOnly = false;
            this.txtGroupCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGroupCode.Size = new System.Drawing.Size(270, 22);
            this.txtGroupCode.TabIndex = 2;
            this.txtGroupCode.Tag = "GroupCode";
            this.txtGroupCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGroupCode.Texts = "";
            this.txtGroupCode.UnderlinedStyle = false;
            this.txtGroupCode.WordWrap = true;
            this.txtGroupCode._TextChanged += new System.EventHandler(this.txtGroupCode__TextChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(4, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 29);
            this.panel7.TabIndex = 4;
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
            this.label2.Text = "제품군명";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtGroupName);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(122, 37);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(277, 35);
            this.panel8.TabIndex = 5;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupName.BackColor = System.Drawing.SystemColors.Window;
            this.txtGroupName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGroupName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGroupName.BorderRadius = 0;
            this.txtGroupName.BorderSize = 2;
            this.txtGroupName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGroupName.Location = new System.Drawing.Point(3, 6);
            this.txtGroupName.MaxLength = 200;
            this.txtGroupName.Multiline = false;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.OnlyNumber = false;
            this.txtGroupName.PasswordChar = false;
            this.txtGroupName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGroupName.PlaceholderText = "";
            this.txtGroupName.ReadOnly = false;
            this.txtGroupName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGroupName.Size = new System.Drawing.Size(270, 22);
            this.txtGroupName.TabIndex = 3;
            this.txtGroupName.Tag = "GroupName";
            this.txtGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtGroupName.Texts = "";
            this.txtGroupName.UnderlinedStyle = false;
            this.txtGroupName.WordWrap = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(403, 40);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(114, 29);
            this.panel9.TabIndex = 6;
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
            this.label4.Text = "제품군약어";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtAliasName);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(521, 37);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(278, 35);
            this.panel10.TabIndex = 7;
            // 
            // txtAliasName
            // 
            this.txtAliasName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAliasName.BackColor = System.Drawing.SystemColors.Window;
            this.txtAliasName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAliasName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAliasName.BorderRadius = 0;
            this.txtAliasName.BorderSize = 2;
            this.txtAliasName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAliasName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtAliasName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAliasName.Location = new System.Drawing.Point(4, 6);
            this.txtAliasName.MaxLength = 100;
            this.txtAliasName.Multiline = false;
            this.txtAliasName.Name = "txtAliasName";
            this.txtAliasName.OnlyNumber = false;
            this.txtAliasName.PasswordChar = false;
            this.txtAliasName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAliasName.PlaceholderText = "";
            this.txtAliasName.ReadOnly = false;
            this.txtAliasName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAliasName.Size = new System.Drawing.Size(270, 22);
            this.txtAliasName.TabIndex = 4;
            this.txtAliasName.Tag = "AliasName";
            this.txtAliasName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAliasName.Texts = "";
            this.txtAliasName.UnderlinedStyle = false;
            this.txtAliasName.WordWrap = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label5);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(4, 76);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(114, 29);
            this.panel11.TabIndex = 8;
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
            this.label5.Text = "기본제품단위";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.cboDefaultEachUnitCode);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(122, 73);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(277, 35);
            this.panel12.TabIndex = 9;
            // 
            // cboDefaultEachUnitCode
            // 
            this.cboDefaultEachUnitCode.BackColor = System.Drawing.Color.PowderBlue;
            this.cboDefaultEachUnitCode.BorderColor = System.Drawing.Color.Transparent;
            this.cboDefaultEachUnitCode.BorderSize = 1;
            this.cboDefaultEachUnitCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDefaultEachUnitCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboDefaultEachUnitCode.Font = new System.Drawing.Font("굴림", 10F);
            this.cboDefaultEachUnitCode.ForeColor = System.Drawing.Color.DimGray;
            this.cboDefaultEachUnitCode.IconColor = System.Drawing.Color.Navy;
            this.cboDefaultEachUnitCode.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboDefaultEachUnitCode.ListTextColor = System.Drawing.Color.DimGray;
            this.cboDefaultEachUnitCode.Location = new System.Drawing.Point(0, 0);
            this.cboDefaultEachUnitCode.Name = "cboDefaultEachUnitCode";
            this.cboDefaultEachUnitCode.Padding = new System.Windows.Forms.Padding(3);
            this.cboDefaultEachUnitCode.Size = new System.Drawing.Size(277, 35);
            this.cboDefaultEachUnitCode.TabIndex = 2;
            this.cboDefaultEachUnitCode.Tag = "DefaultEachUnitCode";
            this.cboDefaultEachUnitCode.Texts = "";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label6);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(403, 76);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(114, 29);
            this.panel13.TabIndex = 10;
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
            this.label6.Text = "기본포장단위";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.cboDefaultPackingUnitCode);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(521, 73);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(278, 35);
            this.panel14.TabIndex = 11;
            // 
            // cboDefaultPackingUnitCode
            // 
            this.cboDefaultPackingUnitCode.BackColor = System.Drawing.Color.PowderBlue;
            this.cboDefaultPackingUnitCode.BorderColor = System.Drawing.Color.Transparent;
            this.cboDefaultPackingUnitCode.BorderSize = 1;
            this.cboDefaultPackingUnitCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDefaultPackingUnitCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboDefaultPackingUnitCode.Font = new System.Drawing.Font("굴림", 10F);
            this.cboDefaultPackingUnitCode.ForeColor = System.Drawing.Color.DimGray;
            this.cboDefaultPackingUnitCode.IconColor = System.Drawing.Color.Navy;
            this.cboDefaultPackingUnitCode.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboDefaultPackingUnitCode.ListTextColor = System.Drawing.Color.DimGray;
            this.cboDefaultPackingUnitCode.Location = new System.Drawing.Point(0, 0);
            this.cboDefaultPackingUnitCode.Name = "cboDefaultPackingUnitCode";
            this.cboDefaultPackingUnitCode.Padding = new System.Windows.Forms.Padding(3);
            this.cboDefaultPackingUnitCode.Size = new System.Drawing.Size(278, 35);
            this.cboDefaultPackingUnitCode.TabIndex = 2;
            this.cboDefaultPackingUnitCode.Tag = "DefaultPackingUnitCode";
            this.cboDefaultPackingUnitCode.Texts = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 29);
            this.panel5.TabIndex = 12;
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
            this.label1.TabIndex = 4;
            this.label1.Text = "비고";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel6, 3);
            this.panel6.Controls.Add(this.txtRemark);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(122, 109);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(677, 35);
            this.panel6.TabIndex = 13;
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemark.BackColor = System.Drawing.SystemColors.Window;
            this.txtRemark.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRemark.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRemark.BorderRadius = 0;
            this.txtRemark.BorderSize = 2;
            this.txtRemark.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRemark.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtRemark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRemark.Location = new System.Drawing.Point(3, 6);
            this.txtRemark.MaxLength = 255;
            this.txtRemark.Multiline = false;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.OnlyNumber = false;
            this.txtRemark.PasswordChar = false;
            this.txtRemark.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRemark.PlaceholderText = "";
            this.txtRemark.ReadOnly = false;
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemark.Size = new System.Drawing.Size(670, 22);
            this.txtRemark.TabIndex = 3;
            this.txtRemark.Tag = "Remark";
            this.txtRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRemark.Texts = "";
            this.txtRemark.UnderlinedStyle = false;
            this.txtRemark.WordWrap = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnDuplicate);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(403, 4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(114, 29);
            this.panel15.TabIndex = 14;
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDuplicate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDuplicate.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.btnDuplicate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDuplicate.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnDuplicate.BorderRadius = 0;
            this.btnDuplicate.BorderSize = 0;
            this.btnDuplicate.FlatAppearance.BorderSize = 0;
            this.btnDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuplicate.ForeColor = System.Drawing.Color.White;
            this.btnDuplicate.Image = global::P05_Business.Properties.Resources._58561_check_check;
            this.btnDuplicate.Location = new System.Drawing.Point(0, 2);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(114, 24);
            this.btnDuplicate.TabIndex = 4;
            this.btnDuplicate.Text = "중복체크";
            this.btnDuplicate.TextColor = System.Drawing.Color.White;
            this.btnDuplicate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDuplicate.UseVisualStyleBackColor = false;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.lblDuplicateMsg);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(524, 4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(272, 29);
            this.panel16.TabIndex = 15;
            // 
            // lblDuplicateMsg
            // 
            this.lblDuplicateMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDuplicateMsg.Location = new System.Drawing.Point(0, 0);
            this.lblDuplicateMsg.Name = "lblDuplicateMsg";
            this.lblDuplicateMsg.Size = new System.Drawing.Size(272, 29);
            this.lblDuplicateMsg.TabIndex = 0;
            this.lblDuplicateMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDuplicateMsg.UseCustomForeColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 155);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 371);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel42);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 0;
            // 
            // panel42
            // 
            this.panel42.Controls.Add(this.btnAddRow);
            this.panel42.Controls.Add(this.btnDelRow);
            this.panel42.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel42.Location = new System.Drawing.Point(658, 0);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(142, 35);
            this.panel42.TabIndex = 4;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRow.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddRow.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.btnAddRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRow.BorderColor = System.Drawing.Color.CadetBlue;
            this.btnAddRow.BorderRadius = 0;
            this.btnAddRow.BorderSize = 0;
            this.btnAddRow.FlatAppearance.BorderSize = 0;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRow.ForeColor = System.Drawing.Color.White;
            this.btnAddRow.Image = global::P05_Business.Properties.Resources._58560_add_add;
            this.btnAddRow.Location = new System.Drawing.Point(15, 5);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(60, 24);
            this.btnAddRow.TabIndex = 2;
            this.btnAddRow.Text = "추가";
            this.btnAddRow.TextColor = System.Drawing.Color.White;
            this.btnAddRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRow.UseVisualStyleBackColor = false;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnDelRow
            // 
            this.btnDelRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelRow.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDelRow.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.btnDelRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelRow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelRow.BorderRadius = 0;
            this.btnDelRow.BorderSize = 0;
            this.btnDelRow.FlatAppearance.BorderSize = 0;
            this.btnDelRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRow.ForeColor = System.Drawing.Color.White;
            this.btnDelRow.Image = global::P05_Business.Properties.Resources._58562_remove_remove;
            this.btnDelRow.Location = new System.Drawing.Point(78, 5);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(60, 24);
            this.btnDelRow.TabIndex = 1;
            this.btnDelRow.Text = "제거";
            this.btnDelRow.TextColor = System.Drawing.Color.White;
            this.btnDelRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelRow.UseVisualStyleBackColor = false;
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.metroLabel2.Location = new System.Drawing.Point(0, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 35);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "◎ 제품정보";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 323);
            this.panel2.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(794, 323);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellValueChanged);
            // 
            // frmItemMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Name = "frmItemMng";
            this.Text = "제품등록";
            this.Load += new System.EventHandler(this.frmItemMng_Load);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel42.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel42;
        private P02_K_CONTROL_WIN.KButton btnAddRow;
        private P02_K_CONTROL_WIN.KButton btnDelRow;
        private P02_K_CONTROL_WIN.KTextBox txtGroupCode;
        private P02_K_CONTROL_WIN.KTextBox txtGroupName;
        private P02_K_CONTROL_WIN.KTextBox txtAliasName;
        private P02_K_CONTROL_WIN.KComboBox cboDefaultEachUnitCode;
        private P02_K_CONTROL_WIN.KComboBox cboDefaultPackingUnitCode;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private P02_K_CONTROL_WIN.KTextBox txtRemark;
        private System.Windows.Forms.Panel panel15;
        private P02_K_CONTROL_WIN.KButton btnDuplicate;
        private System.Windows.Forms.Panel panel16;
        private MetroFramework.Controls.MetroLabel lblDuplicateMsg;
    }
}