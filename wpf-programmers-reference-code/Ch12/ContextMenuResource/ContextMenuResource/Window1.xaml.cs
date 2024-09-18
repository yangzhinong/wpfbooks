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

namespace ContextMenuResource
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

        // Remember the image clicked.
        private Image m_ImageClicked = null;
        private void img_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                m_ImageClicked = (Image)sender;
            }
        }

        // Display details for the person clicked.
        private void mnuDetails_Click(object sender, RoutedEventArgs e)
        {
            if (m_ImageClicked != null)
                MessageBox.Show("Display details for " + m_ImageClicked.Tag.ToString());
        }
        // Email the person clicked.
        private void mnuEmail_Click(object sender, RoutedEventArgs e)
        {
            if (m_ImageClicked != null)
                MessageBox.Show("Email " + m_ImageClicked.Tag.ToString());
        }
        // Phone the person clicked.
        private void mnuPhone_Click(object sender, RoutedEventArgs e)
        {
            if (m_ImageClicked != null)
                MessageBox.Show("Phone " + m_ImageClicked.Tag.ToString());
        }
        // Delete the person clicked.
        private void mnuDelete_Click(object sender, RoutedEventArgs e)
        {
            if (m_ImageClicked != null)
                MessageBox.Show("Delete " + m_ImageClicked.Tag.ToString());
        }
	}
}