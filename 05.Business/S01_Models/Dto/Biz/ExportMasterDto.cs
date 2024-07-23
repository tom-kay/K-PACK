using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Biz
{
    internal class ExportMasterDto
    {
        [Required]
        [Description("인보이스 번호")]
        public string InvoiceNo { get; set; }

        [Description("인보이스 일자")]
        public string InvoiceDate { get; set; }

        [Description("Shipper코드")]
        public string ShipperCode { get; set; }

        [Description("Shipper주소")]
        public string ShipperAddress { get; set; }

        [Description("Consignee코드")]
        public string ConsigneeCode { get; set; }

        [Description("Consignee주소")]
        public string ConsigneeAddress { get; set; }

        [Description("Notify코드")]
        public string NotifyCode { get; set; }

        [Description("Notify주소")]
        public string NotifyAddress { get; set; }

        [Description("Buyer코드")]
        public string BuyerCode { get; set; }

        [Description("Buyer주소")]
        public string BuyerAddress { get; set; }

        [Description("출발일자")]
        public string DepartureDate { get; set; }

        [Description("운송수단(항공기/선박)이름")]
        public string CarrierName { get; set; }

        [Description("출발지코드")]
        public string PolCode { get; set; }

        [Description("배송조건코드")]
        public string DeliveryTermCode { get; set; }

        [Description("지불조건코드")]
        public string PaymentTermCode { get; set; }

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

        public List<ExportContainerDto> ExportContainers { get; set; }

        public List<ExportPackingDto> ExportPackings { get; set; }

        public List<ExportInvoiceDto> ExportInvoices { get; set; }


    }
}
