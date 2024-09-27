using System.ComponentModel.DataAnnotations;
using System.Data;

namespace P05_Business.S01_Models.Dto.Biz
{
    internal class OrderDetailDto : DtoBase
    {
        [Required]
        [StringLength(30)]
        public string OrderNo { get; set; } // 주문번호

        [Required]
        public int DetailId { get; set; } // 주문상세코드

        [StringLength(50)]
        public string ItemGroupCode { get; set; } // 제품그룹코드

        public int? ItemCode { get; set; } // 제품코드

        public int? SeqNo { get; set; } // 등록순번

        [StringLength(20)]
        public string ItemNo { get; set; } // 제품번호

        [StringLength(100)]
        public string SizeName { get; set; } // 사이즈명

        [StringLength(200)]
        public string Description { get; set; } // 규격

        public decimal? Qty { get; set; } // 수량

        [StringLength(20)]
        public string UnitCode { get; set; } // 단위코드

        public string UnitName { get; set; } // 단위명

        [StringLength(50)]
        public string MarkingColor { get; set; } // 마킹컬러

        [StringLength(255)]
        public string Remark { get; set; } // 비고

        public string BuyerPoNo { get; set; } // 수주번호

    }
}
