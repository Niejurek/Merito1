using Microsoft.AspNetCore.Mvc;

namespace AngularApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return id.ToString();
        }
    }
}
