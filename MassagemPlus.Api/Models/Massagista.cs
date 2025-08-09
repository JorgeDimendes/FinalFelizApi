using MassagemPlus.Api.Enum;

namespace MassagemPlus.Api.Models;

public class Massagista
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string SenhaHash { get; set; }
    
    public string Nome { get; set; }  = null!;
    public string FotoPerfil { get; set; } = null!;
    public string Descricao { get; set; }  = null!;
    
    public string Telefone { get; set; } = string.Empty;
    public string Cidade { get; set; } = null!;
    public string Estado { get; set; }  = null!;
    public string Endereco { get; set; } = string.Empty;
    
    public List<FormasPagamento>? FormasPagamentos{ get; set; }
    public ICollection<MassagemComum>? MassagensComum { get; set; }
    public ICollection<FotoLocal>? FotosLocal { get; set; }
    public ICollection<ServicoPremium>? ServicosPremium { get; set; }
}