using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TxDOTAutomation.Base
{
    /// <summary>
    /// Generic class to create an instance of a page
    /// This helps in keeping track of the current page we are working on
    /// Call "GetInstance<whicheverwebpage>();"
    /// store it in "CurrentPage" like ""CurrentPage = GetInstance<whicheverwebpage>()"
    /// </summary>
    public class Base
    {
        public BasePage CurrentPage { get; set; }

        private IWebDriver _driver { get; set; }

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver

            };
            PageFactory.InitElements(DriverContext.Driver, pageInstance);
            return pageInstance;
        }

        /// <summary>
        ///Specify the methods in the page by using
        ///"CurrentPage.As<LeftMenuBar>().ClickLibrary();"
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        /// <returns></returns>
        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
