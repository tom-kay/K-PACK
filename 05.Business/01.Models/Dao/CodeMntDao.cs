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
	public class CodeMntDao
	{
		
		public IList<CodeMasterDto> GetCodeMasterList()
		{
			IList<CodeMasterDto> list = DaoFactory.getInstance.QueryForList<CodeMasterDto>("selectCodeMasterList", null);
			
			return list;
		}

		public void insertEmployee(string emp)
		{
			DaoFactory.getInstance.Insert("insertEmployee", emp);
		}
		public void updateEmployee(string emp)
		{
			DaoFactory.getInstance.Update("updateEmployee", emp);
		}
		public void deleteEmployeeByEmpno(int id)
		{
			DaoFactory.getInstance.Delete("deleteEmployeeByEmpno", id);
		}
	}
}
