using EcommerceAdmin.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace EcommerceAdmin.Infrastructure.Authentication;

public static class AuthenticationSetup
{
    public static IServiceCollection AddDynamicAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        var provider = configuration["AuthenticationConnectors:Provider"] ?? "Entra";
        
        // Find the connector implementation that matches the provider name
        var connectorType = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(IAuthenticationConnector).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .FirstOrDefault(t => 
            {
                var instance = (IAuthenticationConnector)Activator.CreateInstance(t)!;
                return instance.ProviderName.Equals(provider, StringComparison.OrdinalIgnoreCase);
            });

        if (connectorType != null)
        {
            var connector = (IAuthenticationConnector)Activator.CreateInstance(connectorType)!;
            connector.ConfigureServices(services, configuration);
        }
        else
        {
            // Default fallback or throw exception
            throw new InvalidOperationException($"Authentication connector '{provider}' is not supported.");
        }

        return services;
    }
}
