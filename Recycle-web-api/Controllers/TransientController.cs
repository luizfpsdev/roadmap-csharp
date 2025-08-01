using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recycle_web_api.Services;

namespace Recycle_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransientController : ControllerBase
    {
        public TransientController()
        {
            
        }
        [HttpGet()]
        public ActionResult<Resultado> Get()
        {
            return Ok(new Resultado());
        }
    }
}
