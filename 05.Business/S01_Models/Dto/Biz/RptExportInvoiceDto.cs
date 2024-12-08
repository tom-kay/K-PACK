using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Biz
{
    /// <summary>
    /// 레포트용 수출 송장 정보
    /// </summary>
    internal class RptExportInvoiceDto : DtoBase
    {
        [Description("송장번호")]
        public string InvoiceNo { get; set; }

        [Description("송장Id")]
        public int InvoiceId { get; set; }

        [Description("송장순번")]
        public int InvoiceSeq { get; set; }

        [Description("발주번호")]
        public string OrderNo { get; set; }

        [Description("발주상세ID")]
        public int OrderDetailId { get; set; }

        [Description("제품그룹코드")]
        public string ItemGroupCode { get; set; }

        [Description("제품그룹명")]
        public string ItemGroupName { get; set; }

        [Description("제품그룹약어명")]
        public string ItemGroupAliasName { get; set; }

        [Description("제품코드")]
        public string ItemCode { get; set; }

        [Description("제품명")]
        public string ItemName { get; set; }

        [Description("제품약어명")]
        public string ItemAliasName { get; set; }

        [Description("제품사이즈")]
        public string ItemSize { get; set; }

        [Description("제품길이")]
        public string ItemLength { get; set; }

        [Description("미화환산수량")]
        public decimal UsQty { get; set; }

        [Description("제품수량")]
        public decimal Qty { get; set; }

        [Description("단가")]
        public decimal UnitPrice { get; set; }

        [Description("금액")]
        public decimal Amount { get; set; }

    }
}
