using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto
{
	public class DtoBase
	{ 
		public string DelYn { get; set; }
		public DateTime? CreateDt { get; set; }
		public DateTime? UpdateDt { get; set; }
		public DateTime? DeleteDt { get; set; }
	}
}
