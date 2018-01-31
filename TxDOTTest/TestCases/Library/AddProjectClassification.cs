using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TxDOTAutomation.Base;
using TxDOTAutomation.Helpers;
using TxDOTAutomation.Pages.GenericPages;
using TxDOTAutomation.Pages.LibraryPages;
using TxDOTTest.Pages.LibraryPages;
using static TxDOTAutomation.Base.Browser;

namespace TxDOTTest.TestCases.Library
{
    [TestClass]
    public class _TC_6697 : Base
    {
        string url = "https://phase1atxdotauto.masterworkslive.com/Modules/USRMGMT/Login.aspx";
        //string url = "https://txdotqaphase2.masterworkslive.com/";

        /// <summary>
        /// Test method to create a new Project Classification library Item.
        /// </summary>
        [TestMethod]
        public void TC_6697()
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
                System.Threading.Thread.Sleep(1500);
                CurrentPage = CurrentPage.As<ProjectClassificationListPage>().ClickProjectClassificationNew();
                //Random r = new Random();
                //CurrentPage = CurrentPage.As<District>().ClickDistrictSave(r.Next(90, 99).ToString(), "asdkfdsljk");
                fileName = Environment.CurrentDirectory.ToString() + "\\ExcelData\\LibraryNew\\Project Classification.xlsx";
                ExcelHelpers.PopulateInCollection(fileName, "Project Classification");
                CurrentPage = CurrentPage.As<ProjectClassification>().ClickProjectClassificationSave(ExcelHelpers.ReadData(1, "Code :"), ExcelHelpers.ReadData(1, "Name :"), ExcelHelpers.ReadData(1, "Project Type :"), ExcelHelpers.ReadData(1, "Project Sub Type :"), ExcelHelpers.ReadData(1, "Description :"), ExcelHelpers.ReadData(1, "Is Enabled :"));

            }

            catch (Exception e)
            {
                LogHelpers.Write("Test Failed" + e.Message);
            }

        }
    }
}




