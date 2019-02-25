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
using System.Diagnostics;

namespace Lab_115_Norwthwind_Entity_With_OOP
{
    /// <summary>
    /// Lab 115 
    /// Read Custoemrs and cast to active customers 
    /// Set is Active true for all customers
    /// 
    /// Create 2 list boxes and a radio button/toogle button to enable or disable an active customer
    /// 
    /// Click on customer to select and display all details on screen (TextBlock,Stackpanel,Listbox)
    /// 
    /// When clicked on enable/ disable button reverses the state of the isactive state
    /// 
    /// First list is only for active customers.
    ///             if state is false remove inactive customers from listbox
    ///             
    /// Second List is only for inactive state remove from first but add to second 
    /// 
    /// Reverse the process if Inactive customer is selected move to first listbox by using the toogle button
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            
        }
    }

    //Interface is like a tool that classes can use
    interface IDoThis
    {
        void DoThis();
    }

    interface IDoThat
    {
        void DoThat();
    }

    class ActiveCustomer : Customer, IDoThis, IDoThat
    {
        public bool IsActive;

        public void DoThis()
        {

        }
        public void DoThat()
        {

        }

    }



    //public partial class Customer   // Partial: Extends class to add other fields
    //{
    //    public void DoThis()
    //    {
    //        Trace.WriteLine("Customer doing Something");
    //    }
    //}
}
