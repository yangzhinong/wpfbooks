using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Documents;
using System.Windows.Media;

namespace PrintShapes
{
    class ShapesPaginator : DocumentPaginator
    {
        private Size m_PageSize;

        // Save the page size.
        public ShapesPaginator(Size page_size)
        {
            m_PageSize = page_size;
        }

        // Return the needed page.
        public override DocumentPage GetPage(int pageNumber)
        {
            const double WID = 600;
            const double HGT = 800;

            Grid drawing_grid = new Grid();
            drawing_grid.Width = m_PageSize.Width;
            drawing_grid.Height = m_PageSize.Height;

            switch (pageNumber)
            {
                case 0: // Ellipse
                    Ellipse ell = new Ellipse();
                    ell.Fill = Brushes.Orange;
                    ell.Stroke = Brushes.Blue;
                    ell.StrokeThickness = 1;
                    ell.HorizontalAlignment = HorizontalAlignment.Center;
                    ell.VerticalAlignment = VerticalAlignment.Center;
                    ell.Width = WID;
                    ell.Height = HGT;
                    drawing_grid.Children.Add(ell);
                    break;

                case 1: // Triangle.
                    Polygon triangle = new Polygon();
                    triangle.Fill = Brushes.Yellow;
                    triangle.Stroke = Brushes.Red;
                    triangle.StrokeThickness = 10;
                    triangle.HorizontalAlignment = HorizontalAlignment.Center;
                    triangle.VerticalAlignment = VerticalAlignment.Center;

                    DoubleCollection dash_array = new DoubleCollection();
                    dash_array.Add(2);
                    triangle.StrokeDashArray = dash_array;

                    PointCollection triangle_pts = new PointCollection();
                    triangle_pts.Add(new Point(WID / 2, 0));
                    triangle_pts.Add(new Point(WID, HGT));
                    triangle_pts.Add(new Point(0, HGT));
                    triangle.Points = triangle_pts;
                    drawing_grid.Children.Add(triangle);
                    break;

                case 2: // Diamond.
                    Polygon diamond = new Polygon();
                    diamond.Fill = Brushes.LightBlue;
                    diamond.Stroke = Brushes.Green;
                    diamond.StrokeThickness = 20;
                    diamond.HorizontalAlignment = HorizontalAlignment.Center;
                    diamond.VerticalAlignment = VerticalAlignment.Center;
                    diamond.StrokeLineJoin = PenLineJoin.Round;

                    PointCollection diamond_pts = new PointCollection();
                    diamond_pts.Add(new Point(WID / 2, 0));
                    diamond_pts.Add(new Point(WID, HGT / 2));
                    diamond_pts.Add(new Point(WID / 2, HGT));
                    diamond_pts.Add(new Point(0, HGT / 2));
                    diamond.Points = diamond_pts;
                    drawing_grid.Children.Add(diamond);
                    break;

                case 3: // Star.
                    Polygon star = new Polygon();
                    star.Fill = Brushes.Pink;
                    star.FillRule = FillRule.Nonzero;
                    star.Stroke = Brushes.Black;
                    star.StrokeThickness = 10;
                    star.HorizontalAlignment = HorizontalAlignment.Center;
                    star.VerticalAlignment = VerticalAlignment.Center;

                    PointCollection star_pts = new PointCollection();
                    double theta = -System.Math.PI / 2;
                    double dtheta = System.Math.PI * 4 / 5;
                    for (int i=0; i<=4; i++)
                    {
                        star_pts.Add(new Point(
                            WID / 2 + WID / 2 * System.Math.Cos(theta),
                            HGT / 2 + WID / 2 * System.Math.Sin(theta)));
                        theta += dtheta;
                    }
                    star.Points = star_pts;
                    drawing_grid.Children.Add(star);
                    break;
            }

            // Arrange to make the controls draw themselves.
            Rect rect = new Rect(new Point(0, 0), m_PageSize);
            drawing_grid.Arrange(rect);

            // Return a DocumentPage wrapping the grid.
            return new DocumentPage(drawing_grid);
        }

        // If pagination is in progress and PageCount is not final, return False.
        // If pagination is complete and PageCount is final, return True.
        // In this example, there is no pagination to do.
        public override bool IsPageCountValid
        {
            get { return true; }
        }

        // The number of pages paginated so far.
        // This example has exactly 4 pages.
        public override int PageCount
        {
            get { return 4; }
        }

        // The suggested page size.
        public override Size PageSize
        {
            get { return m_PageSize; }
            set { m_PageSize = value; }
        }

        // The element currently being paginated.
        public override IDocumentPaginatorSource Source
        {
            get { return null; }
        }
    }
}
