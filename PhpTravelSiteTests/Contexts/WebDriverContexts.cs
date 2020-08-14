using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PhpTravelSiteTests.Contexts
{
    public class WebDriverContext
    {
        public IWebDriver driver { get; set; }

        WebDriverContext()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }

    }
}
