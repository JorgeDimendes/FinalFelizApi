using MassagemPlus.Api.Models;

namespace MassagemPlus.Api.Repository.Interfaces;

public interface IMassagistaRepository : IRepository<Models.Massagista>
{
    Task<Massagista> GetById(int id);
}