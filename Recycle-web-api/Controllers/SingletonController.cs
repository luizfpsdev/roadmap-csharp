using Microsoft.AspNetCore.Mvc;
using Recycle_web_api.Abstrations;

namespace Recycle_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        public SingletonController(ICiclodeVidaSingleton ciclodeVidaSingleton)
        {
            CiclodeVidaSingleton = ciclodeVidaSingleton;
        }

        public ICiclodeVidaSingleton CiclodeVidaSingleton { get; }

        [HttpGet()]
        public ActionResult<Resultado> GetSingleton()
        {
            return Ok(new Resultado(CiclodeVidaSingleton.GetContador()));
        }
    }
}
