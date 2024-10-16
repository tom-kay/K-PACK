﻿using System.ComponentModel.DataAnnotations;

namespace P05_Business.S01_Models.Dto.Base
{
    public class UserMngDto : DtoBase
	{	
        public string UserId { get; set; }
		public string CompanyNameK { get; set; }
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
		public string EnterDt { get; set; }
		public string LeaveDt { get; set; }
		public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string TeamCode { get; set; }
        public string TeamName { get; set; }
        public string PositionCode { get; set; }
		public string PositionName { get; set; }
		public string JobCode { get; set; }
		public string JobName { get; set; }
		[MaxLength(255, ErrorMessage = "[담당업무]은 최대 255자까지 입력 가능합니다.")]
		public string TaskCharge { get; set; }
		[Required(ErrorMessage ="[로그인ID]는 필수 항목입니다.")]
		[MaxLength(50, ErrorMessage = "[로그인ID]는 최대 50자까지 입력 가능합니다.")]
		public string LoginId { get; set; }
		[Required(ErrorMessage = "[로그인 비밀번호]는 필수 항목입니다.")]
		public string LoginPw { get; set; }
		public int? LoginErrorCnt { get; set; }
		public string UseYn { get; set; }
		
	}
}
