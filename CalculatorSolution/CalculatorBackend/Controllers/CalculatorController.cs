using Microsoft.AspNetCore.Mvc;
using CalculatorTests.StepDefinitions;
using CalculatorTestss.StepDefinitions;

namespace CalculatorBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculController : ControllerBase
    {
        [HttpPost("calcul")]
        public IActionResult Calculer([FromForm] double nombre1, [FromForm] double nombre2)
        {
            try
            {
                // Create an instance of SpecFlow steps for addition
                var calculator = new CalculatorSteps();

                // Call steps to define the numbers
                calculator.GivenTheFirstNumberIs(nombre1);
                calculator.GivenTheSecondNumberIs(nombre2);

                // Perform addition
                calculator.WhenTheTwoNumbersAreAdded();

                // Get the result
                double result = calculator.GetResult();


                // Return the result
                return Ok(result);

            }
            catch (Exception ex)
            {
                // Handle errors
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPost("multiplication")]
        public IActionResult Multiplier([FromForm] double nombre1, [FromForm] double nombre2)
        {
            try
            {
                // Create an instance of SpecFlow steps for multiplication
                var multiplication = new MultiplicationSteps();

                // Call steps to define the numbers
                multiplication.GivenTheFirstNumberForMultiplicationIs(nombre1.ToString());
                multiplication.GivenTheSecondNumberForMultiplicationIs(nombre2.ToString());

                // Perform multiplication
                multiplication.WhenTheTwoNumbersAreMultiplied();

                // Get the result
                double result = multiplication.GetResult();

                // Return the result
                return Ok(result.ToString("F2"));  // or return Ok(result.ToString("F2")) for 2 decimal places

            }
            catch (Exception ex)
            {
                // Handle errors
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPost("subtraction")]
        public IActionResult Soustraire([FromForm] double nombre1, [FromForm] double nombre2)
        {
            try
            {
                // Create an instance of SpecFlow steps for subtraction
                var subtraction = new SubtractionSteps();

                // Call steps to define the numbers
                subtraction.GivenTheFirstNumberForSubtractionIs(nombre1);
                subtraction.GivenTheSecondNumberForSubtractionIs(nombre2);

                // Perform subtraction
                subtraction.WhenTheTwoNumbersAreSubtracted();

                // Get the result
                double result = subtraction.GetResult();

                // Return the result
                return Ok(result.ToString("F2"));  // or return Ok(result.ToString("F2")) for 2 decimal places

            }
            catch (Exception ex)
            {
                // Handle errors
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPost("division")]
        public IActionResult Diviser([FromForm] double nombre1, [FromForm] double nombre2)
        {
            try
            {
                // Create an instance of SpecFlow steps for division
                var division = new DivisionSteps();

                // Call steps to define the numbers
                division.GivenTheFirstNumberForDivisionIs(nombre1);
                division.GivenTheSecondNumberForDivisionIs(nombre2);

                // Perform division
                division.WhenTheTwoNumbersAreDivided();

                // Get the result
                double result = division.GetResult();

                // Return the result
                return Ok(result.ToString("F2"));  // or return Ok(result.ToString("F2")) for 2 decimal places

            }
            catch (Exception ex)
            {
                // Handle errors
                return BadRequest($"Error: {ex.Message}");
            }
        }


        [HttpPost("squareRoot")]
        public IActionResult CalculateSquareRoot([FromForm] double number)
        {
            try
            {
                // Créer une instance des étapes de SpecFlow pour la racine carrée
                var squareRootStep = new SquareRootSteps();

                // Définir le nombre
                squareRootStep.GivenIHaveEnteredTheNumber(number);

                // Effectuer le calcul de la racine carrée
                squareRootStep.WhenICalculateTheSquareRoot();

                // Obtenir le résultat
                double result = squareRootStep.GetResult();

                // Retourner le résultat avec deux décimales
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Gérer les erreurs
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpPost("primeNumber")]
        public IActionResult CheckPrimeNumber([FromForm] int number)
        {
            try
            {
                // Créer une instance des étapes de SpecFlow pour vérifier les nombres premiers
                var primeNumberStep = new PrimeNumberSteps();

                // Définir le nombre
                primeNumberStep.GivenTheNumberIs(number);

                // Vérifier si le nombre est premier
                primeNumberStep.WhenICheckIfTheNumberIsPrime();

                // Obtenir le résultat via la méthode GetResult
                string result = primeNumberStep.GetResult();

                // Retourner le résultat
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Gérer les erreurs
                return BadRequest($"Error: {ex.Message}");
            }
        }

    }
}
