using log4net;
using SmartSql.Abstractions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using P05_Business.S01_Models.Dto.Base;
using Microsoft.VisualBasic.ApplicationServices;

namespace P05_Business.S01_Models.Dao.Base
{
	public class CodeMntDao : DaoFactory
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public List<CodeMasterDto> SelectCodeMasterList(CodeMasterDto item)
		{
			RequestContext context = new RequestContext
			{
				Scope = "CodeMng",
				SqlId = "selectCodeMasterList",
				Request = item
			};
			List<CodeMasterDto> codes = SqlMapper.Query<CodeMasterDto>(context).ToList();

			return codes;
		}

		public CodeMasterDto SelectCodeMasterSingle(CodeMasterDto item)
		{

			RequestContext context = new RequestContext
			{
				Scope = "CodeMng",
				SqlId = "selectCodeMaster",
				Request = item
			};
			CodeMasterDto code = null;

			code = SqlMapper.QuerySingle<CodeMasterDto>(context);

			return code;

		}

		public int InsertCodeMaster(CodeMasterDto item)
		{
			int result;

			RequestContext context = new RequestContext
			{
				Scope = "CodeMng",
				SqlId = "insertCodeMaster",
				Request = item
			};

			try
			{
				SqlMapper.BeginTransaction();
				int iSave = SqlMapper.Execute(context);
				SqlMapper.CommitTransaction();

				result = iSave;

			}
			catch (System.Exception ex)
			{
				SqlMapper.RollbackTransaction();

				result = -1;

				throw ex;
			}
			

			return result;
		}

		public int DeleteCodeMaster(CodeMasterDto item)
		{
			int result = 0;

			RequestContext context = new RequestContext
			{
				Scope = "CodeMng",
				SqlId = "deleteCodeMaster",
				Request = item
			};

			try
			{
				SqlMapper.BeginTransaction();
				result = SqlMapper.Execute(context);
				SqlMapper.CommitTransaction();
			}
			catch (System.Exception ex)
			{
				SqlMapper.RollbackTransaction();
				result = -1;
				throw ex;
			}

			return result;
		}
	}
}
