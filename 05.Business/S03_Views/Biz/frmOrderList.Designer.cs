namespace P05_Business.S03_Views.Biz
{
    partial class frmOrderList
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
            this.txtOrderNo = new P02_K_CONTROL_WIN.KTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPoNo = new P02_K_CONTROL_WIN.KTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cnbBuyer = new P02_K_CONTROL_WIN.KCodeNameBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cnbWork = new P02_K_CONTROL_WIN.KCodeNameBox();
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
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
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
            this.pnlBody.Location = new System.Drawing.Point(0, 125);
            this.pnlBody.Size = new System.Drawing.Size(1135, 436);
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
            this.pnlSearchOptional.Size = new System.Drawing.Size(1135, 90);
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
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1135, 70);
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
            this.cboPeriodType.TabIndex = 2;
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
            this.pdbDate.DateFromValue = "2024-05-24";
            this.pdbDate.DateToValue = "2024-05-24";
            this.pdbDate.Location = new System.Drawing.Point(3, 5);
            this.pdbDate.MaximumSize = new System.Drawing.Size(265, 22);
            this.pdbDate.MinimumSize = new System.Drawing.Size(265, 22);
            this.pdbDate.Name = "pdbDate";
            this.pdbDate.Size = new System.Drawing.Size(265, 22);
            this.pdbDate.TabIndex = 0;
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
            this.label2.Text = "발주번호";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtOrderNo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(501, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 29);
            this.panel4.TabIndex = 3;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderNo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtOrderNo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtOrderNo.BorderRadius = 0;
            this.txtOrderNo.BorderSize = 2;
            this.txtOrderNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOrderNo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtOrderNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOrderNo.Location = new System.Drawing.Point(3, 3);
            this.txtOrderNo.MaxLength = 32767;
            this.txtOrderNo.Multiline = false;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.OnlyNumber = false;
            this.txtOrderNo.PasswordChar = false;
            this.txtOrderNo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtOrderNo.PlaceholderText = "";
            this.txtOrderNo.ReadOnly = false;
            this.txtOrderNo.Size = new System.Drawing.Size(246, 22);
            this.txtOrderNo.TabIndex = 1;
            this.txtOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOrderNo.Texts = "";
            this.txtOrderNo.UnderlinedStyle = false;
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
            this.label3.Text = "PO NO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtPoNo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(879, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(253, 29);
            this.panel6.TabIndex = 5;
            // 
            // txtPoNo
            // 
            this.txtPoNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPoNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtPoNo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPoNo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPoNo.BorderRadius = 0;
            this.txtPoNo.BorderSize = 2;
            this.txtPoNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPoNo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtPoNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPoNo.Location = new System.Drawing.Point(3, 3);
            this.txtPoNo.MaxLength = 32767;
            this.txtPoNo.Multiline = false;
            this.txtPoNo.Name = "txtPoNo";
            this.txtPoNo.OnlyNumber = false;
            this.txtPoNo.PasswordChar = false;
            this.txtPoNo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPoNo.PlaceholderText = "";
            this.txtPoNo.ReadOnly = false;
            this.txtPoNo.Size = new System.Drawing.Size(247, 22);
            this.txtPoNo.TabIndex = 1;
            this.txtPoNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoNo.Texts = "";
            this.txtPoNo.UnderlinedStyle = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 38);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 29);
            this.panel7.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "BUYER";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cnbBuyer);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(123, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(252, 29);
            this.panel8.TabIndex = 7;
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
            this.cnbBuyer.Size = new System.Drawing.Size(252, 29);
            this.cnbBuyer.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(381, 38);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(114, 29);
            this.panel9.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "발주처";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cnbWork);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(501, 38);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(252, 29);
            this.panel10.TabIndex = 9;
            // 
            // cnbWork
            // 
            this.cnbWork.AddParams = null;
            this.cnbWork.BackColor = System.Drawing.Color.White;
            this.cnbWork.CodeValue = "";
            this.cnbWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnbWork.FormName = "frmCustomerPopup";
            this.cnbWork.FormTitle = "발주처 조회";
            this.cnbWork.Location = new System.Drawing.Point(0, 0);
            this.cnbWork.Margin = new System.Windows.Forms.Padding(0);
            this.cnbWork.MinimumSize = new System.Drawing.Size(229, 29);
            this.cnbWork.Name = "cnbWork";
            this.cnbWork.Namespace = "P05_Business.S03_Views.Popup.Biz";
            this.cnbWork.NameValue = "";
            this.cnbWork.Size = new System.Drawing.Size(252, 29);
            this.cnbWork.TabIndex = 0;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeight = 70;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 10);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(1135, 426);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseClick);
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 561);
            this.Name = "frmOrderList";
            this.Text = "발주조회";
            this.Load += new System.EventHandler(this.frmOrderList_Load);
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
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private P02_K_CONTROL_WIN.KComboBox cboPeriodType;
        private P02_K_CONTROL_WIN.KTextBox txtOrderNo;
        private P02_K_CONTROL_WIN.KTextBox txtPoNo;
        private System.Windows.Forms.Panel panel2;
        private P02_K_CONTROL_WIN.KPeriodDateBox pdbDate;
        private P02_K_CONTROL_WIN.KCodeNameBox cnbBuyer;
        private P02_K_CONTROL_WIN.KCodeNameBox cnbWork;
    }
}