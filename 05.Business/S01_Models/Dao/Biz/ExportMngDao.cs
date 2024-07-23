using log4net;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Biz;
using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dao.Biz
{
    internal class ExportMngDao : DaoFactory
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal List<ExportMasterDto> SelectExportMasterList(ExportMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ExportMng",
                SqlId = "selectExportMasterList",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<ExportMasterDto> exports = SqlMapper.Query<ExportMasterDto>(context).ToList();

            return exports;
        }

        internal ExportMasterDto SelectExportMaster(ExportMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ExportMng",
                SqlId = "selectExportMaster",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            ExportMasterDto export = SqlMapper.QuerySingle<ExportMasterDto>(context);

            return export;
        }

        internal int MergeExportMaster(ExportMasterDto param, Common.RequestCRUD request)
        {
            int save;

            try
            {
                SqlMapper.BeginTransaction();

                RequestContext context = new RequestContext
                {
                    Scope = "Biz.ExportMng",
                    SqlId = request == RequestCRUD.Create ? "insertExportMaster" : "updateExportMaster",
                    Request = param
                };

                log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                save = SqlMapper.Execute(context);
                
                List<ExportContainerDto> containers = param.ExportContainers;
                List<ExportPackingDto> packings = param.ExportPackings;
                List<ExportInvoiceDto> invoices = param.ExportInvoices;

                if (save >= 0)
                {
                    if (containers != null)
                    {
                        foreach (ExportContainerDto container in containers)
                        {
                            context = new RequestContext
                            {
                                Scope = "Biz.ExportMng",
                                SqlId = "mergeExportContainer",
                                Request = container
                            };

                            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                            save = SqlMapper.Execute(context);

                            if (save < 0) break;
                        }
                    }

                    if (packings != null)
                    {
                        foreach (ExportPackingDto packing in packings)
                        {
                            context = new RequestContext
                            {
                                Scope = "Biz.ExportMng",
                                SqlId = "mergeExportPacking",
                                Request = packing
                            };

                            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                            save = SqlMapper.Execute(context);

                            if (save < 0) break;
                        }
                    }

                    if (invoices != null)
                    {
                        foreach (ExportInvoiceDto invoice in invoices)
                        {
                            context = new RequestContext
                            {
                                Scope = "Biz.ExportMng",
                                SqlId = "mergeExportInvoice",
                                Request = invoice
                            };

                            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                            save = SqlMapper.Execute(context);

                            if (save < 0) break;
                        }
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

        internal int DeleteExportMaster(ExportMasterDto param)
        {
            int delete;

            RequestContext context = new RequestContext
            {
                Scope = "Biz.ExportMng",
                SqlId = "deleteExportMaster",
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

        internal List<ExportContainerDto> SelectExportContainerList(ExportContainerDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ExportMng",
                SqlId = "selectExportContainerList",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<ExportContainerDto> containers = SqlMapper.Query<ExportContainerDto>(context).ToList();

            return containers;
        }

        internal List<ExportPackingDto> SelectExportPackingList(ExportPackingDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ExportMng",
                SqlId = "selectExportPackingList",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<ExportPackingDto> packings = SqlMapper.Query<ExportPackingDto>(context).ToList();

            return packings;
        }

        internal List<ExportInvoiceDto> SelectExportInvoiceList(ExportInvoiceDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ExportMng",
                SqlId = "selectExportInvoiceList",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<ExportInvoiceDto> invoices = SqlMapper.Query<ExportInvoiceDto>(context).ToList();

            return invoices;
        }
    }

}
