using TechTalk.SpecFlow;

namespace UniversalConverter.Specs.Steps
{
    [Binding]
    public class ConversionSteps
    {
        private ConversionStepsDriver _driver; 

        [When(@"I navigate to convert/(.*)")]
        public void WhenINavigateToConvert(string conversionInput)
        {
            _driver = new ConversionStepsDriver();
            _driver.NavigateToConvert(conversionInput);
        }

        [Then(@"I should see (.*)")]
        public void ThenIShouldSee(string expectedOutput)
        {
            _driver.AssertConvertedInputEquals(expectedOutput);
        }
 
    }
}