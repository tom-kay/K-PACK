using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Biz
{
    internal class ExportContainerDto
    {
        [Required]
        [Description("인보이스번호")]
        public string InvoiceNo { get; set; }

        [Required]
        [Description("컨테이너ID")]
        public string ContainerId { get; set; }

        [Description("컨테이너번호")]
        public string ContainerNo { get; set; }

        [Description("봉인번호1")]
        public string SealNo1 { get; set; }

        [Description("봉인번호2")]
        public string SealNo2 { get; set; }

        [Description("봉인번호3")]
        public string SealNo3 { get; set; }
    }
}
