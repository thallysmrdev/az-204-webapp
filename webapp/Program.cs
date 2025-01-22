var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "AZ-204 - Teste deploy app");

app.Run();
