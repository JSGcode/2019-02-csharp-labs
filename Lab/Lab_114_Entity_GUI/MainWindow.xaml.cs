using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace Lab_114_Entity_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Customer> customersFromDatabase = new List<Customer>();
        static List<string> customerList = new List<string>();
        static List<string> Cities = new List<string>() { "London", "Mexico City", "Hong Kong", "Toronto", "Quito",
                                                          "Lima", "Tokyo", "Berlin" };
        Customer customer1;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            CityDropdown.ItemsSource = Cities;
            using (var db = new NorthwindEntities())
            {
                customersFromDatabase = db.Customers.ToList<Customer>();
                ListOfCustomers.ItemsSource = customersFromDatabase;
                ListOfCustomers.DisplayMemberPath = "ContactName";
            }
        }

        private void ListOfCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                customer1 = (Customer)ListOfCustomers.SelectedItem;
                Details.Text = $"Name: {customer1.ContactName}\nCity: {customer1.City}";
            }
        }

        private void CityDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                var customerToUpdate =
                    db.Customers.Where(c => c.ContactName == customer1.ContactName).FirstOrDefault();

                // UPDATE
                if (!CityDropdown.Text.Equals(""))
                {
                    customerToUpdate.ContactName = EditName.Text;
                    customerToUpdate.City = CityDropdown.SelectedItem.ToString();
                    db.SaveChanges();
                }
                else
                {
                    customerToUpdate.ContactName = EditName.Text;
                    db.SaveChanges();
                }
                Initialize();
            }
        }
    }
}
