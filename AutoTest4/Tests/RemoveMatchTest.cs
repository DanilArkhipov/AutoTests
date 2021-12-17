using AutoTest4.Data;
using NUnit.Framework;


namespace AutoTest4.Tests
{
    [TestFixture]
    public class RemoveMatchTest : TestBase
    {
        UserData userData = new UserData("Admin@admin.admin", "a1s2d3f4");

        [Test]
        public void deleteMatchTest()
        {
            ApplicationManager.NavigationHelper.GoToHomePage();
            ApplicationManager.NavigationHelper.GoToRegPage();
            ApplicationManager.NavigationHelper.ChangeRegPageToLogPage();
            ApplicationManager.LoginHelper.Login(userData);
            ApplicationManager.NavigationHelper.GoToAdminPage();
            ApplicationManager.NavigationHelper.GoToAdminMatchPage();
            ApplicationManager.MatchHelper.DeleteMatch();
            Assert.IsTrue(ApplicationManager.MatchHelper.CheckRemovedMatch());
            ApplicationManager.LoginHelper.Logout();
        }
    }
}