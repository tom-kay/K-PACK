﻿using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace P05_Business.Common
{   
    /// <summary>
    /// DataGridView 생성 설정
    /// </summary>
    public class UserDataGrid
	{
		public enum TextType
		{
			None,
			Text,
			Date,
			Time,
			DateTime
		}

		/// <summary>
		/// DataGridView Frame 설정
		/// </summary>
		/// <param name="dataGrid"></param>
		/// <param name="sizeColumnsMode"></param>
		public static void Create(DataGridView dataGrid, DataGridViewAutoSizeColumnsMode sizeColumnsMode)
		{
			dataGrid.Refresh();

			dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
			dataGrid.AutoSizeColumnsMode = sizeColumnsMode;  //사용자정의
			dataGrid.AllowUserToResizeRows = false;
			dataGrid.BackgroundColor = SystemColors.Window;
			dataGrid.BorderStyle = BorderStyle.None;
			dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGrid.AutoGenerateColumns = false;
			dataGrid.RowHeadersVisible = false;
			dataGrid.EnableHeadersVisualStyles = false;

			dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGrid.ColumnHeadersHeight = 35;
			dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;			
			dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft New Tai Lue", 12f, FontStyle.Bold);
			dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
			dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
			dataGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

			dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGrid.DefaultCellStyle.Font = new Font("Microsoft New Tai Lue", 12f);
			dataGrid.DefaultCellStyle.BackColor = Color.White;
			dataGrid.DefaultCellStyle.ForeColor = SystemColors.WindowText;
			dataGrid.DefaultCellStyle.SelectionBackColor = Color.White;
			dataGrid.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;

			dataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.Beige;
			dataGrid.RowsDefaultCellStyle.SelectionForeColor = SystemColors.WindowText;

			dataGrid.RowTemplate.Height = 35;
		}

		public static void End(DataGridView dataGrid)
		{	
			dataGrid.DataSource = null;
			dataGrid.Rows.Clear();
		}

		/// <summary>
		/// 텍스박스 컬럼 추가.
		/// </summary>
		/// <param name="dataGrid">DataGridView</param>
		/// <param name="name">컬럼명</param>
		/// <param name="headerText">컬럼헤더 텍스트</param>
		/// <param name="readOnly">컬럼 읽기 전용 설정</param>
		/// <param name="visible">컬럼 노출 설정</param>
		/// <param name="columnWidth">컬럼 넓이 설정</param>
		/// <param name="alignment">컬럼 정렬 설정</param>
		public static void AddTextBoxColumn(DataGridView dataGrid
			, string name, string headerText, bool readOnly, bool visible, int columnWidth
			, DataGridViewContentAlignment alignment, TextType textType = TextType.None)
		{
			DataGridViewTextBoxColumn text = new DataGridViewTextBoxColumn();

			dataGrid.Columns.Add(SetGridCommonOption(text, name, headerText, readOnly, visible, columnWidth, alignment, textType));

		}

		/// <summary>
		/// 콤보박스 컬럼 추가
		/// </summary>
		/// <param name="dataGrid">DataGridView</param>
		/// <param name="name">컬럼명</param>
		/// <param name="headerText">컬럼헤더 텍스트</param>
		/// <param name="readOnly">컬럼 읽기 전용 설정</param>
		/// <param name="visible">컬럼 노출 설정</param>
		/// <param name="columnWidth">컬럼 넓이 설정</param>
		/// <param name="alignment">컬럼 정렬 설정</param>
		public static void AddComboBoxColumn(DataGridView dataGrid
			, string name, string headerText, bool readOnly, bool visible, int columnWidth
			, DataGridViewContentAlignment alignment)
		{
			DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();

			dataGrid.Columns.Add(SetGridCommonOption(combo, name, headerText, readOnly, visible, columnWidth, alignment));
		}

		/// <summary>
		/// 체크박스 컬럼 추가
		/// </summary>
		/// <param name="dataGrid">DataGridView</param>
		/// <param name="name">컬럼명</param>
		/// <param name="headerText">컬럼헤더 텍스트</param>
		/// <param name="readOnly">컬럼 읽기 전용 설정</param>
		/// <param name="visible">컬럼 노출 설정</param>
		/// <param name="columnWidth">컬럼 넓이 설정</param>
		/// <param name="alignment">컬럼 정렬 설정</param>
		public static void AddCheckBoxColumn(DataGridView dataGrid
			, string name, string headerText, bool readOnly, bool visible, int columnWidth
			, DataGridViewContentAlignment alignment)
		{
			DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();

			dataGrid.Columns.Add(SetGridCommonOption(check, name, headerText, readOnly, visible, columnWidth, alignment));
		}

		/// <summary>
		/// 버튼 컬럼 추가.
		/// </summary>
		/// <param name="dataGrid">DataGridView</param>
		/// <param name="name">컬럼명</param>
		/// <param name="headerText">컬럼헤더 텍스트</param>
		/// <param name="readOnly">컬럼 읽기 전용 설정</param>
		/// <param name="visible">컬럼 노출 설정</param>
		/// <param name="columnWidth">컬럼 넓이 설정</param>
		/// <param name="alignment">컬럼 정렬 설정</param>
		public static void AddButtonColumn(DataGridView dataGrid
			, string name, string headerText, bool readOnly, bool visible, int columnWidth
			, DataGridViewContentAlignment alignment)
		{
			DataGridViewButtonColumn button = new DataGridViewButtonColumn();

			dataGrid.Columns.Add(SetGridCommonOption(button, name, headerText, readOnly, visible, columnWidth, alignment));
		}

		/// <summary>
		/// 이미지 컬럼 추가
		/// </summary>
		/// <param name="dataGrid">DataGridView</param>
		/// <param name="name">컬럼명</param>
		/// <param name="headerText">컬럼헤더 텍스트</param>
		/// <param name="readOnly">컬럼 읽기 전용 설정</param>
		/// <param name="visible">컬럼 노출 설정</param>
		/// <param name="columnWidth">컬럼 넓이 설정</param>
		/// <param name="alignment">컬럼 정렬 설정</param>
		public static void AddImageColumn(DataGridView dataGrid
			, string name, string headerText, bool readOnly, bool visible, int columnWidth
			, DataGridViewContentAlignment alignment)
		{
			DataGridViewImageColumn image = new DataGridViewImageColumn();

			dataGrid.Columns.Add(SetGridCommonOption(image, name, headerText, readOnly, visible, columnWidth, alignment));
		}

		/// <summary>
		/// 링크 컬럼 추가.
		/// </summary>
		/// <param name="dataGrid">DataGridView</param>
		/// <param name="name">컬럼명</param>
		/// <param name="headerText">컬럼헤더 텍스트</param>
		/// <param name="readOnly">컬럼 읽기 전용 설정</param>
		/// <param name="visible">컬럼 노출 설정</param>
		/// <param name="columnWidth">컬럼 넓이 설정</param>
		/// <param name="alignment">컬럼 정렬 설정</param>
		public static void AddLinkColumn(DataGridView dataGrid
			, string name, string headerText, bool readOnly, bool visible, int columnWidth
			, DataGridViewContentAlignment alignment)
		{
			DataGridViewLinkColumn link = new DataGridViewLinkColumn();

			dataGrid.Columns.Add(SetGridCommonOption(link, name, headerText, readOnly, visible, columnWidth, alignment));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataGrid">DataGridView</param>
		/// <param name="name">컬럼명</param>
		/// <param name="headerText">컬럼헤더 텍스트</param>
		/// <param name="readOnly">컬럼 읽기 전용 설정</param>
		/// <param name="visible">컬럼 노출 설정</param>
		/// <param name="columnWidth">컬럼 넓이 설정</param>
		/// <param name="alignment">컬럼 정렬 설정</param>
		/// <returns></returns>
		private static DataGridViewColumn SetGridCommonOption(DataGridViewColumn column
			, string name, string headerText, bool readOnly, bool visible, int columnWidth
			, DataGridViewContentAlignment alignment, TextType textType = TextType.None)
		{
			column.Name = name;
			column.DataPropertyName = name;
			column.HeaderText = headerText;
			column.FillWeight = columnWidth;
			column.ReadOnly = readOnly;
			column.Visible = visible;
			column.DefaultCellStyle.Alignment = alignment;
			column.SortMode = DataGridViewColumnSortMode.NotSortable;
			column.DefaultCellStyle.Font = new Font("Microsoft New Tai Lue", 12);
            if (textType != TextType.None && textType != TextType.Text)
            {
				switch (textType)
				{
					case TextType.Date:
						column.DefaultCellStyle.Format = "yyyy-MM-dd";
						break;
					case TextType.Time:
						column.DefaultCellStyle.Format = "HH:mm:ss";
						break;
					case TextType.DateTime:
						column.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
						break;
					default:
						break;
				}
				
            }

            return column;
		}
	}
}