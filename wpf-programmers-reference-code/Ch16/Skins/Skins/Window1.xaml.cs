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

namespace Skins
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

        // Use the selected skin.
        private void ctxSkin_Click(object sender, RoutedEventArgs e)
        {
            // Get the context menu item that was clicked.
            MenuItem menu_item = (MenuItem)sender;

            // Create a new resource dictionary, using the
            // menu item's Tag property as the dictionary URI.
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri((String)menu_item.Tag, UriKind.Relative);

            // Remove all but the first dictionary.
            while (App.Current.Resources.MergedDictionaries.Count > 1)
            {
                App.Current.Resources.MergedDictionaries.RemoveAt(1);
            }

            // Install the new dictionary.
            App.Current.Resources.MergedDictionaries.Add(dict);
        }

        // Display the options context menu.
        private void Options_MouseDown(object sender, RoutedEventArgs e)
        {
            ctxOptions.IsOpen = true;
        }
    }
}