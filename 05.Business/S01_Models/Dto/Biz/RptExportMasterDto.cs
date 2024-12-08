using P05_Business.S04_Reports.Rpt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Biz
{
    /// <summary>
    /// 레포트용 수출 대표정보
    /// </summary>
    internal class RptExportMasterDto : DtoBase
    {
        [Description("송장번호")]
        public string InvoiceNo { get; set; }

        [Description("인보이스일자")]
        public string InvoiceDate { get; set; }

        [Description("송하인코드")]
        public string ShipperCode { get; set; }

        [Description("송하인명")]
        public string ShipperName { get; set; }

        [Description("송하인주소")]
        public string ShipperAddress { get; set; }

        [Description("수하인코드")]
        public string ConsigneeCode { get; set; }

        [Description("송하인명")]
        public string ConsigneeName { get; set; }

        [Description("송하인주소")]
        public string ConsigneeAddress { get; set; }

        [Description("통지처코드")]
        public string NotifyCode { get; set; }

        [Description("통지처명")]
        public string NotifyName { get; set; }

        [Description("통지처주소")]
        public string NotifyAddress { get; set; }

        [Description("바이어코드")]
        public string BuyerCode { get; set; }

        [Description("바이어명")]
        public string BuyerName { get; set; }

        [Description("바이어주소")]
        public string BuyerAddress { get; set; }

        [Description("출발일자")]
        public string DepartureDate { get; set; }

        [Description("운송기명")]
        public string CarrierName { get; set; }

        [Description("선적지코드")]
        public string PolCode { get; set; }

        [Description("선적지명")]
        public string PolName { get; set; }

        [Description("도착지명")]
        public string DestinationName { get; set; }

        [Description("하적지코드")]
        public string PodCode { get; set; }

        [Description("하적지명")]
        public string PodName { get; set; }

        [Description("운송조건코드")]
        public string DeliveryTermCode { get; set; }

        [Description("운송조건명")]
        public string DeliveryTermName { get; set; }

        [Description("지불조건코드")]
        public string PaymentTermCode { get; set; }

        [Description("지불조건명")]
        public string PaymentTermName { get; set; }

        [Description("지불내용")]
        public string PaymentDesc { get; set; }

        [Description("부피")]
        public decimal Measurement { get; set; }

        [Description("실중량")]
        public decimal NetWeight { get; set; }

        [Description("포장중량")]
        public decimal GrossWeight { get; set; }

        [Description("송하인비고")]
        public string ShippingMark { get; set; }

        [Description("비고")]
        public string Remark { get; set; }

        [Description("팩킹비고")]
        public string PackingRemark { get; set; }

        [Description("송장비고")]
        public string InvoiceRemark { get; set; }

        [Description("수주 번호")]
        public RptExportBuyerPoDto RptExportBuyerPo { get; set; }

        [Description("컨테이너 정보")]
        public RptExportContainerDto RptExportContainer { get; set; }

        [Description("팩킹정보")]
        public List<RptExportPackingListDto> RptExportPackingList { get; set; }

        [Description("송정정보")]
        public List<RptExportInvoiceDto> RptExportInvoice { get; set; }

    }
}
