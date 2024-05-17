using log4net;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Biz;
using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P05_Business.S01_Models.Dao.Biz
{
    internal class OrderMngDao : DaoFactory
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal List<OrderMasterDto> SelectOrderMasterList(OrderMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.OrderMng",
                SqlId = "selectOrderMasterList",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<OrderMasterDto> orders = SqlMapper.Query<OrderMasterDto>(context).ToList();

            return orders;
        }

        internal OrderMasterDto SelectOrderMaster(OrderMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.OrderMng",
                SqlId = "selectOrderMaster",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            OrderMasterDto order = SqlMapper.QuerySingle<OrderMasterDto>(context);

            return order;
        }

        internal int MergeOrderMaster(OrderMasterDto param, Common.RequestCRUD request)
        {
            int save;

            try
            {
                SqlMapper.BeginTransaction();

                RequestContext context = new RequestContext
                {
                    Scope = "Biz.OrderMng",
                    SqlId = request == RequestCRUD.Create ? "insertOrderMaster" : "updateOrderMaster",
                    Request = param
                };

                log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                save = SqlMapper.Execute(context);

                List<OrderDetailDto> details = param.Details;

                if (save >= 0 && details != null)
                {
                    foreach (OrderDetailDto detail in details)
                    {
                        if ((detail.DataState & (System.Data.DataRowState.Added | System.Data.DataRowState.Modified)) != 0)
                        {
                            context = new RequestContext
                            {
                                Scope = "Biz.OrderMng",
                                SqlId = "insertOrderDetail",
                                Request = detail
                            };

                            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                            save = SqlMapper.Execute(context);

                        }
                        else if (detail.DataState == System.Data.DataRowState.Deleted)
                        {
                            context = new RequestContext
                            {
                                Scope = "Biz.OrderMng",
                                SqlId = "deleteOrderDetail",
                                Request = detail
                            };

                            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                            save = SqlMapper.Execute(context);

                        }

                        if (save < 0) break;
                    }
                }

                SqlMapper.CommitTransaction();

            }
            catch (Exception ex)
            {
                SqlMapper.RollbackTransaction();
                throw ex;
            }


            return save;
        }

        internal int DeleteOrderMaster(OrderMasterDto param)
        {
            int delete;

            RequestContext context = new RequestContext
            {
                Scope = "Biz.OrderMng",
                SqlId = "deleteOrderMaster",
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

        internal List<OrderDetailDto> SelectOrderDetailList(OrderDetailDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.OrderMng",
                SqlId = "selectOrderDetailList",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<OrderDetailDto> orders = SqlMapper.Query<OrderDetailDto>(context).ToList();

            return orders;
        }
    }
}
