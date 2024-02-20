using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System.Collections.Generic;

namespace P05_Business.S02_Controllers.Base
{
	public class CodeMngController
	{
		public List<CodeMasterDto> GetCodeMasterList(CodeMasterDto item)
		{

			CodeMntDao dao = new CodeMntDao();
			List<CodeMasterDto> list = dao.SelectCodeMasterList(item);

			return list;

		}

		public CodeMasterDto GetCodeMaster(CodeMasterDto item)
		{
			CodeMntDao dao = new CodeMntDao();
			CodeMasterDto codeMaster = dao.SelectCodeMasterSingle(item);

			return codeMaster;
		}

		public CodeMasterDto AddCodeMaster(CodeMasterDto item)
		{
			CodeMntDao dao = new CodeMntDao();
			int iSave = dao.InsertCodeMaster(item);

			CodeMasterDto codeMasterDto = null;
			if (!iSave.Equals(-1))
			{
				codeMasterDto = dao.SelectCodeMasterSingle(item); 
			}

			return codeMasterDto;
		}

		public int RemoveCodeMaster(CodeMasterDto item)
		{
			CodeMntDao dao = new CodeMntDao();
			int result = dao.DeleteCodeMaster(item);

			return result;

		}

	}
}
