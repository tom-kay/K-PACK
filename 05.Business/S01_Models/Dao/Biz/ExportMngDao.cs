using log4net;
using P05_Business.Common;
using P05_Business.S01_Models.Dto.Biz;
using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                            if (container.DataState == System.Data.DataRowState.Deleted)
                            {
                                context = new RequestContext
                                {
                                    Scope = "Biz.ExportMng",
                                    SqlId = "deleteExportContainer",
                                    Request = container
                                };
                            }
                            else
                            {
                                context = new RequestContext
                                {
                                    Scope = "Biz.ExportMng",
                                    SqlId = "mergeExportContainer",
                                    Request = container
                                };
                            }

                            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                            save = SqlMapper.Execute(context);

                            if (save < 0) break;
                        }
                    }

                    if (packings != null)
                    {
                        foreach (ExportPackingDto packing in packings)
                        {
                            if (packing.DataState == System.Data.DataRowState.Deleted)
                            {
                                context = new RequestContext
                                {
                                    Scope = "Biz.ExportMng",
                                    SqlId = "deleteExportPacking",
                                    Request = packing
                                };
                            }
                            else
                            {
                                context = new RequestContext
                                {
                                    Scope = "Biz.ExportMng",
                                    SqlId = "mergeExportPacking",
                                    Request = packing
                                };
                            }

                            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
                            save = SqlMapper.Execute(context);

                            if (save < 0) break;
                        }
                    }

                    if (invoices != null)
                    {
                        foreach (ExportInvoiceDto invoice in invoices)
                        {
                            if (invoice.DataState == System.Data.DataRowState.Deleted)
                            {
                                context = new RequestContext
                                {
                                    Scope = "Biz.ExportMng",
                                    SqlId = "deleteExportInvoice",
                                    Request = invoice
                                };
                            }
                            else
                            {
                                context = new RequestContext
                                {
                                    Scope = "Biz.ExportMng",
                                    SqlId = "mergeExportInvoice",
                                    Request = invoice
                                };
                            }

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

        /// <summary>
        /// 레포트용 수출 마스터 정보 조회
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        internal RptExportMasterDto SelectRptExportMaster(ExportMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ExportMng",
                SqlId = "selectExportMasterRpt",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            RptExportMasterDto master = SqlMapper.QuerySingle<RptExportMasterDto>(context);

            return master;
        }

        /// <summary>
        /// 레포트용 수출 수주 정보 조회
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        internal RptExportBuyerPoDto SelectRptExportBuyerPo(ExportMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ExportMng",
                SqlId = "selectExportBuyerPoRpt",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            RptExportBuyerPoDto po = SqlMapper.QuerySingle<RptExportBuyerPoDto>(context);

            return po;
        }

        /// <summary>
        /// 레포트용 수출 컨테이너 정보 조회
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        internal RptExportContainerDto SelectRptExportContainer(ExportMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ExportMng",
                SqlId = "selectExportContainerRpt",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            RptExportContainerDto conatiner = SqlMapper.QuerySingle<RptExportContainerDto>(context);

            return conatiner;
        }

        /// <summary>
        /// 레포트용 수출 팩킹 정보 조회
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        internal List<RptExportPackingListDto> SelectRptExportPackingList(ExportMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ExportMng",
                SqlId = "selectExportPackingListRpt",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<RptExportPackingListDto> packing = SqlMapper.Query<RptExportPackingListDto>(context).ToList();

            return packing;
        }

        /// <summary>
        /// 레포트용 수출 송장 정보 조회
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        internal List<RptExportInvoiceDto> SelectRptExportInvoice(ExportMasterDto param)
        {
            RequestContext context = new RequestContext
            {
                Scope = "Biz.ExportMng",
                SqlId = "selectExportInvoiceRpt",
                Request = param
            };
            log.Info(SqlMapper.SqlBuilder.BuildSql(context));
            List<RptExportInvoiceDto> packing = SqlMapper.Query<RptExportInvoiceDto>(context).ToList();

            
            return packing;
        }

    }

}
