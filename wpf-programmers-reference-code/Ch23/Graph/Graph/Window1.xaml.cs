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

using System.Windows.Media.Media3D;

namespace Graph
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Ground.
            Material ground_material = new DiffuseMaterial(Brushes.Chocolate);
            MeshGeometry3D ground_mesh = null;
            MakeRectangle(TheModel, ref ground_mesh, ground_material,
                new Point3D(-3, 0, -5), new Point3D(-3, 0, 5), new Point3D(3, 0, 5), new Point3D(3, 0, -5),
                new Point(0, 0), new Point(0, 1), new Point(1, 1), new Point(1, 0));

            // Background.
            Material background_material = new DiffuseMaterial(Brushes.Goldenrod);
            MeshGeometry3D background_mesh = null;
            MakeRectangle(TheModel, ref background_mesh, background_material,
                new Point3D(-3, 0, -5), new Point3D(-3, 5, -5), new Point3D(-3, 5, 5), new Point3D(-3, 0, 5),
                new Point(0, 0), new Point(0, 1), new Point(1, 1), new Point(1, 0));

            // Make a graph.
            double[,] values = {
                {1.08, 2.5, 2.13, 3.3, 3.9, 3.5},
                {1.73, 1.78, 2.82, 3.01, 4.51, 3.98},
                {1.13, 2.28, 3.12, 2.51, 3.31, 2.67},
                {0.69, 1.38, 2.84, 2.24, 3.95, 3.56}
            };
            MakeGraph(TheModel, values, 5, -3, -4, 3, 4);
        }

        // Make a rectangle. If rect_mesh is null, make a new one and add it to the model.
        // The points p1, p2, p3, p4 should be outwardly oriented.
        // The points u1, u2, u3, u4 give the texture coordinates for the points p1, p2, p3, p4.
        private void MakeRectangle(Model3DGroup rect_model,
            ref MeshGeometry3D rect_mesh, Material rect_material,
            Point3D p1, Point3D p2, Point3D p3, Point3D p4,
            Point u1, Point u2, Point u3, Point u4)
        {
            // Make the mesh if we must.
            if (rect_mesh == null)
            {
                rect_mesh = new MeshGeometry3D();
                GeometryModel3D new_model = new GeometryModel3D(rect_mesh, rect_material);
                rect_model.Children.Add(new_model);
            }

            // Make the points.
            rect_mesh.Positions.Add(p1);
            rect_mesh.Positions.Add(p2);
            rect_mesh.Positions.Add(p3);
            rect_mesh.Positions.Add(p4);

            // Set the texture coordinates.
            rect_mesh.TextureCoordinates.Add(u1);
            rect_mesh.TextureCoordinates.Add(u2);
            rect_mesh.TextureCoordinates.Add(u3);
            rect_mesh.TextureCoordinates.Add(u4);

            // Make the triangles.
            int i1 = rect_mesh.Positions.Count - 4;
            rect_mesh.TriangleIndices.Add(i1);
            rect_mesh.TriangleIndices.Add(i1 + 1);
            rect_mesh.TriangleIndices.Add(i1 + 2);

            rect_mesh.TriangleIndices.Add(i1);
            rect_mesh.TriangleIndices.Add(i1 + 2);
            rect_mesh.TriangleIndices.Add(i1 + 3);
        }

        // Make a 3D bar chart.
        private void MakeGraph(Model3DGroup graph_model, double[,] values, double max_value,
            double xmin, double zmin, double xmax, double zmax)
        {
            // Make material for the top.
            LinearGradientBrush graph_brush = new LinearGradientBrush();
            graph_brush.StartPoint = new Point(0, 0);
            graph_brush.EndPoint = new Point(0, 1);
            graph_brush.GradientStops.Add(new GradientStop(Colors.Blue, 0.0));
            graph_brush.GradientStops.Add(new GradientStop(Colors.Lime, 0.25));
            graph_brush.GradientStops.Add(new GradientStop(Colors.Yellow, 0.5));
            graph_brush.GradientStops.Add(new GradientStop(Colors.Orange, 0.75));
            graph_brush.GradientStops.Add(new GradientStop(Colors.Red, 1.0));
            Material graph_material = new DiffuseMaterial(graph_brush);

            // Make a mesh.
            MeshGeometry3D chart_mesh = new MeshGeometry3D();
            GeometryModel3D new_model = new GeometryModel3D(chart_mesh, graph_material);
            graph_model.Children.Add(new_model);

            int num_x = values.GetUpperBound(0) + 1;
            int num_z = values.GetUpperBound(1) + 1;
            double dx = (xmax - xmin) / num_x;
            double dz = (zmax - zmin) / num_z;
            double x = xmin;
            for (int ix = 0; ix <= num_x - 1; ix++)
            {
                double z = zmin;
                for (int iz = 1; iz <= num_z - 1; iz++)
                {
                    double y1 = values[ix, iz - 1];
                    double y2 = values[ix, iz];
                    double u1 = y1 / max_value;
                    double u2 = y2 / max_value;
                    MakeRectangle(graph_model, ref chart_mesh, graph_material,
                        new Point3D(x, y1, z), new Point3D(x, y2, z + dz), new Point3D(x + dx, y2, z + dz), new Point3D(x + dx, y1, z),
                        new Point(0, u1), new Point(0, u2), new Point(1, u2), new Point(1, u1));
                    MakeRectangle(graph_model, ref chart_mesh, graph_material,
                        new Point3D(x, y1, z), new Point3D(x + dx, y1, z), new Point3D(x + dx, y2, z + dz), new Point3D(x, y2, z + dz),
                        new Point(0, u1), new Point(1, u1), new Point(1, u2), new Point(0, u2));

                    z += dz;
                }
                x += dx;
            }
        }
    }
}