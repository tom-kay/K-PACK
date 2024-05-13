namespace P05_Business.S03_Views.Base
{
    partial class frmMemoList
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
            this.txtTitle = new P02_K_CONTROL_WIN.KTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtContents = new P02_K_CONTROL_WIN.KTextBox();
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
            this.pnlBody.Size = new System.Drawing.Size(800, 471);
            // 
            // pnlSearchMain
            // 
            this.pnlSearchMain.Size = new System.Drawing.Size(800, 561);
            // 
            // pnlSearchButtonBar
            // 
            this.pnlSearchButtonBar.Size = new System.Drawing.Size(800, 35);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(406, 0);
            // 
            // pnlSearchOptional
            // 
            this.pnlSearchOptional.AutoSize = true;
            this.pnlSearchOptional.Controls.Add(this.tableLayoutPanel1);
            this.pnlSearchOptional.Size = new System.Drawing.Size(800, 55);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 35);
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
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "제목";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(123, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 29);
            this.panel2.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitle.BorderColor = System.Drawing.Color.Empty;
            this.txtTitle.BorderFocusColor = System.Drawing.Color.Empty;
            this.txtTitle.BorderRadius = 0;
            this.txtTitle.BorderSize = 2;
            this.txtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTitle.Location = new System.Drawing.Point(3, 3);
            this.txtTitle.MaxLength = 200;
            this.txtTitle.Multiline = false;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.OnlyNumber = false;
            this.txtTitle.PasswordChar = false;
            this.txtTitle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.ReadOnly = false;
            this.txtTitle.Size = new System.Drawing.Size(268, 22);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Tag = "";
            this.txtTitle.Texts = "";
            this.txtTitle.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(403, 3);
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
            this.label2.TabIndex = 2;
            this.label2.Text = "내용";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtContents);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(523, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 29);
            this.panel4.TabIndex = 3;
            // 
            // txtContents
            // 
            this.txtContents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContents.BackColor = System.Drawing.SystemColors.Window;
            this.txtContents.BorderColor = System.Drawing.Color.Empty;
            this.txtContents.BorderFocusColor = System.Drawing.Color.Empty;
            this.txtContents.BorderRadius = 0;
            this.txtContents.BorderSize = 2;
            this.txtContents.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContents.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContents.Location = new System.Drawing.Point(3, 3);
            this.txtContents.MaxLength = 32767;
            this.txtContents.Multiline = false;
            this.txtContents.Name = "txtContents";
            this.txtContents.OnlyNumber = false;
            this.txtContents.PasswordChar = false;
            this.txtContents.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContents.PlaceholderText = "";
            this.txtContents.ReadOnly = false;
            this.txtContents.Size = new System.Drawing.Size(268, 22);
            this.txtContents.TabIndex = 1;
            this.txtContents.Tag = "";
            this.txtContents.Texts = "";
            this.txtContents.UnderlinedStyle = false;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 10);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(800, 461);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_CellMouseClick);
            // 
            // frmMemoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Name = "frmMemoList";
            this.Text = "메모조회";
            this.Load += new System.EventHandler(this.frmMemoList_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private P02_K_CONTROL_WIN.KTextBox txtTitle;
        private P02_K_CONTROL_WIN.KTextBox txtContents;
    }
}