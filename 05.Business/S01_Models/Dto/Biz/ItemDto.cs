using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace P05_Business.S01_Models.Dto.Biz
{
    internal class ItemDto : DtoBase
    {
        [Required(ErrorMessage ="[그룹코드]는 필수 입니다.")]
        public string GroupCode { get; set; }
        [Required(ErrorMessage = "[아이템코드]는 필수 입니다.")]
        public int? ItemCode { get; set; }
        [Required(ErrorMessage = "[아이템번호]는 필수 입니다.")]
        public string ItemNo { get; set; }
        [Description("아이템명")]
        public string ItemName { get; set; }
        [Description("아이템명별칭(약어)")]
        public string AliasName { get; set; }
        [Description("사이즈")]
        public string Size { get; set; }
        [Description("사이즈별칭(약어)")]
        public string AliasSize { get; set; }
        [Description("상세설명")]
        public string Description { get; set; }
        [Description("상세설명별칭(약어)")]
        public string AliasDescription { get; set; }
        [Description("단위")]
        public string UnitCode { get; set; }
        [Description("단위명")]
        public string UnitName { get; set; }
        [Description("비고")]
        public string Remark { get; set; }
        [Description("데이터상태값")]
        public DataRowState? DataState { get; set; }

    }
}
