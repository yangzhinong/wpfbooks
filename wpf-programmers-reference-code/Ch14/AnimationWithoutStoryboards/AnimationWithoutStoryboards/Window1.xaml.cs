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

using System.Windows.Media.Animation;

namespace AnimationWithoutStoryboards
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

        // Start the animation.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Get geometry info.
            double ball_wid = ellBall.ActualWidth;
            double ball_hgt = ellBall.ActualHeight;
            int max_x = (int)(canTable.ActualWidth - ball_wid);
            int max_y = (int)(canTable.ActualHeight - ball_hgt);

            // Set the ball's initial position.
            Random rand = new Random();
            double x = rand.Next(0, max_x);
            double y = rand.Next(0, max_y);
            Canvas.SetLeft(ellBall, x);
            Canvas.SetTop(ellBall, y);

            // Make animations.
            const double TRANSIT_TIME = 1;
            DoubleAnimationUsingKeyFrames x_animation =
                new DoubleAnimationUsingKeyFrames();
            x_animation.RepeatBehavior = RepeatBehavior.Forever;
            double l_time = TRANSIT_TIME * x / max_x;
            double r_time = TRANSIT_TIME - l_time;
            // To right edge.
            x_animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    max_x,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(r_time))));
            // Back to left edge.
            x_animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(r_time + TRANSIT_TIME))));
            // Back to start.
            x_animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    x,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(r_time + TRANSIT_TIME + l_time))));

            DoubleAnimationUsingKeyFrames y_animation = new DoubleAnimationUsingKeyFrames();
            y_animation.RepeatBehavior = RepeatBehavior.Forever;
            double t_time = TRANSIT_TIME * y / max_y;
            double b_time = TRANSIT_TIME - t_time;
            // To bottom edge.
            y_animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    max_y,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(b_time))));
            // Back to top edge.
            y_animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    0,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(b_time + TRANSIT_TIME))));
            // Back to start.
            y_animation.KeyFrames.Add(
                new LinearDoubleKeyFrame(
                    y,
                    KeyTime.FromTimeSpan(TimeSpan.FromSeconds(b_time + TRANSIT_TIME + t_time))));

            // Apply the animations.
            ellBall.BeginAnimation(Canvas.LeftProperty, x_animation);
            ellBall.BeginAnimation(Canvas.TopProperty, y_animation);
        }

        // Exit.
        private void ellBall_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
	}
}