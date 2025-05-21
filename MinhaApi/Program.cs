var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();  // Para Swagger
builder.Services.AddSwaggerGen();            // Para Swagger
builder.Services.AddAuthorization();         // Corrige o erro de autorização

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization(); // Agora funciona corretamente

app.MapControllers();

app.Run();
