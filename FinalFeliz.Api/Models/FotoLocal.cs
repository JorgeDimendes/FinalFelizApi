using System.Text.Json.Serialization;

namespace FinalFeliz.Api.Models;

public class FotoLocal
{
    public int Id { get; set; }
    public string? Url { get; set; }
    
    public int MassagistaId { get; set; }
    [JsonIgnore]
    public Massagista? Massagista { get; set; }
}