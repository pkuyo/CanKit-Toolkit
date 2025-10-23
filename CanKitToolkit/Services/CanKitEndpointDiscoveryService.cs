using CanKit.Core.Endpoints;
using CanKitToolkit.Models;

namespace CanKitToolkit.Services
{
    public class CanKitEndpointDiscoveryService : IEndpointDiscoveryService
    {
        public Task<IReadOnlyList<EndpointInfo>> DiscoverAsync()
        {
            // Try enumerate from known providers; missing providers are simply ignored
            var list = new List<EndpointInfo>();
            try
            {
                var entries = BusEndpointEntry.Enumerate("pcan", "kvaser", "socketcan", "zlg", "virtual");
                foreach (var ep in entries)
                {
                    list.Add(new EndpointInfo
                    {
                        Id = ep.Endpoint,
                        DisplayName = string.IsNullOrWhiteSpace(ep.Title) ? ep.Endpoint : ep.Title!,
                        IsCustom = false
                    });
                }
            }
            catch
            {
                // ignore discovery failures; user can still enter custom endpoint
            }

            // Always append Custom option
            list.Add(EndpointInfo.Custom());
            return Task.FromResult<IReadOnlyList<EndpointInfo>>(list);
        }
    }
}

