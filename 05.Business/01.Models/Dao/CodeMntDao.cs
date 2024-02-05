using _05.Business._01.Models.Dto;
using IBatisNet.DataMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Business._01.Models.Dao
{
	public class CodeMntDao : DaoFactory
	{

    public static string FindDepartment(int deptId)
    {

      ISqlMapper mapper = EntityMapper;
      string str = mapper.QueryForObject<string>("selectCodeMasterList", deptId);
      return str;

    }

    public List<CodeMasterDto> GetCodeMasterList()
		{
      ISqlMapper mapper = EntityMapper;
      List<CodeMasterDto> list = mapper.QueryForList<CodeMasterDto>("selectCodeMasterList", null).ToList();
			
			return list;
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
