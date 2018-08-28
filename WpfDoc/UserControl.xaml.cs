using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight;

namespace WpfDoc
{
    /// <summary>
    /// Interaction logic for UserControl.xaml
    /// </summary>
    public partial class UserControl : Window
    {

        public UserControl()
        {
            InitializeComponent();
            
            this.DataContext = new UserControlViewModel();
            
        }
    }

    public class UserControlViewModel : ViewModelBase
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public UserControlViewModel()
        {
            Customers = new ObservableCollection<Customer>
            {
                new Customer {Name = "Isa", Age = "12"},
                new Customer {Name = "Wis", Age = "22"},
            };
        }
    }

    public class UserControlDesignTimeViewModel : ViewModelBase
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public UserControlDesignTimeViewModel()
        {
            Customers = new ObservableCollection<Customer>
            {
                new Customer {Name = "Isa", Age = "12"},
                new Customer {Name = "Wis", Age = "22"},
            };
        }
    }


    public class Customer
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
