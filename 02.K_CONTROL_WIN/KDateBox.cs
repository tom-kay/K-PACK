using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_K_CONTROL_WIN
{
    public partial class KDateBox : UserControl
    {
        [Category("DateValue"), Description("날짜를 설정한거나 가져온다.")]
        public string DateValue
        {
            get { return lblDate.Text; }
            set {
                DateTime dt;
                bool isDate = DateTime.TryParse(value, out dt);
                if (!isDate)
                {
                    value = DateTime.MinValue.ToString("yyyy-MM-dd");
                }

                lblDate.Text = value; 
            }
        }

        [Category("TextAlign"), Description("콘텐츠의 맞춤을 설정한다.")]
        [Localizable(true)]
        [DefaultValue(ContentAlignment.MiddleCenter)]
        public ContentAlignment TextAlign
        {
            set
            {
                lblDate.TextAlign = value;
            }
        }

        public KDateBox()
        {
            InitializeComponent();
        }

        private void KDateBox_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
