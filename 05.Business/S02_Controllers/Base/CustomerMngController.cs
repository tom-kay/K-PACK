using log4net;
using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace P05_Business.S02_Controllers.Base
{
    internal class CustomerMngController
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		CustomerMngDao dao = new CustomerMngDao();

		internal List<CustomerDto> GetCustomerList(CustomerDto param)
		{
			
			List<CustomerDto> list = dao.SelectCustomerList(param);

			return list;
		}

		internal CustomerDto GetCustomer(CustomerDto param)
		{
			CustomerDto customer = dao.SelectCustomerSingle(param);

			List<CustomerEmpDto> custEmps = dao.SelectCustomerEmpList(param);

			customer.Employees = custEmps;

			return customer;
		}

		internal bool AddCustomer(CustomerDto param)
		{
			bool isSave = true;
			int save = dao.InsertCustomer(param);

			if (save < 0) isSave = false;

			return isSave;
		}

		internal int RemoveCustomer(CustomerDto param)
		{
			int delete = dao.DeleteCustomer(param);

			return delete;
		}

        internal List<CustomerDto> GetCustomerPopupList(CustomerDto param)
        {
            List<CustomerDto> list = dao.SelectCustomerPopupList(param);

            return list;
        }
    }
}
