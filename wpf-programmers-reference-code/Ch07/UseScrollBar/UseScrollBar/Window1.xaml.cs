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

namespace UseScrollBar
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

            // Add event handlers here after all three ScrollBars have been created.
            sbarRed.ValueChanged += sbar_ValueChanged;
            sbarGreen.ValueChanged += sbar_ValueChanged;
            sbarBlue.ValueChanged += sbar_ValueChanged;
        }

        // Display a color sample.
        private void sbar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte r = (byte)sbarRed.Value;
            byte g = (byte)sbarGreen.Value;
            byte b = (byte)sbarBlue.Value;
            Color clr = Color.FromRgb(r, g, b);
            SolidColorBrush br = new SolidColorBrush(clr);
            lblSample.Background = br;

            lblRed.Content = r;
            lblGreen.Content = g;
            lblBlue.Content = b;
        }
    }
}