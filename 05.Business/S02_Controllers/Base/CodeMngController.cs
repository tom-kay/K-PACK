using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System.Collections.Generic;

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
