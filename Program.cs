var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Genneffer Santana de Lima Vieira, Você é o amor da minha vida S2!");

app.Run();
