using IBatisNet.Common.Utilities;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _05.Business
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "log4net.config"));

            Console.Write(executeFunction());
            Console.Read();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        private static object syncLock = new object(); private static ISqlMapper mapper = null;
        

        public static ISqlMapper EntityMapper
        {
            //get
            //{
            //    try
            //    {
            //        ISqlMapper mapper = Mapper.Instance();
            //        mapper.DataSource.ConnectionString = "Data Source=(local);Initial Catalog=web;Integrated Security=True";
            //        return mapper;
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}

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
                                XmlDocument sqlMapConf = Resources.GetEmbeddedResourceAsXmlDocument("conf.SqlMap.config, Dao");
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

        public static Int32 executeFunction()
        {
            ISqlMapper mapper = EntityMapper;
            Int32 val = mapper.QueryForObject<Int32>("MemberMapper.getMemberCnt", "Footer");

            return val;
        }
    }

}
