using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxDOTAutomation.Base;

namespace TxDOTTest.Pages.GenericPages
{
    class SelectRecord : BasePage
    {

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_C1_MWGrid_ctl00_ctl04_MultiSelectCheckBox']")]
        private IWebElement checkFirst { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='TXLIBDV_IsEnabled_Id']")]
        private IWebElement checkIsEnabled { get; set; }

        public void ClickCheckFirst()
        {
            checkFirst.Click();
        }

        public void ClickIsEnabled()
        {
            checkIsEnabled.Click();
        }

    }
}
