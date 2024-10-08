﻿using log4net;
using P05_Business.S01_Models.Dto.Base;
using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P05_Business.S01_Models.Dao.Base
{
    public class UserMngDao : DaoFactory
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public List<UserMngDto> SelectUserList(UserMngDto item)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.UserMng",
				SqlId = "selectUserList",
				Request = item
			};
			List<UserMngDto> results = SqlMapper.Query<UserMngDto>(context).ToList();
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));
			
			return results;
		}

		public UserMngDto SelectUserSingle(UserMngDto item)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.UserMng",
				SqlId = "selectUser",
				Request = item
			};
			UserMngDto result = SqlMapper.QuerySingle<UserMngDto>(context);
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return result;
		}

		public string InsertUser(UserMngDto item)
		{
			string result;

			RequestContext context = new RequestContext
			{
				Scope = "Base.UserMng",
				SqlId = "insertUser",
				Request = item
			};

			try
			{
				SqlMapper.BeginTransaction();
				result = SqlMapper.ExecuteScalar<string>(context);
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));
				SqlMapper.CommitTransaction();

			}
			catch (Exception ex)
			{
				SqlMapper.RollbackTransaction();
				throw ex;
			}


			return result;
		}

		public int DeleteUser(UserMngDto item)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.UserMng",
				SqlId = "deleteUser",
				Request = item
			};

			int result;
			try
			{
				SqlMapper.BeginTransaction();
				result = SqlMapper.Execute(context);
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));
				SqlMapper.CommitTransaction();
			}
			catch (System.Exception ex)
			{
				SqlMapper.RollbackTransaction();
				throw ex;
			}

			return result;
		}

		public UserMngDto SignInUser(UserMngDto item)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.UserMng",
				SqlId = "signInUser",
				Request = item
			};
			UserMngDto result = SqlMapper.QuerySingle<UserMngDto>(context);
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return result;
		}

		internal int UpdateLoginUserInfo(UserMngDto userMng)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.UserMng",
				SqlId = "updateUser",
				Request = userMng
			};

			int result;
			try
			{
				SqlMapper.BeginTransaction();
				result = SqlMapper.Execute(context);
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));
				SqlMapper.CommitTransaction();
			}
			catch (System.Exception ex)
			{
				SqlMapper.RollbackTransaction();
				throw ex;
			}

			return result;
		}

		internal UserMngDto SelectCurrentPassword(UserMngDto userMng)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.UserMng",
				SqlId = "selectUserPassword",
				Request = userMng
			};
			UserMngDto result = SqlMapper.QuerySingle<UserMngDto>(context);
			log.Info(SqlMapper.SqlBuilder.BuildSql(context));

			return result;
		}

		internal int UpdateLoginUserPassword(UserMngDto param)
		{
			RequestContext context = new RequestContext
			{
				Scope = "Base.UserMng",
				SqlId = "updateUserPassword",
				Request = param
			};

			int result;
			try
			{
				SqlMapper.BeginTransaction();
				result = SqlMapper.Execute(context);
				log.Info(SqlMapper.SqlBuilder.BuildSql(context));
				SqlMapper.CommitTransaction();
			}
			catch (System.Exception ex)
			{
				SqlMapper.RollbackTransaction();
				throw ex;
			}

			return result;
		}
	}
}
