using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TxDOTAutomation.Base;
using TxDOTTest.Pages.GenericPages;


namespace TxDOTAutomation.Pages.LibraryPages
{
    public class ProjectShortDescription : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#LIBPJSD_ReferenceID_Id")]
        private IWebElement txtReferenceId { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#LIBPJSD_ShortDescription_Id")]
        private IWebElement txtShortDescriptionId { get; set; }

        [FindsBy(How = How.Id, Using = "lnkSave")]
        private IWebElement btnSave { get; set; }

        /// <summary>
        /// Method to click and save the newly created Project Short Description
        /// </summary>
        /// <param name="referenceID_Id"></param>
        /// <param name="shortdescriptionID_Id"></param>
        /// <returns>Division page is returned</returns>
        public ProjectShortDescriptionListPage ClickProjectShortDescriptionSave(string referenceID_Id, string shortdescriptionID_Id)
        {
            txtReferenceId.SendKeys(referenceID_Id);
            txtShortDescriptionId.SendKeys(shortdescriptionID_Id);
            btnSave.Click();

            return GetInstance<ProjectShortDescriptionListPage>();
            //return new ProjectShortDescription();
        }

        public void ClickIsEnabled()
        {
            GetInstance<SelectRecord>().As<SelectRecord>().ClickIsEnabled();

        }

        public ProjectShortDescriptionListPage ClickEditSave()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickSave();
            return GetInstance<ProjectShortDescriptionListPage>();
        }

        internal BasePage ClickProjectShortDescpriptionSave(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}