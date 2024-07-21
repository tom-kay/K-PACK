using P02_K_CONTROL_WIN;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace P05_Business
{
	internal static class Program
	{
		/// <summary>
		/// 해당 애플리케이션의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main()
		{
			SystemHelper.SetupSystemFont();	//프로그램에서 사용할 폰트 설치


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
