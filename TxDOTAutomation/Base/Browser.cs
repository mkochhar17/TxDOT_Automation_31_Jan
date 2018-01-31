using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace TxDOTAutomation.Base
{
    /// <summary>
    /// Class which consists of all the enum constants of browser type which we can use
    /// Default browser is set to FireFox
    /// </summary>
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public BrowserType Type { get; set; }


        /// <summary>
        /// Method to simplyfy the access of the URL
        /// " DriverContext.Browser.GoToUrl(url)"
        /// </summary>
        /// <param name="url"></param>
        public void GoToUrl(String url)
        {
            DriverContext.Driver.Url = url;
        }


        /// <summary>
        /// Method to choose the browser type.
        /// Default is Firefox
        /// Use "OpenBrowser(BrowserType.Chrome);" specify which ever browser you want
        /// </summary>
        /// <param name="browserType"></param>
        public static void OpenBrowser(BrowserType browserType = BrowserType.FireFox)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }

        //Constants for the browser type
        public enum BrowserType
        {
            InternetExplorer,
            FireFox,
            Chrome
        }


    }
}
