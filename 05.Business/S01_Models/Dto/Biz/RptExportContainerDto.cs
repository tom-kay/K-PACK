using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Biz
{
    /// <summary>
    /// 레포트용 수출 컨테이너 리스트 정보
    /// </summary>
    internal class RptExportContainerDto : DtoBase
    {
        [Description("인보이스번호")]
        public string InvoiceNo { get; set; }

        [Description("컨테이너번호")]
        public string ContainerNo { get; set; }
    }
}
