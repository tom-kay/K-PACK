using log4net.Config;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Business.Common
{
    internal static class LogConfig
    {
        public static void Configure()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                string configPath = Path.Combine(ApplicationDeployment.CurrentDeployment.DataDirectory, "log4net.config");
                XmlConfigurator.Configure(new FileInfo(configPath));
            }
            else
            {
                XmlConfigurator.Configure();
            }
        }
    }
}
