using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_K_CONTROL_WIN
{
    public partial class KPeriodDateBox : UserControl
    {   

        [Category("DateFromValue"), Description("시작일자를 설정한거나 가져온다.")]
        public string DateFromValue
        {
            get
            {
                return lblFromDate.Text;
            }
            set
            {
                lblFromDate.Text = value;
            }
        }

        [Category("DateToValue"), Description("종료일자를 설정한거나 가져온다.")]
        public string DateToValue
        {
            get
            {
                return lblToDate.Text;
            }
            set
            {
                lblToDate.Text = value;
            }
        }

        [Category("TextAlign"), Description("콘텐츠의 맞춤을 설정한다.")]
        public ContentAlignment TextAlign
        {   
            get
            {
                return lblFromDate.TextAlign;
            }
            set
            {
                lblFromDate.TextAlign = value;
                lblToDate.TextAlign = value;
            }
        }

        public KPeriodDateBox()
        {
            InitializeComponent();

        }
        private void KPeriodDateBox_Load(object sender, EventArgs e)
        {
            lblFromDate.Text = lblToDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void lblFromDate_TextChanged(object sender, EventArgs e)
        {
            DateTime dtFrom;
            DateTime dtTo;

            bool isFromDate = DateTime.TryParse(lblFromDate.Text, out dtFrom);
            bool isToDate = DateTime.TryParse(lblToDate.Text, out dtTo);

            if (isFromDate && isToDate)
            {
                if (dtFrom > dtTo)
                {
                    MessageBox.Show("시작일자가 종료일자보다 클 수 없습니다.");
                }
            }
        }

        private void lblToDate_TextChanged(object sender, EventArgs e)
        {   
            DateTime dtFrom;
            DateTime dtTo;

            bool isFromDate = DateTime.TryParse(lblFromDate.Text, out dtFrom);
            bool isToDate = DateTime.TryParse(lblToDate.Text, out dtTo);

            if (isFromDate && isToDate)
            {
                if (dtFrom > dtTo)
                {
                    MessageBox.Show("종료일자가 시작일자보다 작을 수 없습니다.");
                } 
            }
        }
    }
}
