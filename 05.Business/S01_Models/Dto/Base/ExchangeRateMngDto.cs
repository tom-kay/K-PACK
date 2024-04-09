using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Base
{
	internal class ExchangeRateMngDto : DtoBase
	{
		[Required(ErrorMessage ="[고시일자]는 필수 입니다.")]
		[Description("고시일자")]
        public string ExDate { get; set; }
		[Required(ErrorMessage = "[통화코드]는 필수 입니다.")]
		[Description("통화코드")]
		public string CurrCode { get; set; }
		[Description("통화명")]
		public string CurrName { get; set; }
		[Description("현금살때")]
		public decimal CashBuy { get; set; }
		[Description("현금살때Spread")]
		public decimal CashBuySpread { get; set; }
		[Description("현금팔때")]
		public decimal CashSale { get; set; }
		[Description("현금팔때Spread")]
		public decimal CashSaleSpread { get; set; }
		[Description("송금보낼때")]
		public decimal RemitSend { get; set; }
		[Description("송금받을때")]
		public decimal RemitRecv { get; set; }
		[Description("T/C 살때")]
		public decimal TCBuy { get; set; }
		[Description("외화수표팔때")]
		public decimal Check { get; set; }
		[Description("매매기준율")]
		public decimal BasicRate { get; set; }
		[Description("환가료율")]
		public decimal Commission { get; set; }
		[Description("미화환산율")]
		public decimal Convert { get; set; }

		[Description("데이터 상태")]
		DataRowState DataState { get; set; }
	}
}
