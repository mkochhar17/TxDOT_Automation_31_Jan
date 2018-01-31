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
    public class DepartmentInitiative : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#LIBDPIN_Initiative_Id")]
        private IWebElement txtInitiative { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#LIBDPIN_Description_Id")]
        private IWebElement txtDescription { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#LIBDPIN_IsActive_Id")]
        private IWebElement clickIsEnabled { get; set; }
       

        public DepartmentInitiativeListPage DepartmentInitiativeData(string initiative, string description)
        {
            txtInitiative.SendKeys(initiative);
            txtDescription.SendKeys(description);
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickSave();
            return GetInstance<DepartmentInitiativeListPage>();
            //return new District();
        }

        public void ClickIsEnabled()
        {
            clickIsEnabled.Click();


        }



        public DepartmentInitiativeListPage ClickEditSave()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickSave();
            return GetInstance<DepartmentInitiativeListPage>();
        }
    }
}
