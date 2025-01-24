

using CRUDSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var builder = WebApplication.CreateBuilder(args);

// Adiciona o DbContext com a connection string do appsettings.json
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configurar os serviços
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Necessário para o Swagger funcionar
builder.Services.AddSwaggerGen(); // Adiciona o Swagger

var app = builder.Build();

// Configurar o pipeline de requisição
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Habilita o middleware do Swagger
    app.UseSwaggerUI(); // Configura a interface do Swagger
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // Mapeia os controllers

app.Run();
