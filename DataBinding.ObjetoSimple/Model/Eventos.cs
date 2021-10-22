using System;

namespace DataBinding.ObjetoSimple.Model
{
    public class Eventos
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
                }
            }
        }
    }
}
