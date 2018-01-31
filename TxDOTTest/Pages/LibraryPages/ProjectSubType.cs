using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TxDOTAutomation.Base;
using OpenQA.Selenium.Support.UI;

namespace TxDOTTest.Pages.LibraryPages
{
    public class ProjectSubType : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#LIBSBTY_ProjectType_Id")]
        private IWebElement txtProjectType { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#LIBSBTY_SubType_Id")]
        private IWebElement txtProjectSubType { get; set; }

        [FindsBy(How = How.Id, Using = "lnkSave")]
        private IWebElement btnSave { get; set; }


        public ProjectSubTypeListPage ClickProjectSubTypeSave(string projectTypeName, string projectSubTypeName)
        {
            SelectElement projectTypeNameString = new SelectElement(txtProjectType);
            projectTypeNameString.SelectByText(projectTypeName);
            txtProjectSubType.SendKeys(projectSubTypeName);
            btnSave.Click();

            return GetInstance<ProjectSubTypeListPage>();
            //return new Project Sub Type();
        }
    }
}
