using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SelectColor
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Update the sample.
        private void scr_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            // Get the new color.
            Color clr = new Color();
            clr.R = (byte)scrRed.Value;
            clr.G = (byte)scrGreen.Value;
            clr.B = (byte)scrBlue.Value;
            clr.A = 255;

            // Apply the color.
            SolidColorBrush br = new SolidColorBrush(clr);
            grdSample.Background = br;
        }
    }
}
