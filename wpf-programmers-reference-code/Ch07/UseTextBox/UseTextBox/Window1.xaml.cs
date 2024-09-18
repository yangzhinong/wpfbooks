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

namespace UseTextBox
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

        // Update the menu's checkboxes.
        private void mnuFontStyle_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            // Bold.
            mnuFontStyleBold.IsChecked = IsBold();

            // Italic.
            mnuFontStyleItalic.IsChecked = IsItalic();

            // Underlined.
            mnuFontStyleUnderline.IsChecked = IsUnderlined();
        }

        // Return true if the text is bold.
        private bool IsBold()
        {
            Object fw_obj = txtBody.GetValue(
                TextElement.FontWeightProperty);
            if (fw_obj is FontWeight)
            {
                FontWeight fw = (FontWeight)fw_obj;
                return (fw == FontWeights.Bold);
            }
            else
            {
                return false;
            }
        }

        // Return True if the text is italicized.
        private bool IsItalic()
        {
            Object it_obj = txtBody.GetValue(
                TextElement.FontStyleProperty);
            if (it_obj is FontStyle)
            {
                FontStyle it = (FontStyle)it_obj;
                return (it == FontStyles.Italic);
            }
            else
            {
                return false;
            }
        }

        // Return True if the text is underlined.
        private bool IsUnderlined()
        {
            Object ul_obj = txtBody.GetValue(Paragraph.TextDecorationsProperty);
            if (ul_obj is TextDecorationCollection)
            {
                TextDecorationCollection decorations = (TextDecorationCollection)ul_obj;
                return ((decorations.Count > 0) &&
                    (decorations[0].Location == TextDecorationLocation.Underline));
            }
            else
            {
                return false;
            }
        }

        // Toggle bold.
        private void mnuFontBold_Click(object sender, RoutedEventArgs e)
        {
            if (IsBold())
                txtBody.SetValue(FontWeightProperty, FontWeights.Normal);
            else
                txtBody.SetValue(FontWeightProperty, FontWeights.Bold);
        }

        // Toggle italic.
        private void mnuFontItalic_Click(object sender, RoutedEventArgs e)
        {
            if (IsItalic())
                txtBody.SetValue(FontStyleProperty, FontStyles.Normal);
            else
                txtBody.SetValue(FontStyleProperty, FontStyles.Italic);
        }

        // Toggle underline.
        private void mnuFontUnderline_Click(object sender, RoutedEventArgs e)
        {
            TextDecorationCollection decorations = new TextDecorationCollection();

            if (!IsUnderlined())
            {
                TextDecoration text_decoration = new TextDecoration();
                text_decoration.Location = TextDecorationLocation.Underline;
                decorations.Add(text_decoration);
            }

            txtBody.SetValue(Paragraph.TextDecorationsProperty, decorations);
        }

        // Update the FontSize menu.
        private void mnuFontSize_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            Object fs_obj = txtBody.GetValue(
                TextElement.FontSizeProperty);
            if (fs_obj == DependencyProperty.UnsetValue)
            {
                mnuFontSizeSmall.IsChecked = false;
                mnuFontSizeMedium.IsChecked = false;
                mnuFontSizeLarge.IsChecked = false;
            }
            else
            {
                double fs = (double)fs_obj;
                mnuFontSizeSmall.IsChecked = (fs < 16.0);
                mnuFontSizeMedium.IsChecked = ((fs >= 16.0) && (fs < 22.0));
                mnuFontSizeLarge.IsChecked = (fs >= 22.0);
            }
        }

        // Set the selected font's size.
        private void FontSize_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mnu = (MenuItem)sender;
            switch (mnu.Header.ToString())
            {
                case "_Small":
                    txtBody.SetValue(TextElement.FontSizeProperty, 10.0);
                    break;
                case "_Medium":
                    txtBody.SetValue(TextElement.FontSizeProperty, 16.0);
                    break;
                case "_Large":
                    txtBody.SetValue(TextElement.FontSizeProperty, 22.0);
                    break;
            }
        }

        // Update the Text Color menu.
        private void mnuFontTextColor_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            Object br_obj = txtBody.GetValue(
                TextElement.ForegroundProperty);
            if (br_obj is SolidColorBrush)
            {
                SolidColorBrush br = (SolidColorBrush)br_obj;
                mnuFontTextColorBlack.IsChecked = (br.Color.Equals(Colors.Black));
                mnuFontTextColorRed.IsChecked = (br.Color.Equals(Colors.Red));
                mnuFontTextColorGreen.IsChecked = (br.Color.Equals(Colors.Green));
                mnuFontTextColorBlue.IsChecked = (br.Color.Equals(Colors.Blue));
            }
            else
            {
                mnuFontTextColorBlack.IsChecked = false;
                mnuFontTextColorRed.IsChecked = false;
                mnuFontTextColorGreen.IsChecked = false;
                mnuFontTextColorBlue.IsChecked = false;
            }
        }

        // Set the selection's text color.
        private void mnuFontTextColor_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mnu = (MenuItem)sender;
            switch (mnu.Header.ToString())
            {
                case "_Black":
                    txtBody.SetValue(TextElement.ForegroundProperty, Brushes.Black);
                    break;
                case "_Red":
                    txtBody.SetValue(TextElement.ForegroundProperty, Brushes.Red);
                    break;
                case "_Green":
                    txtBody.SetValue(TextElement.ForegroundProperty, Brushes.Green);
                    break;
                case "B_lue":
                    txtBody.SetValue(TextElement.ForegroundProperty, Brushes.Blue);
                    break;
            }
        }

        // Update the Background Color menu.
        private void mnuFontBackgroundColor_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            Object br_obj = txtBody.GetValue(
                TextElement.BackgroundProperty);
            if (br_obj is SolidColorBrush)
            {
                SolidColorBrush br = (SolidColorBrush)br_obj;
                mnuFontBackgroundColorLightBlue.IsChecked = (br.Color.Equals(Colors.LightBlue));
                mnuFontBackgroundColorWhite.IsChecked = (br.Color.Equals(Colors.White));
                mnuFontBackgroundColorYellow.IsChecked = (br.Color.Equals(Colors.Yellow));
            }
            else
            {
                mnuFontBackgroundColorLightBlue.IsChecked = false;
                mnuFontBackgroundColorWhite.IsChecked = false;
                mnuFontBackgroundColorYellow.IsChecked = false;
            }
        }

        // Set the background color.
        private void mnuFontBackgroundColor_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mnu = (MenuItem)sender;
            switch (mnu.Header.ToString())
            {
                case "_Light Blue":
                    txtBody.Background = Brushes.LightBlue;
                    break;
                case "_White":
                    txtBody.Background = Brushes.White;
                    break;
                case "_Yellow":
                    txtBody.Background = Brushes.Yellow;
                    break;
            }
        }

        // Update the font family menu.
        private void mnuFontFamily_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            Object ff_obj = txtBody.GetValue(
                TextElement.FontFamilyProperty);
            if (ff_obj is FontFamily)
            {
                FontFamily ff = (FontFamily)ff_obj;
                mnuFontFamilyTimes.IsChecked = (ff.Equals(new FontFamily("Times New Roman")));
                mnuFontFamilyArial.IsChecked = (ff.Equals(new FontFamily("Arial")));
                mnuFontFamilyCourier.IsChecked = (ff.Equals(new FontFamily("Courier New")));
            }
            else
            {
                mnuFontFamilyTimes.IsChecked = false;
                mnuFontFamilyArial.IsChecked = false;
                mnuFontFamilyCourier.IsChecked = false;
            }
        }

        // Set the font family.
        private void mnuFontFamily_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mnu = (MenuItem)sender;
            switch (mnu.Header.ToString())
            {
                case "_Times New Roman":
                    txtBody.SetValue(TextElement.FontFamilyProperty, new FontFamily("Times New Roman"));
                    break;
                case "_Arial":
                    txtBody.SetValue(TextElement.FontFamilyProperty, new FontFamily("Arial"));
                    break;
                case "_Courier New":
                    txtBody.SetValue(TextElement.FontFamilyProperty, new FontFamily("Courier New"));
                    break;
            }
        }

        // Enable or disable the Undo and Redo commands.
        private void mnuEdit_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            mnuEditUndo.IsEnabled = (txtBody.CanUndo);
            mnuEditRedo.IsEnabled = (txtBody.CanRedo);
        }

        // Undo.
        private void mnuEditUndo_Click(object sender, RoutedEventArgs e)
        {
            txtBody.Undo();
        }

        // Redo.
        private void mnuEditRedo_Click(object sender, RoutedEventArgs e)
        {
            txtBody.Redo();
        }

        // Toggle the selection's bullet state.
        private void mnuParaBullet_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.ToggleBullets.Execute(null, txtBody);
        }

        // Toggle the selection's number state.
        private void mnuParaNumber_Click(object sender, RoutedEventArgs e)
        {
            EditingCommands.ToggleNumbering.Execute(null, txtBody);
        }

        // Left align the text.
        private void mnuParaAlignLeft_Click(object sender, RoutedEventArgs e)
        {
            txtBody.TextAlignment = TextAlignment.Left;
        }

        // Center the text.
        private void mnuParaAlignCenter_Click(object sender, RoutedEventArgs e)
        {
            txtBody.TextAlignment = TextAlignment.Center;
        }

        // Right align the text.
        private void mnuParaAlignRight_Click(object sender, RoutedEventArgs e)
        {
            txtBody.TextAlignment = TextAlignment.Right;
        }

        // Justify the text.
        private void mnuParaAlignJustify_Click(object sender, RoutedEventArgs e)
        {
            txtBody.TextAlignment = TextAlignment.Justify;
        }
    }
}