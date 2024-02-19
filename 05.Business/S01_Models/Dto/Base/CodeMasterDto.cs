using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Base
{	
	public class CodeMasterDto : DtoBase
	{
		[Required(ErrorMessage ="Code는 필수 입니다.")]
		[MaxLength(20, ErrorMessage = "Code 최대 길이는 20자 입니다.")]
		public  string Code { get; set; }
		[MaxLength(50, ErrorMessage = "Name 최대 길이는 50자 입니다.")]
		public  string Name { get; set; }

		public  string UseYn { get; set; }

	}
}
