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

namespace Lights
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

        // Build the squares.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DiffuseMaterial mat_yellow = new DiffuseMaterial(Brushes.Yellow);

            MakePlane(Model00, -1, -1, 1, 1, 0.1, 0.1, mat_yellow);
            MakePlane(Model10, -1, -1, 1, 1, 0.1, 0.1, mat_yellow);
            MakePlane(Model01, -1, -1, 1, 1, 0.1, 0.1, mat_yellow);
            MakePlane(Model11, -1, -1, 1, 1, 0.1, 0.1, mat_yellow);
        }

        // Make a plane.
        private void MakePlane(Model3DGroup model_group, double xmin, double zmin, double xmax, double zmax, double dx, double dz, Material plane_material)
        {
            MeshGeometry3D new_mesh = new MeshGeometry3D();
            new_mesh.Positions = new Point3DCollection();
            new_mesh.TriangleIndices = new Int32Collection();

            // Make the points.
            int num_x = (int)((xmax - xmin) / dx);
            int num_z = (int)((zmax - zmin) / dz);
            double z = zmin;
            for (int iz = 1; iz <= num_z; iz++)
            {
                double x = xmin;
                for (int ix = 1; ix <= num_x; ix++)
                {
                    new_mesh.Positions.Add(new Point3D(x, 0, z));
                    x += dx;
                }
                z += dz;
            }

            // Make the triangles.
            for (int iz = 1; iz <= num_z - 2; iz++)
            {
                for (int ix = 0; ix <= num_x - 2; ix++)
                {
                    new_mesh.TriangleIndices.Add(iz * num_x + ix);
                    new_mesh.TriangleIndices.Add((iz + 1) * num_x + ix);
                    new_mesh.TriangleIndices.Add((iz + 1) * num_x + ix + 1);

                    new_mesh.TriangleIndices.Add(iz * num_x + ix);
                    new_mesh.TriangleIndices.Add((iz + 1) * num_x + ix + 1);
                    new_mesh.TriangleIndices.Add(iz * num_x + ix + 1);
                }
            }

            // Set the model's material.
            GeometryModel3D new_model = new GeometryModel3D(new_mesh, plane_material);

            // Add the new model to the model group.
            model_group.Children.Add(new_model);
        }
	}
}