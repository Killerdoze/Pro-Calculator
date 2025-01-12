using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace CalculatorTests.StepDefinitions
{
    [Binding]
    public class DivisionSteps
    {
        private double _firstNumber;
        private double _secondNumber;
        private double _result;

        [Given(@"the first number for division is (.*)")]
        public void GivenTheFirstNumberForDivisionIs(double firstNumber)
        {
            _firstNumber = firstNumber;
        }

        [Given(@"the second number for division is (.*)")]
        public void GivenTheSecondNumberForDivisionIs(double secondNumber)
        {
            _secondNumber = secondNumber;
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = Divide(_firstNumber, _secondNumber);
        }

        [Then(@"the result for division should be (.*)")]
        public void ThenTheResultForDivisionShouldBe(double expectedResult)
        {
            Assert.AreEqual(expectedResult, _result, "The result of the division is incorrect.");
        }

        private double Divide(double a, double b)
        {
            if (b == 0.0)
            {
                return double.NaN; // Handle division by zero
            }

            return Math.Round((a / b),3);
        }

        public double GetResult()
        {
            return _result;
        }
    }
}
