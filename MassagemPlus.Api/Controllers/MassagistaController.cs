using MassagemPlus.Api.Data;
using MassagemPlus.Api.Models;
using MassagemPlus.Api.Repository;
using MassagemPlus.Api.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MassagemPlus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MassagistaController : ControllerBase
    {
        private readonly IRepository<Massagista> _RepoMassagista;
        public MassagistaController(IRepository<Massagista> RepoMassagista)
        {
            _RepoMassagista = RepoMassagista;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Massagista>>> Get()
        {
            var massagistas = await _RepoMassagista.GetAll();
            return Ok(massagistas);
        }

        [HttpPost]
        public async Task<ActionResult<Massagista>> Post([FromBody] Massagista massagista)
        {
            var massagistaCriado = await _RepoMassagista.Post(massagista);
            return Ok(massagistaCriado);
        }
    }
}
