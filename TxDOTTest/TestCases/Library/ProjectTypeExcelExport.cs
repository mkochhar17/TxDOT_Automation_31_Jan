using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TxDOTAutomation.Base;
using TxDOTAutomation.Helpers;
using TxDOTAutomation.Pages.GenericPages;
using TxDOTAutomation.Pages.LibraryPages;
using static TxDOTAutomation.Base.Browser;
using TxDOTTest.Pages.GenericPages;
using System.Threading;
using static TxDOTTest.Pages.GenericPages.MenuBarOthers;
using TxDOTTest.Pages.LibraryPages;

namespace TxDOTTest.TestCases
{
    [TestClass]
    public class _TC_PROJECT_TYPE_EXCEL_EXPORT : Base
    {
        string url = "https://phase1atxdotauto.masterworkslive.com/";
        [TestMethod]
        public void TC_PROJECT_TYPE_EXCEL_EXPORT()
        {
            try
            {
                string fileName = Environment.CurrentDirectory.ToString() + "\\ExcelData\\LibraryNew\\Login.xlsx";
                ExcelHelpers.PopulateInCollection(fileName,"Sheet1");
                OpenBrowser(BrowserType.Chrome);
                //LogHelpers.Write("Opening the Chrome Browser");

                DriverContext.Browser.GoToUrl(url);
                CurrentPage = GetInstance<LoginPage>();
                CurrentPage = CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
                CurrentPage.As<LeftMenuBar>().ClickLibrary();
                CurrentPage = CurrentPage.As<LeftMenuBar>().ClickExpandTree();
                CurrentPage = CurrentPage.As<LibraryLeftPane>().ClickProjectType();
                DriverContext.Driver.SwitchTo().Frame("contentFrame");
                CurrentPage.As<ProjectTypeListPage>().ClickExcelImportExportButton();
                CurrentPage.As<ProjectTypeListPage>().ClickExcelExport(ExportType.ExcelExportXls);
            }


            catch (Exception e)
            {
                LogHelpers.Write("Test Failed" + e.Message);
            }

        }
    }
}
