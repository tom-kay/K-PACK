using System.ComponentModel.DataAnnotations;

namespace P05_Business.S01_Models.Dto.Base
{
	public class CodeDetailDto : DtoBase
	{

		[Required(ErrorMessage ="[CODE]는 필수 입니다.")]
		[MaxLength(20,ErrorMessage = "[CODE]는 최대 20자리까지만 허용됩니다.")]
		public string Code { get; set; }

		[Required(ErrorMessage = "[MASTER CODE]는 필수 입니다.")]
		[MaxLength(20, ErrorMessage = "[MASTER CODE]는 최대 20자리까지만 허용됩니다.")]
		public string MasterCode { get; set; }

        public string MasterName { get; set; }

        [MaxLength(20, ErrorMessage = "[코드명]은 최대 50자리까지만 허용됩니다.")]
		public string Name { get; set; }

		[MaxLength(20, ErrorMessage = "[설명]은 최대 255자리까지만 허용됩니다.")]
		public string Remark { get; set; }

		[MaxLength(20, ErrorMessage = "[옵션1]은 최대 20자리까지만 허용됩니다.")]
		public string Option1 { get; set; }

		[MaxLength(20, ErrorMessage = "[옵션2]은 최대 20자리까지만 허용됩니다.")]
		public string Option2 { get; set; }

		[MaxLength(20, ErrorMessage = "[옵션3]은 최대 20자리까지만 허용됩니다.")]
		public string Option3 { get; set; }

		[MaxLength(20, ErrorMessage = "[옵션4]은 최대 20자리까지만 허용됩니다.")]
		public string Option4 { get; set; }

		[MaxLength(20, ErrorMessage = "[옵션5]은 최대 20자리까지만 허용됩니다.")]
		public string Option5 { get; set; }

		[MaxLength(20, ErrorMessage = "[옵션6]은 최대 20자리까지만 허용됩니다.")]
		public string Option6 { get; set; }

		[MaxLength(20, ErrorMessage = "[옵션7]은 최대 20자리까지만 허용됩니다.")]
		public string Option7 { get; set; }

		[MaxLength(20, ErrorMessage = "[옵션8]은 최대 20자리까지만 허용됩니다.")]
		public string Option8 { get; set; }

		[MaxLength(20, ErrorMessage = "[옵션9]은 최대 20자리까지만 허용됩니다.")]
		public string Option9 { get; set; }

		[MaxLength(20, ErrorMessage = "[옵션10]은 최대 20자리까지만 허용됩니다.")]
		public string Option10 { get; set; }

		public string UseYn { get; set; }

	}
}
