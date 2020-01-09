using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject.PageObjects
{
    public class UserFormPage
    {
        private IWebDriver _driver;
        private By _userFormTitle = By.XPath("//p[contains(.,'This is a demo website')]");

        private By _initialField = By.Id("Initial");
        private By _firstNameField = By.Id("FirstName");
        private By _middleNameField = By.Id("MiddleName");

        private By _saveButton = By.Name("Save");

        public UserFormPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public bool IsBrowserOnUserFormPage()
        {
            try
            {
                _driver.FindElement(_userFormTitle);
                return true;
            }
            catch (WebDriverException)
            {
                throw new WebDriverException("User not on User form page as expected");
            }

        }

        public void EnterUserFormDetails(string initial, string firstName, string middleName)
        {
            try
            {
                _driver.FindElement(_initialField).SendKeys(initial);
                _driver.FindElement(_firstNameField).SendKeys(firstName);
                _driver.FindElement(_middleNameField).SendKeys(middleName);
            }
            catch (WebDriverException)
            {
                throw new WebDriverException("Error when entering details on user form page");
            }
        }

        public void ClickSaveButton()
        {
            try
            {
                _driver.FindElement(_saveButton).Click();
            }
            catch (WebDriverException)
            {
                throw new WebDriverException("Save button not found on user form page");
            }
        }
    }
}
