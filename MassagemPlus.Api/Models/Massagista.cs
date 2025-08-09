using MassagemPlus.Api.Enum;

namespace MassagemPlus.Api.Models;

public class Massagista
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string SenhaHash { get; set; }
    public string Nome { get; set; } = null!;
    public string? FotoPerfil { get; set; }
    public string? Descricao { get; set; }
    public string? Telefone { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string? Endereco { get; set; }
    
    public List<FormasPagamento>? FormasPagamentos{ get; set; }
    public ICollection<MassagemComum>? MassagensComum { get; set; }
    public ICollection<FotoLocal>? FotosLocal { get; set; }
    public ICollection<ServicoPremium>? ServicosPremium { get; set; }
}