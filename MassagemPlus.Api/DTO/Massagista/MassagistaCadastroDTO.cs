using System.ComponentModel.DataAnnotations;

namespace MassagemPlus.Api.DTO.Massagista;

public class MassagistaCadastroDTO
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres.")]
    public string SenhaHash { get; set; } = null!;  // Aqui recebe a senha em texto

    [Required]
    public string Nome { get; set; } = null!;
}