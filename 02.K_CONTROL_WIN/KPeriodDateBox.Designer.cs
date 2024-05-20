namespace P02_K_CONTROL_WIN
{
    partial class KPeriodDateBox
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblToDate = new System.Windows.Forms.Label();
            this.btnToCalendar = new P02_K_CONTROL_WIN.KButtonCalendar();
            this.btnFromCalendar = new P02_K_CONTROL_WIN.KButtonCalendar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFromCalendar);
            this.panel1.Controls.Add(this.lblFromDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 22);
            this.panel1.TabIndex = 12;
            // 
            // lblFromDate
            // 
            this.lblFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(0, 0);
            this.lblFromDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(100, 22);
            this.lblFromDate.TabIndex = 14;
            this.lblFromDate.Tag = "NONE";
            this.lblFromDate.Text = "9999-99-99";
            this.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFromDate.TextChanged += new System.EventHandler(this.lblFromDate_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(122, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 22);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 0;
            this.label1.Tag = "NONE";
            this.label1.Text = "─";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnToCalendar);
            this.panel3.Controls.Add(this.lblToDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(143, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 22);
            this.panel3.TabIndex = 14;
            // 
            // lblToDate
            // 
            this.lblToDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(0, 0);
            this.lblToDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(100, 22);
            this.lblToDate.TabIndex = 14;
            this.lblToDate.Tag = "NONE";
            this.lblToDate.Text = "9999-99-99";
            this.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblToDate.TextChanged += new System.EventHandler(this.lblToDate_TextChanged);
            // 
            // btnToCalendar
            // 
            this.btnToCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToCalendar.BackgroundImage = global::P02_K_CONTROL_WIN.Properties.Resources.may_2009_event_calendar_may_2009_event_calendar;
            this.btnToCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnToCalendar.FlatAppearance.BorderSize = 0;
            this.btnToCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCalendar.Location = new System.Drawing.Point(100, 0);
            this.btnToCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.btnToCalendar.Name = "btnToCalendar";
            this.btnToCalendar.Size = new System.Drawing.Size(22, 22);
            this.btnToCalendar.TabIndex = 16;
            this.btnToCalendar.Tag = "lblToDate";
            this.btnToCalendar.UseVisualStyleBackColor = true;
            // 
            // btnFromCalendar
            // 
            this.btnFromCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFromCalendar.BackgroundImage = global::P02_K_CONTROL_WIN.Properties.Resources.may_2009_event_calendar_may_2009_event_calendar;
            this.btnFromCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFromCalendar.FlatAppearance.BorderSize = 0;
            this.btnFromCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromCalendar.Location = new System.Drawing.Point(100, 0);
            this.btnFromCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFromCalendar.Name = "btnFromCalendar";
            this.btnFromCalendar.Size = new System.Drawing.Size(22, 22);
            this.btnFromCalendar.TabIndex = 15;
            this.btnFromCalendar.Tag = "lblFromDate";
            this.btnFromCalendar.UseVisualStyleBackColor = true;
            // 
            // KPeriodDateBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(265, 22);
            this.MinimumSize = new System.Drawing.Size(265, 22);
            this.Name = "KPeriodDateBox";
            this.Size = new System.Drawing.Size(265, 22);
            this.Load += new System.EventHandler(this.KPeriodDateBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private KButtonCalendar btnFromCalendar;
        private KButtonCalendar btnToCalendar;
    }
}
