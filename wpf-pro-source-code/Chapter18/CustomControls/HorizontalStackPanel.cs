using System;
using System.Windows;
using System.Windows.Controls;

namespace CustomControls
{
    public class HorizontalStackPanel:Panel
    {
        public int Space
        {
            get { return (int)GetValue(SpaceProperty); }
            set { SetValue(SpaceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Space.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SpaceProperty =
            DependencyProperty.Register("Space", typeof(int), typeof(HorizontalStackPanel), new PropertyMetadata(0));

        protected override Size MeasureOverride(Size availableSize)
        {
            double width = 0;
            double height = 0;
            foreach (UIElement child in base.InternalChildren)
            {
                child.Measure(availableSize);
                if (child.DesiredSize.Height> height)
                {
                    height= child.DesiredSize.Height;
                }
                width += child.DesiredSize.Width + Space;
            }
            if (base.InternalChildren.Count > 0)
            {
                width -= Space;
            }
            if (availableSize.Height == double.PositiveInfinity || availableSize.Width == double.PositiveInfinity)
            {
                return new Size(width, height);
            } else
            {
                return new Size(Math.Max(availableSize.Width, width), Math.Max(availableSize.Height, height));
            }
           
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            if (base.InternalChildren.Count <= 1)
            {
                if (base.InternalChildren.Count == 1)
                {
                    base.InternalChildren[0].Arrange(new Rect(0,0, finalSize.Width, finalSize.Height));
                }
                return finalSize;
            }
            double width = (finalSize.Width - (base.InternalChildren.Count-1)*Space)/ base.InternalChildren.Count;

            double left = 0;

            for(var i=0; i<base.InternalChildren.Count; i++)
            {
                UIElement child= base.InternalChildren[i];
                child.Arrange(new Rect() { X = left, Y = 0, Width = width, Height = child.DesiredSize.Height});
                left +=width + Space;
            }
            return finalSize;
        }
    }
}
