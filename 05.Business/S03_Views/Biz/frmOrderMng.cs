using log4net;
using P01_K_DESIGN_WIN;
using P05_Business.S01_Models.Dto.Biz;
using P05_Business.S02_Controllers.Biz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Biz
{
    public partial class frmOrderMng : frmEditContainer
    {
        #region -- Variables
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        OrderMngController ctrl;

        OrderMasterDto dtoMaser;
        List<OrderDetailDto> dtoDetails;
        #endregion -- Variables

        #region -- Constructor
        public frmOrderMng()
        {
            InitializeComponent();

            ctrl = new OrderMngController();
            dtoMaser = new OrderMasterDto();
            dtoDetails = new List<OrderDetailDto>();
        }

        public frmOrderMng(string code) : this()
        {
            IS_LINK_OPEN = true;
        }
        #endregion -- Constructor

        #region -- Control Event
        private void frmOrderMng_Load(object sender, EventArgs e)
        {

        }

        private void btnInit_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion -- Control Event

        #region -- Method

        #endregion -- Method
    }
}
