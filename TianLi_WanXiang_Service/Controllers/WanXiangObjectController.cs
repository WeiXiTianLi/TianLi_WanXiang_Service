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

        // POST: WanXiangObject
        // Route: PostObject
        [HttpPost]
        //[Route("PostObject")]
        public ActionResult Post([FromBody] WanXiangObject value)
        {
            // Console Print value to console
            Console.WriteLine(value.ObjectName);
            if (value.X == 0 && value.Y == 0 && value.Z == 0)
            {
                return BadRequest();
            }
            if (value.ObjectName is null || value.ObjectName == "")
            {
                return BadRequest();
            }
            return Ok();
        }
        
    }
}