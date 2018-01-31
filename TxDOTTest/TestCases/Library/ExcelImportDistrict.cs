using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TxDOTAutomation.Base;
using TxDOTAutomation.Helpers;
using TxDOTAutomation.Pages.GenericPages;
using TxDOTAutomation.Pages.LibraryPages;
using static TxDOTAutomation.Base.Browser;
using TxDOTTest.Pages.GenericPages;

namespace TxDOTTest.TestCases
{
    [TestClass]
    public class _TC_16481 : Base
    {
        string url = "https://phase1atxdotauto.masterworkslive.com/Modules/USRMGMT/Login.aspx";
        //string url = "https://txdotqaphase2.masterworkslive.com/";
        [TestMethod]
        public void TC_16481()
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
                CurrentPage = CurrentPage.As<DistrictListPage>().ClickExcelImportButton();
                CurrentPage.As<ExcelImportDetails>().ClickBrowse(@"D:\TXDOT_Local\TxDOTAutomation\TxDOTAutomation\TxDOTTest\ExcelData\LibraryNew\District.xlsx");
                CurrentPage.As<ExcelImportDetails>().ClickUpload();
                System.Threading.Thread.Sleep(1500);
                CurrentPage.As<ExcelImportDetails>().ClickSave();
                CurrentPage = GetInstance<DistrictListPage>().As<DistrictListPage>().ClickExcelImportBack();
                //CurrentPage.As<DistrictListPage>().ClickFirstCheckBox();
                //CurrentPage = CurrentPage.As<DistrictListPage>().ClickDistrictEdit();
                //CurrentPage.As<District>().ClickIsMetro();
                //CurrentPage = CurrentPage.As<District>().ClickEditSave();
                
            }
            

            catch (Exception e)
            {
                LogHelpers.Write("Test Failed" + e.Message);
            }

                     
        }
    }
}
