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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMdiContainer));
            pnlMainContainer = new Panel();
            pnlBottomBar = new Panel();
            lblMainMsg = new Label();
            lblDate = new Label();
            lblTime = new Label();
            splMenu = new Splitter();
            panelSubMenuBar = new Panel();
            lblTitle = new Label();
            panelTopMenuBar = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnCloseChildForm = new Button();
            btnMenu5 = new Button();
            btnMenu4 = new Button();
            btnMenu3 = new Button();
            btnMenu2 = new Button();
            btnMenu1 = new Button();
            btnMenu0 = new Button();
            panelLogo = new Panel();
            pnlTitleBar = new Panel();
            btnMaximum = new PictureBox();
            btnExit = new PictureBox();
            btnNormal = new PictureBox();
            btnMinimum = new PictureBox();
            tmDateTime = new System.Windows.Forms.Timer(components);
            pnlMainContainer.SuspendLayout();
            pnlBottomBar.SuspendLayout();
            panelSubMenuBar.SuspendLayout();
            panelTopMenuBar.SuspendLayout();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimum).BeginInit();
            SuspendLayout();
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.BackColor = SystemColors.ActiveCaption;
            pnlMainContainer.Controls.Add(pnlBottomBar);
            pnlMainContainer.Controls.Add(splMenu);
            pnlMainContainer.Controls.Add(panelSubMenuBar);
            pnlMainContainer.Controls.Add(panelTopMenuBar);
            pnlMainContainer.Controls.Add(pnlTitleBar);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(0, 0);
            pnlMainContainer.Margin = new Padding(2);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Size = new Size(1192, 496);
            pnlMainContainer.TabIndex = 0;
            // 
            // pnlBottomBar
            // 
            pnlBottomBar.BackColor = Color.FromArgb(55, 61, 69);
            pnlBottomBar.Controls.Add(lblMainMsg);
            pnlBottomBar.Controls.Add(lblDate);
            pnlBottomBar.Controls.Add(lblTime);
            pnlBottomBar.Dock = DockStyle.Bottom;
            pnlBottomBar.Location = new Point(133, 466);
            pnlBottomBar.Name = "pnlBottomBar";
            pnlBottomBar.Size = new Size(1059, 30);
            pnlBottomBar.TabIndex = 3;
            // 
            // lblMainMsg
            // 
            lblMainMsg.Anchor = AnchorStyles.Left;
            lblMainMsg.AutoSize = true;
            lblMainMsg.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainMsg.ForeColor = Color.White;
            lblMainMsg.Location = new Point(4, 8);
            lblMainMsg.Margin = new Padding(4, 0, 4, 0);
            lblMainMsg.Name = "lblMainMsg";
            lblMainMsg.Size = new Size(53, 15);
            lblMainMsg.TabIndex = 2;
            lblMainMsg.Text = "Message";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 12F);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(790, 5);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(165, 20);
            lblDate.TabIndex = 1;
            lblDate.Text = "9999년 12월 31일 일요일";
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 12F);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(963, 5);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(71, 20);
            lblTime.TabIndex = 0;
            lblTime.Text = "00:00:00";
            // 
            // splMenu
            // 
            splMenu.Location = new Point(130, 60);
            splMenu.Name = "splMenu";
            splMenu.Size = new Size(3, 436);
            splMenu.TabIndex = 4;
            splMenu.TabStop = false;
            // 
            // panelSubMenuBar
            // 
            panelSubMenuBar.BackColor = Color.FromArgb(0, 150, 136);
            panelSubMenuBar.Controls.Add(lblTitle);
            panelSubMenuBar.Dock = DockStyle.Left;
            panelSubMenuBar.Location = new Point(0, 60);
            panelSubMenuBar.Name = "panelSubMenuBar";
            panelSubMenuBar.Size = new Size(130, 436);
            panelSubMenuBar.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("CookieRun Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(130, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Home";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTopMenuBar
            // 
            panelTopMenuBar.BackColor = Color.FromArgb(51, 51, 76);
            panelTopMenuBar.Controls.Add(button3);
            panelTopMenuBar.Controls.Add(button2);
            panelTopMenuBar.Controls.Add(button1);
            panelTopMenuBar.Controls.Add(btnCloseChildForm);
            panelTopMenuBar.Controls.Add(btnMenu5);
            panelTopMenuBar.Controls.Add(btnMenu4);
            panelTopMenuBar.Controls.Add(btnMenu3);
            panelTopMenuBar.Controls.Add(btnMenu2);
            panelTopMenuBar.Controls.Add(btnMenu1);
            panelTopMenuBar.Controls.Add(btnMenu0);
            panelTopMenuBar.Controls.Add(panelLogo);
            panelTopMenuBar.Dock = DockStyle.Top;
            panelTopMenuBar.Location = new Point(0, 20);
            panelTopMenuBar.Name = "panelTopMenuBar";
            panelTopMenuBar.Size = new Size(1192, 40);
            panelTopMenuBar.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1674, 0);
            button3.Name = "button3";
            button3.Size = new Size(24, 24);
            button3.TabIndex = 10;
            button3.Text = "○";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1694, 0);
            button2.Name = "button2";
            button2.Size = new Size(24, 24);
            button2.TabIndex = 9;
            button2.Text = "○";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1715, 0);
            button1.Name = "button1";
            button1.Size = new Size(24, 24);
            button1.TabIndex = 8;
            button1.Text = "○";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Dock = DockStyle.Right;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Image = (Image)resources.GetObject("btnCloseChildForm.Image");
            btnCloseChildForm.Location = new Point(1145, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(47, 40);
            btnCloseChildForm.TabIndex = 7;
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // btnMenu5
            // 
            btnMenu5.Dock = DockStyle.Left;
            btnMenu5.FlatAppearance.BorderSize = 0;
            btnMenu5.FlatStyle = FlatStyle.Flat;
            btnMenu5.Font = new Font("CookieRun Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMenu5.ForeColor = Color.Gainsboro;
            btnMenu5.Location = new Point(505, 0);
            btnMenu5.Name = "btnMenu5";
            btnMenu5.Size = new Size(75, 40);
            btnMenu5.TabIndex = 6;
            btnMenu5.Text = "button6";
            btnMenu5.UseVisualStyleBackColor = true;
            // 
            // btnMenu4
            // 
            btnMenu4.Dock = DockStyle.Left;
            btnMenu4.FlatAppearance.BorderSize = 0;
            btnMenu4.FlatStyle = FlatStyle.Flat;
            btnMenu4.Font = new Font("CookieRun Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMenu4.ForeColor = Color.Gainsboro;
            btnMenu4.Location = new Point(430, 0);
            btnMenu4.Name = "btnMenu4";
            btnMenu4.Size = new Size(75, 40);
            btnMenu4.TabIndex = 5;
            btnMenu4.Text = "button5";
            btnMenu4.UseVisualStyleBackColor = true;
            // 
            // btnMenu3
            // 
            btnMenu3.Dock = DockStyle.Left;
            btnMenu3.FlatAppearance.BorderSize = 0;
            btnMenu3.FlatStyle = FlatStyle.Flat;
            btnMenu3.Font = new Font("CookieRun Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMenu3.ForeColor = Color.Gainsboro;
            btnMenu3.Location = new Point(355, 0);
            btnMenu3.Name = "btnMenu3";
            btnMenu3.Size = new Size(75, 40);
            btnMenu3.TabIndex = 4;
            btnMenu3.Text = "button4";
            btnMenu3.UseVisualStyleBackColor = true;
            // 
            // btnMenu2
            // 
            btnMenu2.Dock = DockStyle.Left;
            btnMenu2.FlatAppearance.BorderSize = 0;
            btnMenu2.FlatStyle = FlatStyle.Flat;
            btnMenu2.Font = new Font("CookieRun Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMenu2.ForeColor = Color.Gainsboro;
            btnMenu2.Location = new Point(280, 0);
            btnMenu2.Name = "btnMenu2";
            btnMenu2.Size = new Size(75, 40);
            btnMenu2.TabIndex = 3;
            btnMenu2.Text = "button3";
            btnMenu2.UseVisualStyleBackColor = true;
            // 
            // btnMenu1
            // 
            btnMenu1.Dock = DockStyle.Left;
            btnMenu1.FlatAppearance.BorderSize = 0;
            btnMenu1.FlatStyle = FlatStyle.Flat;
            btnMenu1.Font = new Font("CookieRun Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMenu1.ForeColor = Color.Gainsboro;
            btnMenu1.Location = new Point(205, 0);
            btnMenu1.Name = "btnMenu1";
            btnMenu1.Size = new Size(75, 40);
            btnMenu1.TabIndex = 2;
            btnMenu1.Text = "button2";
            btnMenu1.UseVisualStyleBackColor = true;
            // 
            // btnMenu0
            // 
            btnMenu0.Dock = DockStyle.Left;
            btnMenu0.FlatAppearance.BorderSize = 0;
            btnMenu0.FlatStyle = FlatStyle.Flat;
            btnMenu0.Font = new Font("CookieRun Bold", 9.749998F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnMenu0.ForeColor = Color.Gainsboro;
            btnMenu0.Location = new Point(130, 0);
            btnMenu0.Name = "btnMenu0";
            btnMenu0.Size = new Size(75, 40);
            btnMenu0.TabIndex = 1;
            btnMenu0.Text = "button1";
            btnMenu0.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Dock = DockStyle.Left;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(130, 40);
            panelLogo.TabIndex = 0;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(13, 93, 142);
            pnlTitleBar.Controls.Add(btnMaximum);
            pnlTitleBar.Controls.Add(btnExit);
            pnlTitleBar.Controls.Add(btnNormal);
            pnlTitleBar.Controls.Add(btnMinimum);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1192, 20);
            pnlTitleBar.TabIndex = 0;
            pnlTitleBar.MouseDoubleClick += pnlTitleBar_MouseDoubleClick;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // btnMaximum
            // 
            btnMaximum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximum.BackColor = SystemColors.ControlDarkDark;
            btnMaximum.Cursor = Cursors.Hand;
            btnMaximum.Image = Properties.Resources.btnMaximizar;
            btnMaximum.Location = new Point(1132, 0);
            btnMaximum.Margin = new Padding(2);
            btnMaximum.Name = "btnMaximum";
            btnMaximum.Size = new Size(30, 20);
            btnMaximum.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMaximum.TabIndex = 3;
            btnMaximum.TabStop = false;
            btnMaximum.Click += btnMaximum_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.IndianRed;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.btnCerrar;
            btnExit.Location = new Point(1162, 0);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 20);
            btnExit.SizeMode = PictureBoxSizeMode.CenterImage;
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            btnExit.Click += btnClose_Click;
            // 
            // btnNormal
            // 
            btnNormal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNormal.BackColor = SystemColors.ControlDarkDark;
            btnNormal.Cursor = Cursors.Hand;
            btnNormal.Image = Properties.Resources.btnRestaurar;
            btnNormal.Location = new Point(1132, 0);
            btnNormal.Margin = new Padding(2);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(30, 20);
            btnNormal.SizeMode = PictureBoxSizeMode.CenterImage;
            btnNormal.TabIndex = 1;
            btnNormal.TabStop = false;
            btnNormal.Click += btnNormal_Click;
            // 
            // btnMinimum
            // 
            btnMinimum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimum.BackColor = SystemColors.ControlDarkDark;
            btnMinimum.Cursor = Cursors.Hand;
            btnMinimum.Image = Properties.Resources.btnMinimizar;
            btnMinimum.Location = new Point(1102, 0);
            btnMinimum.Margin = new Padding(2);
            btnMinimum.Name = "btnMinimum";
            btnMinimum.Size = new Size(30, 20);
            btnMinimum.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMinimum.TabIndex = 0;
            btnMinimum.TabStop = false;
            btnMinimum.Click += bntMinimize_Click;
            // 
            // tmDateTime
            // 
            tmDateTime.Enabled = true;
            tmDateTime.Tick += tmDateTime_Tick;
            // 
            // frmMdiContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 496);
            Controls.Add(pnlMainContainer);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(569, 300);
            Name = "frmMdiContainer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlMainContainer.ResumeLayout(false);
            pnlBottomBar.ResumeLayout(false);
            pnlBottomBar.PerformLayout();
            panelSubMenuBar.ResumeLayout(false);
            panelTopMenuBar.ResumeLayout(false);
            pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMaximum).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainContainer;
        private Panel pnlTitleBar;
        private PictureBox btnMinimum;
        private PictureBox btnExit;
        private PictureBox btnNormal;
        private Panel panelTopMenuBar;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnCloseChildForm;
        private Button btnMenu5;
        private Button btnMenu4;
        private Button btnMenu3;
        private Button btnMenu2;
        private Button btnMenu1;
        private Button btnMenu0;
        private Panel panelLogo;
        private Panel panelSubMenuBar;
        private Label lblTitle;
        private Panel pnlBottomBar;
        private Label lblTime;
        private Label lblDate;
        private Label lblMainMsg;
        private PictureBox btnMaximum;
        private System.Windows.Forms.Timer tmDateTime;
        private Splitter splMenu;
    }
}
