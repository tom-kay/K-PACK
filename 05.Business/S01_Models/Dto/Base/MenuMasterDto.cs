using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.S01_Models.Dto.Base
{
	public class MenuMasterDto : DtoBase
	{
		public string MenuId { get; set; }
		public string ParentId { get; set; }
		public string MenuName { get; set; }
		public string MenuType { get; set; }
		public string Namespace { get; set; }
		public string FormName { get; set; }
		public int OrderSeq { get; set; }
		public int DepthNo { get; set; }
		public string UseYn { get; set; }
	}
}
