var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "FarPostTeam present\nВорМашин");

app.Run();
