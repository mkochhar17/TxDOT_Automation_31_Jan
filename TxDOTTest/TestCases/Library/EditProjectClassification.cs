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
    public class _TC_6704 : Base
    {
        string url = "https://phase1atxdotauto.masterworkslive.com/Modules/USRMGMT/Login.aspx";
        //string url = "https://txdotqaphase2.masterworkslive.com/";

        /// <summary>
        /// Test method to edit a new Project Classification library Item.
        /// </summary>
        [TestMethod]
        public void TC_6704()
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
                CurrentPage.As<ProjectClassificationListPage>().ClickFirstCheckBox();
                CurrentPage = CurrentPage.As<ProjectClassificationListPage>().ClickProjectClassificationEdit();
                fileName = Environment.CurrentDirectory.ToString() + "\\ExcelData\\LibraryNew\\Project Classification.xlsx";
                ExcelHelpers.PopulateInCollection(fileName, "Project Classification");
                CurrentPage = CurrentPage.As<ProjectClassification>().ClickProjectClassificationSave(ExcelHelpers.ReadData(2, "Code :"), ExcelHelpers.ReadData(2, "Name :"), ExcelHelpers.ReadData(2, "Project Type :"), ExcelHelpers.ReadData(2, "Project Sub Type :"), ExcelHelpers.ReadData(2, "Description :"), ExcelHelpers.ReadData(2, "Is Enabled :"));






            }

            catch (Exception e)
            {
                LogHelpers.Write("Test Failed" + e.Message);
            }

        }
    }
}




