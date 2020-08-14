using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyStoreSpecflowTest.PageObjects
{
    class ProductPage
    {
        private IWebDriver driver;
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AddToCart()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(d => driver.FindElement(By.Id("add_to_cart"))).Click();
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("add_to_cart"))).Click(); 
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='add_to_cart']"))).Click();
        }

        public void ProceedToCheckOut()
        {
            string title = "Proceed to checkout";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(String.Format("a[title='{0}']", title)))).Click();        
        }
    }
}
