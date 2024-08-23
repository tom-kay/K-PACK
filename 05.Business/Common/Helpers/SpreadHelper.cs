using FarPoint.Win;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using FarPoint.Win.Spread.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.Common.Helpers
{
    internal class SpreadHelper
    {
        /// <summary>
        /// 날짜 포맷
        /// </summary>
        public static readonly string DEFAULT_DATE_FORMAT = "YYYY-MM-DD HH:mm:ss";
        public static readonly string DEFAULT_TIME_FORMAT = "HH:mm:ss";
        public static readonly string DEFAULT_DATETIME_FORMAT = "YYYY-MM-DD HH:mm:ss";

        /// <summary>
        /// GridBackColor
        /// 그리드 배경색 설정
        /// </summary>
        private static class GridBackColor
        {
            public static readonly Color GrayArea = Color.LightGray;
            public static readonly Color Header = Color.FromArgb(125, 183, 240);
            public static readonly Color Background = Color.White;
            public static readonly Color AlternateRow = Color.GhostWhite;
            public static readonly Color Selection = Color.Blue;
            public static readonly Color Edit = Color.White;
            public static readonly Color Readonly = Color.White;
            public static readonly Color Mandatory = SystemColors.Info;
            public static readonly Color SubTotal = Color.Azure;
            public static readonly Color GrandTotal = Color.Blue;
        }

        /// <summary>
        /// GridForeColor
        /// 그리드 전경색 설정
        /// </summary>
        private static class GridForeColor
        {
            public static Color Header = Color.Black;
            public static Color AlternateRow = Color.GhostWhite;
            public static Color Selection = Color.White;
            public static Color Edit = Color.Black;
            public static Color Readonly = Color.Black;
            public static Color Mandatory = Color.Black;
            public static Color SubTotal = Color.Blue;
            public static Color GrandTotal = Color.White;
        }

        public enum GridHorizontalAlignment
        {
            Left = 0,
            Center = 1,
            Right = 2,
            General = 3
        }

        public enum GridVerticalAlignment
        {
            Middle = 0,
            Top = 1,
            Bottom = 2,
            General = 3
        }

        /// <summary>
        /// 그리드 스타일 설정
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="style"></param>
        //public static void SetGridStyle(FpSpread fpSpread, GridStyle style)
        //{
        //    // Skin 설정
        //    fpSpread.Skin = DefaultSpreadSkins.Classic;
        //    fpSpread.ActiveSheet.DefaultStyle.VisualStyles = VisualStyles.On;
        //    fpSpread.InterfaceRenderer = null;

        //    // BackColor, ForeColor 설정
        //    //fpSpread.ActiveSheet.GrayAreaBackColor = GridBackColor.GrayArea;
        //    //fpSpread.ActiveSheet.Columns.Default.BackColor = GridBackColor.Background;
        //    //fpSpread.ActiveSheet.ColumnHeader.DefaultStyle.BackColor = GridBackColor.Header;
        //    //fpSpread.ActiveSheet.RowHeader.DefaultStyle.BackColor = GridBackColor.Header;
        //    //fpSpread.ActiveSheet.SheetCornerStyle.BackColor = GridBackColor.Header;
        //    //fpSpread.ActiveSheet.SelectionBackColor = GridBackColor.Selection;
        //    //fpSpread.ActiveSheet.SelectionForeColor = GridForeColor.Selection;

        //    // 스크롤바 관련 설정
        //    fpSpread.ColumnSplitBoxPolicy = SplitBoxPolicy.Never;
        //    fpSpread.RowSplitBoxPolicy = SplitBoxPolicy.Never;
        //    fpSpread.HorizontalScrollBarPolicy = ScrollBarPolicy.AsNeeded;
        //    fpSpread.VerticalScrollBarPolicy = ScrollBarPolicy.AsNeeded;
        //    fpSpread.ScrollTipPolicy = ScrollTipPolicy.Vertical;

        //    // Column, Row 관련 설정
        //    fpSpread.AllowColumnMove = true;
        //    fpSpread.AllowRowMove = false;
        //    fpSpread.RetainSelectionBlock = false;
        //    fpSpread.EditModeReplace = true;

        //    fpSpread.ActiveSheet.AutoGenerateColumns = false;
        //    fpSpread.ActiveSheet.DataAutoSizeColumns = false;
        //    fpSpread.ActiveSheet.DataAutoCellTypes = false;

        //    // OperationMode (선택모드) 설정
        //    //fpSpread.ActiveSheet.OperationMode = OperationMode.Normal;
        //    //fpSpread.ActiveSheet.SelectionStyle = SelectionStyles.SelectionColors;
        //    //fpSpread.ActiveSheet.SelectionPolicy = SelectionPolicy.MultiRange;
        //    //fpSpread.ActiveSheet.SelectionUnit = SelectionUnit.Cell;

        //    fpSpread.ActiveSheet.Rows.Default.Height = 24;

        //    // 그리드의 모든 행열 삭제
        //    fpSpread.ActiveSheet.ColumnCount = 0;
        //    fpSpread.ActiveSheet.RowCount = 0;

        //    //fpSpread.Enter += new EventHandler(fpSpread_Enter);
        //}

        /// <summary>
        /// 그리드 스타일 설정
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="style"></param>
        public static void SetGridStyle(FpSpread fpSpread, string style)
        {
            // Skin 설정
            fpSpread.Skin = DefaultSpreadSkins.Classic;
            fpSpread.ActiveSheet.DefaultStyle.VisualStyles = VisualStyles.Off;
            fpSpread.InterfaceRenderer = null;

            // BackColor, ForeColor 설정
            fpSpread.ActiveSheet.GrayAreaBackColor = GridBackColor.Background;
            //fpSpread.ActiveSheet.Columns.Default.BackColor = GridBackColor.Background;
            fpSpread.ActiveSheet.ColumnHeader.DefaultStyle.BackColor = GridBackColor.Header;
            fpSpread.ActiveSheet.RowHeader.DefaultStyle.BackColor = GridBackColor.Header;
            fpSpread.ActiveSheet.SheetCornerStyle.BackColor = GridBackColor.Header;
            //fpSpread.ActiveSheet.SelectionBackColor = GridBackColor.Selection;
            //fpSpread.ActiveSheet.SelectionForeColor = GridForeColor.Selection;
            fpSpread.Tag = style.ToString();

            BevelBorder bevelBorder1 = new BevelBorder(BevelBorderType.Lowered, Color.FromArgb(182, 214, 245), System.Drawing.Color.Empty);
            fpSpread.ActiveSheet.DefaultStyle.Border = bevelBorder1;

            //if (style.ToString().Equals(style))
            //{
            //    fpSpread.ActiveSheet.AlternatingRows.Count = 2;
            //    fpSpread.ActiveSheet.AlternatingRows.Get(0).BackColor = Color.White;
            //    fpSpread.ActiveSheet.AlternatingRows.Get(1).BackColor = Color.Azure;
            //}

            // 스크롤바 관련 설정
            fpSpread.ColumnSplitBoxPolicy = SplitBoxPolicy.Never;
            fpSpread.RowSplitBoxPolicy = SplitBoxPolicy.Never;
            fpSpread.HorizontalScrollBarPolicy = ScrollBarPolicy.AsNeeded;
            fpSpread.VerticalScrollBarPolicy = ScrollBarPolicy.AsNeeded;
            fpSpread.ScrollTipPolicy = ScrollTipPolicy.Vertical;

            // Column, Row 관련 설정
            fpSpread.AllowColumnMove = false;
            fpSpread.AllowRowMove = false;
            fpSpread.RetainSelectionBlock = false;
            fpSpread.EditModeReplace = true;

            fpSpread.ActiveSheet.AutoGenerateColumns = false;
            fpSpread.ActiveSheet.DataAutoSizeColumns = false;
            fpSpread.ActiveSheet.DataAutoCellTypes = false;

            // OperationMode (선택모드) 설정
            //fpSpread.ActiveSheet.SelectionStyle = SelectionStyles.SelectionColors;
            //fpSpread.ActiveSheet.OperationMode = OperationMode.Normal;
            //if (style == GridStyle.InPlaceEdit)
            //{
            //    fpSpread.ActiveSheet.SelectionUnit = SelectionUnit.Cell;
            //    fpSpread.ActiveSheet.SelectionPolicy = SelectionPolicy.Single;
            //}
            //else
            //{
            //    fpSpread.ActiveSheet.SelectionUnit = SelectionUnit.Row;
            //    fpSpread.ActiveSheet.SelectionPolicy = SelectionPolicy.Single;
            //}

            fpSpread.ActiveSheet.Rows.Default.Height = 22;

            // 그리드의 모든 행열 삭제
            fpSpread.ActiveSheet.ColumnCount = 0;
            fpSpread.ActiveSheet.RowCount = 0;
            //fpSpread.Enter += new EventHandler(fpSpread_Enter);

            //fpSpread.PreviewKeyDown += OnSpreadPreviewKeyDown;
            fpSpread.KeyDown += OnSpreadKeyDown;
        }

        private static void OnSpreadKeyDown(object sender, KeyEventArgs e)
        {
            FpSpread fpSpread = (FpSpread)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (fpSpread.ActiveSheet.ActiveRowIndex < fpSpread.ActiveSheet.Rows.Count - 1)
                {
                    fpSpread.ActiveSheet.ActiveRowIndex++;
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="cellAlignment"></param>
        /// <param name="enabled"></param>
        public static void AddColumn(FpSpread fpSpread, string fieldName, string label, int width, GridHorizontalAlignment cellAlignment, bool enabled)
        {
            fpSpread.ActiveSheet.Columns.Add(fpSpread.ActiveSheet.Columns.Count, 1);

            FarPoint.Win.Spread.Column column = fpSpread.ActiveSheet.Columns[fpSpread.ActiveSheet.Columns.Count - 1];

            column.Tag = fieldName;
            column.DataField = fieldName;
            column.Label = label;
            column.Width = width;
            column.VerticalAlignment = CellVerticalAlignment.Center;
            column.HorizontalAlignment = ToCellHorizontalAlignment(cellAlignment);
            column.Locked = !enabled;
            column.BackColor = enabled ? GridBackColor.Edit : GridBackColor.Readonly;
        }

        /// <summary>
        /// 문자 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="maxLength"></param>
        /// <param name="enabled"></param>
        public static void AddTextColumn(FpSpread fpSpread, string fieldName, string label, int width, int maxLength, bool enabled)
        {
            AddTextColumn(fpSpread, fieldName, label, width, maxLength, GridHorizontalAlignment.Left, enabled);

        }

        /// <summary>
        /// 문자 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="maxLength"></param>
        /// <param name="cellAlignment"></param>
        /// <param name="enabled"></param>
        public static void AddTextColumn(FpSpread fpSpread, string fieldName, string label, int width, int maxLength, GridHorizontalAlignment cellAlignment, bool enabled)
        {
            AddColumn(fpSpread, fieldName, label, width, cellAlignment, enabled);

            FarPoint.Win.Spread.Column column = fpSpread.ActiveSheet.Columns[fpSpread.ActiveSheet.Columns.Count - 1];

            TextCellType cellType = new TextCellType();
            cellType.MaxLength = maxLength;
            column.CellType = cellType;
        }

        /// <summary>
        /// 숫자 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="decimalPlaces"></param>
        /// <param name="showSeparator"></param>
        /// <param name="enabled"></param>
        public static void AddNumberColumn(FpSpread fpSpread, string fieldName, string label, int width, int decimalPlaces, bool showSeparator, bool enabled)
        {
            AddNumberColumn(fpSpread, fieldName, label, width, decimalPlaces, showSeparator, GridHorizontalAlignment.Right, enabled);
        }

        /// <summary>
        /// 숫자 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="decimalPlaces"></param>
        /// <param name="showSeparator"></param>
        /// <param name="cellAlignment"></param>
        /// <param name="enabled"></param>
        public static void AddNumberColumn(FpSpread fpSpread, string fieldName, string label, int width, int decimalPlaces, bool showSeparator, GridHorizontalAlignment cellAlignment, bool enabled)
        {
            AddColumn(fpSpread, fieldName, label, width, cellAlignment, enabled);

            FarPoint.Win.Spread.Column column = fpSpread.ActiveSheet.Columns[fpSpread.ActiveSheet.Columns.Count - 1];

            NumberCellType cellType = new NumberCellType();
            cellType.DecimalPlaces = decimalPlaces;
            cellType.FixedPoint = false;
            cellType.DecimalSeparator = ".";
            cellType.Separator = ",";
            cellType.ShowSeparator = showSeparator;
            cellType.MaximumValue = 9999999999999.9999;
            column.CellType = cellType;
        }

        /// <summary>
        /// 날짜 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="enabled"></param>
        public static void AddDateColumn(FpSpread fpSpread, string fieldName, string label, int width, bool enabled)
        {
            AddDateTimeColumn(fpSpread, fieldName, label, width, DEFAULT_DATE_FORMAT, enabled);
        }

        /// <summary>
        /// 시간 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="enabled"></param>
        public static void AddTimeColumn(FpSpread fpSpread, string fieldName, string label, int width, bool enabled)
        {
            AddDateTimeColumn(fpSpread, fieldName, label, width, DEFAULT_TIME_FORMAT, enabled);
        }

        /// <summary>
        /// 날짜/시간 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="enabled"></param>
        public static void AddDateTimeColumn(FpSpread fpSpread, string fieldName, string label, int width, bool enabled)
        {
            AddDateTimeColumn(fpSpread, fieldName, label, width, DEFAULT_DATETIME_FORMAT, enabled);
        }

        /// <summary>
        /// 날짜/시간 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="dateTimeFormat"></param>
        /// <param name="enabled"></param>
        public static void AddDateTimeColumn(FpSpread fpSpread, string fieldName, string label, int width, string dateTimeFormat, bool enabled)
        {
            AddColumn(fpSpread, fieldName, label, width, GridHorizontalAlignment.Center, enabled);

            FarPoint.Win.Spread.Column column = fpSpread.ActiveSheet.Columns[fpSpread.ActiveSheet.Columns.Count - 1];

            DateTimeCellType cellType = new DateTimeCellType();
            cellType.DateTimeFormat = DateTimeFormat.UserDefined;
            cellType.UserDefinedFormat = dateTimeFormat;
            column.CellType = cellType;
        }

        /// <summary>
        /// 체크박스 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="enabled"></param>
        public static void AddCheckBoxColumn(FpSpread fpSpread, string fieldName, string label, int width, bool enabled)
        {
            AddColumn(fpSpread, fieldName, label, width, GridHorizontalAlignment.Center, enabled);

            FarPoint.Win.Spread.Column column = fpSpread.ActiveSheet.Columns[fpSpread.ActiveSheet.Columns.Count - 1];

            CheckBoxCellType cellType = new CheckBoxCellType();
            column.CellType = cellType;
        }

        /// <summary>
        ///  버튼 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="buttonText"></param>
        /// <param name="enabled"></param>
        public static void AddButtonColumn(FpSpread fpSpread, string fieldName, string label, int width, string buttonText, bool enabled)
        {
            AddColumn(fpSpread, fieldName, label, width, GridHorizontalAlignment.Center, enabled);

            FarPoint.Win.Spread.Column column = fpSpread.ActiveSheet.Columns[fpSpread.ActiveSheet.Columns.Count - 1];

            ButtonCellType cellType = new ButtonCellType();
            cellType.Text = buttonText;
            column.CellType = cellType;
        }

        /// <summary>
        /// 콤보박스 컬럼 추가
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="label"></param>
        /// <param name="width"></param>
        /// <param name="dtCombo"></param>
        /// <param name="valueField"></param>
        /// <param name="displayField"></param>
        /// <param name="enabled"></param>
        public static void AddComboBoxColumn(FpSpread fpSpread, string fieldName, string label, int width, DataTable dtCombo, string valueField, string displayField, bool enabled)
        {
            AddColumn(fpSpread, fieldName, label, width, GridHorizontalAlignment.Center, enabled);

            Column column = fpSpread.ActiveSheet.Columns[fpSpread.ActiveSheet.Columns.Count - 1];

            ComboBoxCellType cellType = new ComboBoxCellType();
            string[] valueList = new string[dtCombo.Rows.Count];
            string[] displayList = new string[dtCombo.Rows.Count];
            for (int i = 0; i < dtCombo.Rows.Count; i++)
            {
                //valueList[i] = ConvertUtil.ToString(dtCombo.Rows[i][valueField]);
                //displayList[i] = ConvertUtil.ToString(dtCombo.Rows[i][displayField]);
            }
            cellType.Items = displayList;
            cellType.ItemData = valueList;
            cellType.EditorValue = EditorValue.ItemData;
            column.CellType = cellType;
        }

        public static void AddImageColumn(FpSpread fpSpread, string fieldName, string label, int width)
        {
            AddColumn(fpSpread, fieldName, label, width, GridHorizontalAlignment.Center, false);

            Column column = fpSpread.ActiveSheet.Columns[fpSpread.ActiveSheet.Columns.Count - 1];

            ImageCellType cellType = new ImageCellType();
            cellType.Style = FarPoint.Win.RenderStyle.Normal;
            cellType.TransparencyColor = Color.White;
            cellType.TransparencyTolerance = 20;
            column.CellType = cellType;
        }

        public static void SetColumnHeaders(FpSpread fpSpread, string[,] headers)
        {
            if (headers == null) throw new ArgumentException("Headers is null.");

            if (headers.Length == 0) return;

            // 배열 한 차원의 원소수, 즉 컬럼 수
            int columns = headers.GetLength(0);
            if (columns != fpSpread.ActiveSheet.Columns.Count) throw new ArgumentException("정의된 컬럼과 컬럼타이틀의 갯수가 일치하지 않습니다.");

            int rows = headers.Length / headers.GetLength(0);
            if (rows <= 1) return;

            fpSpread.ActiveSheet.ColumnHeader.Rows.Count = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    string header = headers[j, i];
                    if (header == null) continue;

                    fpSpread.ActiveSheet.ColumnHeader.Cells[i, j].Text = header;

                    int rowSpan = 1;
                    while (i + rowSpan < rows && string.Equals(header, headers[j, i + rowSpan]))
                    {
                        headers[j, i + rowSpan] = null;
                        rowSpan++;
                    }
                    if (rowSpan > 1)
                    {
                        fpSpread.ActiveSheet.ColumnHeader.Cells[i, j].RowSpan = rowSpan;
                    }

                    int colSpan = 1;
                    while (j + colSpan < columns && string.Equals(header, headers[j + colSpan, i]))
                    {
                        headers[j + colSpan, i] = null;
                        colSpan++;
                    }
                    if (colSpan > 1)
                    {
                        fpSpread.ActiveSheet.ColumnHeader.Cells[i, j].ColumnSpan = colSpan;
                    }
                }
            }
        }

        public static int[] GetCheckedRows(FpSpread fpSpread, string columnName)
        {
            int column = GetColumnIndex(fpSpread, columnName);
            return GetCheckedRows(fpSpread, column);
        }

        public static int[] GetCheckedRows(FpSpread fpSpread, int column)
        {
            CheckColumnBounds(fpSpread, column);

            ArrayList list = new ArrayList();
            for (int i = 0; i < fpSpread.ActiveSheet.Rows.Count; i++)
            {
                object value = GetValue(fpSpread, i, column);
                if (value != null && "True".Equals(IsNull(value)))
                {
                    list.Add(i);
                }
            }
            int[] result = new int[list.Count];
            list.CopyTo(result);
            return result;
        }

        /// <summary>
        /// 데이터 소스 바인드
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="dataSource"></param>
        public static void SetDataSource(FpSpread fpSpread, object dataSource)
        {
            try
            {
                if (fpSpread.ActiveSheet.DataSource != null)
                {
                    object obj = fpSpread.ActiveSheet.DataSource;
                    if (obj != null && obj is IDisposable)
                    {
                        ((IDisposable)obj).Dispose();
                    }
                    fpSpread.ActiveSheet.Rows.Clear();
                }

                fpSpread.ActiveSheet.DataSource = dataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 바인드된 데이터소스 클리어
        /// </summary>
        /// <param name="fpSpread"></param>
        public static void ClearDataSource(FpSpread fpSpread)
        {
            try
            {
                if (fpSpread.ActiveSheet.RowCount > 0)
                {
                    fpSpread.ActiveSheet.RowCount = 0;
                }
                if (fpSpread.ActiveSheet.DataSource != null)
                {
                    object obj = fpSpread.ActiveSheet.DataSource;
                    if (obj != null && obj is IDisposable)
                    {
                        ((IDisposable)obj).Dispose();
                    }
                    fpSpread.ActiveSheet.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// fieldName에 해당하는 컬럼의 컬럼인덱스 리턴
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static int GetColumnIndex(FpSpread fpSpread, string columnName)
        {
            if (string.IsNullOrEmpty(columnName)) return -1;

            Column column = fpSpread.ActiveSheet.Columns[columnName];

            if (column != null)
            {
                return column.Index;
            }
            else
            {
                return -1;
            }
        }

        public static string GetText(FpSpread fpSpread, int row, string columnName)
        {
            int column = GetColumnIndex(fpSpread, columnName);

            return GetText(fpSpread, row, column);
        }

        public static string GetText(FpSpread fpSpread, int row, int column)
        {
            CheckRowBounds(fpSpread, row);
            CheckColumnBounds(fpSpread, column);

            return fpSpread.ActiveSheet.Cells[row, column].Text;
        }

        //public static GridRowState GetRowState(FpSpread fpSpread, int row)
        //{
        //    if (row < 0 || row >= fpSpread.ActiveSheet.Rows.Count) throw new ArgumentException("Row index out of range");

        //    if (fpSpread.ActiveSheet.DataSource == null || !(fpSpread.ActiveSheet.DataSource is DataTable))
        //    {
        //        return GridRowState.Added;
        //    }

        //    DataTable dt = (DataTable)fpSpread.ActiveSheet.DataSource;
        //    DataRowState state = dt.Rows[row].RowState;
        //    switch (state)
        //    {
        //        case DataRowState.Added:
        //            return GridRowState.Added;
        //        case DataRowState.Deleted:
        //            return GridRowState.Deleted;
        //        case DataRowState.Modified:
        //            return GridRowState.Modified;
        //        default:
        //            return GridRowState.Unchanged;
        //    }
        //}

        public static void AddRow(FpSpread fpSpread)
        {
            int row = fpSpread.ActiveSheet.Rows.Count;
            AddRow(fpSpread, row);
        }

        public static void AddRow(FpSpread fpSpread, int row)
        {
            if (row < 0)
            {
                throw new ArgumentException("Row Index Out Of Range");
            }

            if (fpSpread.ActiveSheet.DataSource == null || !(fpSpread.ActiveSheet.DataSource is DataTable))
            {
                fpSpread.ActiveSheet.Rows.Add(row, 1);
            }
            else
            {
                DataTable dt = (DataTable)fpSpread.ActiveSheet.DataSource;
                DataRow dr = dt.NewRow();
                dt.Rows.InsertAt(dr, row);
            }
            //SetRowStatus(fpSpread, row, RowStatus.New);
        }

        public static void RemoveRows(FpSpread fpSpread, int[] rows)
        {
            for (int i = rows.Length - 1; i >= 0; i--)
            {
                RemoveRow(fpSpread, rows[i]);
            }
        }

        public static void RemoveRow(FpSpread fpSpread, int row)
        {
            CheckRowBounds(fpSpread, row);

            if (fpSpread.ActiveSheet.DataSource == null || !(fpSpread.ActiveSheet.DataSource is DataTable))
            {
                fpSpread.ActiveSheet.Rows.Remove(row, 1);
            }
            else
            {
                DataTable dt = (DataTable)fpSpread.ActiveSheet.DataSource;
                dt.Rows.RemoveAt(row);
            }
        }

        public static object GetValue(FpSpread fpSpread, int row, string columnName)
        {
            int column = GetColumnIndex(fpSpread, columnName);

            return GetValue(fpSpread, row, column);
        }

        public static object GetValue(FpSpread fpSpread, int row, int column)
        {
            CheckRowBounds(fpSpread, row);
            CheckColumnBounds(fpSpread, column);

            return fpSpread.ActiveSheet.Cells[row, column].Value;
        }

        public static void SetValue(FpSpread fpSpread, int row, string columnName, object value)
        {
            int column = GetColumnIndex(fpSpread, columnName);

            SetValue(fpSpread, row, column, value);
        }

        public static void SetValue(FpSpread fpSpread, int row, int column, object value)
        {
            CheckRowBounds(fpSpread, row);
            CheckColumnBounds(fpSpread, column);

            fpSpread.ActiveSheet.Cells[row, column].Value = value;
            //SetRowStatus(fpSpread, row, RowStatus.Modified);
        }

        public static int GetActiveRow(FpSpread fpSpread)
        {
            return fpSpread.ActiveSheet.ActiveRowIndex;
        }

        public static int GetActiveColumn(FpSpread fpSpread)
        {
            return fpSpread.ActiveSheet.ActiveColumnIndex;
        }

        public static void MergeRowByColumn(FpSpread fpSpread, string columnName)
        {
            MergeRowByColumns(fpSpread, new string[] { columnName }, GridVerticalAlignment.Middle);
        }

        /// <summary>
        /// 그리드의 특정 컬럼의 값이 인접한 아래쪽 로우와 같다면 머지한다.
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        public static void MergeRowByColumn(FpSpread fpSpread, string columnName, GridVerticalAlignment vertAlignment)
        {
            MergeRowByColumns(fpSpread, new string[] { columnName }, vertAlignment);
        }

        public static void MergeRowByColumns(FpSpread fpSpread, string[] columnNames)
        {
            MergeRowByColumns(fpSpread, columnNames, GridVerticalAlignment.Top);
        }

        public static void MergeRowByColumns(FpSpread fpSpread, string[] columnNames, GridVerticalAlignment vertAlignment)
        {
            if (columnNames == null || columnNames.Length == 0) return;

            MergeRowByColumns(fpSpread, ToColumnIndex(fpSpread, columnNames), vertAlignment);
        }

        public static void MergeRowByColumns(FpSpread fpSpread, int[] columns, GridVerticalAlignment vertAlignment)
        {
            if (columns == null || columns.Length == 0) return;

            MergeRows(fpSpread, columns, 0, 0, fpSpread.ActiveSheet.Rows.Count, vertAlignment);
        }

        private static void MergeRows(FpSpread fpSpread, int[] columns, int colPos, int rowPos, int rowLength, GridVerticalAlignment vertAlignment)
        {
            if (colPos >= columns.Length) return;

            while (rowPos < rowLength)
            {
                int rowSpan = CountSameRows(fpSpread, columns[colPos], rowPos, rowLength);
                if (rowSpan > 1)
                {
                    Cell cell = fpSpread.ActiveSheet.Cells[rowPos, columns[colPos]];
                    cell.RowSpan = rowSpan;
                    cell.VerticalAlignment = ToCellVerticalAlignment(vertAlignment);
                }

                MergeRows(fpSpread, columns, colPos + 1, rowPos, rowPos + rowSpan, vertAlignment);

                rowPos += rowSpan;
            }
        }

        private static int CountSameRows(FpSpread fpSpread, int column, int start, int length)
        {
            object value1 = GetValue(fpSpread, start, column);

            int pos = 1;
            while (start + pos < length)
            {
                object value2 = GetValue(fpSpread, start + pos, column);
                if (!object.Equals(value1, value2))
                {
                    return pos;
                }
                pos++;
            }
            return pos;
        }

        /// <summary>
        /// 그리드의 특정 컬럼의 값이 인접한 아래쪽 열과 같다면 머지한다.
        /// 머지할 때 columnName을 기준으로 otherColumns까지 같이 머지한다.
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="otherFields"></param>
        public static void MergeRowByColumns(FpSpread fpSpread, string columnName, string[] otherColumns)
        {
            // columnName의 컬럼 인덱스 찾기
            int column = GetColumnIndex(fpSpread, columnName);
            CheckColumnBounds(fpSpread, column);

            // others의 컬럼 인덱스 찾기
            int[] columns = new int[otherColumns == null ? 0 : otherColumns.Length];
            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = GetColumnIndex(fpSpread, otherColumns[i]);
            }

            // 루프를 돌리면서 columnName이 같은 열을 찾는다.
            for (int i = 0; i < fpSpread.ActiveSheet.Rows.Count; i++)
            {
                object value1 = fpSpread.ActiveSheet.Cells[i, column].Value;
                for (int j = i + 1; j < fpSpread.ActiveSheet.Rows.Count; j++)
                {
                    object value2 = fpSpread.ActiveSheet.Cells[j, column].Value;
                    if (!object.Equals(value1, value2))
                    {
                        // 틀린 값을 찾을 경우 i를 j - 1로 변경한다.
                        // 즉, 내부 루프에서 진행한 열만큼 외부 루프도 진행시켜 버린다.
                        // 따라서 2중 루프를 돌리지만 결국 시간복잡도는 O(n)이다. ^^
                        i = j - 1;
                        break;
                    }
                    else
                    {
                        fpSpread.ActiveSheet.Cells[i, column].RowSpan++;
                        if (otherColumns != null)
                        {
                            // columnName을 머지할 때 otherFields도 같이 머지함
                            for (int k = 0; k < columns.Length; k++)
                            {
                                fpSpread.ActiveSheet.Cells[i, columns[k]].RowSpan++;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 그리드의 특정 컬럼을 머지한다.
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="colSpan"></param>
        public static void MergeColumn(FpSpread fpSpread, string columnName, int colSpan)
        {
            int column = GetColumnIndex(fpSpread, columnName);
            for (int i = 0; i < fpSpread.ActiveSheet.Rows.Count; i++)
            {
                MergeColumn(fpSpread, i, column, colSpan);
            }
        }

        public static void MergeColumn(FpSpread fpSpread, int row, string columnName, int colSpan)
        {
            int column = GetColumnIndex(fpSpread, columnName);
            MergeColumn(fpSpread, row, column, colSpan);
        }

        /// <summary>
        /// 그리드의 특정 컬럼을 머지한다.
        /// </summary>
        /// <param name="fpSpread"></param>
        /// <param name="fieldName"></param>
        /// <param name="colSpan"></param>
        public static void MergeColumn(FpSpread fpSpread, int row, int column, int colSpan)
        {
            CheckRowBounds(fpSpread, row);
            CheckColumnBounds(fpSpread, column);
            fpSpread.ActiveSheet.Cells[row, column].ColumnSpan = colSpan;
        }

        private static void CheckRowBounds(FpSpread fpSpread, int row)
        {
            if (row < 0 || row >= fpSpread.ActiveSheet.RowCount)
            {
                throw new ArgumentException(string.Format("Row Index[{0}] Out Of Range", row));
            }
        }

        private static void CheckColumnBounds(FpSpread fpSpread, int column)
        {
            if (column < 0 || column >= fpSpread.ActiveSheet.ColumnCount)
            {
                throw new ArgumentException(string.Format("Column Index[{0}] Out Of Range", column));
            }
        }

        private static CellVerticalAlignment ToCellVerticalAlignment(GridVerticalAlignment cellAlignment)
        {
            switch (cellAlignment)
            {
                case GridVerticalAlignment.Top:
                    return CellVerticalAlignment.Top;
                case GridVerticalAlignment.Middle:
                    return CellVerticalAlignment.Center;
                case GridVerticalAlignment.Bottom:
                    return CellVerticalAlignment.Bottom;
                default:
                    return CellVerticalAlignment.General;
            }
        }

        private static CellHorizontalAlignment ToCellHorizontalAlignment(GridHorizontalAlignment cellAlignment)
        {
            switch (cellAlignment)
            {
                case GridHorizontalAlignment.Left:
                    return CellHorizontalAlignment.Left;
                case GridHorizontalAlignment.Center:
                    return CellHorizontalAlignment.Center;
                case GridHorizontalAlignment.Right:
                    return CellHorizontalAlignment.Right;
                default:
                    return CellHorizontalAlignment.General;
            }
        }

        private static int[] ToColumnIndex(FpSpread fpSpread, string[] columnNames)
        {
            if (columnNames == null || columnNames.Length == 0) return new int[0];

            int[] result = new int[columnNames.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = GetColumnIndex(fpSpread, columnNames[i]);
            }
            return result;
        }

        private static void GridRowChanged(object sender, DataRowChangeEventArgs e)
        {
            DataTable dt = (DataTable)sender;
            //Console.WriteLine(string.Format("Row Changed = {0}", e.Row.));
        }

        private static void SetTotal(FpSpread fpSpread, string[] keyColumns, string[] valueColumns)
        {
            if (keyColumns == null || keyColumns.Length == 0) return;
            if (valueColumns == null || valueColumns.Length == 0) return;

            SetTotal(fpSpread, ToColumnIndex(fpSpread, keyColumns), ToColumnIndex(fpSpread, valueColumns));
        }

        private static void SetTotal(FpSpread fpSpread, int[] keyColumns, int[] valueColumns)
        {
            CalcTotal(fpSpread, keyColumns, 0, 0, fpSpread.ActiveSheet.Rows.Count, valueColumns);
        }

        private static void CalcTotal(FpSpread fpSpread, int[] columns, int colPos, int rowPos, int rowLength, int[] valueColumns)
        {
            if (colPos >= columns.Length) return;

            while (rowPos < rowLength)
            {
                Cell cell = fpSpread.ActiveSheet.Cells[rowPos, columns[colPos]];
                if (cell.RowSpan > 1)
                {
                }

                CalcTotal(fpSpread, columns, colPos + 1, rowPos, rowPos + cell.RowSpan, valueColumns);

                rowPos += cell.RowSpan;
            }
        }

        public static void SetText(FpSpread spread, int rowInx, int colInx, string alignment, string strText)
        {
            SetText(spread, rowInx, colInx, alignment, strText, Color.White);
        }

        public static void SetText(FpSpread spread, int rowInx, int colInx, string alignment, string strText, double colorNo)
        {
            if (colorNo == 1)
            {
                SetText(spread, rowInx, colInx, alignment, strText, Color.Red);
            }
            else if (colorNo == -1)
            {
                SetText(spread, rowInx, colInx, alignment, strText, Color.Blue);
            }
            else
            {
                SetText(spread, rowInx, colInx, alignment, strText, Color.White);
            }

        }

        public static void SetText(FpSpread spread, int rowInx, int colInx, string alignment, string strText, Color color)
        {
            SheetView sv = spread.ActiveSheet;
            FarPoint.Win.Spread.Cell cell = sv.Cells[rowInx, colInx];

            cell.Text = strText;
            if (alignment.Equals("C"))
            {
                cell.HorizontalAlignment = CellHorizontalAlignment.Center;
            }
            else if (alignment.Equals("L"))
            {
                cell.HorizontalAlignment = CellHorizontalAlignment.Left;
            }
            else if (alignment.Equals("R"))
            {
                cell.HorizontalAlignment = CellHorizontalAlignment.Right;
            }
            cell.BackColor = color;
        }

        public static string IsNull(object value)
        {
            // Check if the value is null or an empty string
            if (value == null || value.ToString().Trim() == string.Empty)
            {
                return "False";
            }
            return value.ToString();
        }

    }
}
