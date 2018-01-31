using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TxDOTAutomation.Base;
using TxDOTAutomation.Pages.LibraryPages;

namespace TxDOTAutomation.Pages.GenericPages
{
    /// <summary>
    /// This Page contains objects initialized for the buttons and Dashboards on the HomePage.
    /// The buttons are Home, Planning,Projects, RightOfWay, LandBank, Library, Administrator
    /// </summary>
   
    public class LeftMenuBar : BasePage
    {
      
        [FindsBy(How = How.XPath, Using = ".//*[@id='MenuTabsUL']//li//a//span[contains(text(),'Home')]")]
        private IWebElement btnHome { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='MenuTabsUL']//li//a//span[contains(text(),'Planning')]")]
        private IWebElement btnPlanning { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='MenuTabsUL']//li//a//span[contains(text(),'Projects')]")]
        private IWebElement btnProjects { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='MenuTabsUL']//li//a//span[contains(text(),'Right of Way')]")]
        private IWebElement btnRightOfWay { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='MenuTabsUL']//li//a//span[contains(text(),'Land Bank')]")]
        private IWebElement btnLandBank { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='MenuTabsUL']//li//a//span[contains(text(),'Library')]")]
        private IWebElement btnLibrary { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='MenuTabsUL']//li//a//span[contains(text(),'Administration')]")]
        private IWebElement btnAdministrator { get; set; }

        /// <summary>
        /// Method clicks on the library.
        /// </summary>
        /// <returns>The menu tab page</returns>
        public void ClickLibrary()
        {
            btnLibrary.Click();
            //return GetInstance<LibraryLeftPane>();
            //return new MenuTab();
        }

        public LibraryLeftPane ClickExpandTree()
        {
            GetInstance<MenuTab>().As<MenuTab>().ClickExpandAll();
            return GetInstance<LibraryLeftPane>();
            //return new District();
        }
    }
}
