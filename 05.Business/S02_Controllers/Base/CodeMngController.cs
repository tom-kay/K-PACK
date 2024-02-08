using P05_Business.S01_Models.Dao;
using P05_Business.S01_Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S02_Controllers.Base
{
	public class CodeMngController
	{
		public List<CodeMasterDto> GetCodeMasterList()
		{

			CodeMntDao dao = new CodeMntDao();
			List<CodeMasterDto> list = dao.GetCodeMasterList();

			return list;

		}
  }
}
