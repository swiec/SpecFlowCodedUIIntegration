using TechTalk.SpecFlow;

namespace SpecFlowCodedUIIntegration.StepsDefinition
{
    [Binding]
    public class SampleCalculatorSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}