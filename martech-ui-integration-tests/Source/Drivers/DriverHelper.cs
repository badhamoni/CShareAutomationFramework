using martech_ui_integration_tests.Source.Enums;
using martech_ui_integration_tests.Source.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace martech_ui_integration_tests.Source.Drivers
{
    public class DriverHelper : ReadAppConfig {
        [ThreadStatic]
        public static IWebDriver _driver;

        [SetUp]
        public void Init_Driver()
        {
            if (Browsers.Chrome.ToString().Equals(GetAppSetting("browser"), StringComparison.OrdinalIgnoreCase))
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                _driver = new ChromeDriver();
            }
            else if (Browsers.Firefox.ToString().Equals(GetAppSetting("browser"), StringComparison.OrdinalIgnoreCase))
            {
                new DriverManager().SetUpDriver(new FirefoxConfig());
                _driver = new FirefoxDriver();
            }
            else if (Browsers.Edge.ToString().Equals(GetAppSetting("browser"), StringComparison.OrdinalIgnoreCase))
            {
                new DriverManager().SetUpDriver(new EdgeConfig());
                _driver = new EdgeDriver();
            }
            else if (Browsers.Ie.ToString().Equals(GetAppSetting("browser"), StringComparison.OrdinalIgnoreCase))
            {
                new DriverManager().SetUpDriver(new InternetExplorerConfig());
                _driver = new InternetExplorerDriver();
            }
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}

