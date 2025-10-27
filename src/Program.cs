using DotNetEnv;
using BugStore.Infra.Extensions;
using src.Endpoints;
Env.Load();
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.MapEndpoints();

app.Run();
