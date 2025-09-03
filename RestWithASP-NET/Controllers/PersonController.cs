using Microsoft.AspNetCore.Mvc;

namespace RestWithASP_NET.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{


    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("subtraction{firstNumber}/{secondNumber}")]
    public IActionResult Subtracao(string primeiroNumero, string segundoNumero)
    {
        if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
        {
            var sub = ConvertToDecimal(primeiroNumero) - ConvertToDecimal(segundoNumero);
            return Ok(sub.ToString());
        }
        return BadRequest("Invalid input");
    }    
    
    private int ConvertToDecimal(string strNumber)
    {
        decimal decimalValue;
        if (decimal.TryParse(strNumber, out decimalValue))
        {
            return (int)decimalValue;
        }

        return 0;
    }

    private bool IsNumeric(string strNumber)
    {
        double number;
        bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        return isNumber;
    }
}
