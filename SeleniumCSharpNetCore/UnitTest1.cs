using NUnit.Framework;
using OpenQA.Selenium;
using WebDriverManager;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager.DriverConfigs.Impl;
using SeleniumCSharpNetCore.Pages;
using SeleniumCSharpNetCore.Steps;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--headless");
            driver = new ChromeDriver(options);
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_Meal']")).SendKeys("tomato");

            driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']//following-sibling::div[text()='Celery']")).Click();


            CustomControl customControl = new(driver);
            customControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");
            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);

            homePage.ClickLogin();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();

            Assert.That(homePage.IsLogOffExist(), "User isn't logged in");
        }
    }
}
