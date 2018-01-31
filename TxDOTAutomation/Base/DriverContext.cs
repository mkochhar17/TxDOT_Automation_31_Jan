using OpenQA.Selenium;

namespace TxDOTAutomation.Base
{

    /// <summary>
    /// Class to take care of driver initialization 
    /// You dont have to do private IWebDriver driver; all the time.
    /// you can just call "DriverContext.Driver" to use driver object
    /// </summary>
    public static class DriverContext
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }

        public static Browser Browser { get; set; }

    }
}
