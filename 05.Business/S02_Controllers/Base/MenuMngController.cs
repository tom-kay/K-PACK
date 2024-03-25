using log4net;
using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System.Collections.Generic;
using System.Reflection;

namespace P05_Business.S02_Controllers.Base
{
	public class MenuMngController
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public List<MenuMasterDto> GetMenuMasterList()
		{

			MenuMntDao dao = new MenuMntDao();
			List<MenuMasterDto> list = dao.GetMenuMasterList();

			return list;

		}
	}
}
