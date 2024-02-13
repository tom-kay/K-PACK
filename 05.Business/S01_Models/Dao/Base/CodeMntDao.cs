using log4net;
using SmartSql.Abstractions;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using P05_Business.S01_Models.Dto.Base;

namespace P05_Business.S01_Models.Dao.Base
{
	public class CodeMntDao : DaoFactory
	{
		public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public CodeMasterDto GetCodeMaster()
    {

      RequestContext context = new RequestContext
      {
        Scope = "CodeMng",
        SqlId = "selectCodeMaster"
      };
      CodeMasterDto code = SqlMapper.QuerySingle<CodeMasterDto>(context);
      
      return code;

    }

    public List<CodeMasterDto> GetCodeMasterList()
		{
      RequestContext context = new RequestContext
      {
        Scope = "CodeMng",
        SqlId = "selectCodeMasterList",
        //Request = new { Ids = new long[] { 1, 2, 3, 4 } }
      };
      List<CodeMasterDto> codes = SqlMapper.Query<CodeMasterDto>(context).ToList();

			return codes;
		}

		//public void insertEmployee(string emp)
		//{
		//	DaoFactory.getInstance.Insert("insertEmployee", emp);
		//}
		//public void updateEmployee(string emp)
		//{
		//	DaoFactory.getInstance.Update("updateEmployee", emp);
		//}
		//public void deleteEmployeeByEmpno(int id)
		//{
		//	DaoFactory.getInstance.Delete("deleteEmployeeByEmpno", id);
		//}
	}
}
