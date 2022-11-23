using Microsoft.AspNetCore.Mvc;

namespace TianLi_WanXiang_Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WanXiangObjectController : ControllerBase
    {
        private readonly ILogger<WanXiangObjectController> _logger;

        public WanXiangObjectController(ILogger<WanXiangObjectController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WanXiangObject> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WanXiangObject
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}