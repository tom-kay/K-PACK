using FluentFTP.Helpers;
using FluentFTP;
using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Upgrade : Form
    {
        private static ProgressBar progressBar;
        private static int totalFiles;
        private static int downloadedFiles;
        private static BackgroundWorker worker;

        public Upgrade()
        {
            progressBar = new ProgressBar
            {
                Dock = DockStyle.Fill,
                Minimum = 0,
                Maximum = 100,
                Value = 0
            };

            this.Controls.Add(progressBar);
            this.Text = "파일 다운로드 진행 중...";
            this.Size = new System.Drawing.Size(400, 100);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowIcon = false;
            this.ControlBox = false;

            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_RunWorkerCompleted);
            worker.WorkerReportsProgress = true;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // 다운로드 작업 수행
            DownloadFiles();
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("파일 다운로드가 완료되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.RunExecutable(); // 다운로드 완료 후 실행
        }

        public void SetTotalFiles(int total)
        {
            totalFiles = total;
            downloadedFiles = 0;
        }

        public void UpdateProgress()
        {
            downloadedFiles++;
            int progressPercentage = (int)((double)downloadedFiles / totalFiles * 100);
            worker.ReportProgress(progressPercentage);
        }

        public void StartDownload()
        {
            worker.RunWorkerAsync();
        }

        private void DownloadFiles()
        {
            using (var client = new FtpClient(Program.ftpHost, Program.ftpUser, Program.ftpPass))
            {
                client.Connect();
                var items = client.GetListing(Program.ftpPath);

                int fileCount = GetFileCount(client, Program.ftpPath);
                SetTotalFiles(fileCount);

                DownloadFileOrDirectory(client, Program.ftpPath, Program.localPath);

                // 버전 파일 다운로드
                client.DownloadFile(Program.localVersionFilePath, Program.versionFilePath, FtpLocalExists.Overwrite, FtpVerify.None);
            }
        }

        private int GetFileCount(FtpClient client, string remotePath)
        {
            var items = client.GetListing(remotePath);
            int count = 0;

            foreach (var item in items)
            {
                if (item.Type == FtpObjectType.Directory)
                {
                    count += GetFileCount(client, item.FullName); // Recursively count files in subdirectories
                }
                else if (item.Type == FtpObjectType.File)
                {
                    count++;
                }
            }

            return count;
        }

        private void DownloadFileOrDirectory(FtpClient client, string remotePath, string localPath)
        {
            var items = client.GetListing(remotePath);

            foreach (var item in items)
            {
                string localFilePath = Path.Combine(localPath, item.Name);

                if (item.Type == FtpObjectType.Directory)
                {
                    if (!Directory.Exists(localFilePath))
                    {
                        Directory.CreateDirectory(localFilePath);
                    }
                    DownloadFileOrDirectory(client, item.FullName, localFilePath);
                }
                else if (item.Type == FtpObjectType.File)
                {
                    DownloadFile(client, item.FullName, localFilePath);
                }
            }
        }

        private void DownloadFile(FtpClient client, string remoteFile, string localFile)
        {
            client.DownloadFile(localFile, remoteFile, FtpLocalExists.Overwrite, FtpVerify.None);
            UpdateProgress();
        }
    }
}
