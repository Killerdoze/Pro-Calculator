using NUnit.Framework;
using TechTalk.SpecFlow;
using System;

namespace CalculatorTests.StepDefinitions
{
    [Binding]
    public class SquareRootSteps
    {
        private double _number;
        private double _result;
        private string _errorMessage;

        // Given: the number is entered
        [Given(@"I have entered the number (.*)")]
        public void GivenIHaveEnteredTheNumber(double number)
        {
            _number = number;
        }

        // When: calculating the square root
        [When(@"I calculate the square root")]
        public void WhenICalculateTheSquareRoot()
        {
            try
            {
                if (_number < 0)
                {
                    throw new ArgumentException("The square root of a negative number is not defined in real numbers.");
                }
                _result = Math.Sqrt(_number);
                _errorMessage = null;  // No error if calculation succeeds
            }
            catch (ArgumentException ex)
            {
                _errorMessage = ex.Message;  // Capture the error message for negative numbers
            }
        }

        // Then: the square result should be correct
        [Then(@"the square result should be (.*)")]
        public void ThenTheResultShouldBe(double expectedResult)
        {
            if (_errorMessage != null)
            {
                Assert.Fail(_errorMessage);  // Fail the test if there was an error
            }
            Assert.AreEqual(expectedResult, _result, 0.01);
        }

        // Then: error message is expected for negative numbers
        [Then(@"I should receive an error message")]
        public void ThenIShouldReceiveAnErrorMessage()
        {
            Assert.IsNotNull(_errorMessage);
            Assert.AreEqual("The square root of a negative number is not defined in real numbers.", _errorMessage);
        }

        // Optionally, if you want to get the result value outside of the test
        public double GetResult()
        {
            return _result;
        }
    }
}
