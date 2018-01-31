using OpenQA.Selenium.Support.PageObjects;

namespace TxDOTAutomation.Base
{
    /// <summary>
    /// Abstract class which initialize the WEB PAGES which use PageFactory
    /// </summary>
    public abstract class BasePage : Base
    {
        
        /// <summary>
        /// Constructor to Initialize the page with PageFactory
        /// </summary>
        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }

    }
}
