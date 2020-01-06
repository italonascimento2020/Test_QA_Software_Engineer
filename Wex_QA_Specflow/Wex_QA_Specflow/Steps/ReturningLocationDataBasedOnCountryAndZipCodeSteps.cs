using System;
using TechTalk.SpecFlow;

namespace Wex_QA_Specflow.Steps
{
    [Binding]
    public class ReturningLocationDataBasedOnCountryAndZipCodeSteps
    {
        [Given(@"the country code us and zip code (.*)")]
        public void GivenTheCountryCodeUsAndZipCode(int p0)
        {
             
        }
        
        [When(@"I request the locations corresponding to these codes")]
        public void WhenIRequestTheLocationsCorrespondingToTheseCodes()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response contains the place name Beverly Hills")]
        public void ThenTheResponseContainsThePlaceNameBeverlyHills()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response contains exactly (.*) location")]
        public void ThenTheResponseContainsExactlyLocation(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response has status code (.*)")]
        public void ThenTheResponseHasStatusCode(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
