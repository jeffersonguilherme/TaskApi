using Infra.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Adiciona serviços ao contêiner
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();  // Para Swagger
builder.Services.AddSwaggerGen();            // Para Swagger
builder.Services.AddAuthorization();         // Corrige o erro de autorização
builder.Services.AddDbContext<TaskDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization(); // Agora funciona corretamente

app.MapControllers();

app.Run();
