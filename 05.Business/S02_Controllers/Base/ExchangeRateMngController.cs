using log4net;
using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System.Collections.Generic;
using System.Reflection;

namespace P05_Business.S02_Controllers.Base
{
    internal class ExchangeRateMngController
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		ExchangeRateMngDao dao;

        public ExchangeRateMngController()
        {	
            dao = new ExchangeRateMngDao();
        }

        internal List<ExchangeRateMngDto> GetExchangeRateList(ExchangeRateMngDto param)
		{	
			List<ExchangeRateMngDto> results = dao.SelectExchangeRateList(param);

			return results; 
		}

		internal ExchangeRateMngDto GetExchangeRateSingle(ExchangeRateMngDto param)
		{
			ExchangeRateMngDto result = dao.SelectExchangeRateSingle(param);

			return result;
		}

		internal bool AddExchangeRate(List<ExchangeRateMngDto> param)
		{
			int result = dao.InsertExchangeRate(param);

			if (result < 0) 
			{ 
				return false;
			}
            else
            {
				return true;
            }

        }

		
	}
}
