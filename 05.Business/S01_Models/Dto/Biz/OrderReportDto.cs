using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Biz
{
    internal class OrderReportDto : DtoBase
    {
        public string OrderNo { get; set; }
        public string RegDt { get; set; }
        public string ExWorkDt { get; set; }
        public string BuyerCustCode { get; set; }
        public string BuyerCustName { get; set; }
        public string BuyerPoNo { get; set; }
        public string DueDt { get; set; }
        public string OrderDt { get; set; }
        public string WorkCustCode { get; set; }
        public string WorkCustName { get; set; }
        public string WorkAddr1 { get; set; }
        public string WorkAddr2 { get; set; }
        public string WorkTelNo { get; set; }
        public string WorkFaxNo { get; set; }
        public string OrderDesc { get; set; }
        public string TermsAndConditions { get; set; }
        public int DetailId { get; set; }
        public string ItemGroupCode { get; set; }
        public string ItemGroupName { get; set; }
        public int ItemCode { get; set; }
        public int SeqNo { get; set; }
        public string ItemNo { get; set; }
        public string SizeName { get; set; }
        public string ItemDesc { get; set; }
        public decimal? Qty { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string MarkingColor { get; set; }
    }
}
