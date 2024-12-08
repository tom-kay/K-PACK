using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Biz
{
    /// <summary>
    /// 레포트용 수출 팩킹 리스트 정보
    /// </summary>
    internal class RptExportPackingListDto : DtoBase
    {

        [Description("송장번호")]
        public string InvoiceNo { get; set; }

        [Description("제품그룹명")]
        public string ItemGroupName { get; set; }

        [Description("제품그룹명약어")]
        public string ItemGroupNameAlias { get; set; }

        [Description("포장단위코드")]
        public string PkgUnitCode { get; set; }

        [Description("포장단위명")]
        public string PkgUnitName { get; set; }

        [Description("포장시작번호")]
        public int PkgStartNo { get; set; }

        [Description("포장끝번호")]
        public int PkgEndNo { get; set; }

        [Description("사이즈명")]
        public string SizeName { get; set; }

        [Description("총수량")]
        public decimal TotQty { get; set; }

        [Description("개별단위명")]
        public string PcsUnitName { get; set; }

        [Description("개발수량")]
        public int PcsQty { get; set; }

        [Description("포장수량")]
        public int PkgQty { get; set; }
    }
}
