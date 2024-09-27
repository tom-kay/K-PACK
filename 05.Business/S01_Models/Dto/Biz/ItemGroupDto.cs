using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P05_Business.S01_Models.Dto.Biz
{
    internal class ItemGroupDto : DtoBase
    {
        [Required(ErrorMessage ="[그룹코드]는 필수 입니다.")]
        public string GroupCode { get; set; }
        [Description("그룹명")]
        public string GroupName { get; set; }
        [Description("그룹명별칭(약어)")]
        public string AliasName { get; set; }
        [Description("기본개별단위코드")]
        public string DefaultEachUnitCode { get; set; }
        [Description("기본개별단위명")]
        public string DefaultEachUnitName { get; set; }
        [Description("기본포장단위코드")]
        public string DefaultPackingUnitCode { get; set; }
        [Description("기본포장단위명")]
        public string DefaultPackingUnitName { get; set; }
        [Description("비고")]
        public string Remark { get; set; }

        [Description("아이템 디테일")]
        public List<ItemDto> Items { get; set; }
    }
}
