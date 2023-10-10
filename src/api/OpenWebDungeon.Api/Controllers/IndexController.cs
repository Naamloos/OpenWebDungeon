using Microsoft.AspNetCore.Mvc;

namespace OpenWebDungeon.Api.Controllers
{
    [ApiController]
    [Route("/")]
    public class IndexController : ControllerBase
    {
        private readonly ILogger<IndexController> _logger;

        public IndexController(ILogger<IndexController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            return "OpenWebDungeon";
        }
    }
}