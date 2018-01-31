using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TxDOTAutomation.Base;
using TxDOTAutomation.Helpers;
using TxDOTAutomation.Pages.GenericPages;
using TxDOTAutomation.Pages.LibraryPages;
using static TxDOTAutomation.Base.Browser;

namespace TxDOTTest.TestCases.Library
{
    [TestClass]
    public class _TC_8605_1 : Base
    {
        string url = "https://phase1atxdotauto.masterworkslive.com/Modules/USRMGMT/Login.aspx";
        //string url = "https://txdotqaphase2.masterworkslive.com/";

        /// <summary>
        /// Test method to Delete a new District.
        /// </summary>
        [TestMethod]
        public void TC_8605_1()
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
                System.Threading.Thread.Sleep(1500);
                CurrentPage.As<DistrictListPage>().ClickFirstCheckBox(); 
                CurrentPage.As<DistrictListPage>().ClickDistrictDelete();
                System.Threading.Thread.Sleep(1500);
                IAlert simpleAlert = DriverContext.Driver.SwitchTo().Alert(); //Dismiss the alert
                simpleAlert.Dismiss();
                CurrentPage.As<DistrictListPage>().ClickDistrictDelete(); //Click Delete again
                //Need a sleep statement here 
                DriverContext.Driver.SwitchTo().Alert(); //Accept the alert
                simpleAlert.Accept();
                                                
            }

            catch (Exception e)
            {
                LogHelpers.Write("Test Failed" + e.Message);
            }

        }
    }
}




