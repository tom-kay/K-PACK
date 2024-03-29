﻿using P02_K_CONTROL_WIN;
using P05_Business.S01_Models.Dto.Base;
using P05_Business.S02_Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.Common.Helpers
{
	public class ComboHelper
	{
		/// <summary>
		/// 콤보박스 초기설정
		/// </summary>
		/// <param name="cbo">콤보박스</param>
		/// <param name="masterCode">조회대상 MasterCode</param>
		/// <param name="allItem">전체 항목 추가</param>
		/// <param name="blankItem">빈 항목 추가</param>
		public static void InitComboBox(KComboBox cbo, string masterCode, bool allItem = false, bool blankItem = false)
		{
			try
			{
				cbo.Items.Clear();

				CodeDetailDto param = new CodeDetailDto()
				{
					MasterCode = masterCode,
				};

				List<CodeDetailDto> items = new CodeMngController().GetUseCodeList(param);

				if (allItem)
				{
					items.Insert(0, new CodeDetailDto() { Code = "", Name = "전체" });
				}

				if (blankItem)
				{
					items.Insert(0, new CodeDetailDto() { Code = "", Name = "" });
				}

				cbo.DataSource = items;
				cbo.ValueMember = "Code";
				cbo.DisplayMember = "Name";

				cbo.SelectedIndex = 0;
			}
			catch
			{
				cbo.Items.Clear();
			}
		}

		/// <summary>
		/// 회사정보 콤보박스 초기 설정
		/// </summary>
		/// <param name="cbo"></param>
		/// <param name="delYn"></param>
		/// <param name="allItem"></param>
		/// <param name="blankItem"></param>
		public static void InitComboBoxCompany(ComboBox cbo, string delYn, bool allItem = false, bool blankItem = false)
		{
			try
			{
				cbo.Items.Clear();

				CompanyInfoDto param = new CompanyInfoDto()
				{
					DelYn = delYn
				};

				List<CompanyInfoDto> items = new CompanyMngController().GetCompanyInfoList(param);

				if (allItem)
				{
					items.Insert(0, new CompanyInfoDto() { CompanyCode = "", CompanyGroup = "전체" });
				}

				if (blankItem)
				{
					items.Insert(0, new CompanyInfoDto() { CompanyCode = "", CompanyGroup = "" });
				}

				cbo.DataSource = items;
				cbo.ValueMember = "CompanyCode";
				cbo.DisplayMember = "CompanyGroup";

				cbo.SelectedIndex = 0;
			}
			catch
			{
				cbo.Items.Clear();
			}
		}
	}
}
