using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace P03_Framework.Helpers
{
	public class ExchangeHelper
	{
		/// <summary>
		/// 하나은행 최초 환율을 가져온다.
		/// </summary>
		/// <param name="searchDate"></param>
		/// <returns></returns>
		public async Task<DataTable> GetExchangeRateHanaBank(string searchDate)
		{
			DataTable dtResult = null;

			string source = await CrawlingExchangeRateHanaBank(searchDate);
			if (!string.IsNullOrEmpty(source))
			{
				dtResult = ConvertToDataTable(source);
			}

			return dtResult;
		}

		/// <summary>
		/// Html을 DataTable로 변환한다.
		/// </summary>
		/// <param name="result">HTML</param>
		/// <returns></returns>
		private DataTable ConvertToDataTable(string source)
		{
			// HTML 소스
			string html = source;

			// HtmlDocument 객체 생성
			var htmlDoc = new HtmlAgilityPack.HtmlDocument();
			htmlDoc.LoadHtml(html);

			// 테이블 찾기
			var table = htmlDoc.DocumentNode.SelectSingleNode("//table");

			// DataTable 생성
			var dataTable = new DataTable();

			// 헤더 설정
			dataTable.Columns.Add("ExDate", typeof(string));  //환율일자
			dataTable.Columns.Add("CurrCode", typeof(string));  //통화코드
			dataTable.Columns.Add("CurrName", typeof(string));  //통화명
			dataTable.Columns.Add("CashBuy", typeof(string));       //현찰살때
			dataTable.Columns.Add("CashBuySpread", typeof(string)); //현찰살때 스프레드
			dataTable.Columns.Add("CashSale", typeof(string));  //현찰팔때
			dataTable.Columns.Add("CashSaleSpread", typeof(string));    //현찰팔때 스프레드
			dataTable.Columns.Add("RemitSend", typeof(string)); //송금보낼때
			dataTable.Columns.Add("RemitRecv", typeof(string)); //송금받을때
			dataTable.Columns.Add("TCBuy", typeof(string));     //T/C 살때
			dataTable.Columns.Add("Check", typeof(string));     //외화수표팔때
			dataTable.Columns.Add("BasicRate", typeof(string));     //매매기준율
			dataTable.Columns.Add("Commission", typeof(string));    //환가료율
			dataTable.Columns.Add("Convert", typeof(string));    //미화환산율


			// 행 데이터 추출
			var rows = table.SelectNodes("tbody/tr");

			foreach (var row in rows)
			{
				var cells = row.SelectNodes("td");

				string pattern = @"pbk\.foreign\.rate\.pbld\.prs\.goFluctuation\('(\w+)','(\d+)'\)";

				// 정규식 객체 생성
				Regex regex = new Regex(pattern);

				// 매치 찾기
				MatchCollection matches = regex.Matches(cells[0].InnerHtml);

				// 매치 대입
				DataRow dataRow = dataTable.NewRow();
				if (matches.Count > 0)
				{
					dataRow[0] = matches[0].Groups[2].Value;
					dataRow[1] = matches[0].Groups[1].Value;
				}

				for (int i = 0; i < cells.Count; i++)
				{
					dataRow[i + 2] = cells[i].InnerText.Trim();
				}

				dataTable.Rows.Add(dataRow);
			}

			return dataTable;
		}

		/// <summary>
		/// 하나은행에서 환율을 크롤링한다.
		/// </summary>
		/// <returns></returns>
		static async Task<string> CrawlingExchangeRateHanaBank(string searchDate)
		{
			HttpClient client = new HttpClient();

			var url = "https://www.hanabank.com/cms/rate/wpfxd651_01i_01.do";

			string originDate = $"{searchDate.Substring(0, 4)}-{searchDate.Substring(4, 2)}-{searchDate.Substring(6, 2)}";

			var data = new Dictionary<string, string>
			{
				{"ajax", "true"},
				{"curCd", ""},
				{"tmpInqStrDt", originDate},
				{"pbldDvCd", "1"},
				{"pbldSqn", ""},
				{"hid_key_data", ""},
				{"inqStrDt", searchDate},
				{"inqKindCd", "1"},
				{"hid_enc_data", ""},
				{"requestTarget", "searchContentDiv"},
			};

			var content = new FormUrlEncodedContent(data);

			// 헤더 설정
			client.DefaultRequestHeaders.Add("Accept", "text/javascript, text/html, application/xml, text/xml, */*");
			client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br, zstd");
			client.DefaultRequestHeaders.Add("Accept-Language", "ko-KR,ko;q=0.9");
			client.DefaultRequestHeaders.Add("Connection", "keep-alive");
			client.DefaultRequestHeaders.Add("Host", "www.hanabank.com");
			client.DefaultRequestHeaders.Add("Origin", "https://www.hanabank.com");
			client.DefaultRequestHeaders.Add("Referer", "https://www.hanabank.com/cms/rate/index.do?contentUrl=/cms/rate/wpfxd651_01i.do");
			client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
			client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
			client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");
			client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Safari/537.36");
			client.DefaultRequestHeaders.Add("X-Prototype-Version", "1.5.1.1");
			client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
			client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Google Chrome\";v=\"123\", \"Not:A-Brand\";v=\"8\", \"Chromium\";v=\"123\"");
			client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
			client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "Windows");

			var response = await client.PostAsync(url, content);

			if (response.IsSuccessStatusCode)
			{
				Console.WriteLine("요청이 성공적으로 처리되었습니다.");
				string responseBody = await response.Content.ReadAsStringAsync();
				Console.WriteLine($"응답: {responseBody}");

				return responseBody;
			}
			else
			{
				Console.WriteLine($"요청이 실패했습니다. 상태 코드: {response.StatusCode}");

				return string.Empty;
			}
		}
	}
}
