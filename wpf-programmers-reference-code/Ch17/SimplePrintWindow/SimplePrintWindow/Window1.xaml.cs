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

namespace SimplePrintWindow
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

        // Print the window.
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            // Display the print dialog.
            PrintDialog pd = new PrintDialog();

            // See if the user clicked OK.
            if (pd.ShowDialog() == true)
            {
                // Print.
                pd.PrintVisual(this, "New Customer");
            }
        }
	}
}