using EPolling.Application.Model.Identity;
using EPolling.Domain.Identity;
using EPolling.Persistence.AppDbContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EPolling.Application.Interface.Identity;
using EPolling.Application.Repository.Identity;
using EPolling.Persistence.Repository.Common;
using EPolling.Persistence.Repository.Data;
using EPolling.Application.Interface.Data;

namespace EPolling.Persistence
{
    public static class PersistenceService
    {
        public static IServiceCollection ConfigurePersistenceService(this IServiceCollection services, IConfiguration config)
        {
            //Add Persistence Services 
            services.Configure<JwtSettings>(config.GetSection("JwtSettings"));
            services.AddDbContext<PollingIdentityDbContext>(options =>
            {
                options.UseSqlServer(config["ConnectionStrings:Database"],
                    b => b.MigrationsAssembly("EPolling.Persistence"));

            });
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<PollingIdentityDbContext>().AddDefaultTokenProviders();
            services.AddTransient<IAuthService, AuthService>();
            services.AddScoped<IOnBoardingRepository, OnBoardingRepository>();
            services.AddScoped<ILgaRepository, LgaRepository>();
            services.AddScoped<IPollingUnitRepository, PollingUnitRepository>();
            services.AddScoped<IStateRepository, StateRepository>();
            services.AddScoped<IWardRepository, WardRepository>();



            services.AddScoped<IOnBoardingRepository, OnBoardingRepository>();

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddGoogle(google =>
            {
                google.ClientId = config["Google:ClientID"];
                google.ClientSecret = config["Google:ClientSecret"];
            }).AddFacebook(face =>
            {
                face.AppId = config["FB:AppID"];
                face.AppSecret = config["FB:AppSecret"];
            }).AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidIssuer = config["JwtSettings:Issuer"],
                    ValidAudience = config["JwtSettings:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JwtSettings:Key"]))
                };
            });

            return services;
        }
    }
}
