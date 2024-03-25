namespace P05_Business.S03_Views.Base
{
	partial class frmCustomerList
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
			this.pnlClose.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			this.pnlInit.SuspendLayout();
			this.pnlPrint.SuspendLayout();
			this.pnlSearchMain.SuspendLayout();
			this.pnlSearchButtonBar.SuspendLayout();
			this.pnlButtons.SuspendLayout();
			this.pnlSearchOptional.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.FlatAppearance.BorderSize = 0;
			// 
			// btnInit
			// 
			this.btnInit.FlatAppearance.BorderSize = 0;
			// 
			// btnPrint
			// 
			this.btnPrint.FlatAppearance.BorderSize = 0;
			// 
			// pnlBody
			// 
			this.pnlBody.Location = new System.Drawing.Point(0, 125);
			this.pnlBody.Size = new System.Drawing.Size(800, 436);
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
			this.pnlSearchOptional.Size = new System.Drawing.Size(800, 90);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 70);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// frmCustomerList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 561);
			this.Name = "frmCustomerList";
			this.Text = "frmCustomerList";
			this.pnlClose.ResumeLayout(false);
			this.pnlSearch.ResumeLayout(false);
			this.pnlInit.ResumeLayout(false);
			this.pnlPrint.ResumeLayout(false);
			this.pnlSearchMain.ResumeLayout(false);
			this.pnlSearchMain.PerformLayout();
			this.pnlSearchButtonBar.ResumeLayout(false);
			this.pnlButtons.ResumeLayout(false);
			this.pnlSearchOptional.ResumeLayout(false);
			this.pnlSearchOptional.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}