using Microsoft.AspNetCore.Mvc;
using Recycle_web_api.Abstrations;

namespace Recycle_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransientController : ControllerBase
    {
        public TransientController(ICicloDeVidaTransientService cicloDeVidaTransientService1, ICicloDeVidaTransientService cicloDeVidaTransientService2)
        {
            CicloDeVidaTransientService1 = cicloDeVidaTransientService1;
            CicloDeVidaTransientService2 = cicloDeVidaTransientService2;
        }

        public ICicloDeVidaTransientService CicloDeVidaTransientService1 { get; }
        public ICicloDeVidaTransientService CicloDeVidaTransientService2 { get; }

        [HttpGet()]
        public ActionResult<Resultado> Get()
        {
            return Ok(new Resultado(CicloDeVidaTransientService1.GetContador()));
        }
    }
}
