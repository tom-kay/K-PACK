using log4net;
using P02_K_CONTROL_WIN;
using P05_Business.Common;
using P05_Business.Common.Helpers;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace P05_Business
{
    internal static class Program
	{
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
		static void Main()
		{
            
            SystemHelper.SetupSystemFont(); //프로그램에서 사용할 폰트 설치

            // log4net 초기화
            LogConfig.Configure();

			//DB Connection 파일 이동.
			try
			{
				// 복사할 파일 경로를 생성해 준다.
				FileHelper.CreateDirectoryIfNotExists(GlobalVariables.CONNECTION_CONFIG_FILE);

				// Config파일이 없으면 Config파일을 복사한다.
				if (!File.Exists(GlobalVariables.CONNECTION_CONFIG_FILE))
				{
					File.Copy(GlobalVariables.CLICKONCE_CONFIG_FILE, GlobalVariables.CONNECTION_CONFIG_FILE, false);
				}
			}
			catch (Exception ex)
			{
                log.Error($"Config 파일 복사 중 오류가 발생했습니다 : {ex.Message}");
            }


            if (IsExistProcessMutex(Process.GetCurrentProcess().ProcessName))
			{
				MessageBox.Show("이미실행중입니다.");
			}
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new frmMain());
			}
		}

		static bool IsExistProcessMutex(string processName)
		{
			bool createdNew;

			// createdNew  : processName로 이미 명명된 뮤텍스가 있을경우 false반환
			// 신규인경우는 true를반환한다.
			Mutex mutex = new Mutex(true, processName, out createdNew);

			if (createdNew == true)
				return false;
			else
				return true;

		}
	}
}
