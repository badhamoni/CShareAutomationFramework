using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace martech_ui_integration_tests.Source.Utilities
{
    public class ReadAppConfig
    {
        public string GetAppSetting(string key)
        {
            string exeConfigPath = GetType().Assembly.Location;
            KeyValueConfigurationElement element = ConfigurationManager.OpenExeConfiguration(exeConfigPath).AppSettings.Settings[key];
            if (element != null)
            {
                string value = element.Value;
                if (!string.IsNullOrEmpty(value))
                    return value;
            }
            return string.Empty;
        }
    }
}
