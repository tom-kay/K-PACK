using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Base
{
    /// <summary>
    /// 항구코드
    /// </summary>
    internal class ShipportCodeDto
    {
        /// <summary>
        /// 항구코드 (Primary Key)
        /// </summary>
        [Required]
        [Description("항구코드")]
        public string PortCode { get; set; }

        /// <summary>
        /// 국가코드
        /// </summary>
        [Description("국가코드")]
        public string CountryCode { get; set; }

        /// <summary>
        /// 항구구분자
        /// </summary>
        [Description("항구구분자")]
        public string PortClass { get; set; }

        /// <summary>
        /// 국가명
        /// </summary>
        [Description("국가명")]
        public string CountryName { get; set; }

        /// <summary>
        /// 항구명
        /// </summary>
        [Description("항구명")]
        public string PortName { get; set; }

        /// <summary>
        /// 회사코드
        /// </summary>
        [Description("회사코드")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 삭제여부
        /// </summary>
        [Description("삭제여부")]
        public string DelYn { get; set; }

        /// <summary>
        /// 생성자
        /// </summary>
        [Description("생성자")]
        public string CreateId { get; set; }

        /// <summary>
        /// 생성일자
        /// </summary>
        [Description("생성일자")]
        public DateTime? CreateDt { get; set; }

        /// <summary>
        /// 수정자
        /// </summary>
        [Description("수정자")]
        public string UpdateId { get; set; }

        /// <summary>
        /// 수정일자
        /// </summary>
        [Description("수정일자")]
        public DateTime? UpdateDt { get; set; }

        /// <summary>
        /// 삭제자
        /// </summary>
        [Description("삭제자")]
        public string DeleteId { get; set; }

        /// <summary>
        /// 삭제일자
        /// </summary>
        [Description("삭제일자")]
        public DateTime? DeleteDt { get; set; }
    }
}
