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
    public class ExcelImportDetails : BasePage
    {
        /// <summary>
        /// Objects for Import Details from Excel File page
        /// </summary>

        [FindsBy(How = How.CssSelector, Using = "#C1_FileUpload1")]
        private IWebElement btnBrowse { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#C1_btnUpload")]
        private IWebElement btnUpload { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#C1_btnSave1")]
        private IWebElement btnSave{ get; set; }

        

        public void ClickBrowse(string filePath)
        {
            btnBrowse.SendKeys(filePath);

        }

        /// <summary>
        /// Method to Click on Upload in Import Details from Excel File page
        /// </summary>

        public void ClickUpload()
        {
            btnUpload.Click();
        }

        /// <summary>
        /// Method to Click on Save in Import Details from Excel File page
        /// </summary>

        public void ClickSave()
        {
            btnSave.Click();
        }

        /// <summary>
        /// Method to Click on Back in Import Details from Excel File page
        /// </summary>

        


    }
}
