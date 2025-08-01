using Microsoft.AspNetCore.Mvc;
using Recycle_web_api.Abstrations;

namespace Recycle_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScopedController : ControllerBase
    {
        public ICicloDeVidaService _cicloDeVidaService { get; set; }
        public ICicloDeVidaService CicloDeVidaService2 { get; }

        public ScopedController(ICicloDeVidaService cicloDeVidaService, ICicloDeVidaService cicloDeVidaService2)
        {
            _cicloDeVidaService = cicloDeVidaService;
            CicloDeVidaService2 = cicloDeVidaService2;
        }
        [HttpGet()]
        public ActionResult<Resultado> Get()
        {
            return Ok(new Resultado(_cicloDeVidaService.GetContador()));
        }
    }
}
