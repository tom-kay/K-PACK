using log4net;
using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System.Collections.Generic;
using System.Reflection;

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

		internal int ModifyLoginUserInfo(UserMngDto userMng)
		{
			int result = dao.UpdateLoginUserInfo(userMng);

			return result;
		}

		internal bool SamePassword(UserMngDto userMng)
		{
			bool result = true;
				
			UserMngDto dto = dao.SelectCurrentPassword(userMng);

			if (dto == null || dto.UserId.Equals(""))
			{
				result = false;
			}

			return result;
		}

		internal int ModifyLoginUserNewPassword(UserMngDto param)
		{
			int result = dao.UpdateLoginUserPassword(param);

			return result;
		}
	}
}
