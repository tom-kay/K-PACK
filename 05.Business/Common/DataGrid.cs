using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.Common
{
	public static class DataGrid
	{
		public static void Create(DataGridView dataGrid, DataGridViewAutoSizeColumnsMode sizeColumnsMode)
		{
			dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
			dataGrid.AutoSizeColumnsMode = sizeColumnsMode;  //사용자정의
			dataGrid.AllowUserToResizeRows = false;
			dataGrid.BackgroundColor = SystemColors.Window;
			dataGrid.BorderStyle = BorderStyle.None;
			dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGrid.ColumnHeadersHeight = 35;
			dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

			dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
			dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft New Tai Lue", 12, FontStyle.Bold);
			dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dataGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.CornflowerBlue;
			dataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

			dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGrid.DefaultCellStyle.BackColor = SystemColors.Window;
			dataGrid.DefaultCellStyle.ForeColor = SystemColors.WindowText;
			dataGrid.DefaultCellStyle.Font = new Font("Microsoft New Tai Lue", 12);
			dataGrid.DefaultCellStyle.SelectionBackColor = Color.Beige;
			dataGrid.DefaultCellStyle.SelectionForeColor = SystemColors.WindowText;
		}
		
		public static void AddTextBoxColumn()
		{
			DataGridViewTextBoxColumn text = new DataGridViewTextBoxColumn();
			text.HeaderText = "";
			text.Width = 10;
			text.ReadOnly = true;
			text.Visible = true;
			text.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			text.DefaultCellStyle.Font = new Font("Microsoft New Tai Lue", 12);
			text.DataPropertyName = "Name";
			text.Name = "Name";

		}

		public static void AddComboBoxColumn()
		{

		}

		public static void AddCheckBoxColumn()
		{

		}

		public static void AddButtonColumn()
		{

		}

		public static void AddImageColumn()
		{

		}

		public static void AddLinkColumn()
		{

		}
	}
}
