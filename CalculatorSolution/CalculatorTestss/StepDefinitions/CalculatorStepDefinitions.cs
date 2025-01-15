using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CalculatorTests.StepDefinitions
{
    [Binding]
    public class CalculatorSteps
    {
        private double _firstNumber;
        private double _secondNumber;
        private double _result;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(double firstNumber)
        {
            _firstNumber = firstNumber;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(double secondNumber)
        {
            _secondNumber = secondNumber;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = Add(_firstNumber, _secondNumber);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double expectedResult)
        {
            Assert.That(expectedResult, Is.EqualTo(_result), "The result of the addition is incorrect.");
        }

        private double Add(double a, double b)
        {
            return Math.Round((a + b), 3);
        }

        public double GetResult()
        {
            return _result;
        }
    }
}
