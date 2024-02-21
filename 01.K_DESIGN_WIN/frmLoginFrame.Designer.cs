namespace P01_K_DESIGN_WIN
{
    partial class frmLoginFrame
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginFrame));
			this.pnlLogo = new System.Windows.Forms.Panel();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnlogin = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.PictureBox();
			this.btnMinimize = new System.Windows.Forms.PictureBox();
			this.pnlBody = new System.Windows.Forms.Panel();
			this.pnlLogin = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pnlLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
			this.pnlBody.SuspendLayout();
			this.pnlLogin.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlLogo
			// 
			this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.pnlLogo.Controls.Add(this.picLogo);
			this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLogo.Location = new System.Drawing.Point(0, 0);
			this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Size = new System.Drawing.Size(292, 305);
			this.pnlLogo.TabIndex = 0;
			this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(80, 111);
			this.picLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(133, 83);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo.TabIndex = 0;
			this.picLogo.TabStop = false;
			// 
			// txtUser
			// 
			this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
			this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser.ForeColor = System.Drawing.Color.Silver;
			this.txtUser.Location = new System.Drawing.Point(4, 5);
			this.txtUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(313, 27);
			this.txtUser.TabIndex = 1;
			this.txtUser.Text = "User";
			// 
			// txtPass
			// 
			this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
			this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPass.ForeColor = System.Drawing.Color.Silver;
			this.txtPass.Location = new System.Drawing.Point(4, 6);
			this.txtPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(313, 27);
			this.txtPass.TabIndex = 2;
			this.txtPass.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(259, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 32);
			this.label1.TabIndex = 4;
			this.label1.Text = "LOGIN";
			// 
			// btnlogin
			// 
			this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
			this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
			this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
			this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnlogin.ForeColor = System.Drawing.Color.LightGray;
			this.btnlogin.Location = new System.Drawing.Point(71, 252);
			this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnlogin.Name = "btnlogin";
			this.btnlogin.Size = new System.Drawing.Size(476, 37);
			this.btnlogin.TabIndex = 3;
			this.btnlogin.Text = "LOGIN";
			this.btnlogin.UseVisualStyleBackColor = false;
			this.btnlogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnClose
			// 
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(587, 12);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(18, 14);
			this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClose.TabIndex = 7;
			this.btnClose.TabStop = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.Location = new System.Drawing.Point(561, 12);
			this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(18, 14);
			this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimize.TabIndex = 8;
			this.btnMinimize.TabStop = false;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// pnlBody
			// 
			this.pnlBody.Controls.Add(this.pnlLogin);
			this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBody.Location = new System.Drawing.Point(292, 0);
			this.pnlBody.Name = "pnlBody";
			this.pnlBody.Size = new System.Drawing.Size(618, 305);
			this.pnlBody.TabIndex = 9;
			// 
			// pnlLogin
			// 
			this.pnlLogin.Controls.Add(this.tableLayoutPanel1);
			this.pnlLogin.Controls.Add(this.btnMinimize);
			this.pnlLogin.Controls.Add(this.btnClose);
			this.pnlLogin.Controls.Add(this.btnlogin);
			this.pnlLogin.Controls.Add(this.label1);
			this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLogin.Location = new System.Drawing.Point(0, 0);
			this.pnlLogin.Name = "pnlLogin";
			this.pnlLogin.Size = new System.Drawing.Size(618, 305);
			this.pnlLogin.TabIndex = 9;
			this.pnlLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.85034F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.14966F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(89, 103);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 87);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(108, 37);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.label2.ForeColor = System.Drawing.Color.Silver;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 37);
			this.label2.TabIndex = 9;
			this.label2.Text = "USER ID";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtUser);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(117, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(321, 37);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label3);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 46);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(108, 38);
			this.panel3.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.label3.ForeColor = System.Drawing.Color.Silver;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 38);
			this.label3.TabIndex = 12;
			this.label3.Text = "PASSWORD";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.txtPass);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(117, 46);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(321, 38);
			this.panel4.TabIndex = 3;
			// 
			// frmLoginFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
			this.ClientSize = new System.Drawing.Size(910, 305);
			this.Controls.Add(this.pnlBody);
			this.Controls.Add(this.pnlLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "frmLoginFrame";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveWindow);
			this.pnlLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
			this.pnlBody.ResumeLayout(false);
			this.pnlLogin.ResumeLayout(false);
			this.pnlLogin.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		public System.Windows.Forms.Panel pnlLogo;
		public System.Windows.Forms.TextBox txtUser;
		public System.Windows.Forms.TextBox txtPass;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.PictureBox picLogo;
		public System.Windows.Forms.PictureBox btnClose;
		public System.Windows.Forms.PictureBox btnMinimize;
		public System.Windows.Forms.Panel pnlBody;
		public System.Windows.Forms.Panel pnlLogin;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Button btnlogin;
	}
}

