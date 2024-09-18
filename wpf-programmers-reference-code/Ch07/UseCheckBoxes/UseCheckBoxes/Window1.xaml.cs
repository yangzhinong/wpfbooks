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

namespace UseCheckBoxes
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
            // Give the shovel racing box an indeterminate state.
            chkShovelRacing.IsChecked = null;
		}

        // Display the current registrations.
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            ShowRegistrations();
        }

        private void ShowRegistrations()
        {
            Console.WriteLine("Current Registrations:");
            if (chkStreetLuge.IsChecked == true) Console.WriteLine("    Street Luge");
            if (chkStreetLuge.IsChecked == null) Console.WriteLine("    (Street Luge?)");
            if (chkSkysurfing.IsChecked == true) Console.WriteLine("    Skysurfing");
            if (chkSkysurfing.IsChecked == null) Console.WriteLine("    (Skysurfing?)");
            if (chkVertTriples.IsChecked == true) Console.WriteLine("    Vert Triples");
            if (chkVertTriples.IsChecked == null) Console.WriteLine("    (Vert Triples?)");
            if (chkShovelRacing.IsChecked == true) Console.WriteLine("    Super-Modified Shovel Racing");
            if (chkShovelRacing.IsChecked == null) Console.WriteLine("    (Super-Modified Shovel Racing?)");
            Console.WriteLine();
        }
	}
}