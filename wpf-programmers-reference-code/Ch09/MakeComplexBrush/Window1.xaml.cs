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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MakeComplexBrush
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        // Build the Grid's Background brush.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RadialGradientBrush br = new RadialGradientBrush();
            br.GradientStops.Add(new GradientStop(Colors.White,  0.00));
            br.GradientStops.Add(new GradientStop(Colors.Red,    0.25));
            br.GradientStops.Add(new GradientStop(Colors.Yellow, 0.50));
            br.GradientStops.Add(new GradientStop(Colors.Lime,   0.75));
            br.GradientStops.Add(new GradientStop(Colors.Blue,   1.00));
            grdBackground.Background = br;
        }
    }
}
