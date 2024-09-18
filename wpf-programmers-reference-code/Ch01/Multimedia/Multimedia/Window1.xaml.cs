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

namespace Multimedia
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

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mmBear.Pause();
            mmFractal.Pause();
            mmButterfly.Pause();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mmBear.Play();
            mmFractal.Play();
            mmButterfly.Play();
        }

        private void btnRewind_Click(object sender, RoutedEventArgs e)
        {
            mmBear.Position = new TimeSpan(0);
            mmFractal.Position = new TimeSpan(0);
            mmButterfly.Position = new TimeSpan(0);
        }
	}
}