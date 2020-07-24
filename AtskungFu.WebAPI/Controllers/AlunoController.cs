using Microsoft.AspNetCore.Mvc;

namespace AtskungFu.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AlunoController :ControllerBase
    {
        public AlunoController() { }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Pessoa:Flavio,Bryan,Ashley,Bia");
            
        }
    }
}