using log4net;
using P05_Business.S01_Models.Dto.Biz;
using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P05_Business.S01_Models.Dao.Biz
{
    internal class ItemMngDao : DaoFactory
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal List<ItemGroupDto> SelectItemGroupList(ItemGroupDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ItemMng",
                SqlId = "selectItemGroupList",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<ItemGroupDto> items = SqlMapper.Query<ItemGroupDto>(context).ToList();

            return items;
        }

        internal ItemGroupDto SelectItemGroup(ItemGroupDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ItemMng",
                SqlId = "selectItemGroup",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            ItemGroupDto item = SqlMapper.QuerySingle<ItemGroupDto>(context);

            return item;
        }

        internal int InsertItemGroup(ItemGroupDto param)
        {
            int save;

            try
            {
                SqlMapper.BeginTransaction();

                RequestContext context = new RequestContext
                {
                    Scope = "Biz.ItemMng",
                    SqlId = "insertItemGroup",
                    Request = param
                };

                log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                save = SqlMapper.Execute(context);

                List<ItemDto> items = param.Items;

                if (save >= 0 && items != null)
                {
                    foreach (ItemDto item in items)
                    {
                        if ((item.DataState & (System.Data.DataRowState.Added | System.Data.DataRowState.Modified)) != 0)
                        {
                            context = new RequestContext
                            {
                                Scope = "Biz.ItemMng",
                                SqlId = "insertItem",
                                Request = item
                            };

                            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                            save = SqlMapper.Execute(context);
                            
                        }
                        else if (item.DataState == System.Data.DataRowState.Deleted)
                        {
                            context = new RequestContext
                            {
                                Scope = "Biz.ItemMng",
                                SqlId = "deleteItem",
                                Request = item
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

        internal int DeleteItemGroup(ItemGroupDto param)
        {
            int delete;

            RequestContext context = new RequestContext
            {
                Scope = "Biz.ItemMng",
                SqlId = "deleteItemGroup",
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

        internal List<ItemDto> SelectItemList(ItemDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ItemMng",
                SqlId = "selectItemList",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<ItemDto> items = SqlMapper.Query<ItemDto>(context).ToList();

            return items;
        }

        internal ItemDto SelectItem(ItemDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ItemMng",
                SqlId = "selectItem",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            ItemDto item = SqlMapper.QuerySingle<ItemDto>(context);

            return item;
        }

        internal int InsertItem(ItemDto param)
        {
            int save;

            try
            {
                SqlMapper.BeginTransaction();

                RequestContext context = new RequestContext
                {
                    Scope = "Biz.ItemMng",
                    SqlId = "insertItem",
                    Request = param
                };

                log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                save = SqlMapper.Execute(context);

                SqlMapper.CommitTransaction();

            }
            catch (Exception ex)
            {
                SqlMapper.RollbackTransaction();
                throw ex;
            }


            return save;
        }
        internal int DeleteItem(ItemDto param)
        {
            int delete;

            RequestContext context = new RequestContext
            {
                Scope = "Biz.ItemMng",
                SqlId = "deleteItem",
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
