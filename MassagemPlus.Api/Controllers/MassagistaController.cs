using MassagemPlus.Api.Data;
using MassagemPlus.Api.DTO.Mappings;
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
            if (massagistas == null || !massagistas.Any())
            {
                return NotFound("Massagistas não encontrados");
            }
            
            //Mapear manualmente para DTO
            #region Mapear manualmente
            /*var massagistasDTO = massagistas.Select(m => new MassagistaListarDTO
            {
                Nome = m.Nome,
                FotoPerfil = m.FotoPerfil,
                Descricao = m.Descricao
            });
            Ou
            var massagistasDTO  = massagistas
               .Select(p => p.MapearParaDto())
               .ToList();
            */
            #endregion

            var massagistasDTO = massagistas.MapearParaDtoGetAll();
            return Ok(massagistasDTO);
        }

        [HttpPost]
        public async Task<ActionResult<MassagistaCadastroDTO>> Post([FromBody] MassagistaCadastroDTO massagista)
        {
            if (massagista == null)
            {
                return BadRequest("Erro ao cadastrar massagista");
            }
            //Dto -> Model
            var massagistaDto = massagista.MapearParaModelCadastro();
            
            //Repository
            var massagistaCriadoDTO = await _RepoMassagista.Post(massagistaDto);
            
            return Ok(massagistaCriadoDTO);
        }
    }
}
