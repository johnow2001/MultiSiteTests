using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStoreSpecflowTest.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectHomePageOption(String option)
        {
            driver.FindElement(By.PartialLinkText(option)).Click();
        }

        public void SelectProduct(String procduct)
        {
            string title = procduct;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //driver.FindElement(By.CssSelector(String.Format("img[title='{0}']", title))).Click();
            

            IWebElement prod = driver.FindElement(By.CssSelector(String.Format("img[title='{0}']", title)));
            //ScrollToView(prod);

            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("arguments[0].scrollIntoView();", prod);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(String.Format("img[title='{0}']", title)))).Click();
        }

        public void HoverAndSelectTab(string option1, string option2)
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(driver.FindElement(By.LinkText(option1))).Perform(); 
            builder.MoveToElement(driver.FindElement(By.LinkText(option2))).Click().Perform();
        }

        public IWebElement ScrollToView(By selector)
        {
            var element = driver.FindElement(selector);
            ScrollToView(element);
            return element;
        }
        public void ScrollToView(IWebElement element)
        {
            if (element.Location.Y > 200)
            {
                ScrollTo(0, element.Location.Y - 100); // Make sure element is in the view but below the top navigation pane
            }

        }

        public void ScrollTo(int xPosition = 0, int yPosition = 0)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            var js = String.Format("window.scrollTo({0}, {1})", xPosition, yPosition);
            jse.ExecuteScript(js);
        }
    }
}
