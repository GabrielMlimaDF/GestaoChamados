using GestaoChamados.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace GestaoChamados.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
      
        [HttpGet("")]
        public ActionResult Get()
        {
            
            return Ok("Funcionando");
        }


    }
}
