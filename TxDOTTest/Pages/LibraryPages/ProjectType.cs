using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TxDOTAutomation.Base;
using TxDOTTest.Pages.GenericPages;

namespace TxDOTTest.Pages.LibraryPages
{
    public class ProjectType : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#LIBPJTY_Type_Id")]
        private IWebElement txtProjectType { get; set; }


        [FindsBy(How = How.Id, Using = "lnkSave")]
        private IWebElement btnSave { get; set; }



        public ProjectTypeListPage ClickProjectTypeSave(string projectTypeName)
        {
            txtProjectType.SendKeys(projectTypeName);
            btnSave.Click();

            return GetInstance<ProjectTypeListPage>();
            //return new District();
        }

    }
}
