using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace EcommerceAdmin.Core.Interfaces;

public interface IAuthenticationConnector
{
    /// <summary>
    /// Gets the name of the connector (e.g., "Entra", "Auth0", "IdentityServer").
    /// </summary>
    string ProviderName { get; }

    /// <summary>
    /// Configures the authentication services required by the connector.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configuration">The application configuration.</param>
    void ConfigureServices(IServiceCollection services, IConfiguration configuration);
}
