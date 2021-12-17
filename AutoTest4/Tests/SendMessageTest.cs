using AutoTest4.Data;
using NUnit.Framework;

namespace AutoTest4.Tests
{
    public class SendMessageTest: TestBase
    {
        MessageData messageData = new MessageData("Hello from SendMessageTest!");
        UserData userData = new UserData("Admin@admin.admin", "a1s2d3f4");

        [Test]
        public void sendMessageTest()
        {
            ApplicationManager.NavigationHelper.GoToHomePage();
            ApplicationManager.NavigationHelper.GoToRegPage();
            ApplicationManager.NavigationHelper.ChangeRegPageToLogPage();
            ApplicationManager.LoginHelper.Login(userData);
            ApplicationManager.NavigationHelper.GoToBlogPage();
            ApplicationManager.NavigationHelper.GoToBlogPostPage();
            ApplicationManager.MessageHelper.SendMessage(messageData);
            ApplicationManager.LoginHelper.Logout();
        }
    }
}
