using AutoTest4.Data;
using OpenQA.Selenium;

namespace AutoTest4.Helpers
{
    public class MessageHelper : HelperBase
    {
        public MessageHelper(ApplicationManager applicationManager) : base(applicationManager) { }

        public void SendMessage(MessageData messageData)
        {
            driver.FindElement(By.Name("text")).Click();
            driver.FindElement(By.Name("text")).SendKeys(messageData.MessageText);
            driver.FindElement(By.CssSelector(".primary-btn")).Click();
        }
    }
}
