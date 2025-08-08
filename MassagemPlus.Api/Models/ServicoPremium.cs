using System.Text.Json.Serialization;

namespace MassagemPlus.Api.Models;

public class ServicoPremium
{
    public int Id { get; set; }
    public string Descricao { get; set; } = null!;
    public decimal Preco { get; set; }
    
    public int MassagistaId { get; set; }
    [JsonIgnore]
    public Massagista Massagista { get; set; }
}