using AutoTest4.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTest4.Tests
{
    public class CreateMatchTest: TestBase
    {
        UserData userData = new UserData("Admin@admin.admin", "a1s2d3f4");
        MatchData matchData = new MatchData("TestTitle", "Football", "TestTournament",
            "Team1", "Team2", "20-01-2022 12:00:00", "5:1", "");

        [Test]
        public void createMatchTest()
        {
            ApplicationManager.NavigationHelper.GoToHomePage();
            ApplicationManager.NavigationHelper.GoToRegPage();
            ApplicationManager.NavigationHelper.ChangeRegPageToLogPage();
            ApplicationManager.LoginHelper.Login(userData);
            ApplicationManager.NavigationHelper.GoToAdminPage();
            ApplicationManager.NavigationHelper.GoToAdminMatchPage();
            ApplicationManager.NavigationHelper.GoToAddMatchPage();
            ApplicationManager.MatchHelper.CreateMatch(matchData);
            Assert.IsTrue(ApplicationManager.MatchHelper.CheckCreatedMatch());
            ApplicationManager.LoginHelper.Logout();
        }
    }
}
