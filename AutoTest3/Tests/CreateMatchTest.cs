using AutoTest3.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTest3.Tests
{
    public class CreateMatchTest: TestBase
    {
        UserData userData = new UserData("Admin@admin.admin", "a1s2d3f4");
        MatchData matchData = new MatchData("TestTitle", "Football", "TestTournament",
            "Team1", "Team2", "2022-01-02T00:00", "5:1", "");

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
        }
    }
}
