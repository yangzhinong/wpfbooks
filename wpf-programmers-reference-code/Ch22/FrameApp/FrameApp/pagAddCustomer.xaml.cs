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
	public partial class pagAddCustomer
	{
		public pagAddCustomer()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

        // Pretend we did something and return to the main page.
        private void btnOk_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Customer created.", "Customer created",
                MessageBoxButton.OK, MessageBoxImage.Information);
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new pagMain());
            }
        }

        // Return to the main page.
        private void btnCancel_Click(object sender, MouseButtonEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new pagMain());
            }
        }
	}
}
