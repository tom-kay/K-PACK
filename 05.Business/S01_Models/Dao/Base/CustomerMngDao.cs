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

		internal CustomerDto SelectCustomerSingle(CustomerDto param)
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

		internal int InsertCustomer(CustomerDto param)
		{
			int save;

			try
			{
				SqlMapper.BeginTransaction();

				RequestContext context = new RequestContext
				{
					Scope = "Base.CustomerMng",
					SqlId = "insertCustomer",
					Request = param
				};

				save = SqlMapper.Execute(context);
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));

				List<CustomerEmpDto> employees = param.Employees;
				if (save >= 0 && employees != null)
				{
                    foreach (CustomerEmpDto employee in employees) 
					{
						if ((employee.DataState & (System.Data.DataRowState.Added | System.Data.DataRowState.Modified)) != 0)
						{
							context = new RequestContext
							{
								Scope = "Base.CustomerMng",
								SqlId = "insertCustomerEmp",
								Request = employee
							};

							save = SqlMapper.Execute(context);
							log.Info(SqlMapper.SqlBuilder.BuildSql(context)); 
						} else if (employee.DataState == System.Data.DataRowState.Deleted)
						{
							context = new RequestContext
							{
								Scope = "Base.CustomerMng",
								SqlId = "deleteCustomerEmp",
								Request = employee
							};

							save = SqlMapper.Execute(context);
							log.Info(SqlMapper.SqlBuilder.BuildSql(context));
						}

						if (save < 0) break;
					}
                }

				SqlMapper.CommitTransaction();

			}
			catch (Exception ex)
			{
				SqlMapper.RollbackTransaction();
				throw ex;
			}


			return save;
		}

		internal int DeleteCustomer(CustomerDto param)
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

		internal List<CustomerEmpDto> SelectCustomerEmpList(CustomerDto param)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.CustomerMng",
				SqlId = "selectCustomerEmpList",
				Request = param
			};
			List<CustomerEmpDto> customers = SqlMapper.Query<CustomerEmpDto>(context).ToList();
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return customers;
		}
	}
}
