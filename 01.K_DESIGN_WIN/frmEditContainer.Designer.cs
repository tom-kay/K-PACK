namespace P01_K_DESIGN_WIN
{
	partial class frmEditContainer
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
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pnlBody = new System.Windows.Forms.Panel();
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.pnlHeaderBlank = new System.Windows.Forms.Panel();
			this.pnlHeaderBtns = new System.Windows.Forms.Panel();
			this.pnlPrint = new System.Windows.Forms.Panel();
			this.btnPrint = new P02_K_CONTROL_WIN.KButton();
			this.pnlInit = new System.Windows.Forms.Panel();
			this.btnInit = new P02_K_CONTROL_WIN.KButton();
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.btnSearch = new P02_K_CONTROL_WIN.KButton();
			this.pnlSave = new System.Windows.Forms.Panel();
			this.btnSave = new P02_K_CONTROL_WIN.KButton();
			this.pnlDelete = new System.Windows.Forms.Panel();
			this.btnDelete = new P02_K_CONTROL_WIN.KButton();
			this.pnlClose = new System.Windows.Forms.Panel();
			this.btnClose = new P02_K_CONTROL_WIN.KButton();
			this.pnlMain.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			this.pnlHeaderBtns.SuspendLayout();
			this.pnlPrint.SuspendLayout();
			this.pnlInit.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			this.pnlSave.SuspendLayout();
			this.pnlDelete.SuspendLayout();
			this.pnlClose.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.pnlBody);
			this.pnlMain.Controls.Add(this.pnlHeader);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(1008, 729);
			this.pnlMain.TabIndex = 0;
			// 
			// pnlBody
			// 
			this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBody.Location = new System.Drawing.Point(0, 35);
			this.pnlBody.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
			this.pnlBody.Name = "pnlBody";
			this.pnlBody.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.pnlBody.Size = new System.Drawing.Size(1008, 694);
			this.pnlBody.TabIndex = 1;
			// 
			// pnlHeader
			// 
			this.pnlHeader.Controls.Add(this.pnlHeaderBlank);
			this.pnlHeader.Controls.Add(this.pnlHeaderBtns);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(1008, 35);
			this.pnlHeader.TabIndex = 0;
			// 
			// pnlHeaderBlank
			// 
			this.pnlHeaderBlank.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlHeaderBlank.Location = new System.Drawing.Point(0, 0);
			this.pnlHeaderBlank.Name = "pnlHeaderBlank";
			this.pnlHeaderBlank.Size = new System.Drawing.Size(471, 35);
			this.pnlHeaderBlank.TabIndex = 1;
			// 
			// pnlHeaderBtns
			// 
			this.pnlHeaderBtns.Controls.Add(this.pnlPrint);
			this.pnlHeaderBtns.Controls.Add(this.pnlInit);
			this.pnlHeaderBtns.Controls.Add(this.pnlSearch);
			this.pnlHeaderBtns.Controls.Add(this.pnlSave);
			this.pnlHeaderBtns.Controls.Add(this.pnlDelete);
			this.pnlHeaderBtns.Controls.Add(this.pnlClose);
			this.pnlHeaderBtns.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlHeaderBtns.Location = new System.Drawing.Point(471, 0);
			this.pnlHeaderBtns.Name = "pnlHeaderBtns";
			this.pnlHeaderBtns.Size = new System.Drawing.Size(537, 35);
			this.pnlHeaderBtns.TabIndex = 0;
			// 
			// pnlPrint
			// 
			this.pnlPrint.Controls.Add(this.btnPrint);
			this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlPrint.Location = new System.Drawing.Point(51, 0);
			this.pnlPrint.Name = "pnlPrint";
			this.pnlPrint.Padding = new System.Windows.Forms.Padding(3);
			this.pnlPrint.Size = new System.Drawing.Size(81, 35);
			this.pnlPrint.TabIndex = 3;
			// 
			// btnPrint
			// 
			this.btnPrint.BackColor = System.Drawing.Color.CadetBlue;
			this.btnPrint.BackgroundColor = System.Drawing.Color.CadetBlue;
			this.btnPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnPrint.BorderRadius = 0;
			this.btnPrint.BorderSize = 0;
			this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnPrint.FlatAppearance.BorderSize = 0;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnPrint.ForeColor = System.Drawing.Color.White;
			this.btnPrint.Location = new System.Drawing.Point(3, 3);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 29);
			this.btnPrint.TabIndex = 0;
			this.btnPrint.Text = "출력";
			this.btnPrint.TextColor = System.Drawing.Color.White;
			this.btnPrint.UseVisualStyleBackColor = false;
			// 
			// pnlInit
			// 
			this.pnlInit.Controls.Add(this.btnInit);
			this.pnlInit.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlInit.Location = new System.Drawing.Point(132, 0);
			this.pnlInit.Name = "pnlInit";
			this.pnlInit.Padding = new System.Windows.Forms.Padding(3);
			this.pnlInit.Size = new System.Drawing.Size(81, 35);
			this.pnlInit.TabIndex = 5;
			// 
			// btnInit
			// 
			this.btnInit.BackColor = System.Drawing.Color.Goldenrod;
			this.btnInit.BackgroundColor = System.Drawing.Color.Goldenrod;
			this.btnInit.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnInit.BorderRadius = 0;
			this.btnInit.BorderSize = 0;
			this.btnInit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnInit.FlatAppearance.BorderSize = 0;
			this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnInit.ForeColor = System.Drawing.Color.White;
			this.btnInit.Location = new System.Drawing.Point(3, 3);
			this.btnInit.Name = "btnInit";
			this.btnInit.Size = new System.Drawing.Size(75, 29);
			this.btnInit.TabIndex = 0;
			this.btnInit.Text = "초기화";
			this.btnInit.TextColor = System.Drawing.Color.White;
			this.btnInit.UseVisualStyleBackColor = false;
			this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
			// 
			// pnlSearch
			// 
			this.pnlSearch.Controls.Add(this.btnSearch);
			this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlSearch.Location = new System.Drawing.Point(213, 0);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Padding = new System.Windows.Forms.Padding(3);
			this.pnlSearch.Size = new System.Drawing.Size(81, 35);
			this.pnlSearch.TabIndex = 4;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.Chocolate;
			this.btnSearch.BackgroundColor = System.Drawing.Color.Chocolate;
			this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnSearch.BorderRadius = 0;
			this.btnSearch.BorderSize = 0;
			this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(3, 3);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 29);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "조회";
			this.btnSearch.TextColor = System.Drawing.Color.White;
			this.btnSearch.UseVisualStyleBackColor = false;
			// 
			// pnlSave
			// 
			this.pnlSave.Controls.Add(this.btnSave);
			this.pnlSave.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlSave.Location = new System.Drawing.Point(294, 0);
			this.pnlSave.Name = "pnlSave";
			this.pnlSave.Padding = new System.Windows.Forms.Padding(3);
			this.pnlSave.Size = new System.Drawing.Size(81, 35);
			this.pnlSave.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
			this.btnSave.BackgroundColor = System.Drawing.Color.ForestGreen;
			this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnSave.BorderRadius = 0;
			this.btnSave.BorderSize = 0;
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(3, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 29);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "저장";
			this.btnSave.TextColor = System.Drawing.Color.White;
			this.btnSave.UseVisualStyleBackColor = false;
			// 
			// pnlDelete
			// 
			this.pnlDelete.Controls.Add(this.btnDelete);
			this.pnlDelete.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlDelete.Location = new System.Drawing.Point(375, 0);
			this.pnlDelete.Name = "pnlDelete";
			this.pnlDelete.Padding = new System.Windows.Forms.Padding(3);
			this.pnlDelete.Size = new System.Drawing.Size(81, 35);
			this.pnlDelete.TabIndex = 1;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
			this.btnDelete.BackgroundColor = System.Drawing.Color.IndianRed;
			this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnDelete.BorderRadius = 0;
			this.btnDelete.BorderSize = 0;
			this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(3, 3);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 29);
			this.btnDelete.TabIndex = 0;
			this.btnDelete.Text = "삭제";
			this.btnDelete.TextColor = System.Drawing.Color.White;
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// pnlClose
			// 
			this.pnlClose.Controls.Add(this.btnClose);
			this.pnlClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlClose.Location = new System.Drawing.Point(456, 0);
			this.pnlClose.Name = "pnlClose";
			this.pnlClose.Padding = new System.Windows.Forms.Padding(3);
			this.pnlClose.Size = new System.Drawing.Size(81, 35);
			this.pnlClose.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Gray;
			this.btnClose.BackgroundColor = System.Drawing.Color.Gray;
			this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnClose.BorderRadius = 0;
			this.btnClose.BorderSize = 0;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(3, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 29);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "닫기";
			this.btnClose.TextColor = System.Drawing.Color.White;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmEditContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.pnlMain);
			this.MinimumSize = new System.Drawing.Size(1024, 768);
			this.Name = "frmEditContainer";
			this.Load += new System.EventHandler(this.frmEditContainer_Load);
			this.pnlMain.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeaderBtns.ResumeLayout(false);
			this.pnlPrint.ResumeLayout(false);
			this.pnlInit.ResumeLayout(false);
			this.pnlSearch.ResumeLayout(false);
			this.pnlSave.ResumeLayout(false);
			this.pnlDelete.ResumeLayout(false);
			this.pnlClose.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		public Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
		public System.Windows.Forms.Panel pnlMain;
		public System.Windows.Forms.Panel pnlBody;
		public System.Windows.Forms.Panel pnlHeader;
		public System.Windows.Forms.Panel pnlHeaderBtns;
		public System.Windows.Forms.Panel pnlHeaderBlank;
		public System.Windows.Forms.Panel pnlPrint;
		public P02_K_CONTROL_WIN.KButton btnPrint;
		public System.Windows.Forms.Panel pnlSave;
		public P02_K_CONTROL_WIN.KButton btnSave;
		public System.Windows.Forms.Panel pnlDelete;
		public P02_K_CONTROL_WIN.KButton btnDelete;
		public System.Windows.Forms.Panel pnlClose;
		public P02_K_CONTROL_WIN.KButton btnClose;
		public System.Windows.Forms.Panel pnlSearch;
		public P02_K_CONTROL_WIN.KButton btnSearch;
		public System.Windows.Forms.Panel pnlInit;
		public P02_K_CONTROL_WIN.KButton btnInit;
	}
}