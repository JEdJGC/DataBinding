using System;
using System.ComponentModel;

namespace DataBinding.ObjetoSimple.Model
{
    public class Eventos : INotifyPropertyChanged
    {

        private string _Title;
        private DateTime _Date;

        public string Title
        {
            get => _Title;
            set
            {
                if(_Title != value)
                {
                    _Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }
        public DateTime Date
        {
            get => _Date;
            set
            {
                if(_Date != value)
                {
                    _Date = value;
                    OnPropertyChanged("Date");

                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
