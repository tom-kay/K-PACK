namespace P05_Business.S03_Views.Popup.Biz
{
    partial class frmCustomerPopup
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
            this.txtCode = new P02_K_CONTROL_WIN.KTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtName = new P02_K_CONTROL_WIN.KTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkDealTypeGeneral = new MetroFramework.Controls.MetroCheckBox();
            this.chkDealTypeProc = new MetroFramework.Controls.MetroCheckBox();
            this.chkDealTypeBuy = new MetroFramework.Controls.MetroCheckBox();
            this.chkDealTypeSale = new MetroFramework.Controls.MetroCheckBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pnlPopupOptional.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlPopupButtonBar.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlInit.SuspendLayout();
            this.pnlSearch.SuspendLayout();
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
            // pnlPopupOptional
            // 
            this.pnlPopupOptional.AutoSize = true;
            this.pnlPopupOptional.Controls.Add(this.tableLayoutPanel1);
            this.pnlPopupOptional.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlPopupOptional.Size = new System.Drawing.Size(796, 90);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(796, 446);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Size = new System.Drawing.Size(796, 35);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(746, 0);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(696, 0);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvList);
            this.pnlBody.Location = new System.Drawing.Point(0, 160);
            this.pnlBody.Size = new System.Drawing.Size(796, 286);
            // 
            // lblPopupTitle
            // 
            this.lblPopupTitle.Size = new System.Drawing.Size(696, 35);
            // 
            // pnlPopupButtonBar
            // 
            this.pnlPopupButtonBar.Size = new System.Drawing.Size(796, 35);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(562, 0);
            // 
            // btnInit
            // 
            this.btnInit.FlatAppearance.BorderSize = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 70);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(103, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 29);
            this.panel1.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtCode.BorderColor = System.Drawing.Color.Empty;
            this.txtCode.BorderFocusColor = System.Drawing.Color.Empty;
            this.txtCode.BorderRadius = 0;
            this.txtCode.BorderSize = 2;
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
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
            this.txtCode.Size = new System.Drawing.Size(286, 22);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCode.Texts = "";
            this.txtCode.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(501, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 29);
            this.panel2.TabIndex = 3;
            // 
            // txtName
            // 
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
            this.txtName.Size = new System.Drawing.Size(286, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 29);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "CODE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(401, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(94, 29);
            this.panel4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(94, 29);
            this.panel5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "거래구분";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel6, 3);
            this.panel6.Controls.Add(this.chkDealTypeGeneral);
            this.panel6.Controls.Add(this.chkDealTypeProc);
            this.panel6.Controls.Add(this.chkDealTypeBuy);
            this.panel6.Controls.Add(this.chkDealTypeSale);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(103, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(690, 29);
            this.panel6.TabIndex = 9;
            // 
            // chkDealTypeGeneral
            // 
            this.chkDealTypeGeneral.AutoSize = true;
            this.chkDealTypeGeneral.BackColor = System.Drawing.Color.Transparent;
            this.chkDealTypeGeneral.Enabled = false;
            this.chkDealTypeGeneral.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkDealTypeGeneral.Location = new System.Drawing.Point(182, 5);
            this.chkDealTypeGeneral.Name = "chkDealTypeGeneral";
            this.chkDealTypeGeneral.Size = new System.Drawing.Size(53, 19);
            this.chkDealTypeGeneral.TabIndex = 3;
            this.chkDealTypeGeneral.Text = "일반";
            this.chkDealTypeGeneral.UseCustomBackColor = true;
            this.chkDealTypeGeneral.UseSelectable = true;
            // 
            // chkDealTypeProc
            // 
            this.chkDealTypeProc.AutoSize = true;
            this.chkDealTypeProc.BackColor = System.Drawing.Color.Transparent;
            this.chkDealTypeProc.Enabled = false;
            this.chkDealTypeProc.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkDealTypeProc.Location = new System.Drawing.Point(113, 5);
            this.chkDealTypeProc.Name = "chkDealTypeProc";
            this.chkDealTypeProc.Size = new System.Drawing.Size(67, 19);
            this.chkDealTypeProc.TabIndex = 2;
            this.chkDealTypeProc.Text = "임가공";
            this.chkDealTypeProc.UseCustomBackColor = true;
            this.chkDealTypeProc.UseSelectable = true;
            // 
            // chkDealTypeBuy
            // 
            this.chkDealTypeBuy.AutoSize = true;
            this.chkDealTypeBuy.BackColor = System.Drawing.Color.Transparent;
            this.chkDealTypeBuy.Enabled = false;
            this.chkDealTypeBuy.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkDealTypeBuy.Location = new System.Drawing.Point(58, 5);
            this.chkDealTypeBuy.Name = "chkDealTypeBuy";
            this.chkDealTypeBuy.Size = new System.Drawing.Size(53, 19);
            this.chkDealTypeBuy.TabIndex = 1;
            this.chkDealTypeBuy.Text = "매입";
            this.chkDealTypeBuy.UseCustomBackColor = true;
            this.chkDealTypeBuy.UseSelectable = true;
            // 
            // chkDealTypeSale
            // 
            this.chkDealTypeSale.AutoSize = true;
            this.chkDealTypeSale.BackColor = System.Drawing.Color.Transparent;
            this.chkDealTypeSale.Enabled = false;
            this.chkDealTypeSale.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkDealTypeSale.Location = new System.Drawing.Point(3, 5);
            this.chkDealTypeSale.Name = "chkDealTypeSale";
            this.chkDealTypeSale.Size = new System.Drawing.Size(53, 19);
            this.chkDealTypeSale.TabIndex = 0;
            this.chkDealTypeSale.Text = "매출";
            this.chkDealTypeSale.UseCustomBackColor = true;
            this.chkDealTypeSale.UseSelectable = true;
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(796, 286);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // frmCustomerPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmCustomerPopup";
            this.Text = "frmCustomerPopup";
            this.pnlPopupOptional.ResumeLayout(false);
            this.pnlPopupOptional.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlPopupButtonBar.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlInit.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private P02_K_CONTROL_WIN.KTextBox txtCode;
        private System.Windows.Forms.Panel panel2;
        private P02_K_CONTROL_WIN.KTextBox txtName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroCheckBox chkDealTypeGeneral;
        private MetroFramework.Controls.MetroCheckBox chkDealTypeProc;
        private MetroFramework.Controls.MetroCheckBox chkDealTypeBuy;
        private MetroFramework.Controls.MetroCheckBox chkDealTypeSale;
    }
}