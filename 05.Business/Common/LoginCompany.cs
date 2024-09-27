using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.Common
{
	public static class LoginCompany
	{

		[Description("회사코드")]
        public static string CompanyCode { get; set; }
		[Description("국적코드")]
        public static string NationalityCode { get; set; }
		[Description("국적명")]
		public static string NationalityName { get; set; }
		[Description("회사그룹")]
		public static string CompanyGroup { get; set; }
		[Description("본사여부")]
		public static bool HeadOffice { get; set; }
		[Description("회사명(한글)")]
		public static string CompanyNameK { get; set; }
		[Description("회사명(영문)")]
		public static string CompanyNameE { get; set; }
		[Description("대표연락처")]
		public static string TelNo { get; set; }
		[Description("팩스번호")]
		public static string FaxNo { get; set; }
		[Description("주소1(한글)")]
		public static string AddressK1 { get; set; }
		[Description("주소2(한글)")]
		public static string AddressK2 { get; set; }
		[Description("주소1(영문)")]
		public static string AddressE1 { get; set; }
		[Description("주소2(영문)")]
		public static string AddressE2 { get; set; }

    }
}
