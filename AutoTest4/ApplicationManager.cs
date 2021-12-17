using AutoTest4.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutoTest4
{
    public class ApplicationManager
    {
        private IWebDriver driver;
        private string baseURL;
        private IJavaScriptExecutor js;
        private Dictionary<string, object> vars;

        private NavigationHelper navigationHelper;
        private LoginHelper loginHelper;
        private MessageHelper messageHelper;
        private MatchHelper matchHelper;

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            driver = new ChromeDriver(@"D:\");
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            baseURL = "http://autotests-itis-bet.herokuapp.com/";
            navigationHelper = new NavigationHelper(this, baseURL);
            loginHelper = new LoginHelper(this);
            messageHelper = new MessageHelper(this);
            matchHelper = new MatchHelper(this);
        }

        public IWebDriver Driver => driver;
        public NavigationHelper NavigationHelper => navigationHelper;
        public LoginHelper LoginHelper => loginHelper;
        public MessageHelper MessageHelper => messageHelper;
        public MatchHelper MatchHelper => matchHelper;

        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.NavigationHelper.GoToHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }

        public void Stop()
        {
            driver.Quit();
        }

        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                //ignore
            }
        }

    }
}
