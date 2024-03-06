var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "FarPostTeam present\nKBAC");

app.Run();
