using OpenQA.Selenium;
using PhpTravelSiteTests.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhpTravelSiteTests.PageObjecstManager
{
    class PageObjectsManager
    {
        private IWebDriver driver;
        private PhPTravelsHomePage phPTravelsHomePage;

        public PageObjectsManager(IWebDriver driver)
        {
            this.driver = driver;
        }

        public PhPTravelsHomePage GetHomePage()
        {
            if (phPTravelsHomePage == null)
            {
                phPTravelsHomePage = new PhPTravelsHomePage(driver);
            }
            return phPTravelsHomePage;
        }


    }
}
