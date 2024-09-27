using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Base
{
    internal class MemoTemplateDto : DtoBase
    {
        [Description("메모키")]
        public int? MemoIdx { get; set; }
        [Description("제목")]
        public string Title { get; set; }
        [Description("내용")]
        public string Contents { get; set; }
    }
}
