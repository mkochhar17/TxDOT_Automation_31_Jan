using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TxDOTAutomation.Base;
using TxDOTAutomation.Helpers;
using TxDOTAutomation.Pages.GenericPages;
using TxDOTAutomation.Pages.LibraryPages;
using static TxDOTAutomation.Base.Browser;
using TxDOTTest.Pages.GenericPages;
using static TxDOTTest.Pages.GenericPages.MenuBarOthers;

namespace TxDOTTest.TestCases
{
    [TestClass]
    public class _TC_16481_2 : Base
    {
        string url = "https://phase1atxdotauto.masterworkslive.com/Modules/USRMGMT/Login.aspx";
        //string url = "https://txdotqaphase2.masterworkslive.com/";
        [TestMethod]
        public void TC_16481_2()
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
                CurrentPage = CurrentPage.As<LibraryLeftPane>().ClickDistrict();
                DriverContext.Driver.SwitchTo().Frame("contentFrame");
                CurrentPage.As<DistrictListPage>().ClickExcelImportExportButton();
                CurrentPage.As<DistrictListPage>().ClickExcelExport(ExportType.ExcelExportXls);


            }


            catch (Exception e)
            {
                LogHelpers.Write("Test Failed" + e.Message);
            }


        }
    }
}
