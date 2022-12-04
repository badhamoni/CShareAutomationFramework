using martech_ui_integration_tests.Source.CustomMethods;
using martech_ui_integration_tests.Source.Pages;
using martech_ui_integration_tests.Source.Utilities;
using System.Configuration;

namespace martech_ui_integration_tests.Tests
{
    [Parallelizable(ParallelScope.All)]
    public class LoginPageTests : CustomActions
    { 
        [Test]
        public void searchBook_01()
        {
            ReadAppConfig readAppConfig = new ReadAppConfig();
            LoginPage loginPage = new LoginPage();
            _driver.Navigate().GoToUrl(readAppConfig.GetAppSetting("url"));
            loginPage.Search();
        }

        [Test]
        public void searchBook_02()
        {
            ReadAppConfig readAppConfig= new ReadAppConfig();
            LoginPage loginPage = new LoginPage();
            _driver.Navigate().GoToUrl(readAppConfig.GetAppSetting("url"));
            loginPage.Search();
        }
    }
}