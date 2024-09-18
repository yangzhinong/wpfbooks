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

using Microsoft.Win32;
using System.Windows.Markup;
using System.IO;

namespace SimpleRichEditor
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

        // Give the selection the chosen font.
        private void cboFont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (rchNotes == null) return;
            if (e.AddedItems.Count < 1) return;
            ComboBoxItem item = (ComboBoxItem)e.AddedItems[0];
            string value = item.Content.ToString();

            FontFamily font_family = new FontFamily(value);
            rchNotes.Selection.ApplyPropertyValue(TextElement.FontFamilyProperty, font_family);
            rchNotes.Focus();
        }

        // Give the selection the chosen size.
        private void cboSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (rchNotes == null) return;
            if (e.AddedItems.Count < 1) return;
            ComboBoxItem item = (ComboBoxItem)e.AddedItems[0];
            string value = item.Content.ToString();

            rchNotes.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, value);
            rchNotes.Focus();
        }

        // Give the selection the chosen color.
        private void cboColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (rchNotes == null) return;
            if (e.AddedItems.Count < 1) return;
            ComboBoxItem item = (ComboBoxItem)e.AddedItems[0];
            string value = item.Content.ToString();

            switch (value)
            {
                case "Black":
                    rchNotes.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Black);
                    break;
                case "Red":
                    rchNotes.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Red);
                    break;
                case "Green":
                    rchNotes.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Green);
                    break;
            }

            rchNotes.Focus();
        }

        // Give the selection the chosen weight.
        private void cboWeight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (rchNotes == null) return;
            if (e.AddedItems.Count < 1) return;
            ComboBoxItem item = (ComboBoxItem)e.AddedItems[0];
            string value = item.Content.ToString();

            switch (value)
            {
                case "Normal":
                    rchNotes.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
                    break;
                case "Bold":
                    rchNotes.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
                    break;
            }

            rchNotes.Focus();
        }

        // Give the selection the chosen style.
        private void cboStyle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (rchNotes == null) return;
            if (e.AddedItems.Count < 1) return;
            ComboBoxItem item = (ComboBoxItem)e.AddedItems[0];
            string value = item.Content.ToString();

            switch (value)
            {
                case "Normal":
                    rchNotes.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
                    break;
                case "Italic":
                    rchNotes.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
                    break;
            }

            rchNotes.Focus();
        }

        // Display the selection's properties.
        private void rchNotes_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (rchNotes == null) return;

            // Font family.
            FontFamily font_family = rchNotes.Selection.GetPropertyValue(TextElement.FontFamilyProperty) as FontFamily;
            if (font_family == null)
            {
                cboFont.Text = "";
            } else {
                cboFont.Text = font_family.Source;
            }

            // Size.
            cboSize.Text = rchNotes.Selection.GetPropertyValue(TextElement.FontSizeProperty).ToString();

            // Color.
            SolidColorBrush br = rchNotes.Selection.GetPropertyValue(TextElement.ForegroundProperty) as SolidColorBrush;
            if (br == null)
            {
                cboColor.Text = "";
            } else {
                switch (br.Color.ToString())
                {
                    case "#FF000000":
                        cboColor.Text = "Black";
                        break;
                    case "#FFFF0000":
                        cboColor.Text = "Red";
                        break;
                    case "#FF008000":
                        cboColor.Text = "Green";
                        break;
                    default:
                        cboColor.Text = "";
                        break;
                }
            }

            // Weight.
            cboWeight.Text = rchNotes.Selection.GetPropertyValue(TextElement.FontWeightProperty).ToString();

            // Style.
            cboStyle.Text = rchNotes.Selection.GetPropertyValue(TextElement.FontStyleProperty).ToString();
        }

        // Load a XAML file.
        private void mnuFileOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".xaml";
            dlg.Filter = "XAML Files (.xaml)|*.xaml|All Files|*.*";

            if (dlg.ShowDialog() == true)
            {
                // Open the file.
                XamlReader reader = new XamlReader();
                FileStream fs = File.OpenRead(dlg.FileName);
                try
                {
                    // Read the FlowDocument stored in the file.
                    FlowDocument flow_document = (FlowDocument)XamlReader.Load(fs);
                    
                    // Display the new FlowDocument.
                    rchNotes.Document = flow_document;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error Reading File",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                finally
                {
                    fs.Close();
                }
            }
        }

        // Save the document.
        private void mnuFileSave_Click(object sender, RoutedEventArgs e)
        {
            // Get the file name.
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".xaml";
            dlg.Filter = "XAML Files (.xaml)|*.xaml|All Files|*.*";

            if (dlg.ShowDialog() == true)
            {
                FileStream fs = File.OpenWrite(dlg.FileName);
                try
                {
                    // Save.
                    XamlWriter.Save(rchNotes.Document, fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error Saving File",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                finally
                {
                    fs.Close();
                }
            }
        }
	}
}