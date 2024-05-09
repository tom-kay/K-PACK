using log4net;
using P01_K_DESIGN_WIN;
using P05_Business.S02_Controllers.Biz;
using System.Reflection;

namespace P05_Business.S03_Views.Biz
{
    public partial class frmItemList : frmSearchContainer
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        ItemMngController ctrl;

        public frmItemList()
        {
            InitializeComponent();

            ctrl = new ItemMngController();
        }

    }
}
