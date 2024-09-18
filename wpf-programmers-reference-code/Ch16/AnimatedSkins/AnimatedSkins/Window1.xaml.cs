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

namespace AnimatedSkins
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

        private void grdEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Email here");
        }

        private void grdPhone_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Phone here");
        }

        private void grdPost_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Post here");
        }
	}
}