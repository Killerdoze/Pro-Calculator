using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CalculatorTests.StepDefinitions
{
    [Binding]
    public class SubtractionSteps
    {
        private double _firstNumber;
        private double _secondNumber;
        private double _result;

        // Given step for the first number
        [Given(@"the first number for subtraction is (.*)")]
        public void GivenTheFirstNumberForSubtractionIs(double firstNumber)
        {
            _firstNumber = firstNumber;
        }

        // Given step for the second number
        [Given(@"the second number for subtraction is (.*)")]
        public void GivenTheSecondNumberForSubtractionIs(double secondNumber)
        {
            _secondNumber = secondNumber;
        }

        // When step for performing the subtraction
        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = Subtract(_firstNumber, _secondNumber);
        }

        // Then step for verifying the result
        [Then(@"the result for subtraction should be (.*)")]
        public void ThenTheResultForSubtractionShouldBe(double expectedResult)
        {
            Assert.That(expectedResult, Is.EqualTo(_result), "The result of the subtraction is incorrect.");
        }

        // Method to perform subtraction
        private double Subtract(double a, double b)
        {
            return a - b;
        }

        // Method to get the result (optional, if needed)
        public double GetResult()
        {
            return _result;
        }
    }
}
