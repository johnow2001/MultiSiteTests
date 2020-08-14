using MyStoreSpecflowTest.Helpers;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MyStoreSpecflowTest.PageObjects
{
    class CartSummaryPage
    {
        private IWebDriver driver;
        public CartSummaryPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void CheckSummaryPage(Table table)
        {
            var expectedSummary = table.CreateInstance<ShoppingCartSummary>();

            ShoppingCartSummary gotSummary = new ShoppingCartSummary();

            IWebElement cartTable = driver.FindElement(By.TagName("tbody"));
            IReadOnlyCollection<IWebElement> rows = cartTable.FindElements(By.TagName("tr"));
            IReadOnlyCollection<IWebElement> cols = null;

            foreach (IWebElement row in rows)
            {
                cols = row.FindElements(By.TagName("td"));
                foreach (IWebElement col in cols)
                {
                    Console.WriteLine(col.Text);
                }               
            }

            IWebElement[] array = cols.ToArray();
            gotSummary.Description = array[1].Text;
            Console.WriteLine("Element 0 = " + gotSummary.Description);
            gotSummary.Available = array[2].Text;
            Console.WriteLine("Element 1 = " + gotSummary.Available);
            gotSummary.UnitPrice = array[3].Text;
            Console.WriteLine("Element 2 = " + gotSummary.UnitPrice);

            table.CompareToInstance<ShoppingCartSummary>(gotSummary);

        }
    }
}
