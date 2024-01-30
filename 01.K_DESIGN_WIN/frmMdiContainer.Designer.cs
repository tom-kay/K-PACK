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
            this.trvSubMenu = new System.Windows.Forms.TreeView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panelTopMenuBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnMenu5 = new System.Windows.Forms.Button();
            this.btnMenu4 = new System.Windows.Forms.Button();
            this.btnMenu3 = new System.Windows.Forms.Button();
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.btnMenu1 = new System.Windows.Forms.Button();
            this.btnMenu0 = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximum = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.PictureBox();
            this.btnMinimum = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.tmDateTime = new System.Windows.Forms.Timer(this.components);
            this.pnlMainContainer.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlBottomBar.SuspendLayout();
            this.panelSubMenuBar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panelTopMenuBar.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimum)).BeginInit();
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
            this.pnlDesktopPane.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktopPane.Location = new System.Drawing.Point(203, 0);
            this.pnlDesktopPane.Name = "pnlDesktopPane";
            this.pnlDesktopPane.Size = new System.Drawing.Size(821, 660);
            this.pnlDesktopPane.TabIndex = 5;
            // 
            // pnlMenuTab
            // 
            this.pnlMenuTab.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            this.panelSubMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelSubMenuBar.Controls.Add(this.trvSubMenu);
            this.panelSubMenuBar.Controls.Add(this.lblTitle);
            this.panelSubMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSubMenuBar.Location = new System.Drawing.Point(0, 0);
            this.panelSubMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSubMenuBar.Name = "panelSubMenuBar";
            this.panelSubMenuBar.Size = new System.Drawing.Size(200, 708);
            this.panelSubMenuBar.TabIndex = 2;
            // 
            // trvSubMenu
            // 
            this.trvSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.trvSubMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvSubMenu.Location = new System.Drawing.Point(0, 29);
            this.trvSubMenu.Name = "trvSubMenu";
            this.trvSubMenu.Size = new System.Drawing.Size(200, 679);
            this.trvSubMenu.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("CookieRun Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
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
            this.panelTopMenuBar.Controls.Add(this.btnCloseChildForm);
            this.panelTopMenuBar.Controls.Add(this.btnMenu5);
            this.panelTopMenuBar.Controls.Add(this.btnMenu4);
            this.panelTopMenuBar.Controls.Add(this.btnMenu3);
            this.panelTopMenuBar.Controls.Add(this.btnMenu2);
            this.panelTopMenuBar.Controls.Add(this.btnMenu1);
            this.panelTopMenuBar.Controls.Add(this.btnMenu0);
            this.panelTopMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenuBar.Location = new System.Drawing.Point(200, 16);
            this.panelTopMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTopMenuBar.Name = "panelTopMenuBar";
            this.panelTopMenuBar.Size = new System.Drawing.Size(824, 44);
            this.panelTopMenuBar.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(777, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(47, 44);
            this.btnCloseChildForm.TabIndex = 7;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // btnMenu5
            // 
            this.btnMenu5.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu5.FlatAppearance.BorderSize = 0;
            this.btnMenu5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMenu5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu5.Font = new System.Drawing.Font("CookieRun Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenu5.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu5.Location = new System.Drawing.Point(500, 0);
            this.btnMenu5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu5.Name = "btnMenu5";
            this.btnMenu5.Size = new System.Drawing.Size(100, 44);
            this.btnMenu5.TabIndex = 6;
            this.btnMenu5.Text = "MEMU6";
            this.btnMenu5.UseVisualStyleBackColor = true;
            // 
            // btnMenu4
            // 
            this.btnMenu4.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu4.FlatAppearance.BorderSize = 0;
            this.btnMenu4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMenu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu4.Font = new System.Drawing.Font("CookieRun Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenu4.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu4.Location = new System.Drawing.Point(400, 0);
            this.btnMenu4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu4.Name = "btnMenu4";
            this.btnMenu4.Size = new System.Drawing.Size(100, 44);
            this.btnMenu4.TabIndex = 5;
            this.btnMenu4.Text = "MEMU5";
            this.btnMenu4.UseVisualStyleBackColor = true;
            // 
            // btnMenu3
            // 
            this.btnMenu3.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu3.FlatAppearance.BorderSize = 0;
            this.btnMenu3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMenu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu3.Font = new System.Drawing.Font("CookieRun Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenu3.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu3.Location = new System.Drawing.Point(300, 0);
            this.btnMenu3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu3.Name = "btnMenu3";
            this.btnMenu3.Size = new System.Drawing.Size(100, 44);
            this.btnMenu3.TabIndex = 4;
            this.btnMenu3.Text = "MEMU4";
            this.btnMenu3.UseVisualStyleBackColor = true;
            // 
            // btnMenu2
            // 
            this.btnMenu2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu2.FlatAppearance.BorderSize = 0;
            this.btnMenu2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu2.Font = new System.Drawing.Font("CookieRun Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenu2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu2.Location = new System.Drawing.Point(200, 0);
            this.btnMenu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(100, 44);
            this.btnMenu2.TabIndex = 3;
            this.btnMenu2.Text = "MEMU3";
            this.btnMenu2.UseVisualStyleBackColor = true;
            // 
            // btnMenu1
            // 
            this.btnMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu1.FlatAppearance.BorderSize = 0;
            this.btnMenu1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu1.Font = new System.Drawing.Font("CookieRun Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenu1.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu1.Location = new System.Drawing.Point(100, 0);
            this.btnMenu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(100, 44);
            this.btnMenu1.TabIndex = 2;
            this.btnMenu1.Text = "MEMU2";
            this.btnMenu1.UseVisualStyleBackColor = true;
            // 
            // btnMenu0
            // 
            this.btnMenu0.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu0.FlatAppearance.BorderSize = 0;
            this.btnMenu0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMenu0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu0.Font = new System.Drawing.Font("CookieRun Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenu0.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu0.Location = new System.Drawing.Point(0, 0);
            this.btnMenu0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenu0.Name = "btnMenu0";
            this.btnMenu0.Size = new System.Drawing.Size(100, 44);
            this.btnMenu0.TabIndex = 1;
            this.btnMenu0.Text = "MEMU1";
            this.btnMenu0.UseVisualStyleBackColor = true;
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
            this.pnlTitleBar.Size = new System.Drawing.Size(824, 16);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMaximum
            // 
            this.btnMaximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximum.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximum.Image = global::_01.K_DESIGN_WIN.Properties.Resources.btnMaximizar;
            this.btnMaximum.Location = new System.Drawing.Point(764, 0);
            this.btnMaximum.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(30, 16);
            this.btnMaximum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximum.TabIndex = 3;
            this.btnMaximum.TabStop = false;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::_01.K_DESIGN_WIN.Properties.Resources.btnCerrar;
            this.btnExit.Location = new System.Drawing.Point(794, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 16);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.Transparent;
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.Image = global::_01.K_DESIGN_WIN.Properties.Resources.btnRestaurar;
            this.btnNormal.Location = new System.Drawing.Point(764, 0);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(2);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(30, 16);
            this.btnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNormal.TabIndex = 1;
            this.btnNormal.TabStop = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMinimum
            // 
            this.btnMinimum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimum.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimum.Image = global::_01.K_DESIGN_WIN.Properties.Resources.btnMinimizar;
            this.btnMinimum.Location = new System.Drawing.Point(734, 0);
            this.btnMinimum.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(30, 16);
            this.btnMinimum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimum.TabIndex = 0;
            this.btnMinimum.TabStop = false;
            this.btnMinimum.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
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
            this.pnlBottomBar.ResumeLayout(false);
            this.pnlBottomBar.PerformLayout();
            this.panelSubMenuBar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.panelTopMenuBar.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected Panel pnlDesktopPane;
        protected TreeView trvSubMenu;
        protected Panel pnlMainContainer;
        protected Panel pnlTitleBar;
        protected PictureBox btnMinimum;
        protected PictureBox btnExit;
        protected PictureBox btnNormal;
        protected Panel panelTopMenuBar;
        protected Button btnCloseChildForm;
        protected Button btnMenu5;
        protected Button btnMenu4;
        protected Button btnMenu3;
        protected Button btnMenu2;
        protected Button btnMenu1;
        protected Button btnMenu0;
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
    }
}
