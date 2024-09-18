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

// Add references to:
//       ReachFramework
//       System.Printing
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace SaveFixedDocument
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

        // Save as an XPS file.
        private void mnuFileSave_Click(System.Object sender, System.Windows.RoutedEventArgs e)
        {
            // Get the file name.
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Shapes";
            dlg.DefaultExt = ".xps";
            dlg.Filter = "XPS Documents (.xps)|*.xps|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                // Save the document.
                // Make an XPS document.
                XpsDocument xps_doc = new XpsDocument(dlg.FileName, System.IO.FileAccess.Write);

                // Make an XPS document writer.
                XpsDocumentWriter doc_writer =
                    XpsDocument.CreateXpsDocumentWriter(xps_doc);
                doc_writer.Write(fdContents);
                xps_doc.Close();
            }
        }
	}
}