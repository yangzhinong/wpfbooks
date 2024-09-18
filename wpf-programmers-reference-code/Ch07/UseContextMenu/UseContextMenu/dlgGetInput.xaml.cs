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

namespace UseContextMenu
{
    /// <summary>
    /// Interaction logic for dlgGetInput.xaml
    /// </summary>
    public partial class dlgGetInput : Window
    {
        // Static method that creates the dialog, displays it, and returns its result.
        public static string ShowDialog(string prompt, string initial_value)
        {
            // Make the new dialog.
            dlgGetInput dlg = new dlgGetInput(prompt, initial_value);

            // Display it.
            bool? result = dlg.ShowDialog();

            // See if the user clicked OK.
            if (result == true) return dlg.txtValue.Text;
            return null;
        }

        // Initialize the dialog.
        public dlgGetInput(string prompt, string initial_value)
        {
            InitializeComponent();

            this.Title = prompt;
            txtValue.Text = initial_value;
            txtValue.Focus();
            txtValue.SelectAll();
        }

        // Close the window.
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        // Close the window.
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
