using log4net;
using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S02_Controllers.Base
{
	public class UserMngController
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		UserMngDao dao = new UserMngDao();

		public List<UserMngDto> GetUserInfoList(UserMngDto user)
		{
			List<UserMngDto> results = dao.SelectUserList(user);

			return results;
		}

		public UserMngDto GetUserInfo(UserMngDto user)
		{
			UserMngDto result = dao.SelectUserSingle(user);

			return result;
		}

		public string AddUserInfo(UserMngDto user)
		{
			string result = dao.InsertUser(user);

			return result;
		}

		public int RemoveUserInfo(UserMngDto user)
		{
			int result = dao.DeleteUser(user);

			return result;
		}

		public UserMngDto signInUser(UserMngDto user)
		{
			UserMngDto result = dao.SignInUser(user);

			return result;
		}
	}
}
