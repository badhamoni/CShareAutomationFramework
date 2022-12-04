using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using martech_ui_integration_tests.Source.Drivers;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace martech_ui_integration_tests.Source.CustomMethods
{
    public class CustomActions : DriverHelper
    {
        int TimeInSeconds = 30;
        public void WaitUntilElementIsClickable(By by) => new WebDriverWait(_driver, TimeSpan.FromSeconds(TimeInSeconds)).Until(ExpectedConditions.ElementToBeClickable(by));
        public void WaitUntilElementIsVisible(By by) => new WebDriverWait(_driver, TimeSpan.FromSeconds(60)).Until(ExpectedConditions.ElementIsVisible(by));
        public void Click(By by) => _driver.FindElement(by).Click();
        public void EnterText(By by, string text) => _driver.FindElement(by).SendKeys(text);
        public string GetText(By by, string text) => _driver.FindElement(by).Text;
        public void SelectText(By by, string text) => new SelectElement(_driver.FindElement(by)).SelectByValue(text);
    }
}