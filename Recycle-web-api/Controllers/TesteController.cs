using Microsoft.AspNetCore.Mvc;

namespace Recycle_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Teste novo controller");
        }
    }
}
