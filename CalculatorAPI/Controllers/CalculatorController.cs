using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add(double a, double b)
        {
            return Ok(a + b);
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(double a, double b)
        {
            return Ok(a - b);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(double a, double b)
        {
            return Ok(a * b);
        }

        [HttpGet("divide")]
        public IActionResult Divide(double a, double b)
        {
            if (b == 0)
                return BadRequest("Division by zero is not allowed.");
            return Ok(a / b);
        }
    }
}
