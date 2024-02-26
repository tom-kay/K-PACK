namespace P05_Business.S03_Views.Popup.Common
{
	partial class frmMasterCodePopup
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
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlPopupOptional
			// 
			this.pnlPopupOptional.AutoSize = true;
			this.pnlPopupOptional.Controls.Add(this.tableLayoutPanel1);
			this.pnlPopupOptional.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.pnlPopupOptional.Size = new System.Drawing.Size(796, 55);
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
			this.pnlBody.Location = new System.Drawing.Point(0, 125);
			this.pnlBody.Size = new System.Drawing.Size(796, 321);
			// 
			// lblPopupTitle
			// 
			this.lblPopupTitle.Size = new System.Drawing.Size(696, 35);
			// 
			// pnlPopupButtonBar
			// 
			this.pnlPopupButtonBar.BackColor = System.Drawing.Color.AliceBlue;
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
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 35);
			this.tableLayoutPanel1.TabIndex = 0;
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
			this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
			this.txtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtCode.Location = new System.Drawing.Point(3, 6);
			this.txtCode.Multiline = false;
			this.txtCode.Name = "txtCode";
			this.txtCode.PasswordChar = false;
			this.txtCode.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtCode.PlaceholderText = "";
			this.txtCode.Size = new System.Drawing.Size(286, 17);
			this.txtCode.TabIndex = 0;
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
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
			this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtName.Location = new System.Drawing.Point(3, 6);
			this.txtName.Multiline = false;
			this.txtName.Name = "txtName";
			this.txtName.PasswordChar = false;
			this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
			this.txtName.PlaceholderText = "";
			this.txtName.Size = new System.Drawing.Size(286, 17);
			this.txtName.TabIndex = 0;
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
			// dgvList
			// 
			this.dgvList.BackgroundColor = System.Drawing.Color.White;
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvList.Location = new System.Drawing.Point(0, 0);
			this.dgvList.Name = "dgvList";
			this.dgvList.RowTemplate.Height = 23;
			this.dgvList.Size = new System.Drawing.Size(796, 321);
			this.dgvList.TabIndex = 0;
			this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
			// 
			// frmMasterCodePopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "frmMasterCodePopup";
			this.Text = "frmMasterCodePopup";
			this.Load += new System.EventHandler(this.frmMasterCodePopup_Load);
			this.pnlPopupOptional.ResumeLayout(false);
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
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private P02_K_CONTROL_WIN.KTextBox txtCode;
		private P02_K_CONTROL_WIN.KTextBox txtName;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvList;
	}
}