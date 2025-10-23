using System.ComponentModel;

namespace CanKitToolkit.Services
{
    public interface IBusState : INotifyPropertyChanged
    {
        bool IsListening { get; }
    }
}

