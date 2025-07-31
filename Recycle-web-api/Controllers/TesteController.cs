using Microsoft.AspNetCore.Mvc;
using Recycle_web_api.Abstrations;

namespace Recycle_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        public ICicloDeVidaService _cicloDeVidaService { get; set; }
        public TesteController(ICicloDeVidaService cicloDeVidaService)
        {
            _cicloDeVidaService = cicloDeVidaService;
        }   
        [HttpGet]
        public ActionResult<Resultado> Get()
        {
            return Ok(new Resultado(_cicloDeVidaService.GetContador()));
        }
    }
}
