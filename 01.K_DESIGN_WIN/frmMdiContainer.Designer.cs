﻿using P02_K_CONTROL_WIN;
using System.Drawing;
using System.Windows.Forms;

namespace P01_K_DESIGN_WIN
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
			this.pnlDesktop = new System.Windows.Forms.Panel();
			this.tabMenuForm = new MetroFramework.Controls.MetroTabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pnlBottomBar = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblMainMsg = new System.Windows.Forms.Label();
			this.cboTimeZone = new MetroFramework.Controls.MetroComboBox();
			this.lblDate = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.splMenu = new System.Windows.Forms.Splitter();
			this.panelSubMenuBar = new System.Windows.Forms.Panel();
			this.panelSubMenuBarBody = new System.Windows.Forms.Panel();
			this.panelSubMenuBarBottom = new System.Windows.Forms.Panel();
			this.panelUserSetting = new System.Windows.Forms.Panel();
			this.btnUserSetting = new System.Windows.Forms.Button();
			this.panelLogout = new System.Windows.Forms.Panel();
			this.btnCloseChildForm = new System.Windows.Forms.Button();
			this.panelSubMenuBarTop = new System.Windows.Forms.Panel();
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.panelTopMenuBar = new System.Windows.Forms.Panel();
			this.lblTopMenuCaption = new System.Windows.Forms.Label();
			this.pnlTitleBar = new System.Windows.Forms.Panel();
			this.btnMaximum = new System.Windows.Forms.PictureBox();
			this.btnExit = new System.Windows.Forms.PictureBox();
			this.btnNormal = new System.Windows.Forms.PictureBox();
			this.btnMinimum = new System.Windows.Forms.PictureBox();
			this.lblTitleBarCaption = new System.Windows.Forms.Label();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.tmDateTime = new System.Windows.Forms.Timer(this.components);
			this.tip = new System.Windows.Forms.ToolTip(this.components);
			this.pnlMainContainer.SuspendLayout();
			this.pnlBody.SuspendLayout();
			this.pnlDesktop.SuspendLayout();
			this.tabMenuForm.SuspendLayout();
			this.pnlBottomBar.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelSubMenuBar.SuspendLayout();
			this.panelSubMenuBarBottom.SuspendLayout();
			this.panelUserSetting.SuspendLayout();
			this.panelLogout.SuspendLayout();
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
			this.pnlMainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
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
			this.pnlBody.Controls.Add(this.pnlDesktop);
			this.pnlBody.Controls.Add(this.pnlBottomBar);
			this.pnlBody.Controls.Add(this.splMenu);
			this.pnlBody.Controls.Add(this.panelSubMenuBar);
			this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBody.Location = new System.Drawing.Point(0, 60);
			this.pnlBody.Name = "pnlBody";
			this.pnlBody.Size = new System.Drawing.Size(1024, 708);
			this.pnlBody.TabIndex = 6;
			// 
			// pnlDesktop
			// 
			this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
			this.pnlDesktop.Controls.Add(this.tabMenuForm);
			this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDesktop.Location = new System.Drawing.Point(203, 0);
			this.pnlDesktop.Name = "pnlDesktop";
			this.pnlDesktop.Size = new System.Drawing.Size(821, 684);
			this.pnlDesktop.TabIndex = 8;
			// 
			// tabMenuForm
			// 
			this.tabMenuForm.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabMenuForm.Controls.Add(this.tabPage1);
			this.tabMenuForm.Controls.Add(this.tabPage2);
			this.tabMenuForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabMenuForm.ItemSize = new System.Drawing.Size(100, 34);
			this.tabMenuForm.Location = new System.Drawing.Point(0, 0);
			this.tabMenuForm.Name = "tabMenuForm";
			this.tabMenuForm.SelectedIndex = 0;
			this.tabMenuForm.Size = new System.Drawing.Size(821, 684);
			this.tabMenuForm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabMenuForm.TabIndex = 7;
			this.tabMenuForm.UseCustomBackColor = true;
			this.tabMenuForm.UseSelectable = true;
			this.tabMenuForm.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabMenuForm_Selected);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(813, 642);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.White;
			this.tabPage2.Location = new System.Drawing.Point(4, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(813, 642);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			// 
			// pnlBottomBar
			// 
			this.pnlBottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
			this.pnlBottomBar.Controls.Add(this.panel1);
			this.pnlBottomBar.Controls.Add(this.cboTimeZone);
			this.pnlBottomBar.Controls.Add(this.lblDate);
			this.pnlBottomBar.Controls.Add(this.lblTime);
			this.pnlBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottomBar.Location = new System.Drawing.Point(203, 684);
			this.pnlBottomBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlBottomBar.Name = "pnlBottomBar";
			this.pnlBottomBar.Size = new System.Drawing.Size(821, 24);
			this.pnlBottomBar.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblMainMsg);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(386, 24);
			this.panel1.TabIndex = 4;
			// 
			// lblMainMsg
			// 
			this.lblMainMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMainMsg.Font = new System.Drawing.Font(SystemHelper._FONT_NAME, 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMainMsg.ForeColor = System.Drawing.Color.White;
			this.lblMainMsg.Location = new System.Drawing.Point(0, 0);
			this.lblMainMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMainMsg.Name = "lblMainMsg";
			this.lblMainMsg.Size = new System.Drawing.Size(386, 24);
			this.lblMainMsg.TabIndex = 2;
			this.lblMainMsg.Text = "Message";
			this.lblMainMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cboTimeZone
			// 
			this.cboTimeZone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboTimeZone.DisplayMember = "KOREA";
			this.cboTimeZone.FontSize = MetroFramework.MetroComboBoxSize.Small;
			this.cboTimeZone.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
			this.cboTimeZone.FormattingEnabled = true;
			this.cboTimeZone.ItemHeight = 19;
			this.cboTimeZone.Location = new System.Drawing.Point(392, 0);
			this.cboTimeZone.Name = "cboTimeZone";
			this.cboTimeZone.Size = new System.Drawing.Size(110, 25);
			this.cboTimeZone.TabIndex = 3;
			this.cboTimeZone.UseSelectable = true;
			// 
			// lblDate
			// 
			this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblDate.ForeColor = System.Drawing.Color.White;
			this.lblDate.Location = new System.Drawing.Point(555, 4);
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
			this.lblTime.Location = new System.Drawing.Point(728, 4);
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
			this.panelSubMenuBar.Controls.Add(this.panelSubMenuBarBody);
			this.panelSubMenuBar.Controls.Add(this.panelSubMenuBarBottom);
			this.panelSubMenuBar.Controls.Add(this.panelSubMenuBarTop);
			this.panelSubMenuBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSubMenuBar.Location = new System.Drawing.Point(0, 0);
			this.panelSubMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelSubMenuBar.Name = "panelSubMenuBar";
			this.panelSubMenuBar.Size = new System.Drawing.Size(200, 708);
			this.panelSubMenuBar.TabIndex = 2;
			// 
			// panelSubMenuBarBody
			// 
			this.panelSubMenuBarBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSubMenuBarBody.Location = new System.Drawing.Point(0, 10);
			this.panelSubMenuBarBody.Name = "panelSubMenuBarBody";
			this.panelSubMenuBarBody.Size = new System.Drawing.Size(200, 644);
			this.panelSubMenuBarBody.TabIndex = 10;
			// 
			// panelSubMenuBarBottom
			// 
			this.panelSubMenuBarBottom.Controls.Add(this.panelUserSetting);
			this.panelSubMenuBarBottom.Controls.Add(this.panelLogout);
			this.panelSubMenuBarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelSubMenuBarBottom.Location = new System.Drawing.Point(0, 654);
			this.panelSubMenuBarBottom.Name = "panelSubMenuBarBottom";
			this.panelSubMenuBarBottom.Size = new System.Drawing.Size(200, 54);
			this.panelSubMenuBarBottom.TabIndex = 9;
			// 
			// panelUserSetting
			// 
			this.panelUserSetting.Controls.Add(this.btnUserSetting);
			this.panelUserSetting.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelUserSetting.Location = new System.Drawing.Point(0, 0);
			this.panelUserSetting.Name = "panelUserSetting";
			this.panelUserSetting.Size = new System.Drawing.Size(139, 54);
			this.panelUserSetting.TabIndex = 10;
			// 
			// btnUserSetting
			// 
			this.btnUserSetting.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnUserSetting.FlatAppearance.BorderSize = 0;
			this.btnUserSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUserSetting.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
			this.btnUserSetting.ForeColor = System.Drawing.Color.Silver;
			this.btnUserSetting.Image = global::P01_K_DESIGN_WIN.Properties.Resources.user_user;
			this.btnUserSetting.Location = new System.Drawing.Point(0, 0);
			this.btnUserSetting.Name = "btnUserSetting";
			this.btnUserSetting.Size = new System.Drawing.Size(139, 54);
			this.btnUserSetting.TabIndex = 0;
			this.btnUserSetting.Text = "USER";
			this.btnUserSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUserSetting.UseVisualStyleBackColor = true;
			// 
			// panelLogout
			// 
			this.panelLogout.AutoSize = true;
			this.panelLogout.Controls.Add(this.btnCloseChildForm);
			this.panelLogout.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelLogout.Location = new System.Drawing.Point(139, 0);
			this.panelLogout.Name = "panelLogout";
			this.panelLogout.Size = new System.Drawing.Size(61, 54);
			this.panelLogout.TabIndex = 9;
			// 
			// btnCloseChildForm
			// 
			this.btnCloseChildForm.AutoSize = true;
			this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
			this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
			this.btnCloseChildForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
			this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCloseChildForm.Name = "btnCloseChildForm";
			this.btnCloseChildForm.Size = new System.Drawing.Size(58, 54);
			this.btnCloseChildForm.TabIndex = 8;
			this.tip.SetToolTip(this.btnCloseChildForm, "LOGOUT");
			this.btnCloseChildForm.UseVisualStyleBackColor = true;
			this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
			// 
			// panelSubMenuBarTop
			// 
			this.panelSubMenuBarTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSubMenuBarTop.Location = new System.Drawing.Point(0, 0);
			this.panelSubMenuBarTop.Name = "panelSubMenuBarTop";
			this.panelSubMenuBarTop.Size = new System.Drawing.Size(200, 10);
			this.panelSubMenuBarTop.TabIndex = 0;
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
			this.panelTopMenuBar.Controls.Add(this.lblTopMenuCaption);
			this.panelTopMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTopMenuBar.Location = new System.Drawing.Point(200, 30);
			this.panelTopMenuBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelTopMenuBar.Name = "panelTopMenuBar";
			this.panelTopMenuBar.Size = new System.Drawing.Size(824, 30);
			this.panelTopMenuBar.TabIndex = 1;
			// 
			// lblTopMenuCaption
			// 
			this.lblTopMenuCaption.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTopMenuCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTopMenuCaption.ForeColor = System.Drawing.Color.White;
			this.lblTopMenuCaption.Location = new System.Drawing.Point(0, 0);
			this.lblTopMenuCaption.Name = "lblTopMenuCaption";
			this.lblTopMenuCaption.Size = new System.Drawing.Size(824, 30);
			this.lblTopMenuCaption.TabIndex = 0;
			this.lblTopMenuCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlTitleBar
			// 
			this.pnlTitleBar.BackColor = System.Drawing.Color.Transparent;
			this.pnlTitleBar.Controls.Add(this.btnMaximum);
			this.pnlTitleBar.Controls.Add(this.btnExit);
			this.pnlTitleBar.Controls.Add(this.btnNormal);
			this.pnlTitleBar.Controls.Add(this.btnMinimum);
			this.pnlTitleBar.Controls.Add(this.lblTitleBarCaption);
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
			this.btnMaximum.Image = global::P01_K_DESIGN_WIN.Properties.Resources.btnMaximizar;
			this.btnMaximum.Location = new System.Drawing.Point(767, 0);
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
			this.btnExit.Image = global::P01_K_DESIGN_WIN.Properties.Resources.btnCerrar;
			this.btnExit.Location = new System.Drawing.Point(797, 0);
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
			this.btnNormal.Image = global::P01_K_DESIGN_WIN.Properties.Resources.btnRestaurar;
			this.btnNormal.Location = new System.Drawing.Point(767, 0);
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
			this.btnMinimum.Image = global::P01_K_DESIGN_WIN.Properties.Resources.btnMinimizar;
			this.btnMinimum.Location = new System.Drawing.Point(737, 0);
			this.btnMinimum.Margin = new System.Windows.Forms.Padding(2);
			this.btnMinimum.Name = "btnMinimum";
			this.btnMinimum.Size = new System.Drawing.Size(30, 30);
			this.btnMinimum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnMinimum.TabIndex = 0;
			this.btnMinimum.TabStop = false;
			this.btnMinimum.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// lblTitleBarCaption
			// 
			this.lblTitleBarCaption.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitleBarCaption.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleBarCaption.ForeColor = System.Drawing.Color.White;
			this.lblTitleBarCaption.Location = new System.Drawing.Point(0, 0);
			this.lblTitleBarCaption.Name = "lblTitleBarCaption";
			this.lblTitleBarCaption.Size = new System.Drawing.Size(824, 30);
			this.lblTitleBarCaption.TabIndex = 5;
			this.lblTitleBarCaption.Text = "(주)카이[본사]";
			this.lblTitleBarCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblTitleBarCaption.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblTitleBarCaption_MouseDoubleClick);
			this.lblTitleBarCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitleBarCaption_MouseDown);
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
			// frmMdiContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.ControlBox = false;
			this.Controls.Add(this.pnlMainContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(1024, 768);
			this.Name = "frmMdiContainer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.pnlMainContainer.ResumeLayout(false);
			this.pnlMainContainer.PerformLayout();
			this.pnlBody.ResumeLayout(false);
			this.pnlDesktop.ResumeLayout(false);
			this.tabMenuForm.ResumeLayout(false);
			this.pnlBottomBar.ResumeLayout(false);
			this.pnlBottomBar.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panelSubMenuBar.ResumeLayout(false);
			this.panelSubMenuBarBottom.ResumeLayout(false);
			this.panelSubMenuBarBottom.PerformLayout();
			this.panelUserSetting.ResumeLayout(false);
			this.panelLogout.ResumeLayout(false);
			this.panelLogout.PerformLayout();
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

		public Panel pnlMainContainer;
		public Panel pnlTitleBar;
		public PictureBox btnMinimum;
		public PictureBox btnExit;
		public PictureBox btnNormal;
		public Panel panelTopMenuBar;
		public Panel panelLogo;
		public Panel panelSubMenuBar;
		public Panel pnlBottomBar;
		public Label lblTime;
		public Label lblDate;
		public Label lblMainMsg;
		public PictureBox btnMaximum;
		public Timer tmDateTime;
		public Splitter splMenu;
		public Panel pnlHeader;
		public Panel pnlBody;
		public Button btnCloseChildForm;
		public Panel pnlDesktop;
		public TabPage tabPage1;
		public TabPage tabPage2;
		public MetroFramework.Controls.MetroComboBox cboTimeZone;
		public Label lblTopMenuCaption;
		public MetroFramework.Controls.MetroTabControl tabMenuForm;
		public Panel panel1;
		public Panel panelSubMenuBarBody;
		public Panel panelSubMenuBarBottom;
		public Panel panelSubMenuBarTop;
		public Panel panelUserSetting;
		public Panel panelLogout;
		public Button btnUserSetting;
		private ToolTip tip;
		public Label lblTitleBarCaption;
	}
}
