using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TxDOTAutomation.Base;
using TxDOTAutomation.Helpers;
using TxDOTAutomation.Pages.GenericPages;
using TxDOTAutomation.Pages.LibraryPages;
using static TxDOTAutomation.Base.Browser;
using TxDOTTest.Pages.GenericPages;
using static TxDOTTest.Pages.GenericPages.MenuBarOthers;
using TxDOTTest.Pages.LibraryPages;

namespace TxDOTTest.TestCases
{
    [TestClass]
    public class _TC_6720_1 : Base
    {
        string url = "https://phase1atxdotauto.masterworkslive.com/Modules/USRMGMT/Login.aspx";
        //string url = "https://txdotqaphase2.masterworkslive.com/";
        [TestMethod]
        public void TC_6720_1()
        {
            try
            {
                string fileName = Environment.CurrentDirectory.ToString() + "\\ExcelData\\LibraryNew\\Login.xlsx";
                ExcelHelpers.PopulateInCollection(fileName, "sheet1");
                OpenBrowser(BrowserType.Chrome);
                //LogHelpers.Write("Opening the Chrome Browser");

                DriverContext.Browser.GoToUrl(url);
                CurrentPage = GetInstance<LoginPage>();
                CurrentPage = CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
                CurrentPage.As<LeftMenuBar>().ClickLibrary();
                CurrentPage = CurrentPage.As<LeftMenuBar>().ClickExpandTree();
                CurrentPage = CurrentPage.As<LibraryLeftPane>().ClickProjectClassification();
                DriverContext.Driver.SwitchTo().Frame("contentFrame");
                CurrentPage.As<ProjectClassificationListPage>().ClickExcelImportExportButton();
                CurrentPage.As<ProjectClassificationListPage>().ClickExcelExport(ExportType.ExcelExportXlsx);


            }


            catch (Exception e)
            {
                LogHelpers.Write("Test Failed" + e.Message);
            }


        }
    }
}
