using TechTalk.SpecFlow;
using FluentAssertions;

namespace TylerEagarCalcProj.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();

        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        //add
        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        //subtract
        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Sub();
        }

        //multiplied
        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Mult();
        }

        
        [When(@"operation \+ is done to the number (.*)")]
        public void WhenOperationAddIsDoneToTheNumber(int number)
        {
            _result = _calculator + number;
        }

        [When(@"operation \- is done to the number (.*)")]
        public void WhenOperationSubtractIsDoneToTheNumber(int number)
        {
            _result = _calculator - number;
        }

        [When(@"operation \/ is done to the number (.*)")]
        public void WhenOperationDivideIsDoneToTheNumber(int number)
        {
            _result = _calculator / number;
        }

        [When(@"operation \% is done to the number (.*)")]
        public void WhenOperationModulasIsDoneToTheNumber(int number)
        {
            _result = _calculator % number;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}
