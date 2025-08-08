var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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