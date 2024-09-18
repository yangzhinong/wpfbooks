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

namespace UseMediaElement
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

        // Play the audio file.
        private void btnPlayAudio_Click(object sender, RoutedEventArgs e)
        {
            mmAudio.Play();
        }

        // Pause the audio file.
        private void btnPauseAudio_Click(object sender, RoutedEventArgs e)
        {
            mmAudio.Pause();
        }

        // Rewind the audio file.
        private void btnRewindAudio_Click(object sender, RoutedEventArgs e)
        {
            mmAudio.Position = new TimeSpan(0);
        }

        // Play the video file.
        private void btnPlayVideo_Click(object sender, RoutedEventArgs e)
        {
            mmJulia.Play();
        }

        // Pause the video file.
        private void btnPauseVideo_Click(object sender, RoutedEventArgs e)
        {
            mmJulia.Pause();
        }

        // Rewind the video file.
        private void btnRewindVideo_Click(object sender, RoutedEventArgs e)
        {
            mmJulia.Position = new TimeSpan(0);
        }
	}
}