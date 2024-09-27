using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace P05_Business.S01_Models.Dto.Biz
{
    internal class ExportMasterDto : DtoBase
    {
        [Required]
        [Description("인보이스 번호")]
        public string InvoiceNo { get; set; }

        [Description("인보이스 일자")]
        public string InvoiceDate { get; set; }

        [Description("Shipper코드")]
        public string ShipperCode { get; set; }

        [Description("Shipper명")]
        public string ShipperName { get; set; }

        [Description("Shipper주소")]
        public string ShipperAddress { get; set; }

        [Description("Consignee코드")]
        public string ConsigneeCode { get; set; }

        [Description("Consignee명")]
        public string ConsigneeName { get; set; }

        [Description("Consignee주소")]
        public string ConsigneeAddress { get; set; }

        [Description("Notify코드")]
        public string NotifyCode { get; set; }

        [Description("Notify명")]
        public string NotifyName { get; set; }

        [Description("Notify주소")]
        public string NotifyAddress { get; set; }

        [Description("Buyer코드")]
        public string BuyerCode { get; set; }

        [Description("Buyer명")]
        public string BuyerName { get; set; }

        [Description("Buyer주소")]
        public string BuyerAddress { get; set; }

        [Description("출발일자")]
        public string DepartureDate { get; set; }

        [Description("운송수단(항공기/선박)이름")]
        public string CarrierName { get; set; }

        [Description("출발지코드")]
        public string PolCode { get; set; }

        [Description("도착지코드")]
        public string PodCode { get; set; }

        [Description("배송조건코드")]
        public string DeliveryTermCode { get; set; }

        [Description("최종도착지")]
        public string DestinationName { get; set; }

        [Description("지불조건코드")]
        public string PaymentTermCode { get; set; }

        [Description("결제조건내용")]
        public string PaymentDesc { get; set; }
        
        [Description("부피")]
        public decimal? Measurement { get; set; }

        [Description("실중량")]
        public decimal? NetWeight { get; set; }

        [Description("총중량")]
        public decimal? GrossWeight { get; set; }

        [Description("Shipping Mark")]
        public string ShippingMark { get; set; }

        [Description("비고")]
        public string Remark { get; set; }

        [Description("Packing List 비고")]
        public string PackingRemark { get; set; }

        [Description("Invoice 비고")]
        public string InvoiceRemark { get; set; }
        [Description("조회일자타입")]
        public string DatePeriodType { get; set; }

        [Description("조회시작일자")]

        public string PeriodFromDt { get; set; }

        [Description("조회종료일자")]
        public string PeriodToDt { get; set; }

        [Description("컨테이너 정보")]
        public List<ExportContainerDto> ExportContainers { get; set; }

        [Description("팩킹리스트 정보")]
        public List<ExportPackingDto> ExportPackings { get; set; }

        [Description("인보이스 정보")]
        public List<ExportInvoiceDto> ExportInvoices { get; set; }


    }
}
