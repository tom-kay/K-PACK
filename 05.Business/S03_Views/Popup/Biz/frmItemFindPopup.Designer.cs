using P02_K_CONTROL_WIN;

namespace P05_Business.S03_Views.Popup.Biz
{
    partial class frmItemFindPopup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvChoice = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new P02_K_CONTROL_WIN.KButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboItemGroup = new P02_K_CONTROL_WIN.KComboBox();
            this.pnlPopupOptional.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlPopupButtonBar.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlInit.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoice)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPopupOptional
            // 
            this.pnlPopupOptional.AutoSize = true;
            this.pnlPopupOptional.Controls.Add(this.tableLayoutPanel3);
            this.pnlPopupOptional.Size = new System.Drawing.Size(982, 55);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(982, 623);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Size = new System.Drawing.Size(982, 35);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(932, 0);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(882, 0);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tableLayoutPanel1);
            this.pnlBody.Location = new System.Drawing.Point(0, 125);
            this.pnlBody.Size = new System.Drawing.Size(982, 498);
            // 
            // lblPopupTitle
            // 
            this.lblPopupTitle.Size = new System.Drawing.Size(882, 35);
            // 
            // pnlPopupButtonBar
            // 
            this.pnlPopupButtonBar.Size = new System.Drawing.Size(982, 35);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pnlSave);
            this.pnlButtons.Location = new System.Drawing.Point(690, 0);
            this.pnlButtons.Size = new System.Drawing.Size(292, 35);
            this.pnlButtons.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButtons.Controls.SetChildIndex(this.pnlSearch, 0);
            this.pnlButtons.Controls.SetChildIndex(this.pnlInit, 0);
            // 
            // pnlInit
            // 
            this.pnlInit.Location = new System.Drawing.Point(49, 0);
            // 
            // btnInit
            // 
            this.btnInit.FlatAppearance.BorderSize = 0;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Location = new System.Drawing.Point(130, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 498);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 492);
            this.panel1.TabIndex = 0;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(460, 492);
            this.dgvList.TabIndex = 0;
            this.dgvList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvList_ColumnHeaderMouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvChoice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(519, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 492);
            this.panel3.TabIndex = 2;
            // 
            // dgvChoice
            // 
            this.dgvChoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChoice.Location = new System.Drawing.Point(0, 0);
            this.dgvChoice.Name = "dgvChoice";
            this.dgvChoice.RowTemplate.Height = 23;
            this.dgvChoice.Size = new System.Drawing.Size(460, 492);
            this.dgvChoice.TabIndex = 0;
            this.dgvChoice.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvChoice_ColumnHeaderMouseClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(466, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(50, 498);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 189);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 35);
            this.panel2.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font(SystemHelper._FONT_NAME, 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = ">>>";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 274);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 35);
            this.panel4.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.Control;
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Font = new System.Drawing.Font(SystemHelper._FONT_NAME, 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Location = new System.Drawing.Point(0, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 35);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "<<<";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSave.Location = new System.Drawing.Point(211, 0);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Padding = new System.Windows.Forms.Padding(3);
            this.pnlSave.Size = new System.Drawing.Size(81, 35);
            this.pnlSave.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnSave.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnSave.BorderRadius = 0;
            this.btnSave.BorderSize = 0;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "추가";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(982, 35);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 29);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "CODE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cboItemGroup);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(123, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(856, 29);
            this.panel6.TabIndex = 1;
            // 
            // cboItemGroup
            // 
            this.cboItemGroup.BackColor = System.Drawing.Color.PowderBlue;
            this.cboItemGroup.BorderColor = System.Drawing.Color.Transparent;
            this.cboItemGroup.BorderSize = 1;
            this.cboItemGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboItemGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemGroup.Font = new System.Drawing.Font("굴림", 10F);
            this.cboItemGroup.ForeColor = System.Drawing.Color.DimGray;
            this.cboItemGroup.IconColor = System.Drawing.Color.Navy;
            this.cboItemGroup.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboItemGroup.ListTextColor = System.Drawing.Color.DimGray;
            this.cboItemGroup.Location = new System.Drawing.Point(0, 0);
            this.cboItemGroup.Name = "cboItemGroup";
            this.cboItemGroup.Padding = new System.Windows.Forms.Padding(1);
            this.cboItemGroup.Size = new System.Drawing.Size(856, 29);
            this.cboItemGroup.TabIndex = 3;
            this.cboItemGroup.Tag = "";
            this.cboItemGroup.Texts = "";
            // 
            // frmItemFindPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 627);
            this.Name = "frmItemFindPopup";
            this.Text = "frmItemFindPopup";
            this.Load += new System.EventHandler(this.frmItemFindPopup_Load);
            this.pnlPopupOptional.ResumeLayout(false);
            this.pnlPopupOptional.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlPopupButtonBar.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlInit.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoice)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvChoice;
        public System.Windows.Forms.Panel pnlSave;
        public P02_K_CONTROL_WIN.KButton btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private P02_K_CONTROL_WIN.KComboBox cboItemGroup;
    }
}