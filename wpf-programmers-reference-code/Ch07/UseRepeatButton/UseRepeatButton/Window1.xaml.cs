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

namespace UseRepeatButton
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

        private int m_NumSent = 0;

        // "Send" a spam message.
        private void rptSendSpam_Click(object sender, RoutedEventArgs e)
        {
            m_NumSent++;
            lblNumSent.Content = m_NumSent.ToString();
        }
	}
}