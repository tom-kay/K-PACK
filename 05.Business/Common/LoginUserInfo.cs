using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.Common
{
	public static class LoginUserInfo
	{
		[Description("사용자ID")]
		public static string UserId { get; set; }
		[Description("사용자명(한글)")]
		public static string UserNameK { get; set; }
		[Description("사용자명(영문)")]
		public static string UserNameE { get; set; }
		[Description("연락처")]
		public static string TelNo1 { get; set; }
		[Description("긴급연락처")]
		public static string TelNo2 { get; set; }
		[Description("이메일")]
		public static string Email { get; set; }
		[Description("부서코드")]
		public static string DepartmentCode { get; set; }
		[Description("부서명")]
		public static string DepartmentName { get; set; }
		[Description("팀코드")]
		public static string TeamCode { get; set; }
		[Description("팀명")]
		public static string TeamName { get; set; }
		[Description("직위코드")]
		public static string PositionCode { get; set; }
		[Description("직위명")]
		public static string PositionName { get; set; }
		[Description("직책코드")]
		public static string JobCode { get; set; }
		[Description("직책명")]
		public static string JobName { get; set; }
		[Description("담당업무")]
		public static string TaskCharge { get; set; }
		[Description("접속ID")]
		public static string LoginId { get; set; }
		
	}
}
