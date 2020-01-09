using NUnit.Framework;
using OpenQA.Selenium;
using NUnitTestProject.PageObjects;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NUnitTestProject.Steps
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;
        private UserFormPage _userFormPage;


        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Given(@"I enter username (.*) and password (.*)")]
        public void GivenIEnterUsernameAndPassword(string userName, string password)
        {
            _loginPage = new LoginPage(_driver);
            _loginPage.EnterLoginDetails(userName, password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            System.Threading.Thread.Sleep(15000);
            _loginPage.SubmitLogin();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            _userFormPage = new UserFormPage(_driver);
            Assert.IsTrue(_userFormPage.IsBrowserOnUserFormPage(), "Log in unsuccessful");
        }

        [Then(@"The test is marked as inconclusive")]
        public void ThenTheTestIsMarkedAsInconclusive()
        {
            Assert.Inconclusive();
        }

    }
}
