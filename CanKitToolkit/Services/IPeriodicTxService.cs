using CanKit.Core.Definitions;

namespace CanKitToolkit.Services
{
    public interface IPeriodicTxService
    {
        void Start(IEnumerable<(ICanFrame frame, TimeSpan period)> items);
        void Stop();
    }
}

