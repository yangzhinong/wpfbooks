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

namespace SpheresWithNormals
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
            MakeSphere(Sphere00, new DiffuseMaterial(Brushes.White), 1, 6, 10, false);
            MakeSphere(Sphere01, new DiffuseMaterial(Brushes.White), 1, 6, 10, true);

            MakeSphere(Sphere10, new DiffuseMaterial(Brushes.White), 1, 20, 30, false);
            MakeSphere(Sphere11, new DiffuseMaterial(Brushes.White), 1, 20, 30, true);
        }

        // Make a sphere.
        private void MakeSphere(Model3DGroup model_group, Material sphere_material, double radius, int num_phi, int num_theta, bool use_radius_normals)
        {
            double dphi = Math.PI / num_phi;
            double dtheta = 2 * Math.PI / num_theta;
            double phi = -Math.PI / 2;
            double theta = 0;
            double r, y;
            Point3D p1, p2, p3, p4;

            // Make the top triangle fan.
            phi = Math.PI / 2 - dphi;
            r = radius * Math.Cos(phi);
            p1 = new Point3D(0, radius, 0);
            y = radius * Math.Sin(phi);

            theta = dtheta;
            p3 = new Point3D(r * Math.Cos(theta), y, r * Math.Sin(theta));
            theta = 0;
            for (int i=1; i<=num_theta; i++)
            {
                p2 = p3;
                p3 = new Point3D(r * Math.Cos(theta), y, r * Math.Sin(theta));
                MakeTriangle(model_group, sphere_material, p1, p2, p3, use_radius_normals);
                theta -= dtheta;
            }

            // Make the bottom triangle fan.
            phi = -Math.PI / 2 + dphi;
            theta = 0;
            r = radius * Math.Cos(phi);
            p1 = new Point3D(0, -radius, 0);
            y = radius * Math.Sin(phi);

            theta = -dtheta;
            p3 = new Point3D(r * Math.Cos(theta), y, r * Math.Sin(theta));
            theta = 0;
            for (int i=1; i<=num_theta; i++)
            {
                p2 = p3;
                p3 = new Point3D(r * Math.Cos(theta), y, r * Math.Sin(theta));
                MakeTriangle(model_group, sphere_material, p1, p2, p3, use_radius_normals);
                theta += dtheta;
            }

            // Make the strips between.
            double phi1 = Math.PI / 2 - dphi;

            for (int p=1; p<=num_phi - 2; p++)
            {
                double phi2 = phi1 - dphi;
                double r1 = radius * Math.Cos(phi1);
                double r2 = radius * Math.Cos(phi2);

                double y1 = radius * Math.Sin(phi1);
                double y2 = radius * Math.Sin(phi2);

                theta = -dtheta;
                p3 = new Point3D(r1 * Math.Cos(theta), y1, -r1 * Math.Sin(theta));
                p4 = new Point3D(r2 * Math.Cos(theta), y2, -r2 * Math.Sin(theta));
                theta = 0;
                for (int t=1; t<=num_theta; t++)
                {
                    p1 = p3;
                    p2 = p4;
                    p3 = new Point3D(r1 * Math.Cos(theta), y1, -r1 * Math.Sin(theta));
                    p4 = new Point3D(r2 * Math.Cos(theta), y2, -r2 * Math.Sin(theta));
                    MakeTriangle(model_group, sphere_material, p1, p2, p4, use_radius_normals);
                    MakeTriangle(model_group, sphere_material, p1, p4, p3, use_radius_normals);
                    theta += dtheta;
                }
                phi1 = phi2;
            }
        }

        // Make a single triangle.
        private void MakeTriangle(Model3DGroup model_group, Material triangle_material, Point3D p1, Point3D p2, Point3D p3, bool use_radius_normals)
        {
            // Define the new mesh geometry.
            MeshGeometry3D new_mesh = new MeshGeometry3D();

            // Define the points.
            new_mesh.Positions = new Point3DCollection(3);
            new_mesh.Positions.Add(p1);
            new_mesh.Positions.Add(p2);
            new_mesh.Positions.Add(p3);

            // Define the triangle.
            new_mesh.TriangleIndices = new Int32Collection(3);
            new_mesh.TriangleIndices.Add(0);
            new_mesh.TriangleIndices.Add(1);
            new_mesh.TriangleIndices.Add(2);

            // Set normals if appropriate.
            if (use_radius_normals)
            {
                new_mesh.Normals = new Vector3DCollection(3);
                new_mesh.Normals.Add(new Vector3D(p1.X, p1.Y, p1.Z));
                new_mesh.Normals.Add(new Vector3D(p2.X, p2.Y, p2.Z));
                new_mesh.Normals.Add(new Vector3D(p3.X, p3.Y, p3.Z));
            }

            // Set the model's material.
            GeometryModel3D new_model = new GeometryModel3D(new_mesh, triangle_material);

            // Add the new model to the model group.
            model_group.Children.Add(new_model);
        }
    }
}