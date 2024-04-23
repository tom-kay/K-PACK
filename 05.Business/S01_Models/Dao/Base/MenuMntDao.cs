using P05_Business.S01_Models.Dto;
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

        internal List<MenuMasterDto> SelectMenuMasterListByKey(MenuMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "MenuMng",
                SqlId = "selectMenuMasterListByKey",
                //Request = new { Ids = new long[] { 1, 2, 3, 4 } }
            };
            List<MenuMasterDto> menus = SqlMapper.Query<MenuMasterDto>(context).ToList();
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));

            return menus;
        }

        //public void insertEmployee(string emp)
        //{
        //	DaoFactory.getInstance.Insert("insertEmployee", emp);
        //}
        //public void updateEmployee(string emp)
        //{
        //	DaoFactory.getInstance.Update("updateEmployee", emp);
        //}
        //public void deleteEmployeeByEmpno(int id)
        //{
        //	DaoFactory.getInstance.Delete("deleteEmployeeByEmpno", id);
        //}
    }
}
