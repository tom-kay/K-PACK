using log4net;
using SmartSql.Abstractions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using P05_Business.S01_Models.Dto.Base;
using System;

namespace P05_Business.S01_Models.Dao.Base
{
    public class MenuMntDao : DaoFactory
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public CodeMasterDto GetMenuMaster()
		{

			RequestContext context = new RequestContext
			{
				Scope = "MenuMng",
				SqlId = "selectCodeMaster"
			};
			CodeMasterDto menu = SqlMapper.QuerySingle<CodeMasterDto>(context);
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return menu;

		}

		public List<MenuMasterDto> GetMenuMasterList()
		{
			RequestContext context = new RequestContext
			{
				Scope = "MenuMng",
				SqlId = "selectMenuMasterList",
				//Request = new { Ids = new long[] { 1, 2, 3, 4 } }
			};
			List<MenuMasterDto> menus = SqlMapper.Query<MenuMasterDto>(context).ToList();
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return menus;
		}

        internal List<MenuMasterDto> SelectMenuMasterListByParentKey(MenuMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "MenuMng",
                SqlId = "selectMenuMasterListByParentKey",
                Request = param,
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<MenuMasterDto> menus = SqlMapper.Query<MenuMasterDto>(context).ToList();
            
            return menus;
        }

        internal MenuMasterDto SelectMenuMasterByKey(MenuMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "MenuMng",
                SqlId = "selectMenuMasterByKey",
                Request = param,
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            MenuMasterDto menu = SqlMapper.QuerySingle<MenuMasterDto>(context);

            return menu;
        }

        internal int InsertMenuMaster(MenuMasterDto param)
        {
            int delete;

            RequestContext context = new RequestContext
            {
                Scope = "MenuMng",
                SqlId = "insertMenuMaster",
                Request = param
            };

            try
            {
                SqlMapper.BeginTransaction();
                log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                delete = SqlMapper.Execute(context);
                SqlMapper.CommitTransaction();

            }
            catch (Exception ex)
            {
                SqlMapper.RollbackTransaction();
                throw ex;
            }


            return delete;
        }

        internal int DeleteMenuMaster(MenuMasterDto param)
        {
            int delete;

            RequestContext context = new RequestContext
            {
                Scope = "MenuMng",
                SqlId = "deleteMenuMaster",
                Request = param
            };

            try
            {
                SqlMapper.BeginTransaction();
                log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                delete = SqlMapper.Execute(context);
                SqlMapper.CommitTransaction();

            }
            catch (Exception ex)
            {
                SqlMapper.RollbackTransaction();
                throw ex;
            }


            return delete;
        }

        internal int UpdateMenuMasterOrder(List<MenuMasterDto> param)
        {
            int update = 0;

            try
            {
                SqlMapper.BeginTransaction();
                
                foreach (MenuMasterDto item in param)
                {   
                    RequestContext context = new RequestContext
                    {
                        Scope = "MenuMng",
                        SqlId = "updateMenuMasterOrder",
                        Request = item
                    };

                    
                    log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                    update = SqlMapper.Execute(context);
                }

                SqlMapper.CommitTransaction();
            }
            catch (Exception ex)
            {
                SqlMapper.RollbackTransaction();
                throw ex;
            }


            return update;
        }
    }
}
