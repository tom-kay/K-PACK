using SmartSql.Abstractions;
using System.Collections.Generic;
using System.Linq;
using P05_Business.S01_Models.Dto.Base;
using log4net;
using System.Reflection;
using P05_Business.S01_Models.Dto.Biz;
using System;

namespace P05_Business.S01_Models.Dao.Base
{
	public class CodeMntDao : DaoFactory
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

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
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

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
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

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
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));
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
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));
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
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

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
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

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
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));
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
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));
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
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return items;
		}

        internal List<ShipportCodeDto> selectShipportCodeList(ShipportCodeDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "CodeMng",
                SqlId = "selectShipportCodeList",
                Request = param
            };
            List<ShipportCodeDto> datas = SqlMapper.Query<ShipportCodeDto>(context).ToList();
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));

            return datas;
        }

        internal List<AirportCodeDto> selectAirportCodeList(AirportCodeDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "CodeMng",
                SqlId = "selectAirportCodeList",
                Request = param
            };
            List<AirportCodeDto> datas = SqlMapper.Query<AirportCodeDto>(context).ToList();
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));

            return datas;
        }
        #endregion

    }
}
