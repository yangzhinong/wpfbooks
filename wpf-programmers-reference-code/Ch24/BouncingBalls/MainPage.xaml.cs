using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.Windows.Threading;

namespace BouncingBalls
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private DateTime LastUpdate;
        private List<Ball> Balls;
        private DispatcherTimer Clock;

        // Get ready to run.
        private void canField_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            GetReady();
        }

        // Get ready to run.
        private void GetReady()
        {
            // Delete any old Balls. Necessary if the user resizes.
            canField.Children.Clear();

            // Make some Balls.
            Balls = new List<Ball>();
            Random rand = new Random();
            Rect bounds = new Rect(0, 0, canField.ActualWidth, canField.ActualHeight);
            for (int i = 1; i <= 5; i++)
            {
                Balls.Add(RandomBall(rand, bounds, canField));
            }

            // Prepare the timer.
            LastUpdate = DateTime.Now;
            Clock = new DispatcherTimer();
            Clock.Interval = TimeSpan.FromSeconds(0.1);
            Clock.Tick += Clock_Tick;
            Clock.Start();
        }

        // Return a random Ball.
        private Ball RandomBall(Random rand, Rect bounds, Panel container)
        {
            // Make the ellipse.
            Ellipse new_ellipse = new Ellipse();
            container.Children.Add(new_ellipse);
            new_ellipse.Width = rand.Next(50, 150);
            new_ellipse.Height = new_ellipse.Width;

            GradientStop stop1, stop2;
            GradientStopCollection stops;

            // Make the stroke brush.
            stop1 = new GradientStop();
            stop1.Color = Colors.Green;
            stop1.Offset = 0;
            stop2 = new GradientStop();
            stop2.Color = Color.FromArgb(255, 0, 255, 0);
            stop2.Offset = 1;
            stops = new GradientStopCollection() {stop1, stop2};
            new_ellipse.Stroke = new LinearGradientBrush(stops, 45);
            new_ellipse.StrokeThickness = 10;

            // Make the fill brush.
            stop1 = new GradientStop();
            stop1.Color = Colors.Green;
            stop1.Offset = 1;
            stop2 = new GradientStop();
            stop2.Color = Color.FromArgb(255, 0, 255, 0);
            stop2.Offset = 0;
            stops = new GradientStopCollection() {stop1, stop2};
            new_ellipse.Fill = new LinearGradientBrush(stops, 45);

            // Make the initial transform.
            TranslateTransform transform = new TranslateTransform();
            transform.X = rand.Next(0, (int)(bounds.Right - new_ellipse.Width));
            transform.Y = rand.Next(0, (int)(bounds.Bottom - new_ellipse.Height));
            new_ellipse.RenderTransform = transform;

            // Get velocities.
            double vx = rand.Next(30, 100);
            if (rand.Next(0, 2) == 0) vx = -vx;
            double vy = rand.Next(30, 100);
            if (rand.Next(0, 2) == 0) vy = -vy;

            // Make the Ball.
            return new Ball(new_ellipse, transform, vx, vy, bounds);
        }

        // Update the balls.
        private void Clock_Tick(object sender, EventArgs e)
        {
            DateTime time_now = DateTime.Now;
            TimeSpan elapsed = time_now.Subtract(LastUpdate);

            foreach (Ball a_ball in Balls)
            {
                a_ball.Update(elapsed);
            }

            LastUpdate = time_now;
        }
    }
}
