using log4net;
using P05_Business.Common;
using P05_Business.S01_Models.Dao.Biz;
using P05_Business.S01_Models.Dto.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S02_Controllers.Biz
{
    internal class ExportMngController
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        ExportMngDao dao;

        public ExportMngController()
        {
            dao = new ExportMngDao();
        }

        internal List<ExportMasterDto> GetExportMasterList(ExportMasterDto param)
        {
            List<ExportMasterDto> list = dao.SelectExportMasterList(param);
            return list;
        }

        internal ExportMasterDto GetExportMaster(ExportMasterDto param)
        {
            // 마스터 정보 조회
            ExportMasterDto master = dao.SelectExportMaster(param);

            if (master != null && !string.IsNullOrEmpty(master.InvoiceNo))
            {
                // 컨테이너 정보 조회
                ExportContainerDto container = new ExportContainerDto{
                    InvoiceNo = master.InvoiceNo,
                    CompanyCode = master.CompanyCode,
                };

                master.ExportContainers = dao.SelectExportContainerList(container);

                // 팩킹리스트 정보 조회
                ExportPackingDto packing = new ExportPackingDto{
                    InvoiceNo = master.InvoiceNo,
                    CompanyCode = master.CompanyCode,
                };

                master.ExportPackings = dao.SelectExportPackingList(packing);

                // 인보이스 정보 조회
                ExportInvoiceDto invoice = new ExportInvoiceDto{
                    InvoiceNo = master.InvoiceNo,
                    CompanyCode = master.CompanyCode,
                };

                master.ExportInvoices = dao.SelectExportInvoiceList(invoice);
            }

            return master;
        }

        internal bool AddExportMaster(ExportMasterDto param, RequestCRUD request)
        {
            int iSave = dao.MergeExportMaster(param, request);

            bool isSave = true;
            if (iSave < 0)
            {
                isSave = false;
            }

            return isSave;
        }

        internal bool RemoveExportMaster(ExportMasterDto param)
        {
            int iDelete = dao.DeleteExportMaster(param);

            bool isDelete = true;
            if (iDelete < 0)
            {
                isDelete = false;
            }

            return isDelete;
        }
    }
}
