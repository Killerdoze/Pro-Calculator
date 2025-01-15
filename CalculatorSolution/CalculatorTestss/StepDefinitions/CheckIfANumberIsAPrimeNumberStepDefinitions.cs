using NUnit.Framework;
using System;

namespace CalculatorTestss.StepDefinitions  // Changez ici pour correspondre à votre structure de dossiers
{
    [Binding]
    public class PrimeNumberSteps
    {
        private int _number;
        private string _result;

        [Given(@"the prime number is (\d+)")]
        public void GivenTheNumberIs(int number)
        {
            _number = number;
        }

        [When(@"I check if the number is prime")]
        public void WhenICheckIfTheNumberIsPrime()
        {
            _result = IsPrime(_number) ? "Prime" : "Not Prime";
        }

        [Then(@"the prime result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult));
        }

        public string GetResult()
        {
            return _result;  // Retourne le résultat calculé
        }

        // Rendre la méthode IsPrime statique
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
