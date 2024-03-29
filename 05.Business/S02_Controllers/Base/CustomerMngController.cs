using Dapper;
using log4net;
using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using SmartSql.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
			CustomerDto customer = dao.selectCustomerSingle(param);

			return customer;
		}

		internal int AddCustomer(CustomerDto param)
		{
			int save = dao.insertCustomer(param);

			return save;
		}

		internal int RemoveCustomer(CustomerDto param)
		{
			int delete = dao.deleteCustomer(param);

			return delete;
		}
	}
}
