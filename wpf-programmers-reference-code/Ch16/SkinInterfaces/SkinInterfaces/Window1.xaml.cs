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

namespace SkinInterfaces
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

            // Start with the red skin.
            LoadSkin("Red.xaml");
		}

    #region "Work routines"
        private void RepairDisk()
        {
            MessageBox.Show("Repair Disk");
        }

        private void VirusCheck()
        {
            MessageBox.Show("Virus Check");
        }

        private void FormatDisk()
        {
            MessageBox.Show("Format Disk");
        }

        // Load the skin file and wire up event handlers.
        private void LoadSkin(string skin_file)
        {
            // Load the controls.
            FrameworkElement element =
                (FrameworkElement)Application.LoadComponent(
                    new Uri(skin_file, UriKind.Relative));
            this.Content = element;

            // Wire up the event handlers.
            Button btn;
            Polygon pgn;
            Rectangle rect;
            Grid grd;
            Ellipse ell;

            switch (element.Tag.ToString())
            {
                case "Red":
                    btn = (Button)element.FindName("btnRepairDisk");
                    btn.Click += new RoutedEventHandler(btnRepairDisk_Click);

                    btn = (Button)element.FindName("btnVirusCheck");
                    btn.Click += new RoutedEventHandler(btnVirusCheck_Click);

                    btn = (Button)element.FindName("btnFormatDisk");
                    btn.Click += new RoutedEventHandler(btnFormatDisk_Click);

                    pgn = (Polygon)element.FindName("pgnSkin");
                    pgn.MouseDown += new MouseButtonEventHandler(
                        pgnSkin_MouseDown);

                    rect = (Rectangle)element.FindName("rectMove");
                    rect.MouseDown += new MouseButtonEventHandler(
                        rectMove_MouseDown);

                    grd = (Grid)element.FindName("grdExit");
                    grd.MouseDown += new MouseButtonEventHandler(
                        grdExit_MouseDown);
                    break;

                case "Blue":
                    grd = (Grid)element.FindName("grdRepairDisk");
                    grd.MouseDown += new MouseButtonEventHandler(
                        grdRepairDisk_MouseDown);

                    grd = (Grid)element.FindName("grdVirusCheck");
                    grd.MouseDown += new MouseButtonEventHandler(
                        grdVirusCheck_MouseDown);

                    grd = (Grid)element.FindName("grdFormatDisk");
                    grd.MouseDown += new MouseButtonEventHandler(
                        grdFormatDisk_MouseDown);

                    // Uses the same event handler as pgnSkin.
                    ell = (Ellipse)element.FindName("ellSkin");
                    ell.MouseDown +=
                        new System.Windows.Input.MouseButtonEventHandler(
                            pgnSkin_MouseDown);

                    // Uses the same event handler as rectMove.
                    ell = (Ellipse)element.FindName("ellMove");
                    ell.MouseDown +=
                        new System.Windows.Input.MouseButtonEventHandler(
                            rectMove_MouseDown);

                    grd = (Grid)element.FindName("grdExit");
                    grd.MouseDown +=
                        new System.Windows.Input.MouseButtonEventHandler(
                            grdExit_MouseDown);
                    break;
            }
        }
    #endregion // Work routines

    #region "Red skin event handlers"
        private void btnRepairDisk_Click(object sender, RoutedEventArgs e)
        {
            RepairDisk();
        }

        private void btnVirusCheck_Click(object sender, RoutedEventArgs e)
        {
            VirusCheck();
        }

        private void btnFormatDisk_Click(object sender, RoutedEventArgs e)
        {
            FormatDisk();
        }

        private void pgnSkin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement element = (FrameworkElement)sender;
            LoadSkin(element.Tag.ToString());
        }

        private void rectMove_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void grdExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    #endregion // Red skin event handlers"

    #region "Blue skin event handlers"
        private void grdRepairDisk_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RepairDisk();
        }

        private void grdVirusCheck_MouseDown(object sender, MouseButtonEventArgs e)
        {
            VirusCheck();
        }

        private void grdFormatDisk_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FormatDisk();
        }
    #endregion // Blue skin event handlers"
    }
}