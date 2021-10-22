using System;
using System.Windows;
using DataBinding.ObjetoSimple.Model;

namespace DataBinding.ObjetoSimple
{
   
    public partial class MainWindow : Window
    {
        private Eventos evento;
        public MainWindow()
        {
            InitializeComponent();

            evento = new Eventos()
            {
                Title = "Reunion de academia",
                Date = new DateTime(2021, 10, 22)
            };
            UpdateUI();
        }

        private void UpdateUI()
        {
            eventoTextBox.Text = evento.Title;
            fechaDatePicker.SelectedDate = evento.Date;
        }

        private void modificarEventoButton_Click(object sender, RoutedEventArgs e)
        {
            evento.Title = evento.Title.ToUpper();
            evento.Date = evento.Date.AddDays(1);
            UpdateUI();
        }
    }
}
