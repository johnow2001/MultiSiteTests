using MyStoreSpecflowTest.Drivers;
using MyStoreSpecflowTest.PageObjects;
using MyStoreSpecflowTest.PageObjectManager;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MyStoreSpecflowTest.Steps
{
    [Binding]
    class TestStepDefinitions
    {
        private IWebDriver browser;
        private POManager pObjectManager;
        private HomePage homePage;
        private ProductPage productPage;
        private CartSummaryPage cartSummaryPage;
        public TestStepDefinitions(DriverContext driverContext)
        {
            this.browser = driverContext.Driver;
        }

        [Given(@"I navigate to the page ""(.*)""")]
        public void GivenINavigateToThePage(string url)
        {
            browser.Navigate().GoToUrl(url);
            pObjectManager = new POManager(browser);
            homePage = pObjectManager.GetHomePage();
        }

        [When(@"I slect the ""(.*)"" option")]
        public void WhenISlectTheOption(string option)
        {
            homePage.SelectHomePageOption(option);
        }


        [When(@"I select ""(.*)"" product")]
        public void WhenISelectProduct(string product)
        {
            homePage.SelectProduct(product);
        }

        [When(@"I select Add to cart")]
        public void WhenISelectAddToCart()
        {
            productPage = pObjectManager.GetProductPage();
            productPage.AddToCart();
        }

        [When(@"I select Proceed to checkout")]
        public void WhenISelectProceedToCheckout()
        {
            productPage.ProceedToCheckOut();
        }

        [Then(@"I can see the items in the shopping cart summary")]
        public void CheckShoppingCartSummary(Table table)
        {
            cartSummaryPage = pObjectManager.GetCartSummaryPage();
            cartSummaryPage.CheckSummaryPage(table);
        }

        [When(@"I slect the ""(.*)"" and ""(.*)"" tab option")]
        public void HoverAndTabSelection(string option1, string option2)
        {
            homePage.HoverAndSelectTab(option1, option2);
        }


    }
}
