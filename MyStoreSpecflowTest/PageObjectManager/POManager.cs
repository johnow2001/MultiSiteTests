using MyStoreSpecflowTest.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStoreSpecflowTest.PageObjectManager
{
    class POManager
    {
        private IWebDriver driver;
        private HomePage homePage;
        private ProductPage productPage;
        private CartSummaryPage cartSummaryPage;

        public POManager(IWebDriver driver)
        {
            this.driver = driver;
        }

        public HomePage GetHomePage()
        {
            if(homePage == null)
            {
                homePage = new HomePage(this.driver);
            }
            return homePage;
        }

        public ProductPage GetProductPage()
        {
            if(productPage == null)
            {
                productPage = new ProductPage(this.driver);
            }
            return productPage;
        }

        public CartSummaryPage GetCartSummaryPage()
        {
            if(cartSummaryPage == null)
            {
                cartSummaryPage = new CartSummaryPage(this.driver);
            }
            return cartSummaryPage;
        }
    }
}
