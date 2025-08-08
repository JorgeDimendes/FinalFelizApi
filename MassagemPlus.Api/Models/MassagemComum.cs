using System.Text.Json.Serialization;

namespace MassagemPlus.Api.Models;

public class MassagemComum
{
    public int Id { get; set; }
    public TimeSpan DuracaoMassagem { get; set; }
    public decimal Preco { get; set; }

    public int MassagistaId { get; set; }
    [JsonIgnore]
    public Massagista Massagista { get; set; } = null!;
}