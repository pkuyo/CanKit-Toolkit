using CanKitToolkit.Models;

namespace CanKitToolkit.Services
{
    public interface IDeviceService
    {
        Task<DeviceCapabilities> GetCapabilitiesAsync(string endpoint);
    }
}

