using System.ComponentModel.DataAnnotations;

namespace P05_Business.S01_Models.Dto.Base
{
	public class CompanyInfoDto : DtoBase
	{
		[Required(ErrorMessage ="[회사코드]는 필수 입니다.")]
		[MaxLength(4, ErrorMessage = "[회사코드]는 최대 4 자리입니다.")]
		public string CompanyCode { get; set; }

		[MaxLength(30, ErrorMessage = "[회사그룹]은 최대 30 자리입니다.")]
		public string CompanyGroup { get; set; }

        public string Nationality { get; set; }

		[MaxLength(255, ErrorMessage = "[회사명(한글)]은 최대 255 자리입니다.")]
		public string CompanyNameK { get; set; }

		[MaxLength(255, ErrorMessage = "[회사명(영문)]은 최대 255 자리입니다.")]
		public string CompanyNameE { get; set; }

		[MaxLength(30, ErrorMessage = "[대표번호]는 최대 30 자리입니다.")]
		public string TelNo { get; set; }

		[MaxLength(30, ErrorMessage = "[팩스번호]는 최대 30 자리입니다.")]
		public string FaxNo { get; set; }

        [MaxLength(255, ErrorMessage = "[주소(한글)1]은 최대 255 자리입니다.")]
		public string AddressK1 { get; set; }

		[MaxLength(255, ErrorMessage = "[주소(한글)2]은 최대 255 자리입니다.")]
		public string AddressK2 { get; set; }

		[MaxLength(255, ErrorMessage = "[주소(영문)1]은 최대 255 자리입니다.")]
		public string AddressE1 { get; set; }

		[MaxLength(255, ErrorMessage = "[주소(영문)2]은 최대 255 자리입니다.")]
		public string AddressE2 { get; set; }
		
	}
}
