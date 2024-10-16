using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController] // Indicates that this class is an API controller
    [Route("[controller]")] // Sets the base route for the controller
    public class CalculatorController : ControllerBase
    {
        // GET: /calculator/add?a=10&b=5
        [HttpGet("add")] // Specifies that this method responds to GET requests at the "add" route
        public ActionResult<decimal> Add(decimal a, decimal b)
        {
            return a + b; // Returns the sum of the two parameters
        }

        // GET: /calculator/subtract?a=10&b=5
        [HttpGet("subtract")] // Specifies the route for subtraction
        public ActionResult<decimal> Subtract(decimal a, decimal b)
        {
            return a - b; // Returns the difference of the two parameters
        }

        // GET: /calculator/multiply?a=10&b=5
        [HttpGet("multiply")] // Specifies the route for multiplication
        public ActionResult<decimal> Multiply(decimal a, decimal b)
        {
            return a * b; // Returns the product of the two parameters
        }

        // GET: /calculator/divide?a=10&b=5
        [HttpGet("divide")] // Specifies the route for division
        public ActionResult<decimal> Divide(decimal a, decimal b)
        {
            if (b == 0) return BadRequest("Division by zero is not allowed."); // Handle division by zero
            return a / b; // Returns the quotient of the two parameters
        }

        // GET: /calculator/modulo?a=10&b=5
        [HttpGet("modulo")] // Specifies the route for modulo operation
        public ActionResult<decimal> Modulo(decimal a, decimal b)
        {
            return a % b; // Returns the remainder of the two parameters
        }
    }
}
