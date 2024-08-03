using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using P01_K_DESIGN_WIN;
using P05_Business.Common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Biz
{
    public partial class frmExportMng : frmEditContainer
    {
        public frmExportMng()
        {
            InitializeComponent();
        }

        private void frmExportMng_Load(object sender, EventArgs e)
        {
            GridHelper.CreateGrid(spdContainerList);
            GridHelper.AddTextColumn(spdContainerList, "ContainerNo", "Cntr No.", true, true, 150, CellHorizontalAlignment.Left, CellVerticalAlignment.Center);
            GridHelper.AddTextColumn(spdContainerList, "SealNo1", "Seal No.1", true, true, 100, CellHorizontalAlignment.Left, CellVerticalAlignment.Center);
            GridHelper.AddTextColumn(spdContainerList, "SealNo2", "Seal No.2", true, true, 100, CellHorizontalAlignment.Left, CellVerticalAlignment.Center);
            GridHelper.AddTextColumn(spdContainerList, "SealNo3", "Seal No.3", true, true, 100, CellHorizontalAlignment.Left, CellVerticalAlignment.Center);
            GridHelper.EndGrid(spdContainerList);


            spdContainerList.Sheets[0].RowCount = 10;
        }

    }
}
