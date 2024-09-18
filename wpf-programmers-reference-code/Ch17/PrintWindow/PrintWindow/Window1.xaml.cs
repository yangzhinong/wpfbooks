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
//   System.Printing
//   ReachFramework
using System.Printing;
using System.Windows.Media.Effects;

namespace PrintWindow
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

        // Print the window centered.
        private void btnPrintCentered_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == true)
            {
                PrintWindowCentered(pd, this, "New Customer", null);
            }
        }

        // Print the window stretched to fit.
        private void btnPrintStretched_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if (pd.ShowDialog() == true)
            {
                PrintWindowCentered(pd, this, "New Customer", new Thickness(50));
            }
        }

        // Print a Window centered on the printer.
        private void PrintWindowCentered(PrintDialog pd, Window win, String title, Thickness? margin)
        {
            // Make a Grid to hold the contents.
            Grid drawing_area = new Grid();
            drawing_area.Width = pd.PrintableAreaWidth;
            drawing_area.Height = pd.PrintableAreaHeight;

            // Make a Viewbox to stretch the result if necessary.
            Viewbox view_box = new Viewbox();
            drawing_area.Children.Add(view_box);
            view_box.HorizontalAlignment = HorizontalAlignment.Center;
            view_box.VerticalAlignment = VerticalAlignment.Center;

            if (margin == null)
            {
                // Center without resizing.
                view_box.Stretch = Stretch.None;
            }
            else
            {
                // Resize to fit the margin.
                view_box.Margin = margin.Value;
                view_box.Stretch = Stretch.Uniform;
            }

            // Make a VisualBrush holding an image of the Window's contents.
            VisualBrush vis_br = new VisualBrush(win);

            // Make a rectangle the size of the Window.
            Rectangle win_rect = new Rectangle();
            view_box.Child = win_rect;
            win_rect.Width = win.Width;
            win_rect.Height = win.Height;
            win_rect.Fill = vis_br;
            win_rect.Stroke = Brushes.Black;
            win_rect.BitmapEffect = new DropShadowBitmapEffect();

            // Arrange to produce output.
            Rect rect = new Rect(0, 0,
                pd.PrintableAreaWidth, pd.PrintableAreaHeight);
            drawing_area.Arrange(rect);

            // Print it.
            pd.PrintVisual(drawing_area, title);
        }
    }
}