using SmartSql;
using SmartSql.Abstractions;
using System;


namespace P05_Business.S01_Models.Dao
{
	public class DaoFactory
	{
		public static ISmartSqlMapper SqlMapper
		{
			get
			{
				try
				{
					ISmartSqlMapper SqlMapper = MapperContainer.Instance.GetSqlMapper("SmartSqlMapConfig.xml");
					return SqlMapper;
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}
	}


}
