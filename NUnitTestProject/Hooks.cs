using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using TechTalk.SpecFlow;

namespace SpecflowParallelTests
{
    [Binding]
    public class Hooks
    {

        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Initialize()
        {

            ChromeOptions chromeOptions = new ChromeOptions();

            _driver = new RemoteWebDriver(new Uri("http://192.168.1.112:44444/wd/hub"), chromeOptions.ToCapabilities());
            

            //_driver = new FirefoxDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);

        }

        [AfterScenario]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}
