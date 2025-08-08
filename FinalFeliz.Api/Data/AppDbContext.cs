using FinalFeliz.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalFeliz.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options)
    {
    }

    public DbSet<Massagista> Massagistas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ServicoPremium> ServicosPremium { get; set; }
    public DbSet<MassagemComum> MassagensComum { get; set; }
    public DbSet<FotoLocal> FotosLocal { get; set; }
}