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
        public void Post([FromBody] WanXiangObject value)
        {
            
            


        }
    }
}