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
    public static Models.Massagista? MapearParaModelAtualizacao(this MassagistaAtualizarDTO massagistaDto)
    {
        //DTO -> Model
        return new Models.Massagista
        {
            Id = massagistaDto.Id,
            Email =  massagistaDto.Email,
            SenhaHash = massagistaDto.SenhaHash,
            Nome = massagistaDto.Nome,
            FotoPerfil = massagistaDto.FotoPerfil,
            Descricao = massagistaDto.Descricao,
            Telefone = massagistaDto.Telefone,
            Cidade = massagistaDto.Cidade,
            Estado = massagistaDto.Estado,
            Endereco =  massagistaDto.Endereco,
            FormasPagamentos =  massagistaDto.FormasPagamentos,
            MassagensComum = massagistaDto.MassagensComum,
            FotosLocal =  massagistaDto.FotosLocal,
            ServicosPremium =  massagistaDto.ServicosPremium
        };
    }
    #endregion
}