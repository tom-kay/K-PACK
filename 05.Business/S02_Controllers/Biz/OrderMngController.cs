using log4net;
using P05_Business.Common;
using P05_Business.S01_Models.Dao.Biz;
using P05_Business.S01_Models.Dto.Biz;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S02_Controllers.Biz
{
    internal class OrderMngController
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        OrderMngDao dao;

        public OrderMngController()
        {
            dao = new OrderMngDao();
        }

        internal List<OrderMasterDto> GetOrderMasterList(OrderMasterDto param)
        {
            List<OrderMasterDto> list = dao.SelectOrderMasterList(param);
            return list;
        }

        internal OrderMasterDto GetOrderMaster(OrderMasterDto param)
        {
            OrderMasterDto master = dao.SelectOrderMaster(param);

            if (master != null && !string.IsNullOrEmpty(master.OrderNo))
            {
                OrderDetailDto detail = new OrderDetailDto();
                detail.OrderNo = master.OrderNo;
                detail.CompanyCode = master.CompanyCode;

                master.Details = dao.SelectOrderDetailList(detail);
            }

            return master;
        }

        internal bool AddOrderMaster(OrderMasterDto param, RequestCRUD request)
        {
            int iSave = dao.MergeOrderMaster(param, request);

            bool isSave = true;
            if (iSave < 0)
            {
                isSave = false;
            }

            return isSave;
        }

        internal bool RemoveOrderMaster(OrderMasterDto param)
        {
            int iDelete = dao.DeleteOrderMaster(param);

            bool isDelete = true;
            if (iDelete < 0)
            {
                isDelete = false;
            }

            return isDelete;
        }

        internal List<OrderReportDto> GetReportOrderData(OrderMasterDto param)
        {
            List<OrderReportDto> dtos = dao.SelectReportOrderData(param);

            return dtos;
        }
    }
}
