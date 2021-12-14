using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage : DriverHelper
    {
        public LoginPage(IWebDriver driver) : base()
        {
            this.driver = driver;
        }

        IWebElement txtUserName => driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => driver.FindElement(By.XPath("//input[@class = 'btn btn-default']"));

        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }
        
        public void ClickLogin()
        {            
            btnLogin.Click();
        }
    }
}
