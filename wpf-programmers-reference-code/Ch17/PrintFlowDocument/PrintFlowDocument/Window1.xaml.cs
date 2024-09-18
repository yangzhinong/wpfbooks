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
//   ReachFramework
//   System.Printing
using System.Windows.Xps;
using System.Printing;

namespace PrintFlowDocument
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

        // Print the FlowDocument.
        private void mnuFilePrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == true)
            {
                // Set a page width and height.
                //double wid = fdContents.PageWidth;
                //double hgt = fdContents.PageHeight;
                //fdContents.PageHeight = 900;
                //fdContents.PageWidth = 700;


                // Make an XPS document writer for the print queue.
                XpsDocumentWriter xps_writer =
                    PrintQueue.CreateXpsDocumentWriter(pd.PrintQueue);

                // Turn the FlowDocument into an IDocumentPaginatorSource.
                IDocumentPaginatorSource paginator_source =
                    (IDocumentPaginatorSource)fdContents;

                // Use the IDocumentPaginatorSource's
                // property to get a paginator.
                xps_writer.Write(paginator_source.DocumentPaginator);


                // Restore the original page width and height.
                //fdContents.PageWidth = wid;
                //fdContents.PageHeight = hgt;
            }
        }
	}
}