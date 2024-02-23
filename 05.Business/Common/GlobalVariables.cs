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
	public class GlobalVariables
	{	
		public static string ExcutePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		public const string LogoFilePath = "Resource";
		public const string LogoFile = "Logo.jpg";

        public static string GetLogoFileImage { get { return Path.Combine(GlobalVariables.ExcutePath, GlobalVariables.LogoFilePath, GlobalVariables.LogoFile); } }
    }
}
