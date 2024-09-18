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

namespace MakeSurface
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
            // Make the surface.
            MakeSurface(TheModel, Splash, -4, -4, 4, 4, 0.1, 0.1, -1, 1);

            // Display a title label.
            MakeTitle(TheModel);
        }

        private delegate double FunctionOfXZ(double x, double z);

        // Make a 3D surface.
        private void MakeSurface(Model3DGroup surface_model, FunctionOfXZ F,
            double xmin, double zmin, double xmax, double zmax,
            double dx, double dz, double ymin, double ymax)
        {
            // Make colored materials.
            LinearGradientBrush surface_brush = new LinearGradientBrush();
            surface_brush.StartPoint = new Point(0, 0);
            surface_brush.EndPoint = new Point(0, 1);
            surface_brush.GradientStops.Add(new GradientStop(Colors.Blue, 0.0));
            surface_brush.GradientStops.Add(new GradientStop(Colors.Lime, 0.25));
            surface_brush.GradientStops.Add(new GradientStop(Colors.Yellow, 0.5));
            surface_brush.GradientStops.Add(new GradientStop(Colors.Orange, 0.75));
            surface_brush.GradientStops.Add(new GradientStop(Colors.Red, 1.0));
            Material surface_material = new DiffuseMaterial(surface_brush);

            // Make a mesh.
            MeshGeometry3D surface_mesh = new MeshGeometry3D();
            GeometryModel3D new_model = new GeometryModel3D(surface_mesh, surface_material);
            surface_model.Children.Add(new_model);

            double dy = ymax - ymin;
            int num_x = (int)((xmax - xmin) / dx);
            int num_z = (int)((zmax - zmin) / dz);
            double x = xmin;
            for (int ix = 0; ix <= num_x - 2; ix++)
            {
                double z = zmin;
                for (int iz = 0; iz <= num_z - 2; iz++)
                {
                    // Make the points.
                    int i1 = surface_mesh.Positions.Count;
                    double y1 = F(x, z);
                    surface_mesh.Positions.Add(new Point3D(x, y1, z));
                    surface_mesh.TextureCoordinates.Add(new Point(0, (y1 - ymin) / dy));

                    int i2 = surface_mesh.Positions.Count;
                    double y2 = F(x, z + dz);
                    surface_mesh.Positions.Add(new Point3D(x, y2, z + dz));
                    surface_mesh.TextureCoordinates.Add(new Point(0, (y2 - ymin) / dy));

                    int i3 = surface_mesh.Positions.Count;
                    double y3 = F(x + dx, z + dz);
                    surface_mesh.Positions.Add(new Point3D(x + dx, y3, z + dz));
                    surface_mesh.TextureCoordinates.Add(new Point(0, (y3 - ymin) / dy));

                    int i4 = surface_mesh.Positions.Count;
                    double y4 = F(x + dx, z);
                    surface_mesh.Positions.Add(new Point3D(x + dx, y4, z));
                    surface_mesh.TextureCoordinates.Add(new Point(0, (y4 - ymin) / dy));

                    // Make the triangles.
                    surface_mesh.TriangleIndices.Add(i1);
                    surface_mesh.TriangleIndices.Add(i2);
                    surface_mesh.TriangleIndices.Add(i3);

                    surface_mesh.TriangleIndices.Add(i1);
                    surface_mesh.TriangleIndices.Add(i3);
                    surface_mesh.TriangleIndices.Add(i4);

                    z += dz;
                }
                x += dx;
            }
        }

        private double SinXZ(double x, double z)
        {
            return Math.Sin(x * z) / 2;
        }

        private double SinXplusSinZ(double x, double z)
        {
            return (Math.Sin(x * 2) + Math.Sin(z * 2)) / 2;
        }

        private double Splash(double x, double z)
        {
            double r = x * x + z * z;
            return Math.Cos(r) / (1 + r / 2);
        }

        // Make a horizontal label at the specified position.
        private void MakeTitle(Model3DGroup the_model)
        {
            Style lbl_sty = new Style(typeof(Label));
            lbl_sty.Setters.Add(new Setter(Label.ForegroundProperty, Brushes.Red));
            lbl_sty.Setters.Add(new Setter(Label.FontFamilyProperty, new FontFamily("Courier New")));
            lbl_sty.Setters.Add(new Setter(Label.FontWeightProperty, FontWeights.Bold));

            StackPanel sp = new StackPanel();
            sp.Background = Brushes.Transparent;
            sp.Orientation = Orientation.Horizontal;
            Thickness normal = new Thickness(0, 0, 0, 0);
            Thickness backup = new Thickness(-5, 0, 0, 0);
            Thickness super = new Thickness(-5, -3, 0, 0);
            sp.Children.Add(new Label() { Style = lbl_sty, Margin = normal, Content = "Cos(x" });
            sp.Children.Add(new Label() { Style = lbl_sty, Margin = super,  Content = "2" });
            sp.Children.Add(new Label() { Style = lbl_sty, Margin = normal, Content = "+ z"});
            sp.Children.Add(new Label() { Style = lbl_sty, Margin = super,  Content = "2" });
            sp.Children.Add(new Label() { Style = lbl_sty, Margin = backup, Content = ") / [1 + (x" });
            sp.Children.Add(new Label() { Style = lbl_sty, Margin = super,  Content = "2" });
            sp.Children.Add(new Label() { Style = lbl_sty, Margin = normal, Content = "+ z" });
            sp.Children.Add(new Label() { Style = lbl_sty, Margin = super,  Content = "2" });
            sp.Children.Add(new Label() { Style = lbl_sty, Margin = backup, Content = ") / 2]" });

            Brush label_brush = new VisualBrush(sp);
            Material label_material = new DiffuseMaterial(label_brush);
            MeshGeometry3D label_mesh = null;
            MakeRectangle(the_model, ref label_mesh, label_material,
                new Point3D(-3, 3, 4), new Point3D(-3, 1, 4),
                new Point3D(-3, 1, -4), new Point3D(-3, 3, -4),
                new Point(0, 0), new Point(0, 1), new Point(1, 1), new Point(1, 0));
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
    }
}