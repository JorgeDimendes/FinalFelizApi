using MassagemPlus.Api.Data;
using MassagemPlus.Api.Repository;
using MassagemPlus.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//SqLite
builder.Services.AddDbContext<AppDbContext>(
    context => context.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

//Repositorys
builder.Services.AddScoped<IMassagistaRepository, MassagistaRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//FinalFelizApi — API para agendamento e serviços de massagem premium
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();