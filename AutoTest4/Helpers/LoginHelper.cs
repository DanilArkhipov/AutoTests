using AutoTest4.Data;
using OpenQA.Selenium;
using System.Threading;

namespace AutoTest4.Helpers
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager applicationManager) : base(applicationManager) { }

        public void Login(UserData userData)
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

        public void Logout()
        {
            applicationManager.NavigationHelper.GoToHomePage();
            driver.FindElement(By.CssSelector(".badge")).Click();
        }

        public bool CheckLogout()
        {
            return driver.FindElement(By.CssSelector(".badge")).Text == "РЕГИСТРАЦИЯ";
        }
    }
}
