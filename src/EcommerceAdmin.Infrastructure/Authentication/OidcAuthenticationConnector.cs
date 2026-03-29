using EcommerceAdmin.Core.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EcommerceAdmin.Infrastructure.Authentication;

public class OidcAuthenticationConnector : IAuthenticationConnector
{
    public string ProviderName => "OIDC";

    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        var authority = configuration["AuthenticationConnectors:OIDC:Authority"];
        var audience = configuration["AuthenticationConnectors:OIDC:Audience"];

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.Authority = authority;
            options.Audience = audience;
            options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidAudience = audience,
                ValidIssuer = authority
            };
        });
    }
}
