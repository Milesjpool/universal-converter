using TechTalk.SpecFlow;

namespace UniversalConverter.Specs.Steps
{
    [Binding]
    public class WalkingSkeletonSteps
    {
        private WalkingSkeletonStepsDriver _driver;

        [When(@"I navigate to an empty page")]
        public void WhenINavigateToTheRootOfTheWebsite()
        {
            _driver = new WalkingSkeletonStepsDriver();
            _driver.NavigateToRoot();
        }

        [Then(@"the API should respond with an OK status code")]
        public void ThenTheAPIShouldRespondWithAnOKStatusCode()
        {
            _driver.AssertStatusCodeIsOk();
        }

    }
}
