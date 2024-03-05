using log4net;
using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System.Collections.Generic;
using System.Reflection;

namespace P05_Business.S02_Controllers.Base
{
	public class CodeMngController
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		#region Code Master
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
		#endregion


		#region Code Detail
		public List<CodeDetailDto> GetCodeDetailList(CodeDetailDto item)
		{
			CodeMntDao dao = new CodeMntDao();
			List<CodeDetailDto> list = dao.SelectCodeDetailList(item);

			return list;
		}

		public CodeDetailDto GetCodeDetail(CodeDetailDto item)
		{
			CodeMntDao dao = new CodeMntDao();
			CodeDetailDto detail = dao.SelectCodeDetailSingle(item);

			return detail;
		}

		public CodeDetailDto AddCodeDetail(CodeDetailDto item)
		{
			CodeMntDao dao = new CodeMntDao();
			int iSave = dao.InsertCodeDetail(item);

			CodeDetailDto dto = null;
			if (!iSave.Equals(-1))
			{
				dto = dao.SelectCodeDetailSingle(item);
			}

			return dto;
		}

		public int RemoveCodeDetail(CodeDetailDto item)
		{
			CodeMntDao dao = new CodeMntDao();
			int result = dao.DeleteCodeDetail(item);

			return result;

		} 

		public List<CodeDetailDto> GetUseCodeList(CodeDetailDto item)
		{
			CodeMntDao dao = new CodeMntDao();
			List<CodeDetailDto> list = dao.selectUseCodeList(item);

			return list;
		}
		#endregion


	}
}
