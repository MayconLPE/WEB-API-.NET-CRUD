using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIFucionarios.Controllers
{
    // Aqui onde se criam as requisições.
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Oi");
        }
    }
}
