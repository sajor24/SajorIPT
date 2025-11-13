using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SajorIPT101Solution.SajorWPF.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propName = null)
        {
            if (Equals(storage, value)) return false;
            storage = value;
            OnPropertyChanged(propName);
            return true;
        }
    }
}