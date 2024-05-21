using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P05_Business.S01_Models.Dto.Biz
{
    internal class OrderMasterDto : DtoBase
    {
        [Required]
        [StringLength(30)]
        public string OrderNo { get; set; } // 발주번호

        [StringLength(10)]
        public string RegDt { get; set; } // 등록일자

        [StringLength(10)]
        public string ExWorkDt { get; set; } // 공장출고일자

        [StringLength(10)]
        public string BuyerCustCode { get; set; } // 바이어코드

        [StringLength(50)]
        public string BuyerPoNo { get; set; } // 바이버주문번호

        [StringLength(10)]
        public string DueDt { get; set; }   //납기일자

        [StringLength(10)]
        public string OrderDt { get; set; } // 주문일자

        [StringLength(10)]
        public string WorkCustCode { get; set; } // 발주처코드

        public string WorkCustName { get; set; } // 매입거래처명

        public string WorkCustAdd1 { get; set; } // 매입거래처주소1

        public string WorkCustAdd2 { get; set; } // 매입거래처주소2

        [StringLength(255)]
        public string Description { get; set; } // 설명

        [StringLength(255)]
        public string Remark { get; set; } // 비고

        public string TermsAndConditions { get; set; } // 조건설명

        public List<OrderDetailDto> Details { get; set; }   //발주상세

        public string DatePeriodType { get; set; }

        public string PeriodFromDt { get; set; }

        public string PeriodToDt { get; set; }
    }
}
