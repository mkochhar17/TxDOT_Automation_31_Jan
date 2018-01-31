using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TxDOTAutomation.Base;
using TxDOTAutomation.Pages.GenericPages;
using TxDOTTest.Pages.LibraryPages;

namespace TxDOTAutomation.Pages.LibraryPages
{
    public class LibraryLeftPane : BasePage
    {

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='District']/nobr")]
        private IWebElement btnDistrict { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Division']/nobr")]
        private IWebElement btnDivision { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Project Type']/nobr")]
        private IWebElement btnProjectType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Project Sub Type']/nobr")]
        private IWebElement btnProjectSubType { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Project Classification']/nobr")]
        private IWebElement btnProjectClassification { get; set; }

       [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Project Short Description']/nobr")]
        private IWebElement btnProjectShortDescription { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id=aria-label='Strategic Transportation Objectives']/nobr")]
        private IWebElement btnStrategicTransporationObjectives { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id=aria-label='Agency Strategic Goals']/nobr")]
        private IWebElement btnAgencyStrategicGoals { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@aria-label='Department Initiative']/nobr")]
        private IWebElement btnDepartmentInitiative { get; set; }



        /// <summary>
        /// Clicks on the District button on the leftPane 
        /// </summary>
        /// <returns>District page appears</returns>



        public DistrictListPage ClickDistrict()
        {
            btnDistrict.Click();
            return GetInstance<DistrictListPage>();
            //return new District();
        }

        public DepartmentInitiativeListPage ClickDepartmentInitiative()
        {
            btnDepartmentInitiative.Click();
            return GetInstance<DepartmentInitiativeListPage>();

        }

        public ProjectClassificationListPage ClickProjectClassification()
        {
            btnProjectClassification.Click();
            return GetInstance<ProjectClassificationListPage>();
        }

    }
}