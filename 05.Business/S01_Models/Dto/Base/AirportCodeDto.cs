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
    /// 세계공항코드
    /// </summary>
    internal class AirportCodeDto : DtoBase
    {
        /// <summary>
        /// IATA공항코드 (Primary Key)
        /// </summary>
        [Required] 
        [Description("IATA공항코드")]
        public string IataCode { get; set; }

        /// <summary>
        /// ICAO공항코드
        /// </summary>
        [Description("ICAO공항코드")]
        public string IcaoCode { get; set; }

        /// <summary>
        /// 영문공항명
        /// </summary>
        [Description("영문공항명")]
        public string NameE { get; set; }

        /// <summary>
        /// 한글공항명
        /// </summary>
        [Description("한글공항명")]
        public string NameK { get; set; }

        /// <summary>
        /// 공항운영상태
        /// </summary>
        [Description("공항운영상태")]
        public string StatusName { get; set; }

    }
}
