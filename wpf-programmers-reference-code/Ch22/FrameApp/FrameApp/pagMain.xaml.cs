using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FrameApp
{
	public partial class pagMain
	{
		public pagMain()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

        // Go to the AddCustomer page.
        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pagAddCustomer());
        }

        // Go to the FindCustomer page.
        private void btnFindCustomer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pagFindCustomer());
        }

        // Go to the Invoices page.
        private void btnInvoices_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pagInvoices());
        }

        // Go to the Shipping page.
        private void btnShipping_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pagShipping());
        }

        // Go to the help Web site.
        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("http://www.vb-helper.com/wpf.htm"));
        }
	}
}
