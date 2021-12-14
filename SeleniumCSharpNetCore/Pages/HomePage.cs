using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCore.Pages
{
    public class HomePage : DriverHelper
    {
        public HomePage(IWebDriver driver) : base()
        {
            this.driver = driver;
        }

        IWebElement lnkLogin => driver.FindElement(By.LinkText("Login"));
        IWebElement lnkLogOff => driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffExist() => lnkLogOff.Displayed;
    }
}
