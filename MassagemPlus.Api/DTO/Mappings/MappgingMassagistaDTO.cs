using MassagemPlus.Api.DTO.Massagista;
using MassagemPlus.Api.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace MassagemPlus.Api.DTO.Mappings;

public static class MappgingMassagistaDTO
{
    #region Get
    public static IEnumerable<MassagistaListarDTO>? MapearParaDtoGetAll(this IEnumerable<Models.Massagista> massagista)
    {
        //Model -> DTO (Vai enviar algo pro cliente)
        return massagista.Select(p => new MassagistaListarDTO
        {
            Nome = p.Nome,
            FotoPerfil = p.FotoPerfil,
            Descricao = p.Descricao
        }).ToList();
    }
    #endregion

    #region Post
    public static Models.Massagista? MapearParaModelCadastro(this MassagistaCadastroDTO massagistaDto)
    {
        //DTO -> Model
        return new Models.Massagista
        {
            Email = massagistaDto.Email,
            SenhaHash = massagistaDto.SenhaHash,
            Nome = massagistaDto.Nome,
        };
    }
    #endregion
    
    #region Put
    public static void MapearParaModelAtualizacao(this MassagistaAtualizarDTO dto, Models.Massagista entity)
    {
        entity.Id = dto.Id;
        entity.Email = dto.Email;
        entity.SenhaHash = dto.SenhaHash;
        entity.Nome = dto.Nome;
        entity.FotoPerfil = dto.FotoPerfil;
        entity.Descricao = dto.Descricao;
        entity.Telefone = dto.Telefone;
        entity.Cidade = dto.Cidade;
        entity.Estado = dto.Estado;
        entity.Endereco = dto.Endereco;
        entity.FormasPagamentos = dto.FormasPagamentos;
        entity.MassagensComum = dto.MassagensComum;
        entity.FotosLocal = dto.FotosLocal;
        entity.ServicosPremium = dto.ServicosPremium;
    }
    
    
    /*public static Models.Massagista? MapearParaModelAtualizacao(this MassagistaAtualizarDTO dto)
    {
        //DTO -> Model
        return new Models.Massagista
        {
            Id = dto.Id,
            Email =  dto.Email,
            SenhaHash = dto.SenhaHash,
            Nome = dto.Nome,
            FotoPerfil = dto.FotoPerfil,
            Descricao = dto.Descricao,
            Telefone = dto.Telefone,
            Cidade = dto.Cidade,
            Estado = dto.Estado,
            Endereco =  dto.Endereco,
            FormasPagamentos =  dto.FormasPagamentos,
            MassagensComum = dto.MassagensComum,
            FotosLocal =  dto.FotosLocal,
            ServicosPremium =  dto.ServicosPremium
        };
    }*/
    #endregion
}