using CanKitToolkit.Models;

namespace CanKitToolkit.Services
{
    public interface IEndpointDiscoveryService
    {
        Task<IReadOnlyList<EndpointInfo>> DiscoverAsync();
    }
}

