// Generated by Selenium IDE
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;


namespace AutoTest3.Tests
{
    [TestFixture]
    public class TestBase
    {
        private ApplicationManager applicationManager;

        public ApplicationManager ApplicationManager => applicationManager;

        [SetUp]
        public void SetUp()
        {
            applicationManager = new ApplicationManager();
        }
        [TearDown]
        protected void TearDown()
        {
            applicationManager.Stop();
        }
    }
}

