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
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.pnlBody = new System.Windows.Forms.Panel();
			this.pnlHeaderBtns = new System.Windows.Forms.Panel();
			this.pnlHeaderBlank = new System.Windows.Forms.Panel();
			this.pnlMain.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Controls.Add(this.pnlBody);
			this.pnlMain.Controls.Add(this.pnlHeader);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(800, 450);
			this.pnlMain.TabIndex = 0;
			// 
			// pnlHeader
			// 
			this.pnlHeader.Controls.Add(this.pnlHeaderBlank);
			this.pnlHeader.Controls.Add(this.pnlHeaderBtns);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(800, 50);
			this.pnlHeader.TabIndex = 0;
			// 
			// pnlBody
			// 
			this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBody.Location = new System.Drawing.Point(0, 50);
			this.pnlBody.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
			this.pnlBody.Name = "pnlBody";
			this.pnlBody.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.pnlBody.Size = new System.Drawing.Size(800, 400);
			this.pnlBody.TabIndex = 1;
			// 
			// pnlHeaderBtns
			// 
			this.pnlHeaderBtns.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlHeaderBtns.Location = new System.Drawing.Point(547, 0);
			this.pnlHeaderBtns.Name = "pnlHeaderBtns";
			this.pnlHeaderBtns.Size = new System.Drawing.Size(253, 50);
			this.pnlHeaderBtns.TabIndex = 0;
			// 
			// pnlHeaderBlank
			// 
			this.pnlHeaderBlank.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlHeaderBlank.Location = new System.Drawing.Point(0, 0);
			this.pnlHeaderBlank.Name = "pnlHeaderBlank";
			this.pnlHeaderBlank.Size = new System.Drawing.Size(547, 50);
			this.pnlHeaderBlank.TabIndex = 1;
			// 
			// frmEditContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlMain);
			this.Name = "frmEditContainer";
			this.pnlMain.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		public Microsoft.VisualBasic.PowerPacks.DataRepeater dataRepeater1;
		public System.Windows.Forms.Panel pnlMain;
		public System.Windows.Forms.Panel pnlBody;
		public System.Windows.Forms.Panel pnlHeader;
		public System.Windows.Forms.Panel pnlHeaderBtns;
		public System.Windows.Forms.Panel pnlHeaderBlank;
	}
}