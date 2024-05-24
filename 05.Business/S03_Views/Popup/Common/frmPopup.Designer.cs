namespace P05_Business
{
    partial class frmPopup
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSave = new System.Windows.Forms.Panel();
            this.btnSave = new P02_K_CONTROL_WIN.KButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnlContainer.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlPopupButtonBar.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlInit.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPopupOptional
            // 
            this.pnlPopupOptional.Size = new System.Drawing.Size(1096, 50);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(1096, 696);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Size = new System.Drawing.Size(1096, 35);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(1046, 0);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(996, 0);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.tableLayoutPanel1);
            this.pnlBody.Location = new System.Drawing.Point(0, 120);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBody.Size = new System.Drawing.Size(1096, 576);
            // 
            // lblPopupTitle
            // 
            this.lblPopupTitle.Size = new System.Drawing.Size(996, 35);
            // 
            // pnlPopupButtonBar
            // 
            this.pnlPopupButtonBar.Size = new System.Drawing.Size(1096, 35);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.pnlSave);
            this.pnlButtons.Location = new System.Drawing.Point(689, 0);
            this.pnlButtons.Size = new System.Drawing.Size(407, 35);
            this.pnlButtons.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButtons.Controls.SetChildIndex(this.pnlSearch, 0);
            this.pnlButtons.Controls.SetChildIndex(this.pnlInit, 0);
            // 
            // pnlInit
            // 
            this.pnlInit.Location = new System.Drawing.Point(164, 0);
            // 
            // btnInit
            // 
            this.btnInit.FlatAppearance.BorderSize = 0;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Location = new System.Drawing.Point(245, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            // 
            // pnlSave
            // 
            this.pnlSave.Controls.Add(this.btnSave);
            this.pnlSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSave.Location = new System.Drawing.Point(326, 0);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Padding = new System.Windows.Forms.Padding(3);
            this.pnlSave.Size = new System.Drawing.Size(81, 35);
            this.pnlSave.TabIndex = 7;
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
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1096, 576);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 570);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(526, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 570);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(576, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 570);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(0, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(0, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(517, 570);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(517, 570);
            this.dataGridView2.TabIndex = 0;
            // 
            // frmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Name = "frmPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnlContainer.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlPopupButtonBar.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlInit.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlSave;
        public P02_K_CONTROL_WIN.KButton btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
