using Microsoft.AspNetCore.Mvc;

namespace RestAPINETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
       
        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        private bool isNumber;

        [HttpGet("sum/(firstNumber)/(secondNumber)")]
        public IActionResult Get(string firstNumber, string SecondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(SecondNumber))
            {
                var sum = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(SecondNumber);

                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }
        private bool IsNumeric(string strNumber)
        {
            double number;
            return isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;   
            }
            return 0;
        }
    }
}