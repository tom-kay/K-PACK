using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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

        public static void MergeColumnHeaders(DataGridView dgv, int headerRowCount, string headerText, params string[] columnNames)
        {
            dgv.CellPainting += (sender, e) =>
            {
                if (e.RowIndex == -1 && columnNames.Contains(dgv.Columns[e.ColumnIndex].Name))
                {
                    int cellHeight = e.CellBounds.Height / headerRowCount;
                    Rectangle newRect = new Rectangle(e.CellBounds.X, e.CellBounds.Y + (cellHeight * (headerRowCount - 1)), e.CellBounds.Width, cellHeight);

                    // 문자열의 정렬을 설정합니다.
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;  // 가로 정렬
                    format.LineAlignment = StringAlignment.Center;  // 세로 정렬

                    e.Graphics.FillRectangle(new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.BackColor), e.CellBounds);
                    e.Graphics.DrawString(headerText,
                        dgv.ColumnHeadersDefaultCellStyle.Font,
                        new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.ForeColor),
                        newRect,
                        format);  // format 인자를 추가합니다.
                    e.Handled = true;
                }
            };

            dgv.Paint += (sender, e) =>
            {
                int height = dgv.ColumnHeadersHeight / headerRowCount;
                int j = 0;

                for (int i = 0; i < columnNames.Length; i++)
                {
                    if (dgv.Columns.Contains(columnNames[i]))
                    {
                        var column = dgv.Columns[columnNames[i]];
                        Rectangle r = dgv.GetCellDisplayRectangle(column.Index, -1, true);

                        r.X += 1;
                        r.Y += height * j + 2;
                        r.Width = r.Width * columnNames.Length - 2;
                        r.Height = height - 3;

                        // 문자열의 정렬을 설정합니다.
                        StringFormat format = new StringFormat();
                        format.Alignment = StringAlignment.Center;  // 가로 정렬
                        format.LineAlignment = StringAlignment.Center;  // 세로 정렬

                        e.Graphics.FillRectangle(new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.BackColor), r);
                        e.Graphics.DrawString(headerText,
                            dgv.ColumnHeadersDefaultCellStyle.Font,
                            new SolidBrush(dgv.ColumnHeadersDefaultCellStyle.ForeColor),
                            r,
                            format);
                        j++;
                    }
                }
            };

            // Merge column headers
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = dgv.ColumnHeadersHeight * headerRowCount;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        public static void MergeColumnHeader(DataGridView gv, StringAlignment align, string strHeader, string startColumn, int mergeCnt)
        {
            try
            {
                int startColumnIdx = gv.Columns[startColumn].Index;

                gv.Paint += (sender, e) =>
                {
                    StringFormat format = new StringFormat();
                    format.Alignment = align;
                    format.LineAlignment = StringAlignment.Center;
                    
                    int mergeColumnWidth = 0;

                    Rectangle r = gv.GetCellDisplayRectangle(startColumnIdx, -1, false);

                    for (int i = startColumnIdx; i < startColumnIdx + mergeCnt; i++)
                    {
                        mergeColumnWidth += gv.GetCellDisplayRectangle(i, -1, false).Width;
                    }

                    r.Width = mergeColumnWidth - 2;
                    r.Height = gv.ColumnHeadersHeight;

                    e.Graphics.FillRectangle(new SolidBrush(gv.ColumnHeadersDefaultCellStyle.BackColor), r);
                    e.Graphics.DrawString(strHeader, new Font("맑은 고딕", 12, System.Drawing.FontStyle.Bold), new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r, format);
                };
            }
            catch
            {

            }
        }


    }
}
