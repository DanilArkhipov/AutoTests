using OpenQA.Selenium;
using System.Threading;

namespace AutoTest3.Helpers
{
    public class NavigationHelper : HelperBase
    {
        private string _baseUrl;
        public NavigationHelper(ApplicationManager applicationManager, string baseUrl) : base(applicationManager)
        {
            _baseUrl = baseUrl;
        }
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(_baseUrl);
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }
        public void GoToRegPage()
        {
            driver.FindElement(By.CssSelector(".badge")).Click();
            Thread.Sleep(1000);
        }

        public void ChangeRegPageToLogPage()
        {
            driver.FindElement(By.Id("logRegSwitch")).Click();
        }

        public void GoToBlogPostPage()
        {
            driver.FindElement(By.CssSelector(".post-corporate-title > a")).Click();
            Thread.Sleep(1000);
        }

        public void GoToBlogPage()
        {
            driver.FindElement(By.CssSelector(".nav-item:nth-child(2) > .nav-link")).Click();
            Thread.Sleep(1000);
        }

        public void GoToAdminPage()
        {
            driver.FindElement(By.CssSelector(".nav-item:nth-child(5) > .nav-link")).Click();
        }

        public void GoToAdminMatchPage()
        {
            driver.FindElement(By.LinkText("Матчи")).Click();
            Thread.Sleep(1000);
        }

        public void GoToAddMatchPage()
        {
            driver.FindElement(By.LinkText("Добавить")).Click();
            Thread.Sleep(1000);
        }

        public void GoToEditMatchPage()
        {
            driver.FindElement(By.CssSelector("tr:nth-child(1) .fa-pen")).Click();
            Thread.Sleep(1000);
        }
    }
}
