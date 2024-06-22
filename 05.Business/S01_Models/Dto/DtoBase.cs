using P05_Business.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace P05_Business.S01_Models.Dto
{
	public class DtoBase : ICloneable
	{
		[Display(Name = "회사코드")]
		public string CompanyCode { get; set; } = LoginCompany.CompanyCode;
		[Display(Name = "삭제유무")]
		public string DelYn { get; set; }
		[Display(Name = "생성자")]
		public string CreateId {  get; set; } = LoginUserInfo.UserId;
		[Display(Name = "생성일자")]
		public DateTime? CreateDt { get; set; }
		[Display(Name = "수정자")]
		public string UpdateId { get; set; } = LoginUserInfo.UserId;
		[Display(Name = "수정일자")]
		public DateTime? UpdateDt { get; set; }
		[Display(Name = "삭제자")]
		public string DeleteId { get; set; } = LoginUserInfo.UserId;
		[Display(Name = "삭제일자")]
		public DateTime? DeleteDt { get; set; }
        [Description("데이터상태값")]
        public DataRowState? DataState { get; set; }

        public object Clone()
		{	
			return this.MemberwiseClone();
		}
	}
}
