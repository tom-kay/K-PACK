using log4net;
using P05_Business.Common;
using SmartSql;
using SmartSql.Abstractions;
using System;
using System.Deployment.Application;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Contexts;


namespace P05_Business.S01_Models.Dao
{
	public class DaoFactory
	{
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static ISmartSqlMapper SqlMapper
		{
			get
			{
				try
				{
					log.Info(GlobalVariables.CONNECTION_CONFIG_FILE);

                    //ISmartSqlMapper SqlMapper = MapperContainer.Instance.GetSqlMapper("SmartSqlMapConfig.xml");
                    ISmartSqlMapper SqlMapper = MapperContainer.Instance.GetSqlMapper(GlobalVariables.CONNECTION_CONFIG_FILE);
                    return SqlMapper;
				}
				catch (Exception ex)
				{
                    log.Error($"Mapper Config 정보를 불러오지 못했습니다 : {ex.Message}");
                    throw ex;
				}
			}
		}
	}


}
