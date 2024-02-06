using _05.Business._01.Models.Dto;
using SmartSql.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace _05.Business._01.Models.Dao
{
  public class CodeMntDao : DaoFactory
	{

    public CodeMasterDto GetCodeMaster()
    {

      RequestContext context = new RequestContext
      {
        Scope = "CodeMng",
        SqlId = "selectCodeMasterList"
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
