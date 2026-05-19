using Microsoft.AspNetCore.Mvc;

namespace AvalantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AvalantController : ControllerBase
    {
        [HttpGet(Name = "StartGame")]
        public string Get()
        {
            return "Welcome to Avalant";
        }
    }
}
