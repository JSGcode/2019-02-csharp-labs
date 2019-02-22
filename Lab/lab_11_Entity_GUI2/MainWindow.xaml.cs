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

namespace lab_11_Entity_GUI2
{
    public partial class MainWindow : Window
    {
        static List<string> customerList = new List<string>();
        static List<Customer> customers = new List<Customer>();
        Customer customer1;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            // List of Strings
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                foreach (var item in customers)
                {
                    customerList.Add($"{item.ContactName} has ID {item.CustomerID}");
                }
                Box1.ItemsSource = customerList;
            }
            // List of objects related to the database Linked to XAML
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                Box2.ItemsSource = customers;
            }
            // Simple Version of previous case
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                Box3.ItemsSource = customers;
                Box3.DisplayMemberPath = "ContactName";
            }
        }

        private void Box3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer1 = (Customer)Box3.SelectedItem;
            TextboxName.Text = customer1.ContactName;
        }
    }
}
