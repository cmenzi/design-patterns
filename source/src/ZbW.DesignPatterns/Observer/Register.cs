using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GoF.Observer
{
    public class Register : INotifyPropertyChanged
    {
        private decimal _total;
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        public decimal Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Total)));
            }
        }

    }

    public class RegisterNoCSharpSugar
    {
        private readonly List<IObservable> _observables = new List<IObservable>();

        private decimal _total;

        public void Register(IObservable observable)
        {
            _observables.Add(observable);
        }

        public decimal Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                Notify(nameof(Total));
            }
        }

        void Notify(string propertyName)
        {
            foreach (var observable in _observables)
            {
                observable.PropertyChanged(propertyName);
            }
        }
    }

    public interface IObservable
    {
        void PropertyChanged(string propertyName);
    }
}
