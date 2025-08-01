using Microsoft.AspNetCore.Mvc;
using Recycle_web_api.Abstrations;

namespace Recycle_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        public ICicloDeVidaService _cicloDeVidaService { get; set; }
        public ICiclodeVidaSingleton CiclodeVidaSingleton { get; }

        public TesteController(ICicloDeVidaService cicloDeVidaService, ICiclodeVidaSingleton ciclodeVidaSingleton)
        {
            _cicloDeVidaService = cicloDeVidaService;
            CiclodeVidaSingleton = ciclodeVidaSingleton;
        }   
        [HttpGet("/scoped")]
        public ActionResult<Resultado> Get()
        {
            return Ok(new Resultado(_cicloDeVidaService.GetContador()));
        }
        [HttpGet("/singleton")]
        public ActionResult<Resultado> GetSingleton()
        {
            return Ok(new Resultado(CiclodeVidaSingleton.GetContador()));
        }
    }
}
