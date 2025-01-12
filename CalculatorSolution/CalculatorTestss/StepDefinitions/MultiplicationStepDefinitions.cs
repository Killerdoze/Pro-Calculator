using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CalculatorTests.StepDefinitions
{
    [Binding]
    public class MultiplicationSteps
    {
        private double _firstNumber;
        private double _secondNumber;
        private double _result;

        [Given(@"the first number for multiplication is (.*)")]
        public void GivenTheFirstNumberForMultiplicationIs(string firstNumber)
        {
            // Convertir en double de manière explicite et gérer l'exception si nécessaire
            if (!double.TryParse(firstNumber, out _firstNumber))
            {
                throw new FormatException("The first number is not a valid double.");
            }
        }

        [Given(@"the second number for multiplication is (.*)")]
        public void GivenTheSecondNumberForMultiplicationIs(string secondNumber)
        {
            // Convertir en double de manière explicite et gérer l'exception si nécessaire
            if (!double.TryParse(secondNumber, out _secondNumber))
            {
                throw new FormatException("The second number is not a valid double.");
            }
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = Multiply(_firstNumber, _secondNumber);
        }

        [Then(@"the result for multiplication should be (.*)")]
        public void ThenTheResultForMultiplicationShouldBe(double expectedResult)
        {
            Assert.AreEqual(expectedResult, _result, "The result of the multiplication is incorrect.");
        }

        private double Multiply(double a, double b)
        {
            return a * b;
        }

        public double GetResult()
        {
            return _result;
        }
    }
}
