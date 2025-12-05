using CanKit.Abstractions.API.Can.Definitions;
using CanKit.Core.Definitions;

namespace CanKitToolkit.Services
{
    public interface IPeriodicTxService
    {
        void Start(IEnumerable<(CanFrame frame, TimeSpan period)> items);
        void Stop();
    }
}

