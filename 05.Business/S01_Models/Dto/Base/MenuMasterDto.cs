using System.ComponentModel.DataAnnotations;

namespace P05_Business.S01_Models.Dto.Base
{
	public class MenuMasterDto : DtoBase
	{
		[Required(ErrorMessage = "[ID]는 필수 입니다.")]
		[MaxLength(255, ErrorMessage = "[ID] 최대길이는 255자 입니다.")]
		public string MenuId { get; set; }
		[MaxLength(255, ErrorMessage = "[Parent ID] 최대길이는 255자 입니다.")]
		public string ParentId { get; set; }
		[MaxLength(255, ErrorMessage = "[ID] 최대길이는 255자 입니다.")]
		public string MenuName { get; set; }
		public string MenuType { get; set; }
		[MaxLength(255, ErrorMessage = "[NAMESPACE] 최대길이는 255자 입니다.")]
		public string Namespace { get; set; }
		[MaxLength(255, ErrorMessage = "[FORM NAME] 최대길이는 255자 입니다.")]
		public string FormName { get; set; }
		public int? OrderSeq { get; set; }
		public int? DepthNo { get; set; }
		public string UseYn { get; set; }
	}
}
