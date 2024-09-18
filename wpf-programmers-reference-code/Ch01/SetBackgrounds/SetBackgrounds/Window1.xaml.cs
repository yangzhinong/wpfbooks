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

namespace SetBackgrounds
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

        private void btnHorizontal_Click(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush bg = new LinearGradientBrush(Colors.White, Colors.Green, 90);
            grdMain.Background = bg;
        }

        private void btnVertical_Click(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush bg = new LinearGradientBrush(Colors.White, Colors.Red, 0);
            grdMain.Background = bg;
        }
	}
}