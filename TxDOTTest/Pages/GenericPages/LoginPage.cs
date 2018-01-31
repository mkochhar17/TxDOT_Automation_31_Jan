using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TxDOTAutomation.Base;

namespace TxDOTAutomation.Pages.GenericPages
{
    //Interits the page factory initialization in Initializer.cs
    public class LoginPage : BasePage
    {

        //Objects for the Login Page
        [FindsBy(How = How.Id, Using = "txtUserID")]
        private IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "txtPassword")]
        private IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "btnLogin")]
        private IWebElement btnLogin { get; set; }

        /// <summary>
        /// Method to login. 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>Left Menu Bar page is returned</returns>
        public LeftMenuBar Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Click();

            return GetInstance<LeftMenuBar>();
            //return new LeftMenuBar(); 
        }
    }
}
