using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCore
{
    public class CustomControl : DriverHelper
    {
        public CustomControl(IWebDriver Driver) : base()
        {
            this.driver = Driver;
        }

        public void ComboBox(string controlName, string value)
        {
            var comboControl = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboControl.Clear();
            comboControl.SendKeys(value);
            driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }
    }
}
