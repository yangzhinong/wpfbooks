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

namespace SingleMeshSpheres
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

        // Build the model.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MakeSingleMeshSphere(Sphere00, new DiffuseMaterial(Brushes.White), 1, 6, 10);
            MakeSingleMeshSphere(Sphere01, new DiffuseMaterial(Brushes.White), 1, 20, 30);
        }

        // Make a sphere.
        private void MakeSingleMeshSphere(Model3DGroup model_group, Material sphere_material, double radius, int num_phi, int num_theta)
        {
            // Define the new mesh geometry.
            MeshGeometry3D new_mesh = new MeshGeometry3D();
            new_mesh.Positions = new Point3DCollection(3);
            new_mesh.TriangleIndices = new Int32Collection(3);

            double dphi = Math.PI / num_phi;
            double dtheta = 2 * Math.PI / num_theta;
            double theta = 0;

            // Make the top point.
            new_mesh.Positions.Add(new Point3D(0, radius, 0));

            // Make the middle points.
            double phi1 = Math.PI / 2 - dphi;
            for (int p=1; p<=num_phi - 1; p++)
            {
                double r1 = radius * Math.Cos(phi1);
                double y1 = radius * Math.Sin(phi1);

                theta = 0;
                for (int t=1; t<=num_theta; t++)
                {
                    new_mesh.Positions.Add(new Point3D(r1 * Math.Cos(theta), y1, -r1 * Math.Sin(theta)));
                    theta += dtheta;
                }
                phi1 -= dphi;
            }

            // Make the bottom point.
            new_mesh.Positions.Add(new Point3D(0, -radius, 0));

            // Make the triangles.
            // Make the top fan.
            int i1, i2, i3, i4;
            i1 = num_theta;
            i2 = 1;
            for (int i=1; i<=num_theta; i++)
            {
                new_mesh.TriangleIndices.Add(0);
                new_mesh.TriangleIndices.Add(i1);
                new_mesh.TriangleIndices.Add(i2);
                i1 = i2;
                i2 += 1;
            }

            // Make the middle triangles.
            for (int p=0; p<=num_phi - 3; p++)
            {
                i3 = 1 + p * num_theta;
                i4 = i3 + num_theta;
                i1 = i4 - 1;
                i2 = i1 + num_theta;
                for (int t=0; t<=num_theta - 1; t++)
                {
                    new_mesh.TriangleIndices.Add(i1);
                    new_mesh.TriangleIndices.Add(i2);
                    new_mesh.TriangleIndices.Add(i4);

                    new_mesh.TriangleIndices.Add(i1);
                    new_mesh.TriangleIndices.Add(i4);
                    new_mesh.TriangleIndices.Add(i3);

                    i1 = i3;
                    i2 = i4;
                    i3 += 1;
                    i4 += 1;
                }
            }

            // Make the bottom fan.
            i3 = new_mesh.Positions.Count - 1; // The last (bottom) point.
            i1 = i3 - 1;
            i2 = i3 - num_theta;
            for (int i=1; i<=num_theta; i++)
            {
                new_mesh.TriangleIndices.Add(i1);
                new_mesh.TriangleIndices.Add(i3);
                new_mesh.TriangleIndices.Add(i2);
                i1 = i2;
                i2 += 1;
            }

            // Set the model's material.
            GeometryModel3D new_model = new GeometryModel3D(new_mesh, sphere_material);

            // Add the new model to the model group.
            model_group.Children.Add(new_model);
        }
    }
}