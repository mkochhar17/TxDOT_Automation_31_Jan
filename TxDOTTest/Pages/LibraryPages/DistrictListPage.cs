using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TxDOTAutomation.Base;
using TxDOTTest.Pages.GenericPages;
using static TxDOTTest.Pages.GenericPages.MenuBarOthers;

namespace TxDOTAutomation.Pages.LibraryPages
{
    public class DistrictListPage : BasePage
    {

        [FindsBy(How = How.CssSelector, Using = "#ctl00_C1_MWGrid_ctl00")]
        private IWebElement tblDistrictList { get; set; }



        /// <summary>
        /// Method to click a New button which creates a New District
        /// </summary>
        /// <returns>New district page is returned </returns>
        public District ClickDepartmentInitiativeNew()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickNew();
            return GetInstance<District>();
            //return new DistrictNew();
        }

        /// <summary>
        /// Method to Click on first record in District List page
        /// </summary>

        public void ClickFirstCheckBox()
        {
            GetInstance<SelectRecord>().As<SelectRecord>().ClickCheckFirst();


        }

        /// <summary>
        /// Method to Click on Edit button to Edit a district record
        /// </summary>
        /// <returns>Returns District Page</returns>

        public District ClickDistrictEdit()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickEdit();
            return GetInstance<District>();
            
        }

        /// <summary>
        /// Method to click on "Is Metro" while editing the District record
        /// </summary>

                
        /// <summary>
        /// Method to Click on Excel Import/Export button in Menu Bar - Others
        /// </summary>
       
        public  void ClickExcelImportExportButton()
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelImportExport();
            //return GetInstance<DistrictListPage>();
            //return new DistrictNew();
        }

        public void ClickExcelExport(ExportType exportType)
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelExportButtons(exportType);
            //return GetInstance<ExcelImportDetails>();
            //return new DistrictNew();
        }

        /// <summary>
        /// Method to click on Excel Import button under Ecel Import/Export in Menu bar - Others
        /// </summary>
        /// <returns> Returns Import Details from Excel File page</returns>

        public ExcelImportDetails ClickExcelImportButton()
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelImport();
            return GetInstance<ExcelImportDetails>();
            //return new DistrictNew();
        }


        public void ClickDistrictDelete()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickDelete();
            return;

        }


        /// <summary>
        /// Method to Click on Back button from Import Details from Excel File page
        /// </summary>
        /// <returns> Returns District List Page</returns>

        public DistrictListPage ClickExcelImportBack()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickBack();
            return GetInstance<DistrictListPage>();
            //return new DistrictNew();
        }

        


    }
}