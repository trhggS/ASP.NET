using Microsoft.AspNetCore.Mvc;

namespace lr3.Controllers
{
    [ApiController]
    [Route("calc")]
    public class ArithmeticController : ControllerBase
    {
        private readonly CalcService _calcService;
        private readonly TimeOfDayService _timeOfDayService;

        public ArithmeticController(CalcService calcService, TimeOfDayService timeOfDayService)
        {
            _calcService = calcService;
            _timeOfDayService = timeOfDayService;
        }

        [HttpGet("add")]
        public IActionResult Add(int a, int b)
        {
            var result = _calcService.Add(a, b);
            return Ok(result);
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(int a, int b)
        {
            var result = _calcService.Subtract(a, b);
            return Ok(result);
        }

        [HttpGet("divide")]
        public IActionResult Divide(int a, int b)
        {
            var result = _calcService.Divide(a, b);
            return Ok(result);
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(int a, int b)
        {
            var result = _calcService.Multiply(a, b);
            return Ok(result);
        }

    }
}
