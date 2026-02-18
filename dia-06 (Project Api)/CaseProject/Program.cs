using System;
using Microsoft.EntityFrameworkCore;
using Data;
using System.Text.Json;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddControllers(); //  

try
{
    // Conexão com o banco de dados, por default
    builder.Services.AddDbContext<AppDbContext> (option =>
    option.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")) .UseSnakeCaseNamingConvention()
);   
}
catch (Exception err)
{
    throw new ArgumentException("Ocorreu um erro a conexão do banco de dados: "+ err);
}
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseHttpsRedirection();
app.MapControllers(); // MAPEAR TO
app.Run();
