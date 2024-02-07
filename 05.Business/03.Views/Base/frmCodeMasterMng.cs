using _05.Business._01.Models.Dao;
using _05.Business._01.Models.Dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05.Business._03.Views
{
	public partial class frmCodeMasterMng : Form
	{
		public frmCodeMasterMng()
		{
			InitializeComponent();

			selectAllCodeMaster();
		}

		public void selectAllCodeMaster()
		{
			CodeMntDao machlist = new CodeMntDao();
			IList<CodeMasterDto> list = machlist.GetCodeMasterList();

		}

	}
}
