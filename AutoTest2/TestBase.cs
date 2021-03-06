// Generated by Selenium IDE
using AutoTest2.Data;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Threading;


namespace AutoTest2
{
    [TestFixture]
    public class TestBase
    {
        private IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(@"D:\");
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        protected void GoToAdminPage()
        {
            driver.FindElement(By.CssSelector(".nav-item:nth-child(5) > .nav-link")).Click();
        }

        protected void Login(UserData userData)
        {
            driver.FindElement(By.Id("Email")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Email")).SendKeys(userData.Email);
            driver.FindElement(By.Id("Password")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Password")).SendKeys(userData.Password);
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".btn")).Click();
        }

        protected void ChangeRegPageToLogPage()
        {
            driver.FindElement(By.Id("logRegSwitch")).Click();
        }

        protected void GoToRegPage()
        {
            driver.FindElement(By.CssSelector(".badge")).Click();
            Thread.Sleep(1000);
        }

        protected void GoToHomePage()
        {
            driver.Navigate().GoToUrl("http://autotests-itis-bet.herokuapp.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
        }


        protected void SendMessage(MessageData messageData)
        {
            driver.FindElement(By.Name("text")).Click();
            driver.FindElement(By.Name("text")).SendKeys(messageData.MessageText);
            driver.FindElement(By.CssSelector(".primary-btn")).Click();
        }

        protected void GoToBlogPostPage()
        {
            driver.FindElement(By.CssSelector(".post-corporate-title > a")).Click();
            Thread.Sleep(1000);
        }

        protected void GoToBlogPage()
        {
            driver.FindElement(By.CssSelector(".nav-item:nth-child(2) > .nav-link")).Click();
            Thread.Sleep(1000);
        }
    }
}

