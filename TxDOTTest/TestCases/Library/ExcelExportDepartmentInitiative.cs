using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxDOTAutomation.Base;
using TxDOTAutomation.Helpers;
using TxDOTAutomation.Pages.GenericPages;
using TxDOTAutomation.Pages.LibraryPages;
using TxDOTTest.Pages.GenericPages;
using TxDOTTest.Pages.LibraryPages;
using static TxDOTAutomation.Base.Browser;
using static TxDOTTest.Pages.GenericPages.MenuBarOthers;

namespace TxDOTTest.TestCases.Library
{
    [TestClass]
    public class _TC_6888_4 : Base
    {
        string url = "https://phase1atxdotauto.masterworkslive.com/Modules/USRMGMT/Login.aspx";

        [TestMethod]
        public void TC_6888_4()
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
                System.Threading.Thread.Sleep(1500);
                CurrentPage = CurrentPage.As<LibraryLeftPane>().ClickDepartmentInitiative();
                DriverContext.Driver.SwitchTo().Frame("contentFrame");
                System.Threading.Thread.Sleep(1500);
                CurrentPage.As<DepartmentInitiativeListPage>().ClickExcelImportExportButton();
                CurrentPage.As<DepartmentInitiativeListPage>().ClickExcelExport(ExportType.ExcelExportXls);



            }

            catch (Exception e)
            {
                LogHelpers.Write("Test Failed" + e.Message);
            }



        }
    }
}
