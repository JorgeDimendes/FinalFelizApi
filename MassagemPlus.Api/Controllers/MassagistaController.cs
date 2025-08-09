using MassagemPlus.Api.Data;
using MassagemPlus.Api.DTO.Massagista;
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
        public async Task<ActionResult<IEnumerable<MassagistaListarDTO>>> Get()
        {
            var massagistas = await _RepoMassagista.GetAll();
            if (massagistas == null)
            {
                return NotFound("Erro ao listar massagistas");
            }
            
            //Mapear manualmente para DTO
            var massagistasDTO = massagistas.Select(m => new MassagistaListarDTO
            {
                Nome = m.Nome,
                FotoPerfil = m.FotoPerfil,
                Descricao = m.Descricao
            });
            
            return Ok(massagistasDTO);
        }

        [HttpPost]
        public async Task<ActionResult<MassagistaCadastroDTO>> Post([FromBody] MassagistaCadastroDTO massagistaDto)
        {
            if (massagistaDto == null)
            {
                return BadRequest("Erro ao cadastrar massagista");
            }
            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var massagistaCriado = new Massagista
            {
                Email = massagistaDto.Email,
                Nome = massagistaDto.Nome,
                SenhaHash = massagistaDto.SenhaHash
            };
            var massagistaCriadoDTO = await _RepoMassagista.Post(massagistaCriado);
            return Ok(massagistaCriadoDTO);
        }
    }
}
