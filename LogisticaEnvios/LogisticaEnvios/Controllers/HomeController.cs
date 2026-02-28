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
            return "Tercer ERROR intencional desde Visual Studio para revert";
        }
    }
}
