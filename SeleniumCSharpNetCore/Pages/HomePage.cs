using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCore.Pages
{
    public class HomePage
    {
        IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            this._driver = driver;
        }

        IWebElement lnkLogin => _driver.FindElement(By.LinkText("Login"));
        IWebElement lnkLogOff => _driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffExist() => lnkLogOff.Displayed;
    }
}
