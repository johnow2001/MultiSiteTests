using MyStoreSpecflowTest.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace MyStoreSpecflowTest.Hooks
{
    [Binding]
    class Hooks
    {
        private IWebDriver driver;
        public Hooks(DriverContext driverContext)
        {
            this.driver = driverContext.Driver;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
