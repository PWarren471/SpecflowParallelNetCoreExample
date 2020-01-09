using OpenQA.Selenium;
using NUnitTestProject.PageObjects;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowParallelTests.Steps
{
    [Binding]
    public class UserFormSteps
    {
        private IWebDriver _driver;
        private UserFormPage _userFormPage;


        public UserFormSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I start entering user form details with initial (.*) first name (.*) and middle name (.*)")]
        public void GivenIStartEnteringUserFormDetailsLike(string initial, string firstName, string middleName)
        {
            _userFormPage = new UserFormPage(_driver);

            _userFormPage.EnterUserFormDetails(initial, firstName, middleName);
            System.Threading.Thread.Sleep(3000);
        }

        [Given(@"I click submit button")]
        public void GivenIClickSubmitButton()
        {
            _userFormPage.ClickSaveButton();
        }


    }
}
