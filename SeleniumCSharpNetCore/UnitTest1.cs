using NUnit.Framework;
using OpenQA.Selenium;
using WebDriverManager;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless");
            Driver = new ChromeDriver(options);
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_Meal']")).SendKeys("tomato");

            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']//following-sibling::div[text()='Celery']")).Click();


            CustomControl customControl = new(Driver);
            customControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            Assert.Pass();
        }
    }
}