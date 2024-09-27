using log4net;
using P05_Business.S01_Models.Dto.Base;
using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P05_Business.S01_Models.Dao.Base
{
    internal class ExchangeRateMngDao : DaoFactory
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		internal List<ExchangeRateMngDto> SelectExchangeRateList(ExchangeRateMngDto param)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.ExchangeRate",
				SqlId = "selectExchangeRateList",
				Request = param
			};
			List<ExchangeRateMngDto> results = SqlMapper.Query<ExchangeRateMngDto>(context).ToList();
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return results;
		}

		internal ExchangeRateMngDto SelectExchangeRateSingle(ExchangeRateMngDto param)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.ExchangeRate",
				SqlId = "selectExchangeRateList",
				Request = param
			};
			ExchangeRateMngDto result = SqlMapper.QuerySingle<ExchangeRateMngDto>(context);
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return result;
		}

		internal int InsertExchangeRate(List<ExchangeRateMngDto> items)
		{
			int result = 0;

			try
			{
				SqlMapper.BeginTransaction();

				foreach (var param in items)
				{
					RequestContext context = new RequestContext
					{
						Scope = "Base.ExchangeRate",
						SqlId = "insertExchangeRate",
						Request = param
					};

					result = SqlMapper.Execute(context);
					log.Info(SqlMapper.SqlBuilder.BuildSql(context)); 
				}

				SqlMapper.CommitTransaction();

			}
			catch (Exception ex)
			{
				SqlMapper.RollbackTransaction();
				throw ex;
			}


			return result;
		}
	}
}
