using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage
    {
        IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement txtUserName => _driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => _driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => _driver.FindElement(By.XPath("//input[@class = 'btn btn-default']"));

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
