namespace P05_Business.S03_Views.Biz
{
    partial class frmExportList
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
            this.cboPeriodType = new P02_K_CONTROL_WIN.KComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pdbDate = new P02_K_CONTROL_WIN.KPeriodDateBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtInvoiceNo = new P02_K_CONTROL_WIN.KTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cnbBuyer = new P02_K_CONTROL_WIN.KCodeNameBox();
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
            this.pnlNew.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvList);
            this.pnlBody.Location = new System.Drawing.Point(0, 90);
            this.pnlBody.Size = new System.Drawing.Size(1135, 471);
            // 
            // pnlSearchMain
            // 
            this.pnlSearchMain.Size = new System.Drawing.Size(1135, 561);
            // 
            // pnlSearchButtonBar
            // 
            this.pnlSearchButtonBar.Size = new System.Drawing.Size(1135, 35);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(714, 0);
            // 
            // pnlSearchOptional
            // 
            this.pnlSearchOptional.AutoSize = true;
            this.pnlSearchOptional.Controls.Add(this.tableLayoutPanel1);
            this.pnlSearchOptional.Size = new System.Drawing.Size(1135, 55);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1135, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboPeriodType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 29);
            this.panel1.TabIndex = 0;
            // 
            // cboPeriodType
            // 
            this.cboPeriodType.BackColor = System.Drawing.Color.PowderBlue;
            this.cboPeriodType.BorderColor = System.Drawing.Color.Transparent;
            this.cboPeriodType.BorderSize = 1;
            this.cboPeriodType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPeriodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodType.Font = new System.Drawing.Font("굴림", 10F);
            this.cboPeriodType.ForeColor = System.Drawing.Color.DimGray;
            this.cboPeriodType.IconColor = System.Drawing.Color.Navy;
            this.cboPeriodType.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboPeriodType.ListTextColor = System.Drawing.Color.DimGray;
            this.cboPeriodType.Location = new System.Drawing.Point(0, 0);
            this.cboPeriodType.Name = "cboPeriodType";
            this.cboPeriodType.Padding = new System.Windows.Forms.Padding(1);
            this.cboPeriodType.Size = new System.Drawing.Size(114, 29);
            this.cboPeriodType.TabIndex = 3;
            this.cboPeriodType.Tag = "";
            this.cboPeriodType.Texts = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pdbDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(123, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 29);
            this.panel2.TabIndex = 1;
            // 
            // pdbDate
            // 
            this.pdbDate.AutoSize = true;
            this.pdbDate.BackColor = System.Drawing.Color.White;
            this.pdbDate.DateFromValue = "2024-08-25";
            this.pdbDate.DateToValue = "2024-08-25";
            this.pdbDate.Location = new System.Drawing.Point(3, 4);
            this.pdbDate.MaximumSize = new System.Drawing.Size(265, 22);
            this.pdbDate.MinimumSize = new System.Drawing.Size(265, 22);
            this.pdbDate.Name = "pdbDate";
            this.pdbDate.Size = new System.Drawing.Size(265, 22);
            this.pdbDate.TabIndex = 1;
            this.pdbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(381, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 29);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "INVOICE NO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtInvoiceNo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(501, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 29);
            this.panel4.TabIndex = 3;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInvoiceNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtInvoiceNo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtInvoiceNo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtInvoiceNo.BorderRadius = 0;
            this.txtInvoiceNo.BorderSize = 2;
            this.txtInvoiceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInvoiceNo.Location = new System.Drawing.Point(3, 3);
            this.txtInvoiceNo.MaxLength = 32767;
            this.txtInvoiceNo.Multiline = false;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.OnlyNumber = false;
            this.txtInvoiceNo.PasswordChar = false;
            this.txtInvoiceNo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtInvoiceNo.PlaceholderText = "";
            this.txtInvoiceNo.ReadOnly = false;
            this.txtInvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNo.Size = new System.Drawing.Size(246, 22);
            this.txtInvoiceNo.TabIndex = 2;
            this.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtInvoiceNo.Texts = "";
            this.txtInvoiceNo.UnderlinedStyle = false;
            this.txtInvoiceNo.WordWrap = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(759, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 29);
            this.panel5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "BUYER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.cnbBuyer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(879, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(253, 29);
            this.panel6.TabIndex = 5;
            // 
            // cnbBuyer
            // 
            this.cnbBuyer.AddParams = null;
            this.cnbBuyer.BackColor = System.Drawing.Color.White;
            this.cnbBuyer.CodeValue = "";
            this.cnbBuyer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnbBuyer.FormName = "frmCustomerPopup";
            this.cnbBuyer.FormTitle = "BUYER 조회";
            this.cnbBuyer.Location = new System.Drawing.Point(0, 0);
            this.cnbBuyer.Margin = new System.Windows.Forms.Padding(0);
            this.cnbBuyer.MinimumSize = new System.Drawing.Size(229, 29);
            this.cnbBuyer.Name = "cnbBuyer";
            this.cnbBuyer.Namespace = "P05_Business.S03_Views.Popup.Biz";
            this.cnbBuyer.NameValue = "";
            this.cnbBuyer.Size = new System.Drawing.Size(253, 29);
            this.cnbBuyer.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 10);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(1135, 461);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // frmExportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 561);
            this.Name = "frmExportList";
            this.Text = "frmExportList";
            this.Load += new System.EventHandler(this.frmExportList_Load);
            this.Controls.SetChildIndex(this.pnlSearchMain, 0);
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
            this.pnlNew.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private P02_K_CONTROL_WIN.KPeriodDateBox pdbDate;
        private P02_K_CONTROL_WIN.KComboBox cboPeriodType;
        private P02_K_CONTROL_WIN.KCodeNameBox cnbBuyer;
        private P02_K_CONTROL_WIN.KTextBox txtInvoiceNo;
    }
}