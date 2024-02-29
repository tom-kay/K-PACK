using log4net;
using P05_Business.S01_Models.Dao.Base;
using P05_Business.S01_Models.Dto.Base;
using System.Collections.Generic;
using System.Reflection;

namespace P05_Business.S02_Controllers.Base
{
	public class CompanyMngController
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		CompanyMngDao dao = new CompanyMngDao();

		public List<CompanyInfoDto> GetCompanyInfoList(CompanyInfoDto companyInfo)
		{	
			List<CompanyInfoDto> results = dao.SelectCompanyList(companyInfo);

			return results;
		}

		public CompanyInfoDto GetCompanyInfo(CompanyInfoDto companyInfo)
		{
			CompanyInfoDto result = dao.SelectCompanySingle(companyInfo);

			return result;
		}

		public int AddCompanyInfo(CompanyInfoDto companyInfo)
		{
			int result = dao.InsertCompany(companyInfo);

			return result;
		}

		public int RemoveCompanyInfo(CompanyInfoDto companyInfo)
		{
			int result = dao.DeleteCompany(companyInfo);

			return result;
		}
	}
}
