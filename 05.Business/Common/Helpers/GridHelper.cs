using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.Common.Helpers
{
    /// <summary>
    /// DataGridView를 이용한 추가 기능
    /// </summary>
    internal class GridHelper
    {
        /// <summary>
        /// 그리드에서 단일 행을 추출해서 DataTable로 변환하여 반환한다.
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        internal static DataTable GetRowData(DataGridView dgv, int rowIndex)
        {
            DataTable dt = (dgv.DataSource as DataTable).Clone();
            DataRow dr = dt.NewRow();
            dr.ItemArray = (dgv.DataSource as DataTable).Rows[rowIndex].ItemArray;
            dt.Rows.Add(dr);
            dt.AcceptChanges();
            return dt;
        }

        internal static void SwapRows(DataGridView dgv, int row1, int row2)
        {
            DataTable dt = dgv.DataSource as DataTable;

            DataRow tempRow = dt.NewRow();
            tempRow.ItemArray = dt.Rows[row1].ItemArray;

            dt.Rows[row1].ItemArray = dt.Rows[row2].ItemArray;
            dt.Rows[row2].ItemArray = tempRow.ItemArray;

            dgv.ClearSelection();
            dgv.Rows[row2].Selected = true; 
            
        }
    }
}
