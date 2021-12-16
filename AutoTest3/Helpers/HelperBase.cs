using OpenQA.Selenium;

namespace AutoTest3.Helpers
{
    public class HelperBase
    {
        protected IWebDriver driver;
        protected ApplicationManager applicationManager;
        
        public HelperBase(ApplicationManager applicationManager)
        {
            this.applicationManager = applicationManager;
            driver = applicationManager.Driver;
        }
    }
}
