using System.Drawing;
using System.Windows.Forms;

namespace _01.K_DESIGN_WIN
{
    partial class frmMdiContainer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMdiContainer));
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlDesktopPane = new System.Windows.Forms.Panel();
            this.pnlMenuTab = new System.Windows.Forms.Panel();
            this.pnlBottomBar = new System.Windows.Forms.Panel();
            this.lblMainMsg = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.splMenu = new System.Windows.Forms.Splitter();
            this.panelSubMenuBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panelTopMenuBar = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximum = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.btnMinimum = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.tmDateTime = new System.Windows.Forms.Timer(this.components);
            this.kTabControl1 = new _02.K_CONTROL_WIN.KTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.pnlMainContainer.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlMenuTab.SuspendLayout();
            this.pnlBottomBar.SuspendLayout();
            this.panelSubMenuBar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimum)).BeginInit();
            this.kTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMainContainer.Controls.Add(this.pnlBody);
            this.pnlMainContainer.Controls.Add(this.pnlHeader);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1024, 768);
            this.pnlMainContainer.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlDesktopPane);
            this.pnlBody.Controls.Add(this.pnlMenuTab);
            this.pnlBody.Controls.Add(this.pnlBottomBar);
            this.pnlBody.Controls.Add(this.splMenu);
            this.pnlBody.Controls.Add(this.panelSubMenuBar);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1024, 708);
            this.pnlBody.TabIndex = 6;
            // 
            // pnlDesktopPane
            // 
            this.pnlDesktopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(199)))), ((int)(((byte)(255)))));
            this.pnlDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktopPane.Location = new System.Drawing.Point(203, 0);
            this.pnlDesktopPane.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDesktopPane.Name = "pnlDesktopPane";
            this.pnlDesktopPane.Size = new System.Drawing.Size(821, 660);
            this.pnlDesktopPane.TabIndex = 5;
            // 
            // pnlMenuTab
            // 
            this.pnlMenuTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(100)))), ((int)(((byte)(146)))));
            this.pnlMenuTab.Controls.Add(this.kTabControl1);
            this.pnlMenuTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMenuTab.Location = new System.Drawing.Point(203, 660);
            this.pnlMenuTab.Name = "pnlMenuTab";
            this.pnlMenuTab.Size = new System.Drawing.Size(821, 24);
            this.pnlMenuTab.TabIndex = 6;
            // 
            // pnlBottomBar
            // 
            this.pnlBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.pnlBottomBar.Controls.Add(this.lblMainMsg);
            this.pnlBottomBar.Controls.Add(this.lblDate);
            this.pnlBottomBar.Controls.Add(this.lblTime);
            this.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomBar.Location = new System.Drawing.Point(203, 684);
            this.pnlBottomBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBottomBar.Name = "pnlBottomBar";
            this.pnlBottomBar.Size = new System.Drawing.Size(821, 24);
            this.pnlBottomBar.TabIndex = 3;
            // 
            // lblMainMsg
            // 
            this.lblMainMsg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMainMsg.AutoSize = true;
            this.lblMainMsg.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMsg.ForeColor = System.Drawing.Color.White;
            this.lblMainMsg.Location = new System.Drawing.Point(4, 6);
            this.lblMainMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainMsg.Name = "lblMainMsg";
            this.lblMainMsg.Size = new System.Drawing.Size(53, 15);
            this.lblMainMsg.TabIndex = 2;
            this.lblMainMsg.Text = "Message";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(552, 4);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(165, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "9999년 12월 31일 일요일";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(725, 4);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 20);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00";
            // 
            // splMenu
            // 
            this.splMenu.Location = new System.Drawing.Point(200, 0);
            this.splMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splMenu.Name = "splMenu";
            this.splMenu.Size = new System.Drawing.Size(3, 708);
            this.splMenu.TabIndex = 4;
            this.splMenu.TabStop = false;
            // 
            // panelSubMenuBar
            // 
            this.panelSubMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.panelSubMenuBar.Controls.Add(this.btnCloseChildForm);
            this.panelSubMenuBar.Controls.Add(this.lblTitle);
            this.panelSubMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSubMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelSubMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSubMenuBar.Name = "panelSubMenuBar";
            this.panelSubMenuBar.Size = new System.Drawing.Size(200, 708);
            this.panelSubMenuBar.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.pnlHeader.Controls.Add(this.panelTopMenuBar);
            this.pnlHeader.Controls.Add(this.pnlTitleBar);
            this.pnlHeader.Controls.Add(this.panelLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1024, 60);
            this.pnlHeader.TabIndex = 5;
            // 
            // panelTopMenuBar
            // 
            this.panelTopMenuBar.BackColor = System.Drawing.Color.Transparent;
            this.panelTopMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenuBar.Location = new System.Drawing.Point(200, 30);
            this.panelTopMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTopMenuBar.Name = "panelTopMenuBar";
            this.panelTopMenuBar.Size = new System.Drawing.Size(824, 30);
            this.panelTopMenuBar.TabIndex = 1;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitleBar.Controls.Add(this.btnMaximum);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Controls.Add(this.btnNormal);
            this.pnlTitleBar.Controls.Add(this.btnMinimum);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(200, 0);
            this.pnlTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(824, 30);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMaximum
            // 
            this.btnMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximum.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximum.Image = global::_01.K_DESIGN_WIN.Properties.Resources.btnMaximizar;
            this.btnMaximum.Location = new System.Drawing.Point(764, 0);
            this.btnMaximum.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(30, 30);
            this.btnMaximum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximum.TabIndex = 3;
            this.btnMaximum.TabStop = false;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::_01.K_DESIGN_WIN.Properties.Resources.btnCerrar;
            this.btnExit.Location = new System.Drawing.Point(794, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.Image = global::_01.K_DESIGN_WIN.Properties.Resources.btnRestaurar;
            this.btnNormal.Location = new System.Drawing.Point(764, 0);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(2);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(30, 30);
            this.btnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNormal.TabIndex = 1;
            this.btnNormal.TabStop = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMinimum
            // 
            this.btnMinimum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimum.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimum.Image = global::_01.K_DESIGN_WIN.Properties.Resources.btnMinimizar;
            this.btnMinimum.Location = new System.Drawing.Point(734, 0);
            this.btnMinimum.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(30, 30);
            this.btnMinimum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimum.TabIndex = 0;
            this.btnMinimum.TabStop = false;
            this.btnMinimum.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // tmDateTime
            // 
            this.tmDateTime.Enabled = true;
            this.tmDateTime.Tick += new System.EventHandler(this.tmDateTime_Tick);
            // 
            // kTabControl1
            // 
            this.kTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.kTabControl1.Controls.Add(this.tabPage1);
            this.kTabControl1.Controls.Add(this.tabPage2);
            this.kTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.kTabControl1.ItemSize = new System.Drawing.Size(120, 21);
            this.kTabControl1.Location = new System.Drawing.Point(0, 0);
            this.kTabControl1.Name = "kTabControl1";
            this.kTabControl1.SelectedIndex = 0;
            this.kTabControl1.Size = new System.Drawing.Size(821, 24);
            this.kTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.kTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 664);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(200, 44);
            this.btnCloseChildForm.TabIndex = 8;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            // 
            // frmMdiContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pnlMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "frmMdiContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlMainContainer.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlMenuTab.ResumeLayout(false);
            this.pnlBottomBar.ResumeLayout(false);
            this.pnlBottomBar.PerformLayout();
            this.panelSubMenuBar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimum)).EndInit();
            this.kTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected Panel pnlDesktopPane;
        protected Panel pnlMainContainer;
        protected Panel pnlTitleBar;
        protected PictureBox btnMinimum;
        protected PictureBox btnExit;
        protected PictureBox btnNormal;
        protected Panel panelTopMenuBar;
        protected Panel panelLogo;
        protected Panel panelSubMenuBar;
        protected Label lblTitle;
        protected Panel pnlBottomBar;
        protected Label lblTime;
        protected Label lblDate;
        protected Label lblMainMsg;
        protected PictureBox btnMaximum;
        protected Timer tmDateTime;
        protected Splitter splMenu;
        protected Panel pnlHeader;
        protected Panel pnlBody;
        protected Panel pnlMenuTab;
        private _02.K_CONTROL_WIN.KTabControl kTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        protected Button btnCloseChildForm;
    }
}
