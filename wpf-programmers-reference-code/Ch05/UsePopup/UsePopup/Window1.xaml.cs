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

namespace UsePopup
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

        // The mouse has entered an image. Display the popup.
        private void img_MouseEnter(object sender, MouseEventArgs e)
        {
            Image img = (Image)sender;
            imgFullScale.Source = img.Source;

            //popFullScale.AllowsTransparency = true;
            //popFullScale.PopupAnimation = System.Windows.Controls.Primitives.PopupAnimation.None;
            //popFullScale.PopupAnimation = System.Windows.Controls.Primitives.PopupAnimation.Fade;
            //popFullScale.PopupAnimation = System.Windows.Controls.Primitives.PopupAnimation.Scroll;
            //popFullScale.PopupAnimation = System.Windows.Controls.Primitives.PopupAnimation.Slide;

            popFullScale.PlacementTarget = img;
            popFullScale.IsOpen = true;
        }

        // The mouse has left an image. Hide the popup.
        private void img_MouseLeave(object sender, MouseEventArgs e)
        {
            popFullScale.IsOpen = false;
        }
	}
}