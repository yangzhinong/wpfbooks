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

namespace GrowingButtons
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

        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the button that was clicked.
            Button btn = (Button)sender;

            // Use its color to make a gradient brush.
            SolidColorBrush br = (SolidColorBrush)btn.Background;
            this.Background = new LinearGradientBrush(
                Colors.White, br.Color, 90);
        }
	}
}