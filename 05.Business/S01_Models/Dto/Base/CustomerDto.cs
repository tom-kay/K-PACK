using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Base
{
	internal class CustomerDto : DtoBase
	{
		[Required(ErrorMessage ="[거래처코드]는 필수 입니다.")]
		[MaxLength(10, ErrorMessage = "[거래처코드]는 최대 10자리 입니다.")]
		[Description("거래처코드")]
        public string CustCode { get; set; }

		[Description("거래처명")]
        public string CustName { get; set; }

		[Description("사업자번호")]
		public string CompanyNo { get; set; }

		[Description("기본주소")]
		public string Address1 { get; set; }

		[Description("상세주소")]
		public string Address2 { get; set; }

		[Description("대표전화번호")]
		public string TelNo { get; set; }

		[Description("팩스번호")]
		public string FaxNo { get; set; }

		[Description("이메일")]
		public string Email { get; set; }

		[Description("국가코드")]
		public string NationCode { get; set; }

		[Description("국가명")]
		public string NationName { get; set; }

		[Description("거래구분(매출)")]
		public string DealTypeSale { get; set; }

		[Description("거래구분(매입)")]
		public string DealTypeBuy { get; set; }

		[Description("거래구분(임가공)")]
		public string DealTypeProc { get; set; }

		[Description("거래구분(일반)")]
		public string DealTypeGeneral { get; set; }

		[Description("대표자명")]
		public string OwnerName { get; set; }

		[Description("거래은행")]
		public string BankName { get; set; }

		[Description("계좌번호")]
		public string AccountNo { get; set; }

		[Description("예금주")]
		public string Depositor { get; set; }

		[Description("비고")]
		public string Remark { get; set; }
    }
}
