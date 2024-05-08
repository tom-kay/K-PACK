using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace P05_Business.S01_Models.Dto.Base
{
    internal class CustomerEmpDto : DtoBase
	{
		[Required(ErrorMessage ="[거래처코드]는 필수 입니다.")]
		[Description("거래처코드")]
        public string CustCode { get; set; }

		[Description("직원 등록 코드")]
		public int? EmpIdx { get; set; }

		[Description("직원명")]
		public string EmpName { get; set; }

		[Description("직위명")]
        public string PositionName { get; set; }

		[Description("전화번호")]
        public string TelNo { get; set; }

		[Description("모바일번호")]
        public string MobileNo { get; set; }

		[Description("이메일")]
		public string Email { get; set; }

		[Description("담당업무")]
		public string TaskCharge { get; set; }

		[Description("비고")]
		public string Remark { get; set; }

		public DataRowState? DataState { get; set; }
	}
}
