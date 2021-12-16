using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumCSharpNetCore.Hooks
{
    [Binding]
    public class Hooks1
    {
        DriverHelper _driverHelper;

        public Hooks1(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            _driverHelper.driver = new ChromeDriver(options);
        }

        [AfterScenario]
        public void AfterScenario()
        { 
            _driverHelper.driver.Quit();
        }
    }
}
