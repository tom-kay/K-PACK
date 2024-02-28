namespace P01_K_DESIGN_WIN
{
    partial class frmPopupFrame
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
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.pnlBody = new System.Windows.Forms.Panel();
			this.pnlPopupOptional = new System.Windows.Forms.Panel();
			this.pnlPopupButtonBar = new System.Windows.Forms.Panel();
			this.pnlButtons = new System.Windows.Forms.Panel();
			this.pnlInit = new System.Windows.Forms.Panel();
			this.btnInit = new P02_K_CONTROL_WIN.KButton();
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.btnSearch = new P02_K_CONTROL_WIN.KButton();
			this.pnlTitleBar = new System.Windows.Forms.Panel();
			this.lblPopupTitle = new System.Windows.Forms.Label();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.pnlContainer.SuspendLayout();
			this.pnlPopupButtonBar.SuspendLayout();
			this.pnlButtons.SuspendLayout();
			this.pnlInit.SuspendLayout();
			this.pnlSearch.SuspendLayout();
			this.pnlTitleBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlContainer
			// 
			this.pnlContainer.BackColor = System.Drawing.Color.AliceBlue;
			this.pnlContainer.Controls.Add(this.pnlBody);
			this.pnlContainer.Controls.Add(this.pnlPopupOptional);
			this.pnlContainer.Controls.Add(this.pnlPopupButtonBar);
			this.pnlContainer.Controls.Add(this.pnlTitleBar);
			this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContainer.Location = new System.Drawing.Point(0, 0);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(784, 561);
			this.pnlContainer.TabIndex = 0;
			this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
			// 
			// pnlBody
			// 
			this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBody.Location = new System.Drawing.Point(0, 170);
			this.pnlBody.Name = "pnlBody";
			this.pnlBody.Size = new System.Drawing.Size(784, 391);
			this.pnlBody.TabIndex = 3;
			// 
			// pnlPopupOptional
			// 
			this.pnlPopupOptional.BackColor = System.Drawing.Color.AliceBlue;
			this.pnlPopupOptional.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlPopupOptional.Location = new System.Drawing.Point(0, 70);
			this.pnlPopupOptional.Margin = new System.Windows.Forms.Padding(0);
			this.pnlPopupOptional.Name = "pnlPopupOptional";
			this.pnlPopupOptional.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.pnlPopupOptional.Size = new System.Drawing.Size(784, 100);
			this.pnlPopupOptional.TabIndex = 2;
			// 
			// pnlPopupButtonBar
			// 
			this.pnlPopupButtonBar.Controls.Add(this.pnlButtons);
			this.pnlPopupButtonBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlPopupButtonBar.Location = new System.Drawing.Point(0, 35);
			this.pnlPopupButtonBar.Name = "pnlPopupButtonBar";
			this.pnlPopupButtonBar.Size = new System.Drawing.Size(784, 35);
			this.pnlPopupButtonBar.TabIndex = 4;
			// 
			// pnlButtons
			// 
			this.pnlButtons.Controls.Add(this.pnlInit);
			this.pnlButtons.Controls.Add(this.pnlSearch);
			this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlButtons.Location = new System.Drawing.Point(550, 0);
			this.pnlButtons.Name = "pnlButtons";
			this.pnlButtons.Size = new System.Drawing.Size(234, 35);
			this.pnlButtons.TabIndex = 0;
			// 
			// pnlInit
			// 
			this.pnlInit.Controls.Add(this.btnInit);
			this.pnlInit.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnlInit.Location = new System.Drawing.Point(72, 0);
			this.pnlInit.Name = "pnlInit";
			this.pnlInit.Padding = new System.Windows.Forms.Padding(3);
			this.pnlInit.Size = new System.Drawing.Size(81, 35);
			this.pnlInit.TabIndex = 6;
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
			this.pnlSearch.Location = new System.Drawing.Point(153, 0);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Padding = new System.Windows.Forms.Padding(3);
			this.pnlSearch.Size = new System.Drawing.Size(81, 35);
			this.pnlSearch.TabIndex = 5;
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
			// pnlTitleBar
			// 
			this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
			this.pnlTitleBar.Controls.Add(this.lblPopupTitle);
			this.pnlTitleBar.Controls.Add(this.btnMinimize);
			this.pnlTitleBar.Controls.Add(this.btnClose);
			this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
			this.pnlTitleBar.Name = "pnlTitleBar";
			this.pnlTitleBar.Size = new System.Drawing.Size(784, 35);
			this.pnlTitleBar.TabIndex = 0;
			this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
			// 
			// lblPopupTitle
			// 
			this.lblPopupTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPopupTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPopupTitle.ForeColor = System.Drawing.Color.White;
			this.lblPopupTitle.Location = new System.Drawing.Point(0, 0);
			this.lblPopupTitle.Name = "lblPopupTitle";
			this.lblPopupTitle.Size = new System.Drawing.Size(684, 35);
			this.lblPopupTitle.TabIndex = 2;
			this.lblPopupTitle.Text = "POPUP NAME";
			this.lblPopupTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblPopupTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPopupTitle_MouseDown);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnMinimize.ForeColor = System.Drawing.Color.White;
			this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnMinimize.Location = new System.Drawing.Point(684, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(50, 35);
			this.btnMinimize.TabIndex = 1;
			this.btnMinimize.Text = "─";
			this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnClose
			// 
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.Location = new System.Drawing.Point(734, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(50, 35);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Ｘ";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmPopupFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.pnlContainer);
			this.Name = "frmPopupFrame";
			this.Opacity = 0.95D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Popup";
			this.Activated += new System.EventHandler(this.frmPopupFrame_Activated);
			this.Load += new System.EventHandler(this.frmPopupFrame_Load);
			this.ResizeEnd += new System.EventHandler(this.frmPopupFrame_ResizeEnd);
			this.SizeChanged += new System.EventHandler(this.frmPopupFrame_SizeChanged);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmPopupFrame_Paint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
			this.pnlContainer.ResumeLayout(false);
			this.pnlPopupButtonBar.ResumeLayout(false);
			this.pnlButtons.ResumeLayout(false);
			this.pnlInit.ResumeLayout(false);
			this.pnlSearch.ResumeLayout(false);
			this.pnlTitleBar.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
		public System.Windows.Forms.Panel pnlPopupOptional;
		public System.Windows.Forms.Panel pnlContainer;
		public System.Windows.Forms.Panel pnlTitleBar;
		public System.Windows.Forms.Button btnClose;
		public System.Windows.Forms.Button btnMinimize;
		public System.Windows.Forms.Panel pnlBody;
		public System.Windows.Forms.Label lblPopupTitle;
		public System.Windows.Forms.Panel pnlPopupButtonBar;
		public System.Windows.Forms.Panel pnlButtons;
		public System.Windows.Forms.Panel pnlInit;
		public P02_K_CONTROL_WIN.KButton btnInit;
		public System.Windows.Forms.Panel pnlSearch;
		public P02_K_CONTROL_WIN.KButton btnSearch;
	}
}