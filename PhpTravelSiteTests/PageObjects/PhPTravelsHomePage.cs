using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PhpTravelSiteTests.Helpers;
using System;
using System.Collections.Generic;

namespace PhpTravelSiteTests.PageObjects
{
    class PhPTravelsHomePage
    {
        private IWebDriver driver;
        public PhPTravelsHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectFlights()
        {
            driver.FindElement(By.XPath("//*[@id='search']/div/div/div/div/div/nav/ul/li[2]/a")).Click();  
        }


        public void EnterFlightDetails(FlightDetails flightDetails)
        {
            IWebElement fromBox = driver.FindElement(By.Id("s2id_location_from"));   
            fromBox.Click();

            IWebElement box = driver.FindElement(By.XPath("//*[@id='select2-drop']/div/input"));
            box.SendKeys(flightDetails.From);
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.ClassName("select2-highlighted")).Click();

            IWebElement toBox = driver.FindElement(By.Id("s2id_location_to"));
            toBox.Click();
            box = driver.FindElement(By.CssSelector("#select2-drop > div > input"));
            box.SendKeys(flightDetails.To);
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.ClassName("select2-highlighted")).Click();

            if(flightDetails.Adults == 0)
            {
                driver.FindElement(By.XPath("//*[@id='flights']/div/div/form/div/div/div[3]/div[3]/div/div/div[1]/div/div[2]/div/span/button[2]")).Click();
            }

            for(int i = 2; i <= flightDetails.Adults; i++)
            {
                driver.FindElement(By.XPath("//*[@id='flights']/div/div/form/div/div/div[3]/div[3]/div/div/div[1]/div/div[2]/div/span/button[1]")).Click(); 
            }

            for(int i = 0; i < flightDetails.Child; i++)
            {
                driver.FindElement(By.XPath("//*[@id='flights']/div/div/form/div/div/div[3]/div[3]/div/div/div[2]/div/div[2]/div/span/button[1]")).Click();
            }

            for (int i = 0; i < flightDetails.Infant; i++)
            {
                driver.FindElement(By.XPath("//*[@id='flights']/div/div/form/div/div/div[3]/div[3]/div/div/div[3]/div/div[2]/div/span/button[1]")).Click();
            }
        }

        public void SelectSearch()
        {
            driver.FindElement(By.XPath("//*[@id='flights']/div/div/form/div/div/div[3]/div[4]/button")).Click();            
        }
    }
}
