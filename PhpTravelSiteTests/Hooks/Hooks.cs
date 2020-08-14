using OpenQA.Selenium;
using PhpTravelSiteTests.Contexts;
using System;
using TechTalk.SpecFlow;

namespace PhpTravelSiteTests.Hooks
{
    [Binding]
    class Hooks
    {
        public IWebDriver Driver { get; set; }
        public Hooks(WebDriverContext driverContext)
        {
            this.Driver = driverContext.driver;
        }

        [BeforeScenario]
        public void ScenarioInfo(ScenarioContext scenarioContext)
        {
            Console.WriteLine($"Starting scenario : {scenarioContext.ScenarioInfo.Title}");
            scenarioContext.TryAdd("Obj1", "11111");
            scenarioContext.TryAdd("Obj2", 2222);
        }

        [AfterScenario]
        public void CloseBrowser(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError != null)
            {
                Console.WriteLine($"Scenario error = {scenarioContext.TestError.Message}");
            }

            Driver.Quit();
            var keys = scenarioContext.Keys;
            foreach(var k in keys)
            {               
                var v = scenarioContext.Get<Object>(k);
                Console.WriteLine($"{k} : {v}");
            }

            Console.WriteLine($"Ending scenario : {scenarioContext.ScenarioInfo.Title}");
        }
    }
}
