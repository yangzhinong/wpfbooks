using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OrderTracking
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void btnUnshippedOrders_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("List unshipped orders here", "Unshipped Orders",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnFindCustomer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Find customer info here", "Find Customer",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnCreateOrder_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Create a new order here", "New Order",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnTrackOrder_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Track orders here", "Track Order",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnSystemMaintenance_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Launch system maintenance application here", "System Maintenance",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
	}
}