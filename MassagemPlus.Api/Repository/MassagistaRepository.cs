using MassagemPlus.Api.Data;
using MassagemPlus.Api.Models;
using MassagemPlus.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MassagemPlus.Api.Repository;

public class MassagistaRepository : Repository<Models.Massagista> , IMassagistaRepository
{
    public MassagistaRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Massagista> GetById(int id)
    {
        return await _dbSet
            .Include(c => c.MassagensComum)
            .Include(c => c.FotosLocal)
            .Include(c => c.ServicosPremium)
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id);
    }
}