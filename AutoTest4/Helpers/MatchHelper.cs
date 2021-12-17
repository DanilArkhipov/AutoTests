using AutoTest4.Data;
using OpenQA.Selenium;
using System.Threading;

namespace AutoTest4.Helpers
{
    public class MatchHelper : HelperBase
    {
        public MatchHelper(ApplicationManager applicationManager) : base(applicationManager) { }

        public void CreateMatch(MatchData matchData)
        {
            driver.FindElement(By.Id("Title")).Click();
            driver.FindElement(By.Id("Title")).SendKeys(matchData.Title);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Sport")).Click();
            {
                var dropdown = driver.FindElement(By.Id("Sport"));
                dropdown.FindElement(By.XPath(string.Format("//option[. = '{0}']", matchData.Sport))).Click();
            }
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Tournament")).Click();
            driver.FindElement(By.Id("Tournament")).SendKeys(matchData.Tournament);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Team1")).Click();
            driver.FindElement(By.Id("Team1")).SendKeys(matchData.Team1);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Team2")).Click();
            driver.FindElement(By.Id("Team2")).SendKeys(matchData.Team2);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Date")).Click();
            driver.FindElement(By.Id("Date")).SendKeys(matchData.Date);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Result")).Click();
            driver.FindElement(By.Id("Result")).SendKeys(matchData.Result);
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".btn")).Click();
        }

        public void UpdateMatch(MatchData matchData)
        {
            driver.FindElement(By.Id("Title")).Clear();
            driver.FindElement(By.Id("Title")).Click();
            driver.FindElement(By.Id("Title")).SendKeys(matchData.Title);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Tournament")).Clear();
            driver.FindElement(By.Id("Tournament")).Click();
            driver.FindElement(By.Id("Tournament")).SendKeys(matchData.Tournament);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("Status")).Click();
            {
                var dropdown = driver.FindElement(By.Id("Status"));
                dropdown.FindElement(By.XPath(string.Format("//option[. = '{0}']", matchData.Status))).Click();
            }
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".btn")).Click();
        }

        public void DeleteMatch()
        {
            driver.FindElement(By.CssSelector("tr:nth-child(1) .fa-trash")).Click();
        }

        public bool CheckUpdatedMatchData(MatchData matchData)
        {
            if (driver.FindElement(By.Id("Title")).GetAttribute("value") != matchData.Title) return false;
            if (driver.FindElement(By.Id("Tournament")).GetAttribute("value") != matchData.Tournament) return false;
            return true;
        }

        public bool CheckCreatedMatch()
        {
            return driver.FindElement(By.CssSelector("tr:nth-child(1) .fa-pen")) != null;
        }

        public bool CheckRemovedMatch()
        {
            try
            {
                driver.FindElement(By.CssSelector("tr:nth-child(1) .fa-pen"));
            }
            catch
            {
                return true;
            }
            return false;

        }
    }
}
