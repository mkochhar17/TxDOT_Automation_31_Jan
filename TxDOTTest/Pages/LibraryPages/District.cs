using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TxDOTAutomation.Base;
using TxDOTTest.Pages.GenericPages;

namespace TxDOTAutomation.Pages.LibraryPages
{
    public class District : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#LIBDIST_Code_Id")]
        private IWebElement txtDistrictNumber { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#LIBDIST_Name_Id")]
        private IWebElement txtDistrictName { get; set; }

        [FindsBy(How = How.Id, Using = "lnkSave")]
        private IWebElement btnSave { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='LIBDIST_IsEnabled_Id']")]
        private IWebElement checkIsEnabled { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='LIBDIST_IsMetro_Id']")]
        private IWebElement checkIsMetro { get; set; }


        public void ClickIsMetro()
        {
            checkIsMetro.Click();
        }

        /// <summary>
        /// Method to click and save the newly created District
        /// </summary>
        /// <param name="districtNumber"></param>
        /// <param name="districtName"></param>
        /// <returns>District page is returned</returns>
        public DistrictListPage ClickDistrictSave(string districtNumber, string districtName)
        {
            txtDistrictNumber.SendKeys(districtNumber);
            txtDistrictName.SendKeys(districtName);
            btnSave.Click();

            return GetInstance<DistrictListPage>();
            //return new District();
        }

        
        public DistrictListPage ClickEditSave()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickSave();
            return GetInstance<DistrictListPage>();
        }
    }
}