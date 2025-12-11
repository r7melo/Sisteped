using SistepedApi.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Registrar todos os serviços via extension methods
builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddValidators()
    .AddSwaggerDocumentation()
    .AddJwtAuthentication(builder.Configuration)
    .AddCorsPolicy();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.UseCors("AllowFrontend");

app.MapControllers();

app.Run();
