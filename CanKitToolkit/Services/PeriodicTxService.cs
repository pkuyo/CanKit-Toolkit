using CanKit.Core.Definitions;

namespace CanKitToolkit.Services
{
    public class PeriodicTxService : IPeriodicTxService
    {
        private readonly IListenerService _listenerService;

        public PeriodicTxService(IListenerService listenerService)
        {
            _listenerService = listenerService;
        }

        public void Start(IEnumerable<(ICanFrame frame, TimeSpan period)> items)
            => _listenerService.StartPeriodic(items);

        public void Stop() => _listenerService.StopPeriodic();
    }
}

