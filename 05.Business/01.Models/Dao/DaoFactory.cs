using IBatisNet.DataMapper.Configuration;
using IBatisNet.DataMapper;
using System.Xml;
using IBatisNet.Common.Utilities;


namespace _05.Business._01.Models.Dao
{
	public class DaoFactory
	{
		private static object syncLock = new object(); 
		private static ISqlMapper mapper = null; 
		public static ISqlMapper getInstance
		{
			get
			{
				try
				{
					if (mapper == null)
					{
						lock (syncLock)
						{
							if (mapper == null)
							{
								DomSqlMapBuilder dom = new DomSqlMapBuilder();
								XmlDocument sqlMapConf = Resources.GetEmbeddedResourceAsXmlDocument("_05.Business.SqlMap.config, SOODAL");
								mapper = dom.Configure(sqlMapConf);
							}
						}
					}
				}
				catch
				{
					throw;
				}
				return mapper;
			}

		}
	}
}
