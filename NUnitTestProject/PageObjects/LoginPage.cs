using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject.PageObjects
{
    public class LoginPage
    {

        private IWebDriver _driver;
        private By _userNameField = By.Name("UserName");
        private By _password = By.Name("Password");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void EnterLoginDetails(string userName, string password)
        {
            try
            {
                _driver.FindElement(_userNameField).SendKeys(userName);
                _driver.FindElement(_password).SendKeys(password);
            }
            catch (WebDriverException)
            {
                throw new WebDriverException("Error when entering user name or password");
            }
        }

        public UserFormPage SubmitLogin()
        {
            try
            {
                _driver.FindElement(By.Name("Login")).Submit();

                return new UserFormPage(_driver);
            }
            catch (WebDriverException)
            {
                throw new WebDriverException("Unable to find Login button");
            }
        }

    }
}
