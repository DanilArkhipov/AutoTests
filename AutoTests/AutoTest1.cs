// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class UntitledTest
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
    [Test]
    public void untitled()
    {
        driver.Navigate().GoToUrl("http://autotests-itis-bet.herokuapp.com/RegLog");
        driver.Manage().Window.Size = new System.Drawing.Size(1536, 864);
        driver.FindElement(By.Id("logRegSwitch")).Click();
        driver.FindElement(By.Id("Email")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.Id("Email")).SendKeys("Admin@admin.admin");
        driver.FindElement(By.Id("Password")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.Id("Password")).SendKeys("a1s2d3f4");
        Thread.Sleep(1000);
        driver.FindElement(By.CssSelector(".btn")).Click();
        driver.FindElement(By.CssSelector(".nav-item:nth-child(5) > .nav-link")).Click();
    }
}

