namespace P05_Business.S03_Views.Popup.Common
{
	partial class frmLoading
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.picLoading1 = new System.Windows.Forms.PictureBox();
			this.btnCloseForm = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLoading1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureBox1.Image = global::P05_Business.Properties.Resources.loading2;
			this.pictureBox1.Location = new System.Drawing.Point(0, 128);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 33);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// picLoading1
			// 
			this.picLoading1.Dock = System.Windows.Forms.DockStyle.Top;
			this.picLoading1.Image = global::P05_Business.Properties.Resources.loading;
			this.picLoading1.Location = new System.Drawing.Point(0, 0);
			this.picLoading1.Name = "picLoading1";
			this.picLoading1.Size = new System.Drawing.Size(128, 128);
			this.picLoading1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picLoading1.TabIndex = 0;
			this.picLoading1.TabStop = false;
			// 
			// btnCloseForm
			// 
			this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCloseForm.AutoSize = true;
			this.btnCloseForm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold);
			this.btnCloseForm.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.btnCloseForm.Location = new System.Drawing.Point(43, 164);
			this.btnCloseForm.Name = "btnCloseForm";
			this.btnCloseForm.Size = new System.Drawing.Size(43, 17);
			this.btnCloseForm.TabIndex = 3;
			this.btnCloseForm.TabStop = true;
			this.btnCloseForm.Text = "CLOSE";
			this.btnCloseForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCloseForm_LinkClicked);
			// 
			// frmLoading
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(128, 179);
			this.Controls.Add(this.btnCloseForm);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.picLoading1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLoading";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmLoading";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.White;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLoading1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picLoading1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.LinkLabel btnCloseForm;
	}
}