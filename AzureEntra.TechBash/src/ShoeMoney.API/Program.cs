using Microsoft.EntityFrameworkCore;
using MinimalApis.Discovery;
using ShoeMoney.Data;
using ShoeMoney.Data.Seeding;
using FluentValidation;
using ShoeMoney.Validators;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ShoeContext>(opt =>
{
  opt.UseSqlServer(builder.Configuration.GetConnectionString("ShoeMoneyDb"));
});

builder.AddTelemetry();

builder.Services.AddCors(cfg =>
{
  cfg.AddDefaultPolicy(x =>
  {
    x.AllowAnyHeader();
    x.AllowAnyMethod();
    x.AllowAnyOrigin();
  });
});

builder.Services.AddHttpContextAccessor();

builder.Services.AddTransient<Seeder>();

builder.Services.AddValidatorsFromAssemblyContaining<OrderValidator>();

builder.Services.ConfigureHttpJsonOptions(options =>
{
  options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
  .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("Entra"));

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
  var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
  using var scope = scopeFactory.CreateScope();

  var ctx = scope.ServiceProvider.GetRequiredService<ShoeContext>();
  ctx.Database.EnsureCreated();

  // Enqueue the seeding
  var seeder = scope.ServiceProvider.GetRequiredService<Seeder>();
  seeder.Seed();
}

app.UseCors();

app.MapDefaultEndpoints();

app.MapApis();

app.Run();
