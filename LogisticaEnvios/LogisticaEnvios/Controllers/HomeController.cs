using Microsoft.AspNetCore.Mvc;

namespace LogisticaEnvios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet(Name = "GetHome")]
        public string Get()
        {
            return "ERROR intencional desde Git Desktop";
        }
    }
}
