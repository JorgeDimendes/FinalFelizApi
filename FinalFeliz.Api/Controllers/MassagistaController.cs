using FinalFeliz.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalFeliz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MassagistaController : ControllerBase
    {
        private readonly AppDbContext _context;
        public MassagistaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Seja bem vindo ao FinalFeliz.Api");
        }
    }
}
