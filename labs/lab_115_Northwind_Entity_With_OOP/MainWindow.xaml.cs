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
using System.Diagnostics;

namespace lab_115_Northwind_Entity_With_OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// Lab 115
    /// 
    /// Read customers and (cast) to ActiveCustomers and 
    /// set IsActive to true for all customers
    /// 
    /// Create  2 list boxes and radio button to enable/disable
    /// our ActiveCustomer
    /// 
    /// Click on Customer to select and display all details on
    /// screen   (TextBlock, StackPanel, ListBox2)
    /// 
    /// When you click on Enable/Disable Toggle button the IsActive 
    /// changes (toggles) state 
    /// 
    /// First listbox = only for ACTIVE CUSTOMERS
    ///         state becomes inactive ==> remove from first listbox
    ///         
    /// Second listbox = only for INACTIVE CUSTOMERS
    ///         inactive state : remove from first but add to 
    ///         second listbox
    /// 
    /// Reverse the process ie click on INACTIVE CUSTOMER (second
    ///         listbox) you can then toggle the state back to 
    ///         enabled (use the radio/toggle button).
    ///         Removed from INACTIVE and add back to ACTIVE list
    /// 
    /// 
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
        // Interface is like a tool you can use/implement
        interface IDoThis
        {
            void DoThis();
        }

        interface IDoThat
        {
            void DoThat();
        }

        // class Customer
        // class ActiveCustomer : Customer
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
    }






}
