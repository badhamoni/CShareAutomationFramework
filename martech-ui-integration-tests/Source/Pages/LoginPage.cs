using martech_ui_integration_tests.Source.CustomMethods;
using martech_ui_integration_tests.Source.Drivers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace martech_ui_integration_tests.Source.Pages
{
    public class LoginPage : CustomActions
    { 
        By searchBox = By.Id("twotabsearchtextbox");

        By searchBtn = By.Id("nav-search-submit-text");

        public void Search()
        {   
            WaitUntilElementIsVisible(searchBox);
            EnterText(searchBox, "Books");
            WaitUntilElementIsClickable(searchBtn);
            Click(searchBtn);       
        }
    }
}
