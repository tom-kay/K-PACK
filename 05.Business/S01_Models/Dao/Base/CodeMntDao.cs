using SmartSql.Abstractions;
using System.Collections.Generic;
using System.Linq;
using P05_Business.S01_Models.Dto.Base;

namespace P05_Business.S01_Models.Dao.Base
{
	public class CodeMntDao : DaoFactory
	{
		#region Code Master
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
		#endregion

		#region Code Detail
		public List<CodeDetailDto> SelectCodeDetailList(CodeDetailDto item)
		{
			RequestContext context = new RequestContext
			{
				Scope = "CodeMng",
				SqlId = "selectCodeDetailList",
				Request = item
			};
			List<CodeDetailDto> codes = SqlMapper.Query<CodeDetailDto>(context).ToList();

			return codes;
		}

		public CodeDetailDto SelectCodeDetailSingle(CodeDetailDto item)
		{

			RequestContext context = new RequestContext
			{
				Scope = "CodeMng",
				SqlId = "selectCodeDetail",
				Request = item
			};
			CodeDetailDto code = null;

			code = SqlMapper.QuerySingle<CodeDetailDto>(context);

			return code;

		}

		public int InsertCodeDetail(CodeDetailDto item)
		{
			int result;

			RequestContext context = new RequestContext
			{
				Scope = "CodeMng",
				SqlId = "insertCodeDetail",
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

		public int DeleteCodeDetail(CodeDetailDto item)
		{
			int result = 0;

			RequestContext context = new RequestContext
			{
				Scope = "CodeMng",
				SqlId = "deleteCodeDetail",
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

		public List<CodeDetailDto> selectUseCodeList(CodeDetailDto item)
		{
			RequestContext context = new RequestContext
			{
				Scope = "CodeMng",
				SqlId = "selectUseCodeList",
				Request = item
			};
			List<CodeDetailDto> items = SqlMapper.Query<CodeDetailDto>(context).ToList();

			return items;
		}
		#endregion

	}
}
