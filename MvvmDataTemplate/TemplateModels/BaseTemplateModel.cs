using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MvvmDataTemplate.TemplateModels
{
    public class BaseTemplateModel : INotifyPropertyChanged
    {
        public BaseTemplateModel()
        {
        }

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
                return false;
            storage = value;
            RaisePropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var e = new PropertyChangedEventArgs(propertyName);
            PropertyChanged?.Invoke(this, e);
        }
    }
}
