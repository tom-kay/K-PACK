using P01_K_DESIGN_WIN.Classes;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P05_Business.S03_Views.Base
{
	public partial class frmCodeMasterList : P01_K_DESIGN_WIN.frmSearchContainer
	{
		CodeMngController ctrl = new CodeMngController();

		public frmCodeMasterList()
		{
			InitializeComponent();

			Set_Menu_Button(new EditButtonSettings { isPrint = false });
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			rdoUseY.Checked = true;
			rdoDelY.Checked = true;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			SearchData();
		}

		private void SearchData()
		{
			try
			{
				CodeMasterDto item = new CodeMasterDto()
				{
					Code = txtCode.Texts,
					Name = txtName.Text,
					UseYn = rdoUseY.Checked ? "Y" : "N",
					DelYn = rdoDelY.Checked ? "Y" : "N",
				};

				List<CodeMasterDto> codeMasters = ctrl.GetCodeMasterList(item);

				dgvList.DataSource = codeMasters;

				//그리드 헤더명 설정
                foreach (DataGridViewColumn	column in dgvList.Columns)
                {
					var prop = typeof(CodeMasterDto).GetProperty(column.Name);
					var attrs = prop.GetCustomAttributes(typeof(DisplayAttribute), false);
                    if (attrs.Length > 0)
                    {
						var displayAttr = attrs[0] as DisplayAttribute;
						column.HeaderText = displayAttr.Name;
                    }
                }

            }
			catch (Exception ex)
			{
				KMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Render_Grid(DataGridView dgv, DataGridViewAutoSizeColumnsMode sizeColumnsMode)
		{
			dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
			dgv.AutoSizeColumnsMode = sizeColumnsMode;	//사용자정의
			dgv.AllowUserToResizeRows = false;
			dgv.BackgroundColor = SystemColors.Window;
			dgv.BorderStyle = BorderStyle.None;
			dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
			dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dgv.ColumnHeadersHeight = 35;
			dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			
			dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
			dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft New Tai Lue", 12, FontStyle.Bold);
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.CornflowerBlue;
			dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
			
			dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dgv.DefaultCellStyle.BackColor = SystemColors.Window;
			dgv.DefaultCellStyle.ForeColor= SystemColors.WindowText;
			dgv.DefaultCellStyle.Font = new Font("Microsoft New Tai Lue", 12);
			dgv.DefaultCellStyle.SelectionBackColor = Color.Beige;
			dgv.DefaultCellStyle.SelectionForeColor= SystemColors.WindowText;
			

			List<DataGridViewColumn> columns = new List<DataGridViewColumn>();
			DataGridViewColumn[] columns1 = new DataGridViewColumn[columns.Count];
			DataGridViewColumn column = new DataGridViewColumn();
			DataGridViewTextBoxColumn text = new DataGridViewTextBoxColumn();
			DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
			DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
			DataGridViewButtonColumn button = new DataGridViewButtonColumn();
			DataGridViewImageColumn image = new DataGridViewImageColumn();
			DataGridViewLinkColumn link = new DataGridViewLinkColumn();
			
			column.HeaderText = "";
			column.Width = 10;
			column.ReadOnly = true;
			column.Visible = true;
			column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			column.DefaultCellStyle.Font = new Font("Microsoft New Tai Lue", 12);
			column.DataPropertyName = "Name";
			column.Name = "Name";
			
			dgv.Columns.AddRange(columns1);
		}
	}
}
