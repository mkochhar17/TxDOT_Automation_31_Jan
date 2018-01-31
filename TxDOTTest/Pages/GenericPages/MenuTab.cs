using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TxDOTAutomation.Base;
using TxDOTAutomation.Pages.LibraryPages;

namespace TxDOTAutomation.Pages.GenericPages
{
    public class MenuTab : BasePage
    {

        [FindsBy(How = How.Id, Using = "ExpandAll")]
        private IWebElement btnExpandAll { get; set; }


        /// <summary>
        /// The Method to click on the ExpandAll button
        /// </summary>
        /// <returns></returns>
        public void  ClickExpandAll()
        {
            btnExpandAll.Click();
            //return GetInstance<LibraryLeftPane>();
            //return new LibraryLeftPane();
        }
    }
}