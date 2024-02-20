namespace P01_K_DESIGN_WIN
{
    partial class frmMessageBox
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
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.labelCaption = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panelBody = new System.Windows.Forms.Panel();
			this.labelMessage = new System.Windows.Forms.Label();
			this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
			this.panelTitleBar.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.panelBody.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panelTitleBar.Controls.Add(this.labelCaption);
			this.panelTitleBar.Controls.Add(this.btnClose);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(2, 2);
			this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(404, 32);
			this.panelTitleBar.TabIndex = 3;
			this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
			// 
			// labelCaption
			// 
			this.labelCaption.AutoSize = true;
			this.labelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCaption.ForeColor = System.Drawing.Color.White;
			this.labelCaption.Location = new System.Drawing.Point(10, 7);
			this.labelCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCaption.Name = "labelCaption";
			this.labelCaption.Size = new System.Drawing.Size(109, 20);
			this.labelCaption.TabIndex = 4;
			this.labelCaption.Text = "labelCaption";
			// 
			// btnClose
			// 
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(357, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(47, 32);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			// 
			// panelButtons
			// 
			this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
			this.panelButtons.Controls.Add(this.button3);
			this.panelButtons.Controls.Add(this.button2);
			this.panelButtons.Controls.Add(this.button1);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(2, 81);
			this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(404, 55);
			this.panelButtons.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.SeaGreen;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.button3.Location = new System.Drawing.Point(270, 11);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(117, 32);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.SeaGreen;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.button2.Location = new System.Drawing.Point(146, 11);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(117, 32);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SeaGreen;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.button1.Location = new System.Drawing.Point(22, 11);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// panelBody
			// 
			this.panelBody.AutoSize = true;
			this.panelBody.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelBody.Controls.Add(this.labelMessage);
			this.panelBody.Controls.Add(this.pictureBoxIcon);
			this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBody.Location = new System.Drawing.Point(2, 34);
			this.panelBody.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panelBody.Name = "panelBody";
			this.panelBody.Padding = new System.Windows.Forms.Padding(12, 9, 0, 0);
			this.panelBody.Size = new System.Drawing.Size(404, 47);
			this.panelBody.TabIndex = 5;
			// 
			// labelMessage
			// 
			this.labelMessage.AutoSize = true;
			this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMessage.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.labelMessage.Location = new System.Drawing.Point(59, 9);
			this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMessage.MaximumSize = new System.Drawing.Size(700, 0);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Padding = new System.Windows.Forms.Padding(6, 5, 12, 14);
			this.labelMessage.Size = new System.Drawing.Size(122, 40);
			this.labelMessage.TabIndex = 1;
			this.labelMessage.Text = "labelMessage";
			this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBoxIcon
			// 
			this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBoxIcon.Image = global::P01_K_DESIGN_WIN.Properties.Resources.chat;
			this.pictureBoxIcon.Location = new System.Drawing.Point(12, 9);
			this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureBoxIcon.Name = "pictureBoxIcon";
			this.pictureBoxIcon.Size = new System.Drawing.Size(47, 38);
			this.pictureBoxIcon.TabIndex = 0;
			this.pictureBoxIcon.TabStop = false;
			// 
			// frmMessageBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(408, 138);
			this.Controls.Add(this.panelBody);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.panelTitleBar);
			this.MinimumSize = new System.Drawing.Size(424, 110);
			this.Name = "frmMessageBox";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MessageBox";
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.panelBody.ResumeLayout(false);
			this.panelBody.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panelTitleBar;
        protected System.Windows.Forms.Label labelCaption;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Panel panelButtons;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Panel panelBody;
        protected System.Windows.Forms.Label labelMessage;
        protected System.Windows.Forms.PictureBox pictureBoxIcon;
    }
}