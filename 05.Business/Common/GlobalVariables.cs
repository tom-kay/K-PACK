using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Business.Common
{
	/// <summary>
	/// Database 처리 결과
	/// </summary>
	public enum ResultCRUD
	{
		/// <summary>
		/// 변동 없음.
		/// </summary>
		None,
		/// <summary>
		/// 조회성공[데이터 존재]
		/// </summary>
		SearchSuccessData,
		/// <summary>
		/// 조회성공[데이터 없음]
		/// </summary>
		SearchSuccessNoData,
		/// <summary>
		/// 조회실패
		/// </summary>
		SearchFailData,
		/// <summary>
		/// 저장성공
		/// </summary>
		SaveSuccessData,
		/// <summary>
		/// 저장실패
		/// </summary>
		SaveFailData,
		/// <summary>
		/// 삭제성공
		/// </summary>
		DeleteSuccessData,
		/// <summary>
		/// 삭제실패
		/// </summary>
		DeleteFailData,
		/// <summary>
		/// 수정성공
		/// </summary>
		UpdateSuccessData,
		/// <summary>
		/// 수정실패
		/// </summary>
		UpdateFailData,
	}

	/// <summary>
	/// Database 처리 요청
	/// </summary>
	public enum RequestCRUD 
	{
		None = 0,
		/// <summary>
		/// 생성
		/// </summary>
		Create,
		/// <summary>
		/// 조회
		/// </summary>
		Read,
		/// <summary>
		/// 수정
		/// </summary>
		Update,
		/// <summary>
		/// 삭제
		/// </summary>
		Delete,
	}

	public enum SAVE_MODE
	{
		None = 0,
		New,
		Update,
	}

	public class GlobalVariables
	{
		public static string ExcutePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		public const string LogoFilePath = "Resource";
		public const string LogoFile = "Logo.jpg";

		public static string GetLogoFileImage { get { return Path.Combine(GlobalVariables.ExcutePath, GlobalVariables.LogoFilePath, GlobalVariables.LogoFile); } }

	}

}
