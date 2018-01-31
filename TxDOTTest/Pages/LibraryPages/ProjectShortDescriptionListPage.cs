using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TxDOTAutomation.Base;
using TxDOTTest.Pages.GenericPages;

namespace TxDOTAutomation.Pages.LibraryPages
{
    public class ProjectShortDescriptionListPage : BasePage
    {

        [FindsBy(How = How.CssSelector, Using = "#ctl00_C1_MWGrid_ctl00")]
        private IWebElement tblProjectShortDescriptionList { get; set; }

        /// <summary>
        /// Method to click a New button which creates a New Project Short Description
        /// </summary>
        /// <returns>New Project Short Description page is returned </returns>
        public ProjectShortDescription ClickProjectShortDescriptionNew()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickNew();
            return GetInstance<ProjectShortDescription>();
            //return new ProjectShortDescriptionNew();
        }

        /// <summary>
        /// Method to Click on first record in ProjectShortDescription List page
        /// </summary>

        public void ClickFirstCheckBox()
        {
            GetInstance<SelectRecord>().As<SelectRecord>().ClickCheckFirst();


        }

        /// <summary>
        /// Method to Click on Edit button to Edit a ProjectShortDescription record
        /// </summary>
        /// <returns>Returns ProjectShortDescription Page</returns>

        public ProjectShortDescription ClickProjectShortDescriptionEdit()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickEdit();
            return GetInstance<ProjectShortDescription>();

        }

        /// <summary>
        /// Method to Click on Excel Import/Export button in Menu Bar - Others
        /// </summary>

        public void ClickExcelImportExportButton()
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelImportExport();
            //return GetInstance<ProjectShortDescriptionListPage>();
            //return new ProjectShortDescriptionNew();
        }

        /// <summary>
        /// Method to click on Excel Import button under Excel Import/Export in Menu bar - Others
        /// </summary>
        /// <returns> Returns Import Details from Excel File page</returns>

        public ExcelImportDetails ClickExcelImportButton()
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelImport();
            return GetInstance<ExcelImportDetails>();
            //return new ProjectShortDescriptionNew();
        }


        public IWebElement GetProjectShortDescriptionList()
        {
            return tblProjectShortDescriptionList;
        }

        /// <summary>
        /// Method to Click on Back button from Import Details from Excel File page
        /// </summary>
        /// <returns> Returns ProjectShortDescription List Page</returns>

        /*
        public ProjectShortDescriptionListPage ClickExcelImportBack()
        {
            GetInstance<ExcelImportDetails>().As<ExcelImportDetails>().ClickBack();
            return GetInstance<ProjectShortDescriptionListPage>();
            //return new ProjectShortDescriptionNew();
        }
        */

        /// <summary>
        /// Method to Click on Is Enabled box
        /// </summary>

        public void ClickProjectShortDescriptionIsEnabled()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickView();
            return;

        }


        public void ClickProjectShortDescriptionDelete()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickDelete();
            return;

        }
    }
}