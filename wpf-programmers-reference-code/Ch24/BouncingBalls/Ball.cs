using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace BouncingBalls
{
    public class Ball
    {
        public Shape MyShape { get; set; }
        public TranslateTransform Transform { get; set; }
        public double Vx { get; set; }
        public double Vy { get; set; }
        public Rect Bounds { get; set; }

        // Constructor.
        public Ball(Shape new_shape, TranslateTransform initial_transform,
            double initial_vx, double initial_vy, Rect the_bounds)
        {
            MyShape = new_shape;
            Transform = initial_transform;
            Vx = initial_vx;
            Vy = initial_vy;
            Bounds = the_bounds;
        }

        // Update our position for the elapsed time.
        public void Update(TimeSpan elapsed)
        {
            double x = Transform.X + Vx * elapsed.TotalSeconds;
            if ((Vx < 0) && (x < Bounds.Left))
            {
                // We hit the left wall.
                Vx = -Vx;
                x += 2 * (Bounds.Left - x);
            } 
            else if ((Vx > 0) && (x + MyShape.Width > Bounds.Right))
            {
                // We hit the right wall.
                Vx = -Vx;
                x -= 2 * (x + MyShape.Width - Bounds.Right);
            }

            double y = Transform.Y + Vy * elapsed.TotalSeconds;
            if ((Vy < 0) && (y < Bounds.Top))
            {
                // We hit the top wall.
                Vy = -Vy;
                y += 2 * (Bounds.Top - y);
            }
            else if ((Vy > 0) && (y + MyShape.Width > Bounds.Bottom))
            {
                // We hit the bottom wall.
                Vy = -Vy;
                y -= 2 * (y + MyShape.Width - Bounds.Bottom);
            }

            Transform.X = x;
            Transform.Y = y;
        }
    }
}
