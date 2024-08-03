﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Biz
{
    internal class ExportPackingDto
    {
        [Required]
        [Description("인보이스번호")]
        public string InvoiceNo { get; set; }

        [Required]
        [Description("팩킹리스트ID")]
        public int? PackingId { get; set; }

        [Description("발주번호")]
        public string OrderNo { get; set; }

        [Description("발주목록ID")]
        public string OrderDetailId { get; set; }

        [Description("포장단위코드")]
        public string PkgUnitCode { get; set; }

        [Description("포장시작번호")]
        public int? PkgStartNo { get; set; }

        [Description("포장끝번호")]
        public int? PkgEndNo { get; set; }

        [Description("수량")]
        public decimal? Qty { get; set; }

        [Description("포장수량")]
        public decimal? PkgQty { get; set; }
    }
}