using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxDOTAutomation.Base;
using TxDOTTest.Pages.GenericPages;

namespace TxDOTTest.Pages.LibraryPages
{
    public class ProjectClassification : BasePage
    {

        [FindsBy(How = How.CssSelector, Using = "#TXLIBPC_ClassificationName_Id")]
        private IWebElement txtCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#TXLIBPC_Description_Id")]
        private IWebElement txtName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#TXLIBPC_ProjectType_Id")]
        private IWebElement slctProjectType { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#TXLIBPC_ProjectSubType_Id")]
        private IWebElement slctProjectSubType { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#TXLIBPC_PCDescription_Id")]
        private IWebElement txtDescription { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#TXLIBPC_IsEnabled_Id")]
        private IWebElement checkIsEnabled { get; set; }

        [FindsBy(How = How.Id, Using = "lnkSave")]
        private IWebElement btnSave { get; set; }


        public ProjectClassificationListPage ClickProjectClassificationSave(string code, string name, string projectType, string projectSubType, string description, string isEnabled)
        {
            txtCode.SendKeys(code);
            txtName.SendKeys(name);
            slctProjectType.SendKeys(projectType);
            slctProjectSubType.SendKeys(projectSubType);
            txtDescription.SendKeys(description);
            checkIsEnabled.SendKeys(isEnabled);
            btnSave.Click();

            return GetInstance<ProjectClassificationListPage>();
            //return new District();
        }

    }
}
