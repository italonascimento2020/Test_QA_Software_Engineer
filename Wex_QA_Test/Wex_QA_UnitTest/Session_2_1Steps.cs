using System;
using TechTalk.SpecFlow;
using Wex_QA_UnitTest_Project;

namespace Wex_QA_UnitTest
{
    [Binding]
    public class Session_2_1Steps
    {
        private Session_2_1 class_session_2_1 = new Session_2_1();

        [Given(@"I navigate to “www\.amazon\.com”\.")]
        public void GivenINavigateToWww_Amazon_Com_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select the option “Books” in the dropdown next to the search text input criteria\.")]
        public void WhenISelectTheOptionBooksInTheDropdownNextToTheSearchTextInputCriteria_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I reach the detailed book page, I check if the name in the header is the same name of the book that I select previously\.")]
        public void WhenIReachTheDetailedBookPageICheckIfTheNameInTheHeaderIsTheSameNameOfTheBookThatISelectPreviously_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I search for “Test automation”\.")]
        public void ThenISearchForTestAutomation_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I select the cheapest book of the page without using any sorting method available\.")]
        public void ThenISelectTheCheapestBookOfThePageWithoutUsingAnySortingMethodAvailable_()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
