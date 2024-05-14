using log4net;
using P05_Business.S01_Models.Dto.Base;
using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P05_Business.S01_Models.Dao.Base
{
    internal class MemoMngDao : DaoFactory
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal List<MemoTemplateDto> SelectMemoList(MemoTemplateDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Base.Memo",
                SqlId = "selectMemoList",
                Request = param,
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<MemoTemplateDto> memos = SqlMapper.Query<MemoTemplateDto>(context).ToList();

            return memos;
        }

        internal MemoTemplateDto SelectMemoSingle(MemoTemplateDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Base.Memo",
                SqlId = "selectMemoSingle",
                Request = param,
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            MemoTemplateDto memo = SqlMapper.QuerySingle<MemoTemplateDto>(context);

            return memo;
        }

        internal int InsertMemo(MemoTemplateDto param)
        {
            int save;

            RequestContext context = new RequestContext
            {
                Scope = "Base.Memo",
                SqlId = "insertMemo",
                Request = param
            };

            try
            {
                SqlMapper.BeginTransaction();
                log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                save = SqlMapper.ExecuteScalar<int>(context);
                SqlMapper.CommitTransaction();

            }
            catch (Exception ex)
            {
                SqlMapper.RollbackTransaction();
                throw ex;
            }


            return save;
        }

        internal int DeleteMemo(MemoTemplateDto param)
        {
            int delete;

            RequestContext context = new RequestContext
            {
                Scope = "Base.Memo",
                SqlId = "deleteMemo",
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

    }
}
