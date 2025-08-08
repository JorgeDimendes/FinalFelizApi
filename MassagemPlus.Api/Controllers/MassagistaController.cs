using MassagemPlus.Api.Data;
using MassagemPlus.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MassagemPlus.Api.Controllers
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
        public async Task<ActionResult<IEnumerable<Massagista>>> Get()
        {
            var massagistas = await _context.Massagistas.ToListAsync();
            return Ok(massagistas);
        }
    }
}
