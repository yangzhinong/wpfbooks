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

namespace UseButtons
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

        // Show the time.
        private void btnShowTime_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString());
        }

        // Display some prime numbers.
        private void btnFindPrime_Click(object sender, RoutedEventArgs e)
        {
            string result = dlgGetInput.ShowDialog("Number of Primes?", "10");
            if (result == null) return;

            int num_primes = int.Parse(result);

            List<int> primes = new List<int>();
            primes.Add(2);

            int i = 3;
            while (primes.Count < num_primes)
            {
                // Assume i is prime.
                bool is_prime = true;

                // See if i is prime.
                for (int j = 2; j < System.Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        is_prime = false;
                        break;
                    }
                }

                // If i is prime, add it to the list.
                if (is_prime) primes.Add(i);

                // Go on to consider the next value.
                i += 2;
            }

            // We have our primes. Display them.
            string txt = "";
            foreach (int num in primes)
            {
                txt += ", " + num.ToString();
            }
            txt = txt.Substring(2);

            MessageBox.Show(txt, num_primes.ToString() + " Primes", 
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Display some Fibonacci numbers.
        private void btnFindFibonacci_Click(object sender, RoutedEventArgs e)
        {
            string result = dlgGetInput.ShowDialog("# Fibonacci Numbers?", "10");
            if (result == null) return;

            int num_numbers = int.Parse(result);

            // Find the Fibonacci numbers.
            List<int> numbers = new List<int>();
            numbers.Add(0);
            numbers.Add(1);
            for (int i=2; i<num_numbers; i++)
            {
                numbers.Add(numbers[i - 1] + numbers[i - 2]);
            }

            // We have our numbers. Display them.
            string txt = "";
            foreach (int num in numbers)
            {
                txt += ", " + num.ToString();
            }
            if (txt.Length > 0) txt = txt.Substring(2);

            MessageBox.Show(txt, num_numbers.ToString() + " Fibonacci numbers",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnNothing_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I said this button doesn't do anything!", "Nothing", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
	}
}