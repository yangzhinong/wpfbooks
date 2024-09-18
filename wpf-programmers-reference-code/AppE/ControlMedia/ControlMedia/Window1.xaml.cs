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

// Add a reference to WindowsBase.
using System.Windows.Threading;

namespace ControlMedia
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

        private DispatcherTimer tmrProgress = new DispatcherTimer();

        // Prepare the timer.
        private void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            tmrProgress = new DispatcherTimer();
            tmrProgress.Tick += tmrProgress_Tick;
        }

        private void btnRewind_Click(object sender, RoutedEventArgs e)
        {
            mmBear.Position = mmBear.Position.Add(new TimeSpan(0, 0, -5));
        }
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            mmBear.Play();
            tmrProgress.Start();
        }
        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            mmBear.Pause();
            tmrProgress.Stop();
        }
        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            mmBear.Stop();
            tmrProgress.Stop();
        }
        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            mmBear.Position = mmBear.Position.Add(new TimeSpan(0, 0, 5));
        }
        private void btnBookmark_Click(object sender, RoutedEventArgs e)
        {
            lstBookmarks.Items.Add(mmBear.Position);
        }

        // Jump to this bookmark.
        private void lstBookmarks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (mmBear == null) return;
            if (e.AddedItems.Count < 1) return;
            TimeSpan bookmark = (TimeSpan)e.AddedItems[0];
            mmBear.Pause();
            mmBear.Position = bookmark;
            scrProgress.Value = mmBear.Position.TotalSeconds;
            lstBookmarks.SelectedIndex = -1;
        }

        // Display the media's progress.
        private void tmrProgress_Tick(Object sender, System.EventArgs e)
        {
            scrProgress.Value = mmBear.Position.TotalSeconds;
        }

        // Prepare the progress ScrollBar.
        private void mmBear_MediaOpened(System.Object sender, System.Windows.RoutedEventArgs e)
        {
            if (mmBear.NaturalDuration.HasTimeSpan)
            {
                TimeSpan ts = mmBear.NaturalDuration.TimeSpan;
                scrProgress.Maximum = ts.TotalSeconds;
                scrProgress.SmallChange = 1;
                scrProgress.LargeChange = ts.TotalSeconds / 10;
            } else {
                scrProgress.Visibility = Visibility.Hidden;
            }
        }

        // Go to the selected position.
        private void scrPosition_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            mmBear.Position = TimeSpan.FromSeconds(e.NewValue);
        }
    }
}