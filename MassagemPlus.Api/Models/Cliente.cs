namespace MassagemPlus.Api.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string SenhaHash { get; set; }

    public string Nome { get; set; }
    public string? FotoPerfil { get; set; }
}