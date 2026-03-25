using EcommerceAdmin.Core.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EcommerceAdmin.Infrastructure.Authentication;

public class EntraAuthenticationConnector : IAuthenticationConnector
{
    public string ProviderName => "Entra";

    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        var tenantId = configuration["AuthenticationConnectors:Entra:TenantId"];
        var clientId = configuration["AuthenticationConnectors:Entra:ClientId"];
        var instance = configuration["AuthenticationConnectors:Entra:Instance"] ?? "https://login.microsoftonline.com/";

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
            {
                options.Authority = $"{instance}{tenantId}/v2.0";
                options.Audience = clientId;
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = clientId,
                    // Additional validation if required
                };
            });
    }
}
