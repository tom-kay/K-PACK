using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Biz
{
    internal class ExportInvoiceDto : DtoBase
    {
        [Required]
        [Description("인보이스번호")]
        public string InvoiceNo { get; set; }

        [Required]
        [Description("인보이스상세ID")]
        public int? InvoiceId { get; set; }

        [Required]
        [Description("정렬순번")]
        public int? InvoiceSeq { get; set; }

        [Description("발주번호")]
        public string OrderNo { get; set; }

        [Description("발주목록ID")]
        public int? OrderDetailId { get; set; }

        [Description("제품길이")]
        public decimal? ItemLength { get; set; }

        [Description("미국 전용 수량(제품길이 X 수량)")]
        public decimal? UsQty { get; set; }

        [Description("제품 수량")]
        public decimal? Qty { get; set; }

        [Description("단가")]
        public decimal? UnitPrice { get; set; }

        [Description("가격")]
        public decimal? Amount { get; set; }

        [Description("수주번호")]
        public string BuyerPoNo {  get; set; }

    }
}
