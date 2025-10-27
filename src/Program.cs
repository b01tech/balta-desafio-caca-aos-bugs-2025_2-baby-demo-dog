using DotNetEnv;
using BugStore.Infra.Extensions;
using BugStore.Endpoints;
using System.Text.Json;

Env.Load();
var builder = WebApplication.CreateBuilder(args);

// Configurar JSON options
builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    options.SerializerOptions.PropertyNameCaseInsensitive = true;
});

builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.MapEndpoints();

app.Run();
