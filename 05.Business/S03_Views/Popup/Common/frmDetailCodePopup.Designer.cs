namespace P05_Business.S03_Views.Popup.Common
{
    partial class frmDetailCodePopup
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
            this.txtMasterCode = new P02_K_CONTROL_WIN.KTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMasterName = new P02_K_CONTROL_WIN.KTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDetailCode = new P02_K_CONTROL_WIN.KTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtDetailName = new P02_K_CONTROL_WIN.KTextBox();
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
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPopupOptional
            // 
            this.pnlPopupOptional.AutoSize = true;
            this.pnlPopupOptional.Controls.Add(this.tableLayoutPanel1);
            this.pnlPopupOptional.Size = new System.Drawing.Size(953, 90);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(953, 537);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Size = new System.Drawing.Size(953, 35);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(903, 0);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(853, 0);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvList);
            this.pnlBody.Location = new System.Drawing.Point(0, 160);
            this.pnlBody.Size = new System.Drawing.Size(953, 377);
            // 
            // lblPopupTitle
            // 
            this.lblPopupTitle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblPopupTitle.Font = new System.Drawing.Font("D2Coding", 12F, System.Drawing.FontStyle.Bold);
            this.lblPopupTitle.Size = new System.Drawing.Size(853, 35);
            // 
            // pnlPopupButtonBar
            // 
            this.pnlPopupButtonBar.Size = new System.Drawing.Size(953, 35);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(719, 0);
            // 
            // btnInit
            // 
            this.btnInit.FlatAppearance.BorderSize = 0;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 70);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "M.CODE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.txtMasterCode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(123, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 29);
            this.panel2.TabIndex = 1;
            // 
            // txtMasterCode
            // 
            this.txtMasterCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMasterCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtMasterCode.BorderColor = System.Drawing.Color.Empty;
            this.txtMasterCode.BorderFocusColor = System.Drawing.Color.Empty;
            this.txtMasterCode.BorderRadius = 0;
            this.txtMasterCode.BorderSize = 2;
            this.txtMasterCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMasterCode.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtMasterCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMasterCode.Location = new System.Drawing.Point(3, 4);
            this.txtMasterCode.MaxLength = 32767;
            this.txtMasterCode.Multiline = false;
            this.txtMasterCode.Name = "txtMasterCode";
            this.txtMasterCode.OnlyNumber = false;
            this.txtMasterCode.PasswordChar = false;
            this.txtMasterCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMasterCode.PlaceholderText = "";
            this.txtMasterCode.ReadOnly = false;
            this.txtMasterCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMasterCode.Size = new System.Drawing.Size(201, 22);
            this.txtMasterCode.TabIndex = 1;
            this.txtMasterCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMasterCode.Texts = "";
            this.txtMasterCode.UnderlinedStyle = false;
            this.txtMasterCode.WordWrap = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(336, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 29);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "M.NAME";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.txtMasterName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(456, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 29);
            this.panel4.TabIndex = 3;
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
            this.txtMasterName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtMasterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMasterName.Location = new System.Drawing.Point(3, 4);
            this.txtMasterName.MaxLength = 32767;
            this.txtMasterName.Multiline = false;
            this.txtMasterName.Name = "txtMasterName";
            this.txtMasterName.OnlyNumber = false;
            this.txtMasterName.PasswordChar = false;
            this.txtMasterName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMasterName.PlaceholderText = "";
            this.txtMasterName.ReadOnly = false;
            this.txtMasterName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMasterName.Size = new System.Drawing.Size(488, 22);
            this.txtMasterName.TabIndex = 2;
            this.txtMasterName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMasterName.Texts = "";
            this.txtMasterName.UnderlinedStyle = false;
            this.txtMasterName.WordWrap = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 29);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "D.CODE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.txtDetailCode);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(123, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 29);
            this.panel6.TabIndex = 5;
            // 
            // txtDetailCode
            // 
            this.txtDetailCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetailCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtDetailCode.BorderColor = System.Drawing.Color.Empty;
            this.txtDetailCode.BorderFocusColor = System.Drawing.Color.Empty;
            this.txtDetailCode.BorderRadius = 0;
            this.txtDetailCode.BorderSize = 2;
            this.txtDetailCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDetailCode.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtDetailCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDetailCode.Location = new System.Drawing.Point(3, 4);
            this.txtDetailCode.MaxLength = 32767;
            this.txtDetailCode.Multiline = false;
            this.txtDetailCode.Name = "txtDetailCode";
            this.txtDetailCode.OnlyNumber = false;
            this.txtDetailCode.PasswordChar = false;
            this.txtDetailCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDetailCode.PlaceholderText = "";
            this.txtDetailCode.ReadOnly = false;
            this.txtDetailCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailCode.Size = new System.Drawing.Size(201, 22);
            this.txtDetailCode.TabIndex = 2;
            this.txtDetailCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDetailCode.Texts = "";
            this.txtDetailCode.UnderlinedStyle = false;
            this.txtDetailCode.WordWrap = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(336, 38);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(114, 29);
            this.panel7.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "D.NAME";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Window;
            this.panel8.Controls.Add(this.txtDetailName);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(456, 38);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(494, 29);
            this.panel8.TabIndex = 7;
            // 
            // txtDetailName
            // 
            this.txtDetailName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetailName.BackColor = System.Drawing.SystemColors.Window;
            this.txtDetailName.BorderColor = System.Drawing.Color.Empty;
            this.txtDetailName.BorderFocusColor = System.Drawing.Color.Empty;
            this.txtDetailName.BorderRadius = 0;
            this.txtDetailName.BorderSize = 2;
            this.txtDetailName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDetailName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.txtDetailName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDetailName.Location = new System.Drawing.Point(3, 4);
            this.txtDetailName.MaxLength = 32767;
            this.txtDetailName.Multiline = false;
            this.txtDetailName.Name = "txtDetailName";
            this.txtDetailName.OnlyNumber = false;
            this.txtDetailName.PasswordChar = false;
            this.txtDetailName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDetailName.PlaceholderText = "";
            this.txtDetailName.ReadOnly = false;
            this.txtDetailName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetailName.Size = new System.Drawing.Size(488, 22);
            this.txtDetailName.TabIndex = 2;
            this.txtDetailName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDetailName.Texts = "";
            this.txtDetailName.UnderlinedStyle = false;
            this.txtDetailName.WordWrap = true;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(953, 377);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // frmDetailCodePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 541);
            this.Name = "frmDetailCodePopup";
            this.Text = "코드조회";
            this.Load += new System.EventHandler(this.frmDetailCodePopup_Load);
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
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private P02_K_CONTROL_WIN.KTextBox txtMasterCode;
        private P02_K_CONTROL_WIN.KTextBox txtMasterName;
        private P02_K_CONTROL_WIN.KTextBox txtDetailCode;
        private P02_K_CONTROL_WIN.KTextBox txtDetailName;
    }
}