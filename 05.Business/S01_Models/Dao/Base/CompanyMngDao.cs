using log4net;
using P05_Business.S01_Models.Dto.Base;
using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P05_Business.S01_Models.Dao.Base
{
	public class CompanyMngDao : DaoFactory
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public List<CompanyInfoDto> SelectCompanyList(CompanyInfoDto item)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.CompanyMng",
				SqlId = "selectCompanyList",
				Request = item
			};
			List<CompanyInfoDto> results = SqlMapper.Query<CompanyInfoDto>(context).ToList();
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return results;
		}

		public CompanyInfoDto SelectCompanySingle(CompanyInfoDto item)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.CompanyMng",
				SqlId = "selectCompany",
				Request = item
			};
			CompanyInfoDto result = SqlMapper.QuerySingle<CompanyInfoDto>(context);
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return result;
		}

		public int InsertCompany(CompanyInfoDto item)
		{
			int result;

			RequestContext context = new RequestContext
			{
				Scope = "Base.CompanyMng",
				SqlId = "insertCompany",
				Request = item
			};

			try
			{
				SqlMapper.BeginTransaction();
				result = SqlMapper.Execute(context);
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));
				SqlMapper.CommitTransaction();

			}
			catch (Exception ex)
			{
				SqlMapper.RollbackTransaction();
				throw ex;
			}


			return result;
		}

		public int DeleteCompany(CompanyInfoDto item)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.CompanyMng",
				SqlId = "deleteCompany",
				Request = item
			};

			int result;
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
				throw ex;
			}

			return result;
		}
	}
}
