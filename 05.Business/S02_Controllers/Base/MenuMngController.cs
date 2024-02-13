using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System.Collections.Generic;

namespace P05_Business.S02_Controllers.Base
{
	public class MenuMngController
	{
		public List<MenuMasterDto> GetMenuMasterList()
		{

			MenuMntDao dao = new MenuMntDao();
			List<MenuMasterDto> list = dao.GetMenuMasterList();

			return list;

		}
	}
}
