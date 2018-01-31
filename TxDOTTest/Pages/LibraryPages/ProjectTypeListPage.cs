using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TxDOTAutomation.Base;
using TxDOTTest.Pages.GenericPages;
using static TxDOTTest.Pages.GenericPages.MenuBarOthers;

namespace TxDOTTest.Pages.LibraryPages
{
    public class ProjectTypeListPage : BasePage
    {
        /*
        [FindsBy(How = How.CssSelector, Using = "#ctl00_C1_MWGrid_ctl00")]
        private IWebElement tblProjectTypeList { get; set; }
        */


        public ProjectType ClickProjectTypeNew()
        {
            GetInstance<MenuBarGeneral>().As<MenuBarGeneral>().ClickNew();
            return GetInstance<ProjectType>();
        }

        /*
        public IWebElement GetProjectTypeList()
        {
            return tblProjectTypeList;
        }
        */

        public void ClickExcelImportExportButton()
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelImportExport();
            //return GetInstance<ProjectTypeListPage>();
            //return new ProjectTypeNew();
        }


        public ExcelImportDetails ClickExcelImportButton()
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelImport();
            return GetInstance<ExcelImportDetails>();
            //return new ProjectTypeNew();
        }

        public void ClickExcelExport(ExportType exportType)
        {
            GetInstance<MenuBarOthers>().As<MenuBarOthers>().ClickExcelExportButtons(exportType);
            //return GetInstance<ExcelImportDetails>();
            //return new ProjectTypeNew();
        }
    }
}
