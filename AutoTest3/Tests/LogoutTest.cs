﻿// Generated by Selenium IDE
using AutoTest3.Data;
using NUnit.Framework;


namespace AutoTest3.Tests
{
    [TestFixture]
    public class LogoutTest : TestBase
    {
        UserData userData = new UserData("Admin@admin.admin", "a1s2d3f4");

        [Test]
        public void goToAdminPageTest()
        {
            ApplicationManager.NavigationHelper.GoToHomePage();
            ApplicationManager.NavigationHelper.GoToRegPage();
            ApplicationManager.NavigationHelper.ChangeRegPageToLogPage();
            ApplicationManager.LoginHelper.Login(userData);
            ApplicationManager.LoginHelper.Logout();
        }
    }
}

