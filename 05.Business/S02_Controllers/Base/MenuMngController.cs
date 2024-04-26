﻿using log4net;
using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace P05_Business.S02_Controllers.Base
{
	public class MenuMngController
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		MenuMntDao dao;

		public List<MenuMasterDto> GetMenuMasterList()
		{

			dao = new MenuMntDao();
			List<MenuMasterDto> list = dao.GetMenuMasterList();

			return list;

		}

        internal List<MenuMasterDto> GetMenuMasterChildList(MenuMasterDto param)
        {
			dao = new MenuMntDao();
			List<MenuMasterDto> list = dao.SelectMenuMasterListByParentKey(param);

			return list;

        }

        internal MenuMasterDto GetMenuMasterSingle(MenuMasterDto param)
        {
            dao = new MenuMntDao();
            MenuMasterDto data = dao.SelectMenuMasterByKey(param);

            return data;
        }

        internal bool SaveMenuMaster(MenuMasterDto param)
        {
            bool isSave = true;
            int save = dao.InsertMenuMaster(param);

            if (save < 0) isSave = false;

            return isSave;
        }
    }
}
