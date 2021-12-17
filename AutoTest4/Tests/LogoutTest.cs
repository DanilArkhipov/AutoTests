﻿// Generated by Selenium IDE
using AutoTest4.Data;
using NUnit.Framework;


namespace AutoTest4.Tests
{
    [TestFixture]
    public class LogoutTest : TestBase
    {
        UserData userData = new UserData("Admin@admin.admin", "a1s2d3f4");

        [Test]
        public void logoutTest()
        {
            ApplicationManager.NavigationHelper.GoToHomePage();
            ApplicationManager.NavigationHelper.GoToRegPage();
            ApplicationManager.NavigationHelper.ChangeRegPageToLogPage();
            ApplicationManager.LoginHelper.Login(userData);
            ApplicationManager.LoginHelper.Logout();
            Assert.IsTrue(ApplicationManager.LoginHelper.CheckLogout());
        }
    }
}

