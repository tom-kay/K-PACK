using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Biz
{
    /// <summary>
    /// 레포트용 수출 바이어 구매 정보
    /// </summary>
    internal class RptExportBuyerPoDto : DtoBase
    {
        [Description("인보이스번호")]
        public string InvoiceNo { get; set; }
        
        [Description("바이어 구매번호")]
        public string BuyerPoNo { get; set; }
        
        [Description("바이어 구매 요청일자")]
        public string BuyerPoDate { get; set; }
    }
}
