using System.ComponentModel.DataAnnotations;

namespace P05_Business.S01_Models.Dto.Base
{
	public class CodeMasterDto : DtoBase
	{
		[Display(Name = "CODE")]
		[Required(ErrorMessage ="[CODE]는 필수 입니다.")]
		[MaxLength(20, ErrorMessage = "[CODE] 최대 길이는 20자 입니다.")]
		public  string Code { get; set; }

		[Display(Name = "NAME")]
		[MaxLength(50, ErrorMessage = "[NAME] 최대 길이는 50자 입니다.")]
		public  string Name { get; set; }

		[Display(Name = "설명")]
		[MaxLength(50, ErrorMessage = "[설명] 최대 길이는 255자 입니다.")]
		public string Remark { get; set; }

		[Display(Name = "사용유무")]
		public  string UseYn { get; set; }

	}
}
