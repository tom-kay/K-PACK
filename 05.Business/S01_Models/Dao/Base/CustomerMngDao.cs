using Dapper;
using log4net;
using P05_Business.S01_Models.Dto.Base;
using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dao.Base
{
	internal class CustomerMngDao : DaoFactory
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		internal List<CustomerDto> SelectCustomerList(CustomerDto param)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.CustomerMng",
				SqlId = "selectCustomerList",
				Request = param
			};
			List<CustomerDto> customers = SqlMapper.Query<CustomerDto>(context).ToList();
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return customers;
		}

		internal CustomerDto selectCustomerSingle(CustomerDto param)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.CustomerMng",
				SqlId = "selectCustomer",
				Request = param
			};
			CustomerDto customers = SqlMapper.QuerySingle<CustomerDto>(context);
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return customers;
		}

		internal int insertCustomer(CustomerDto param)
		{
			int save;

			RequestContext context = new RequestContext
			{
				Scope = "Base.CustomerMng",
				SqlId = "insertCustomer",
				Request = param
			};

			try
			{
				SqlMapper.BeginTransaction();
				save = SqlMapper.Execute(context);
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));
				SqlMapper.CommitTransaction();

			}
			catch (Exception ex)
			{
				SqlMapper.RollbackTransaction();
				throw ex;
			}


			return save;
		}

		internal int deleteCustomer(CustomerDto param)
		{
			int delete;

			RequestContext context = new RequestContext
			{
				Scope = "Base.CustomerMng",
				SqlId = "deleteCustomer",
				Request = param
			};

			try
			{
				SqlMapper.BeginTransaction();
				delete = SqlMapper.Execute(context);
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));
				SqlMapper.CommitTransaction();

			}
			catch (Exception ex)
			{
				SqlMapper.RollbackTransaction();
				throw ex;
			}


			return delete;
		}
	}
}
