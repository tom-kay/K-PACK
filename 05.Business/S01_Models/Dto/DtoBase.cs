using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto
{
	public class DtoBase
	{
		[Display(Name = "삭제유무")]
		public string DelYn { get; set; }
		[Display(Name = "생성일자")]
		public DateTime? CreateDt { get; set; }
		[Display(Name = "수정일자")]
		public DateTime? UpdateDt { get; set; }
		[Display(Name = "삭제일자")]
		public DateTime? DeleteDt { get; set; }
	}
}
