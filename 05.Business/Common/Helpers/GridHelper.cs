using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using P02_K_CONTROL_WIN;
using SmartSql.SqlMap.Tags;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
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
                    e.Graphics.DrawString(strHeader, new Font(SystemHelper._FONT_NAME, 12f, System.Drawing.FontStyle.Bold), new SolidBrush(gv.ColumnHeadersDefaultCellStyle.ForeColor), r, format);
                };
            }
            catch
            {

            }
        }

        internal static void CreateGrid(FpSpread spread)
        {
            FpSpread grid = spread;
            grid.BorderStyle = BorderStyle.None;
            grid.TabStripInsertTab = false;
            grid.TabStripPolicy = TabStripPolicy.Never;
            grid.ColumnSplitBoxPolicy = SplitBoxPolicy.Never;
            grid.RowSplitBoxPolicy = SplitBoxPolicy.Never;
            grid.PaintSelectionHeader = false;
            grid.RetainSelectionBlock = false;

            SheetView sheet = grid.Sheets[0];

            sheet.Rows.Clear();
            sheet.Columns.Clear();

            sheet.AlternatingRows.Count = 2;
            sheet.AlternatingRows[0].BackColor = Color.White;
            sheet.AlternatingRows[1].BackColor = Color.FromArgb(183, 231, 255);

            sheet.OperationMode = OperationMode.RowMode;
            sheet.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.Single;
            sheet.AutoGenerateColumns = false;
            sheet.DataAutoSizeColumns = false;

            foreach (Row hRow in sheet.ColumnHeader.Rows)
            {
                hRow.Height = 35f;
                hRow.Font = new Font("D2Coding", 12f, System.Drawing.FontStyle.Bold);
                hRow.BackColor = Color.CornflowerBlue;
                hRow.ForeColor = Color.White;
            }

            sheet.Rows.Default.Height = 35f;
            sheet.RowHeader.Visible = false;

            // Enter 키 입력 시 다음 셀로 이동
            InputMap inputMap = grid.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
            inputMap.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumn);

            // Enter 키 입력 시 다음 행의 첫 번째 셀로 이동
            inputMap.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow);
        }

        internal static void EndGrid(FpSpread spread)
        {
            FpSpread grid = spread;
            SheetView sheet = grid.Sheets[0];
            sheet.DataSource = null;

            grid.ResizeZeroIndicator = ResizeZeroIndicator.Default;
        }

        internal static void AddTextColumn(FpSpread spread
            , string name, string text, bool readOnly, bool visible, int width
            , CellHorizontalAlignment hAlign, CellVerticalAlignment vAlign)
        {
            TextCellType textCellType = new TextCellType();

            SheetView sheet = spread.Sheets[0];
            sheet.ColumnCount++;

            Column col = sheet.Columns[sheet.ColumnCount - 1];
            col.CellType = textCellType;

            SetBasicColumn(sheet, col, name, text, readOnly, visible, width, hAlign, vAlign);
        }

        internal static void AddNumberColumn(FpSpread spread
            , string name, string text, bool readOnly, bool visible, int width
            , CellHorizontalAlignment hAlign, CellVerticalAlignment vAlign)
        {
            NumberCellType numberCellType = new NumberCellType();

            SheetView sheet = spread.Sheets[0];
            sheet.ColumnCount++;

            Column col = sheet.Columns[sheet.ColumnCount - 1];
            col.CellType = numberCellType;

            SetBasicColumn(sheet, col, name, text, readOnly, visible, width, hAlign, vAlign);
        }

        internal static void AddCurrencyColumn(FpSpread spread
            , string name, string text, bool readOnly, bool visible, int width
            , CellHorizontalAlignment hAlign, CellVerticalAlignment vAlign)
        {
            CurrencyCellType currencyCellType = new CurrencyCellType();

            SheetView sheet = spread.Sheets[0];
            sheet.ColumnCount++;

            Column col = sheet.Columns[sheet.ColumnCount - 1];
            col.CellType = currencyCellType;

            SetBasicColumn(sheet, col, name, text, readOnly, visible, width, hAlign, vAlign);
        }

        internal static void AddPercentColumn(FpSpread spread
            , string name, string text, bool readOnly, bool visible, int width
            , CellHorizontalAlignment hAlign, CellVerticalAlignment vAlign)
        {
            PercentCellType percentCellType = new PercentCellType();

            SheetView sheet = spread.Sheets[0];
            sheet.ColumnCount++;

            Column col = sheet.Columns[sheet.ColumnCount - 1];
            col.CellType = percentCellType;

            SetBasicColumn(sheet, col, name, text, readOnly, visible, width, hAlign, vAlign);
        }

        internal static void AddDateTimeColumn(FpSpread spread
            , string name, string text, bool readOnly, bool visible, int width
            , CellHorizontalAlignment hAlign, CellVerticalAlignment vAlign)
        {
            DateTimeCellType dateTimeCellType = new DateTimeCellType();

            SheetView sheet = spread.Sheets[0];
            sheet.ColumnCount++;

            Column col = sheet.Columns[sheet.ColumnCount - 1];
            col.CellType = dateTimeCellType;

            SetBasicColumn(sheet, col, name, text, readOnly, visible, width, hAlign, vAlign);
        }

        internal static void AddCheckBoxColumn(FpSpread spread
            , string name, string text, bool readOnly, bool visible, int width
            , CellHorizontalAlignment hAlign, CellVerticalAlignment vAlign)
        {
            CheckBoxCellType checkBoxCellType = new CheckBoxCellType();

            SheetView sheet = spread.Sheets[0];
            sheet.ColumnCount++;

            Column col = sheet.Columns[sheet.ColumnCount - 1];
            col.CellType = checkBoxCellType;

            SetBasicColumn(sheet, col, name, text, readOnly, visible, width, hAlign, vAlign);
        }

        internal static void AddComboBoxColumn(FpSpread spread
            , string name, string text, bool readOnly, bool visible, int width
            , CellHorizontalAlignment hAlign, CellVerticalAlignment vAlign, string[] items, string[] itemDatas)
        {
            ComboBoxCellType comboBoxCellType = new ComboBoxCellType();
            comboBoxCellType.Items = items;
            comboBoxCellType.ItemData = itemDatas;

            SheetView sheet = spread.Sheets[0];
            sheet.ColumnCount++;

            Column col = sheet.Columns[sheet.ColumnCount - 1];
            col.CellType = comboBoxCellType;

            SetBasicColumn(sheet, col, name, text, readOnly, visible, width, hAlign, vAlign);


        }

        internal static void AddButtonColumn(FpSpread spread
            , string name, string text, bool readOnly, bool visible, int width
            , CellHorizontalAlignment hAlign, CellVerticalAlignment vAlign)
        {
            ButtonCellType buttonCellType = new ButtonCellType();

            SheetView sheet = spread.Sheets[0];
            sheet.ColumnCount++;

            Column col = sheet.Columns[sheet.ColumnCount - 1];
            col.CellType = buttonCellType;

            SetBasicColumn(sheet, col, name, text, readOnly, visible, width, hAlign, vAlign);
        }

        internal static void AddImageColumn(FpSpread spread
            , string name, string text, bool readOnly, bool visible, int width
            , CellHorizontalAlignment hAlign, CellVerticalAlignment vAlign)
        {
            ImageCellType imageCellType = new ImageCellType();

            SheetView sheet = spread.Sheets[0];
            sheet.ColumnCount++;

            Column col = sheet.Columns[sheet.ColumnCount - 1];
            col.CellType = imageCellType;

            SetBasicColumn(sheet, col, name, text, readOnly, visible, width, hAlign, vAlign);
        }

        internal static void AddHyperLinkColumn(FpSpread spread
            , string name, string text, bool readOnly, bool visible, int width
            , CellHorizontalAlignment hAlign, CellVerticalAlignment vAlign)
        {
            HyperLinkCellType hyperLinkCellType = new HyperLinkCellType();

            SheetView sheet = spread.Sheets[0];
            sheet.ColumnCount++;

            Column col = sheet.Columns[sheet.ColumnCount - 1];
            col.CellType = hyperLinkCellType;

            SetBasicColumn(sheet, col, name, text, readOnly, visible, width, hAlign, vAlign);
        }

        private static void SetBasicColumn(SheetView sheet, Column col
            , string name, string text
            , bool readOnly, bool visible, int width
            , CellHorizontalAlignment hAlign, CellVerticalAlignment vAlign)
        {
            col.Tag = name;
            col.Label = text;
            col.Locked = readOnly;
            col.Visible = visible;
            col.Width = width;
            col.HorizontalAlignment = hAlign;
            col.VerticalAlignment = vAlign;

            if (!col.Visible)
            {
                col.Resizable = false;
            }
        }
    }
}
