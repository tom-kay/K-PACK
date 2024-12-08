using Dapper;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.Common.Helpers
{
    internal static class FileHelper
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        internal static void CreateDirectoryIfNotExists(string path)
        {
            string directory = Path.GetDirectoryName(path);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        /// <summary>
        /// 파일을 복사하는 공통 메서드.
        /// </summary>
        /// <param name="sourceFilePath">소스 파일 경로</param>
        /// <param name="destinationFilePath">대상 파일 경로</param>
        internal static void CopyFile(string sourceFilePath, string destinationFilePath)
        {
            try
            {
                // 소스 파일이 존재하는지 확인
                if (!File.Exists(sourceFilePath))
                {
                    Console.WriteLine("소스 파일이 존재하지 않습니다: " + sourceFilePath);
                    log.Error("소스 파일이 존재하지 않습니다: " + sourceFilePath);
                    return;
                }

                // 대상 경로의 디렉토리가 존재하지 않으면 생성
                string destinationDirectory = Path.GetDirectoryName(destinationFilePath);
                if (!Directory.Exists(destinationDirectory))
                {
                    Directory.CreateDirectory(destinationDirectory);
                }

                // 파일 복사
                File.Copy(sourceFilePath, destinationFilePath, true);
                Console.WriteLine("파일 복사 성공: " + sourceFilePath + " -> " + destinationFilePath);
                log.Info("파일 복사 성공: " + sourceFilePath + " -> " + destinationFilePath);
            }
            catch (Exception ex)
            {
                // 예외 처리
                Console.WriteLine("파일 복사 중 오류 발생: " + ex.Message);
                log.Error("파일 복사 중 오류 발생: " + ex.Message);
            }
        }
    }
}
