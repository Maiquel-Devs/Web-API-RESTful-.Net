var builder = WebApplication.CreateBuilder(args);

// 1. Adiciona o suporte para os seus Controllers
builder.Services.AddControllers();

// 2. Configura o Swagger (Necessário para a interface visual)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 3. Configura o ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    // Gera o arquivo JSON da API
    app.UseSwagger();
    // CRIA A INTERFACE VISUAL no endereço /swagger
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();