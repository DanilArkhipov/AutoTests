using AutoTest4.Data;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTest4.Tests
{
    public class EditMatchTest : TestBase
    {
        UserData userData = new UserData("Admin@admin.admin", "a1s2d3f4");
        MatchData matchData = new MatchData("TestTitleEdited", "", "TestTournamentEdited",
            "", "", "", "", "Active");

        [Test]
        public void editMatchTest()
        {
            ApplicationManager.NavigationHelper.GoToHomePage();
            ApplicationManager.NavigationHelper.GoToRegPage();
            ApplicationManager.NavigationHelper.ChangeRegPageToLogPage();
            ApplicationManager.LoginHelper.Login(userData);
            ApplicationManager.NavigationHelper.GoToAdminPage();
            ApplicationManager.NavigationHelper.GoToAdminMatchPage();
            ApplicationManager.NavigationHelper.GoToEditMatchPage();
            ApplicationManager.MatchHelper.UpdateMatch(matchData);
            ApplicationManager.NavigationHelper.GoToEditMatchPage();
            Assert.IsTrue(ApplicationManager.MatchHelper.CheckUpdatedMatchData(matchData));
            ApplicationManager.LoginHelper.Logout();
        }
    }
}
