using System.Drawing.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;

namespace P02_K_CONTROL_WIN
{
    public class SystemHelper
    {
        private static string _FONT_FILE_PATH = Path.Combine(Application.StartupPath, "Resource", "Font", "D2Coding-Ver1.3.2-20180524-all.ttc");
        public const string _FONT_NAME = "D2Coding";
        private static PrivateFontCollection privateFonts = new PrivateFontCollection();

        [DllImport("gdi32.dll")]
        private static extern int AddFontResource(string lpszFilename);

        public static Font GetSystemFont()
        {
            privateFonts.AddFontFile(_FONT_FILE_PATH);
            Font customFont = new Font(privateFonts.Families[0], 12);
            return customFont;
        }

        private static bool IsFontInstalled(string fontName)
        {
            using (InstalledFontCollection installedFonts = new InstalledFontCollection())
            {
                foreach (var fontFamily in installedFonts.Families)
                {
                    if (fontFamily.Name.Equals(fontName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool InstallFont(string fontFilePath)
        {
            string fontFileName = Path.GetFileName(fontFilePath);
            string fontsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
            string destinationPath = Path.Combine(fontsFolder, fontFileName);

            try
            {
                File.Copy(fontFilePath, destinationPath, true);
                if (AddFontResource(destinationPath) == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error installing font: " + ex.Message);
                return false;
            }
        }

        public static void SetupSystemFont()
        {
            if (!IsFontInstalled(_FONT_NAME))
            {
                if (InstallFont(_FONT_FILE_PATH))
                {
                    Console.WriteLine("Font installed successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to install font.");
                }
            }
            else
            {
                Console.WriteLine("Font is already installed.");
            }
        }
    }
}
