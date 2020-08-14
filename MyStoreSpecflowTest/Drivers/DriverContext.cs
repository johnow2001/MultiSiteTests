using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyStoreSpecflowTest.Drivers
{
    class DriverContext
    {
        public IWebDriver Driver { get; set; }

        public DriverContext()
        {
            Driver = new ChromeDriver();
        }

    }
}
