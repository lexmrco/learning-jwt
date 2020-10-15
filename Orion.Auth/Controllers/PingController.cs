using Microsoft.AspNetCore.Mvc;

namespace Orion.Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "pong";
        }
    }
}
