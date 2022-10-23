using EPolling.Application;
using EPolling.Infrastructure;
using EPolling.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureApplicationService();
builder.Services.ConfigurePersistenceService(builder.Configuration);


builder.Services.ConfigureInfrastructureService();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        policy =>
        {
            policy.AllowAnyOrigin();
            policy.AllowAnyHeader();
            policy.AllowAnyMethod();
        });
});


builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer Scheme.
                        Enter 'Bearer'[space] and then your token in the text input below.
                        Example: Bearer 12345abcdef ",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference {Type = ReferenceType.SecurityScheme, Id = "Bearer"},
            Scheme = "oauth2",
            Name = "Bearer",
            In = ParameterLocation.Header,


        },
        new List<string>()
        }
    });
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "EPolling.API",
        Description = "EPolling API"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("../swagger/v1/swagger.json", "EPolling.API v1"));
}
app.UseAuthentication();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();
app.UseCors("CorsPOlicy");


app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("../swagger/v1/swagger.json", "EPolling.API v1"));

app.Run();
