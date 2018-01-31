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
    public class MenuBarOthers : BasePage
    {

        /// <summary>
        /// Objects for Top Menu Bar - Others
        /// </summary>
        
        [FindsBy(How = How.CssSelector, Using = "#MainToolBar_lnkImportExport")]
        private IWebElement btnExcelImportExport { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MainToolBar_RadRibbonBarControl']//div//div/div//a[@title = 'Excel Import']")]
        private IWebElement btnExcelImport { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MainToolBar_RadRibbonBarControl']//div//div/div//a[@title = 'Excel Export (xls)']")]
        private IWebElement btnExcelExportXls { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MainToolBar_RadRibbonBarControl']//div//div/div//a[@title = 'Excel Export (xlsx)']")]
        private IWebElement btnExcelExportXlsx { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MainToolBar_RadRibbonBarControl']//div//div/div//a[@title = 'Excel Template (xls)']")]
        private IWebElement btnExcelTemplateXls { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MainToolBar_RadRibbonBarControl']//div//div/div//a[@title = 'Excel Template (xlsx)']")]
        private IWebElement btnExcelTemplateXlsx { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MainToolBar_RadRibbonBarControl']//div//div/div//a[@title = 'Excel Template With Data (xls)']")]
        private IWebElement btnExcelTemplateWithDataXls { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MainToolBar_RadRibbonBarControl']//div//div/div//a[@title = 'Excel Template With Data (xlsx)']")]
        private IWebElement btnExcelTemplateWithDataXlsx { get; set; }


        /// <summary>
        /// Method to Click on Excel Import/Export
        /// </summary>
        public void ClickExcelImportExport()
        {
            btnExcelImportExport.Click();
        }


        /// <summary>
        /// Method to Click on Excel Import
        /// </summary>
        public ExcelImportDetails ClickExcelImport()
        {
            btnExcelImport.Click();
            return GetInstance<ExcelImportDetails>();

        }

        public void ClickExcelExportButtons(ExportType exportType)
        {
            switch (exportType)
            {
                case ExportType.ExcelExportXls:
                    btnExcelExportXls.Click();
                    break;
                case ExportType.ExcelExportXlsx:
                    btnExcelExportXlsx.Click();
                    break;
                case ExportType.ExcelTemplateXls:
                    btnExcelTemplateXls.Click();
                    break;
                case ExportType.ExcelTemplateXlsx:
                    btnExcelTemplateXlsx.Click();
                    break;
                case ExportType.ExcelTemplateWithDataXls:
                    btnExcelTemplateWithDataXls.Click();
                    break;
                case ExportType.ExcelTemplateWithDataXlsx:
                    btnExcelTemplateWithDataXlsx.Click();
                    break;
            }
        }


        //Constants for the type of export
        public enum ExportType
        {
            ExcelExportXls,
            ExcelExportXlsx,
            ExcelTemplateXls,
            ExcelTemplateXlsx,
            ExcelTemplateWithDataXls,
            ExcelTemplateWithDataXlsx
        }


        /// <summary>
        /// Method to Click on Excel Export(xls)
        /// </summary>
        public void ClickExcelExportXls()
        {
            btnExcelExportXls.Click();
        }


        /// <summary>
        /// Method to Click on Excel Export(xlsx)
        /// </summary>
        public void ClickExcelExportXlsx()
        {
            btnExcelExportXlsx.Click();
        }


        /// <summary>
        /// Method to Click on Excel Template(xls)
        /// </summary>
        public void ClickExcelTemplateXls()
        {
            btnExcelTemplateXls.Click();
        }


        /// <summary>
        /// Method to Click on Excel Template(xlsx)
        /// </summary>
        public void ClickExcelTemplateXlsx()
        {
            btnExcelTemplateXlsx.Click();
        }


        /// <summary>
        /// Method to Click on Excel Template with Data (xls)
        /// </summary>
        public void ClickExcelTemplateWithDataXls()
        {
            btnExcelTemplateWithDataXls.Click();
        }


        /// <summary>
        /// Method to Click on Excel Template with Data (xlsx)
        /// </summary>
        public void ClickExcelTemplateWithDataXlsx()
        {
            btnExcelTemplateWithDataXlsx.Click();
        }

    }
}
