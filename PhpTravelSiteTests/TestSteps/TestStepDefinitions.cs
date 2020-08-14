using OpenQA.Selenium;
using PhpTravelSiteTests.Contexts;
using PhpTravelSiteTests.Helpers;
using PhpTravelSiteTests.PageObjecstManager;
using PhpTravelSiteTests.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PhpTravelSiteTests.TestSteps
{
    [Binding]
    public sealed class TestStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private readonly IWebDriver _browser;

        private PageObjectsManager poManager;
        private PhPTravelsHomePage homepge;

        public TestStepDefinitions(ScenarioContext scenarioContext, WebDriverContext driverContext)
        {
            _scenarioContext = scenarioContext;
            _browser = driverContext.driver;
        }

        [Given(@"I  navigate to the ""(.*)"" home page")]
        public void GivenINavigateToTheHomePage(string url)
        {
            _browser.Navigate().GoToUrl(url);
            poManager = new PageObjectsManager(_browser);
            homepge = poManager.GetHomePage();
        }

        [When(@"I select Flights")]
        public void WhenISelect()
        {
            homepge.SelectFlights();
        }

        [When(@"I enter the follwoing flight information")]
        public void EnterFlightInformation(Table table)
        {
            var flightDeatis = table.CreateInstance<FlightDetails>();
            homepge.EnterFlightDetails(flightDeatis);
        }

        [When(@"I select search")]
        public void ISelectSearch()
        {
            homepge.SelectSearch();
        }

        [Then(@"A total of ""(.*)"" listings is found")]
        public void TotalListingsIsFound(int p0)
        {
             
        }

        [Then(@"includes the following")]
        public void ThenIncludesTheFollowing(Table table)
        {
             
        }

        [When(@"I book a flight by clicking Book Now")]
        public void BookNow()
        {
            
        }

        [When(@"I enter the follwoing passenger ifnormation")]
        public void EnterPassengerIfnormation(Table table)
        {
             
        }

        [When(@"I select Confirm This Booking")]
        public void WhenISelectConfirmThisBooking()
        {
             
        }

        [Then(@"Booking Status is ""(.*)""")]
        public void ThenBookingStatusIs(string p0)
        {
             
        }

        [When(@"I select Pay Now")]
        public void WhenISelectPayNow()
        {
             
        }

        [When(@"I select a Payment Method of ""(.*)""")]
        public void WhenISelectAPaymentMethodOf(string p0)
        {
             
        }

        [When(@"enter the follwoing card details")]
        public void WhenEnterTheFollwoingCardDetails(Table table)
        {
             
        }



    }
}
