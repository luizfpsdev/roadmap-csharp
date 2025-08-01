using Microsoft.AspNetCore.Mvc;
using Recycle_web_api.Abstrations;

namespace Recycle_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    // exemplo de construtor primário
    public class ScopedController(ICicloDeVidaService cicloDeVidaService, ICicloDeVidaService cicloDeVidaService2) : ControllerBase
    {
        public ICicloDeVidaService CicloDeVidaService { get; set; } = cicloDeVidaService;
        public ICicloDeVidaService CicloDeVidaService2 { get; } = cicloDeVidaService2;

        [HttpGet()]
        public ActionResult<Resultado> Get()
        {
            return Ok(new Resultado(CicloDeVidaService.GetContador()));
        }
    }
}
