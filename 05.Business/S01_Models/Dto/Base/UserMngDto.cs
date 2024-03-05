using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Base
{
	public class UserMngDto
	{	
        public string UserId { get; set; }
		public string CompanyCode { get; set; }
		[MaxLength(50, ErrorMessage ="[사용자명(한글)]은 최대 50자까지 입력 가능합니다.")]
		public string UserNameK { get; set; }
		[MaxLength(50, ErrorMessage = "[사용자명(영문)]은 최대 50자까지 입력 가능합니다.")]
		public string UserNameE { get; set; }
		public string Nationality { get; set; }
		[MaxLength(20, ErrorMessage = "[전화번호1]은 최대 20자까지 입력 가능합니다.")]
		public string TelNo1 { get; set; }
		[MaxLength(20, ErrorMessage = "[전화번호2]은 최대 20자까지 입력 가능합니다.")]
		public string TelNo2 { get; set; }
		[MaxLength(100, ErrorMessage = "[이메일]은 최대 100자까지 입력 가능합니다.")]
		public string Email { get; set; }
		[MaxLength(255, ErrorMessage = "[주소1]은 최대 255자까지 입력 가능합니다.")]
		public string Address1 { get; set; }
		[MaxLength(255, ErrorMessage = "[주소2]은 최대 255자까지 입력 가능합니다.")]
		public string Address2 { get; set; }
		public DateTime? EnterDt { get; set; }
		public DateTime? LeaveDt { get; set; }
		public string DepartmentCode { get; set; }
		public string TeamCode { get; set; }
		public string PositionCode { get; set; }
		public string JobCode { get; set; }
		[MaxLength(255, ErrorMessage = "[담당업무]은 최대 255자까지 입력 가능합니다.")]
		public string TaskCharge { get; set; }
		[MaxLength(50, ErrorMessage = "[로그인ID]는 최대 50자까지 입력 가능합니다.")]
		public string LoginId { get; set; }
		public int? LoginErrorCnt { get; set; }
		public string UseYn { get; set; }
		
	}
}
