using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Business._01.Models.Dto
{
	public class DtoBase
	{ 
		public string DelYn { get; set; }
		public DateTime InsertDt { get; set; }
		public DateTime UpdateDt { get; set; }
		public DateTime DeleteDt { get; set; }
	}
}
