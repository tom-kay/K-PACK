namespace P05_Business.S03_Views.Base
{
	partial class frmExchangeRateMng
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExchangeRateMng));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblExDate = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.cboExDate = new P02_K_CONTROL_WIN.KButtonCalendar();
			this.btnAddRow = new P02_K_CONTROL_WIN.KButton();
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
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Size = new System.Drawing.Size(800, 561);
			// 
			// pnlBody
			// 
			this.pnlBody.Controls.Add(this.panel1);
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
			// 
			// btnDelete
			// 
			this.btnDelete.FlatAppearance.BorderSize = 0;
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
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 35);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(94, 29);
			this.panel2.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 29);
			this.label6.TabIndex = 3;
			this.label6.Text = "고시일자";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.lblExDate);
			this.panel3.Controls.Add(this.cboExDate);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(100, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(600, 35);
			this.panel3.TabIndex = 1;
			// 
			// lblExDate
			// 
			this.lblExDate.AccessibleDescription = "None";
			this.lblExDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblExDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblExDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExDate.Location = new System.Drawing.Point(3, 4);
			this.lblExDate.Name = "lblExDate";
			this.lblExDate.Size = new System.Drawing.Size(126, 27);
			this.lblExDate.TabIndex = 10;
			this.lblExDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnAddRow);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(703, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(94, 29);
			this.panel4.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dgvList);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 45);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.panel1.Size = new System.Drawing.Size(800, 481);
			this.panel1.TabIndex = 1;
			// 
			// dgvList
			// 
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvList.Location = new System.Drawing.Point(0, 10);
			this.dgvList.Name = "dgvList";
			this.dgvList.RowTemplate.Height = 23;
			this.dgvList.Size = new System.Drawing.Size(800, 471);
			this.dgvList.TabIndex = 0;
			// 
			// cboExDate
			// 
			this.cboExDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cboExDate.BackColor = System.Drawing.Color.Transparent;
			this.cboExDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboExDate.BackgroundImage")));
			this.cboExDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.cboExDate.FlatAppearance.BorderSize = 0;
			this.cboExDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cboExDate.Location = new System.Drawing.Point(130, 6);
			this.cboExDate.Name = "cboExDate";
			this.cboExDate.Size = new System.Drawing.Size(22, 22);
			this.cboExDate.TabIndex = 9;
			this.cboExDate.Tag = "lblExDate";
			this.cboExDate.UseVisualStyleBackColor = false;
			// 
			// btnAddRow
			// 
			this.btnAddRow.BackColor = System.Drawing.Color.CadetBlue;
			this.btnAddRow.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.btnAddRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAddRow.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnAddRow.BorderRadius = 0;
			this.btnAddRow.BorderSize = 0;
			this.btnAddRow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAddRow.FlatAppearance.BorderSize = 0;
			this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddRow.ForeColor = System.Drawing.Color.White;
			this.btnAddRow.Image = global::P05_Business.Properties.Resources.inbox_inbox;
			this.btnAddRow.Location = new System.Drawing.Point(0, 0);
			this.btnAddRow.Name = "btnAddRow";
			this.btnAddRow.Size = new System.Drawing.Size(94, 29);
			this.btnAddRow.TabIndex = 3;
			this.btnAddRow.Text = "가져오기";
			this.btnAddRow.TextColor = System.Drawing.Color.White;
			this.btnAddRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddRow.UseVisualStyleBackColor = false;
			this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
			// 
			// frmExchangeRateMng
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 561);
			this.Name = "frmExchangeRateMng";
			this.Text = "환율관리";
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
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvList;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label6;
		private P02_K_CONTROL_WIN.KButton btnAddRow;
		private P02_K_CONTROL_WIN.KButtonCalendar cboExDate;
		private System.Windows.Forms.Label lblExDate;
	}
}