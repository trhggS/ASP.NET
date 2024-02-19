using Microsoft.AspNetCore.Mvc;

namespace lr3.Controllers
{
    [ApiController]
    [Route("time")]
    public class TimeOfDayController : ControllerBase
    {
        private readonly TimeOfDayService _timeOfDayService;

        public TimeOfDayController(TimeOfDayService timeOfDayService)
        {
            _timeOfDayService = timeOfDayService;
        }

        [HttpGet("timeOfDay")]
        public IActionResult GetTimeOfDay()
        {
            var timeOfDay = _timeOfDayService.GetTimeOfDay();
            return Ok(timeOfDay);
        }

    }
}
