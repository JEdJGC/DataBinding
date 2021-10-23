using DataBinding.Collections.Model;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace DataBinding.Collections
{

    public partial class MainWindow : Window
    {

        private ObservableCollection<User> users;

        public MainWindow()
        {
            InitializeComponent();
            LoadUsers();
            //usersListBox.ItemsSource = users;
            DataContext = users;
        }
        private void LoadUsers()
        {
            users = new ObservableCollection<User>();
            users.Add(new User { Name = "Peter Parker" });
            users.Add(new User { Name = "Tony Stark" });
            users.Add(new User { Name = "Natasha Romanoff" });

        }
        private void addUserButton_Click(object sender, RoutedEventArgs e)
        {
                User user = new User { Name = "Nuevo usuario" };
                users.Add(user);
                usersListBox.SelectedItem = user;
                UpdateView();

        }
        private void changeUserButton_Click(object sender, RoutedEventArgs e)
        {
            if(usersListBox.SelectedItem != null)
            {
                User user = usersListBox.SelectedItem as User;
                //user.Name = userTextBox.Text;
                usersListBox.SelectedItem = user;
                UpdateView();

            }

        }
        private void deleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            if(usersListBox.SelectedItem != null)
            {
                User user = usersListBox.SelectedItem as User;
                users.Remove(user);
                UpdateView();
            }
        }

        private void UpdateView()
        {
            //userTextBox.Text = string.Empty;
            usersListBox.Items.Refresh();
            if (users.Count > 0)
            {
                deleteUserButton.IsEnabled = true;
                changeUserButton.IsEnabled = true;
            }
            else
            {
                deleteUserButton.IsEnabled = false;
                changeUserButton.IsEnabled = false;
                usersListBox.SelectedIndex = -1;
            }
        }

    }
}
