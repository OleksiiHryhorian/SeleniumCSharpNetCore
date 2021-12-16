using NUnit.Framework;
using SeleniumCSharpNetCore.Pages;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCore.Steps
{
    [Binding]
    public class LoginSteps
    {
        DriverHelper _driverHelper;
        LoginPage _loginPage;
        HomePage _homePage;

        public LoginSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            _loginPage = new LoginPage(_driverHelper.driver);
            _homePage = new HomePage(_driverHelper.driver);
        }

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driverHelper.driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"I click the login link")]
        public void GivenIClickTheLoginLink()
        {
            _homePage.ClickLogin();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            _loginPage.EnterUserNameAndPassword((string)data.UserName, (string)data.Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            _loginPage.ClickLogin();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Thread.Sleep(5000);
            Assert.That(_homePage.IsLogOffExist(), "User isn't logged in");
        }
    }
}
