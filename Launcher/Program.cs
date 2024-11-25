using FluentFTP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public static class Program
    {
        public static string ftpHost = "kayroot.dothome.co.kr";
        public static string ftpUser = "kayroot";
        public static string ftpPass = "ftp#root24";
        public static string ftpPath = "/html/soodal";
        public static string localPath = Application.StartupPath; // 다운로드할 로컬 경로 설정
        public static string executable = "soodal.exe";
        public static string versionFilePath = ftpPath + "/version.txt";
        public static string localVersionFilePath = Path.Combine(localPath, "version.txt");

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (CheckForUpdates())
            {
                using (Upgrade upgradeForm = new Upgrade())
                {
                    upgradeForm.Load += (sender, e) => { upgradeForm.StartDownload(); };
                    Application.Run(upgradeForm);
                }
            }
            else
            {
                RunExecutable();
            }
        }

        public static bool CheckForUpdates()
        {
            // 서버에서 최신 버전 가져오기
            string latestVersion = GetFtpFileVersion();

            // 로컬 버전 가져오기
            string currentVersion = File.Exists(localVersionFilePath) ? File.ReadAllText(localVersionFilePath).Trim() : "0.0.0.0";

            // 버전이 같으면 업데이트 필요 없음
            return string.Compare(latestVersion, currentVersion) > 0;
        }

        public static string GetFtpFileVersion()
        {
            string version = string.Empty;

            using (var client = new FtpClient(ftpHost, ftpUser, ftpPass))
            {
                
                client.Connect();
                string localTempFilePath = Path.GetTempFileName();

                client.DownloadFile(localTempFilePath, versionFilePath, FtpLocalExists.Overwrite, FtpVerify.None);

                version = File.ReadAllText(localTempFilePath).Trim();
                File.Delete(localTempFilePath);
            }

            return version;
        }

        public static void RunExecutable()
        {
            System.Diagnostics.Process.Start(Path.Combine(localPath, executable), "launcher");
            Application.Exit();
            //UpdateLauncher();
        }

        public static void UpdateLauncher()
        {
            string latestLauncherVersion = GetFtpFileVersion();

            // 현재 런처의 버전 가져오기
            string currentLauncherVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            if (string.Compare(latestLauncherVersion, currentLauncherVersion) > 0)
            {
                using (var client = new FtpClient(ftpHost, ftpUser, ftpPass))
                {
                    client.Connect();
                    //DownloadFile(client, ftpPath + "/Launcher.exe", Path.Combine(localPath, "Launcher.exe"));
                }
                MessageBox.Show("런처가 업데이트되었습니다. 다시 시작해 주세요.", "업데이트 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

    }
}
