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

// Add a reference to ReachFramework.dll.
using System.Windows.Xps.Packaging;

namespace ViewXpsDocument
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

        // Load the XPS document.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Note: Mark the file as "Copy if newer"
            // to make a copy go in the output directory.
            XpsDocument xps_doc = new XpsDocument("Fixed Document.xps", System.IO.FileAccess.Read);
            docViewer.Document = xps_doc.GetFixedDocumentSequence();
        }
	}
}