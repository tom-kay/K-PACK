using P05_Business.S01_Models.Dto.Base;
using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Business.S01_Models.Dao.Base
{
	public class CompanyMngDao : DaoFactory
	{
		public List<CompanyInfoDto> SelectCompanyList(CompanyInfoDto item)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.CompanyMng",
				SqlId = "selectCompanyList",
				Request = item
			};
			List<CompanyInfoDto> results = SqlMapper.Query<CompanyInfoDto>(context).ToList();

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
