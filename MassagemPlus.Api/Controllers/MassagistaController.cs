using MassagemPlus.Api.DTO.Mappings;
using MassagemPlus.Api.DTO.Massagista;
using MassagemPlus.Api.Models;
using MassagemPlus.Api.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MassagemPlus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MassagistaController : ControllerBase
    {
        private readonly IRepository<Massagista> _RepoMassagista;
        private readonly IMassagistaRepository _Repo;
        public MassagistaController(IRepository<Massagista> RepoMassagista, IMassagistaRepository repo)
        {
            _RepoMassagista = RepoMassagista;
            _Repo = repo;
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

        [HttpGet("/buscarId{id}")]
        public async Task<ActionResult<Massagista>> Get(int id)
        {
            var massagista = await _Repo.GetById(id);
            if (massagista == null)
            {
                return NotFound("Massagista não encontrado");
            }
            return Ok(massagista);
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

        [HttpPut("{id}")]
        public async Task<ActionResult<MassagistaAtualizarDTO>> Put(int id, MassagistaAtualizarDTO dto)
        {
            if (id != dto.Id)
            {
                return BadRequest("O ID informado não corresponde ao do objeto enviado.");
            }
            
            var verificaMassagista = await _Repo.GetById(id);
            if (verificaMassagista == null)
                return NotFound("Massagista não encontrado");
            
            //var massagistaDto = dto.MapearParaModelAtualizacao();
            dto.MapearParaModelAtualizacao(verificaMassagista);

            var atualizado = await _RepoMassagista.Put(verificaMassagista);
            return Ok(atualizado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Massagista>> Delete(int id)
        {
            var massagista = await _Repo.GetById(id);
            if (massagista == null)
            {
                return BadRequest("Erro ao localizar massagista");
            }
            var massagistaDeletado = _RepoMassagista.Delete(massagista);
            return Ok(massagistaDeletado);
        }
    }
}