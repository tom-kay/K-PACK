using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Base
{
	internal class CompanyInfoDto : DtoBase
	{
		[Required(ErrorMessage ="[회사코드]는 필수 입니다.")]
		[MaxLength(ErrorMessage = "[회사코드]는 최대 4 자리입니다.")]
		internal string CompanyCode { get; set; }

		[MaxLength(ErrorMessage = "[회사명(한글)]은 최대 255 자리입니다.")]
		internal string CompanyNameK { get; set; }

		[MaxLength(ErrorMessage = "[회사명(영문)]은 최대 255 자리입니다.")]
		internal string CompanyNameE { get; set; }

		internal string Nationality { get; set; }

		[MaxLength(ErrorMessage = "[주소(한글)1]은 최대 255 자리입니다.")]
		internal string AddressK1 { get; set; }

		[MaxLength(ErrorMessage = "[주소(한글)2]은 최대 255 자리입니다.")]
		internal string AddressK2 { get; set; }

		[MaxLength(ErrorMessage = "[주소(영문)1]은 최대 255 자리입니다.")]
		internal string AddressE1 { get; set; }

		[MaxLength(ErrorMessage = "[주소(영문)2]은 최대 255 자리입니다.")]
		internal string AddressE2 { get; set; }
		
	}
}
