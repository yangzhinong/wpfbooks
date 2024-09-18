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

namespace RectanglesAndBoxes
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

        // Build the scene.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Ground.
            Brush ground_brush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/grass_and_brick.jpg")));
            Material ground_material = new DiffuseMaterial(ground_brush);
            MeshGeometry3D ground_mesh = null;
            MakeRectangle(TheModel, ref ground_mesh, ground_material,
                new Point3D(-5, 0, -5), new Point3D(-5, 0, 5), new Point3D(5, 0, 5), new Point3D(5, 0, -5),
                new Point(0, 0), new Point(0, 1), new Point(1, 1), new Point(1, 0));

            // Rock boxes.
            Brush rock_brush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/rock.jpg")));
            Material rock_material = new DiffuseMaterial(rock_brush);
            MeshGeometry3D rock_mesh = null;
            for (int x = -4; x <= 2; x += 6)
            {
                for (int z = -4; z <= 2; z += 6)
                {
                    MakeBox(TheModel, ref rock_mesh, rock_material,
                        new Point3D(x + 0.5, 1.5, z + 0.5), new Point3D(x + 0.5, 1.5, z + 1.5), new Point3D(x + 1.5, 1.5, z + 1.5), new Point3D(x + 1.5, 1.5, z + 0.5),
                        new Point3D(x, 0, z), new Point3D(x, 0, z + 2), new Point3D(x + 2, 0, z + 2), new Point3D(x + 2, 0, z),
                        new Point(0, 0), new Point(0, 1), new Point(1, 1), new Point(1, 0));
                }
            }

            // Metal boxes.
            Brush metal_brush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/metal.jpg")));
            Material metal_material = new DiffuseMaterial(metal_brush);
            MeshGeometry3D metal_mesh = null;
            for (int x = -4; x <= 2; x += 3)
            {
                for (int z = -4; z <= 2; z += 3)
                {
                    if ((x + z) % 2 != 0)
                    {
                        MakeBox(TheModel, ref metal_mesh, metal_material,
                            new Point3D(x, 2, z), new Point3D(x, 2, z + 2), new Point3D(x + 2, 2, z + 2), new Point3D(x + 2, 2, z),
                            new Point3D(x, 0, z), new Point3D(x, 0, z + 2), new Point3D(x + 2, 0, z + 2), new Point3D(x + 2, 0, z),
                            new Point(0, 0), new Point(0, 1), new Point(1, 1), new Point(1, 0));
                    }
                }
            }

            // Cloud cone.
            Brush cloud_brush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/clouds.jpg")));
            Material cloud_material = new DiffuseMaterial(cloud_brush);
            MeshGeometry3D cloud_mesh = null;
            MakeCylinder(TheModel, ref cloud_mesh, cloud_material, 0, 0, 0, 0, 4, 0, 0, 0.2, 0.8, 1, 1.25, 0.5, 30);

            // Globe.
            Brush globe_brush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/world.jpg")));
            Material globe_material = new DiffuseMaterial(globe_brush);
            MeshGeometry3D globe_mesh = null;
            MakeSphere(TheModel, ref globe_mesh, globe_material, 1, 0, 3.75, 0, 20, 30);
        }

        // Make a rectangle. If rect_mesh is null, make a new one and add it to the model.
        // The points p1, p2, p3, p4 should be outwardly oriented.
        // The points u1, u2, u3, u4 give the texture coordinates
		// for the points p1, p2, p3, p4.
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

        // Make a cube. The points p1, p2, p3, p4 should be outwardly oriented.
        // The points p5, p6, p7, p8 should be opposite p1, p2, p3, p4 (so they are inwardly oriented).
        // The points u1, u2, u3, u4 map to the box's sides.
        private void MakeBox(Model3DGroup box_model,
            ref MeshGeometry3D box_mesh, Material box_material,
            Point3D p1, Point3D p2, Point3D p3, Point3D p4,
            Point3D p5, Point3D p6, Point3D p7, Point3D p8,
            Point u1, Point u2, Point u3, Point u4)
        {
            // Top.
            MakeRectangle(box_model, ref box_mesh, box_material, p1, p2, p3, p4, u1, u2, u3, u4);
            // Bottom.
            MakeRectangle(box_model, ref box_mesh, box_material, p8, p7, p6, p5, u1, u2, u3, u4);
            // Left.
            MakeRectangle(box_model, ref box_mesh, box_material, p1, p5, p6, p2, u1, u2, u3, u4);
            // Right.
            MakeRectangle(box_model, ref box_mesh, box_material, p3, p7, p8, p4, u1, u2, u3, u4);
            // Front.
            MakeRectangle(box_model, ref box_mesh, box_material, p2, p6, p7, p3, u1, u2, u3, u4);
            // Back.
            MakeRectangle(box_model, ref box_mesh, box_material, p4, p8, p5, p1, u1, u2, u3, u4);
        }

        // Make a sphere.
        private void MakeSphere(Model3DGroup model_group, ref MeshGeometry3D sphere_mesh, Material sphere_material,
            double radius, double cx, double cy, double cz, int num_phi, int num_theta)
        {
            // Make the mesh if we must.
            if (sphere_mesh == null)
            {
                sphere_mesh = new MeshGeometry3D();
                GeometryModel3D new_model = new GeometryModel3D(sphere_mesh, sphere_material);
                model_group.Children.Add(new_model);
            }

            double dphi = Math.PI / num_phi;
            double dtheta = 2 * Math.PI / num_theta;

            // Remember the first point.
            int pt0 = sphere_mesh.Positions.Count;

            // Make the points.
            double phi1 = Math.PI / 2;
            for (int p = 0; p <= num_phi; p++)
            {
                double r1 = radius * Math.Cos(phi1);
                double y1 = radius * Math.Sin(phi1);

                double theta = 0;
                for (int t = 0; t <= num_theta; t++)
                {
                    sphere_mesh.Positions.Add(new Point3D(
                        cx + r1 * Math.Cos(theta), cy + y1, cz + -r1 * Math.Sin(theta)));
                    sphere_mesh.TextureCoordinates.Add(new Point(
                        (double)t / num_theta, (double)p / num_phi));
                    theta += dtheta;
                }
                phi1 -= dphi;
            }

            // Make the triangles.
            int i1, i2, i3, i4;
            for (int p = 0; p <= num_phi - 1; p++)
            {
                i1 = p * (num_theta + 1);
                i2 = i1 + (num_theta + 1);
                for (int t = 0; t <= num_theta - 1; t++)
                {
                    i3 = i1 + 1;
                    i4 = i2 + 1;
                    sphere_mesh.TriangleIndices.Add(pt0 + i1);
                    sphere_mesh.TriangleIndices.Add(pt0 + i2);
                    sphere_mesh.TriangleIndices.Add(pt0 + i4);

                    sphere_mesh.TriangleIndices.Add(pt0 + i1);
                    sphere_mesh.TriangleIndices.Add(pt0 + i4);
                    sphere_mesh.TriangleIndices.Add(pt0 + i3);
                    i1 += 1;
                    i2 += 1;
                }
            }
        }

        // Make a cylinder using vectors perpendicular to the axis.
        private void MakeCylinder(Model3DGroup model_group, ref MeshGeometry3D cylinder_mesh,
            Material cylinder_material,
            double cx1, double cy1, double cz1,
            double cx2, double cy2, double cz2,
            double uv1, double uv2, double uv3, double uv4,
            double radius1, double radius2, int num_theta)
        {
            // Get the axis.
            Vector3D axis = new Vector3D(cx2 - cx1, cy2 - cy1, cz2 - cz1);

            // Just pick a vector to start from.
            Vector3D vector1 = new Vector3D(1, 0, 0);
            if (Vector3D.AngleBetween(axis, vector1) < 0.1) // See if they're parallel.
            {
                // Pick a different vector1.
                vector1 = new Vector3D(0, 0, 1);
            }

            // Find perpendicular vectors.
            Vector3D vector2 = Vector3D.CrossProduct(axis, vector1);
            vector1 = Vector3D.CrossProduct(axis, vector2);
            vector1.Normalize();
            vector2.Normalize();

            // Make the cylinder.
            MakeCylinder(model_group, ref cylinder_mesh, cylinder_material,
                cx1, cy1, cz1, cx2, cy2, cz2, uv1, uv2, uv3, uv4,
                radius1, radius2, num_theta, vector1, vector2);
        }

        // Make a cylinder. (cx1, cy2, cz1) and (cx2, cy2, cz2) are the centers of the ends.
        // vector1 and vector2 are non-parallel vectors used to build the ends. If these are missing,
        // the routine uses perpendicular unit vectors. Normally these should be unit vectors or omitted.
        private void MakeCylinder(Model3DGroup model_group, ref MeshGeometry3D cylinder_mesh,
            Material cylinder_material,
            double cx1, double cy1, double cz1,
            double cx2, double cy2, double cz2,
            double uv1, double uv2, double uv3, double uv4,
            double radius1, double radius2, int num_theta,
            Vector3D vector1, Vector3D vector2)
        {
            // Make the mesh if we must.
            if (cylinder_mesh == null)
            {
                cylinder_mesh = new MeshGeometry3D();
                GeometryModel3D new_model = new GeometryModel3D(cylinder_mesh, cylinder_material);
                model_group.Children.Add(new_model);
            }

            // Remember the index of the first point in this cylinder.
            int pt0 = cylinder_mesh.Positions.Count;

            // Make the top center point.
            cylinder_mesh.Positions.Add(new Point3D(cx1, cy1, cz1));
            cylinder_mesh.TextureCoordinates.Add(new Point(0.5, uv1));

            // Make the top edge points.
            double dtheta = 2 * Math.PI / num_theta;
            double theta = 0;
            for (int t = 0; t <= num_theta; t++)
            {
                double x = cx1 + radius1 * vector1.X * Math.Cos(theta) + radius1 * vector2.X * Math.Sin(theta);
                double y = cy1 + radius1 * vector1.Y * Math.Cos(theta) + radius1 * vector2.Y * Math.Sin(theta);
                double z = cz1 + radius1 * vector1.Z * Math.Cos(theta) + radius1 * vector2.Z * Math.Sin(theta);
                cylinder_mesh.Positions.Add(new Point3D(x, y, z));
                cylinder_mesh.TextureCoordinates.Add(new Point((double)t / num_theta, uv2));
                theta += dtheta;
            }

            // Make the bottom edge points.
            theta = 0;
            for (int t = 0; t <= num_theta; t++)
            {
                double x = cx2 + radius2 * vector1.X * Math.Cos(theta) + radius2 * vector2.X * Math.Sin(theta);
                double y = cy2 + radius2 * vector1.Y * Math.Cos(theta) + radius2 * vector2.Y * Math.Sin(theta);
                double z = cz2 + radius2 * vector1.Z * Math.Cos(theta) + radius2 * vector2.Z * Math.Sin(theta);
                cylinder_mesh.Positions.Add(new Point3D(x, y, z));
                cylinder_mesh.TextureCoordinates.Add(new Point((double)t / num_theta, uv3));
                theta += dtheta;
            }

            // Make the bottom center point.
            cylinder_mesh.Positions.Add(new Point3D(cx2, cy2, cz2));
            cylinder_mesh.TextureCoordinates.Add(new Point(0.5, uv4));

            // Make the triangles.
            int i1, i2, i3, i4, i_bottom;
            i_bottom = cylinder_mesh.Positions.Count - 1;
            i1 = 1;
            i2 = i1 + (num_theta + 1);
            for (int t = 0; t <= num_theta - 1; t++)
            {
                i3 = i1 + 1;
                i4 = i2 + 1;

                // Top.
                cylinder_mesh.TriangleIndices.Add(pt0 + 0);
                cylinder_mesh.TriangleIndices.Add(pt0 + i1);
                cylinder_mesh.TriangleIndices.Add(pt0 + i3);

                // Side.
                cylinder_mesh.TriangleIndices.Add(pt0 + i1);
                cylinder_mesh.TriangleIndices.Add(pt0 + i2);
                cylinder_mesh.TriangleIndices.Add(pt0 + i4);

                cylinder_mesh.TriangleIndices.Add(pt0 + i1);
                cylinder_mesh.TriangleIndices.Add(pt0 + i4);
                cylinder_mesh.TriangleIndices.Add(pt0 + i3);

                // Bottom.
                cylinder_mesh.TriangleIndices.Add(i_bottom);
                cylinder_mesh.TriangleIndices.Add(pt0 + i4);
                cylinder_mesh.TriangleIndices.Add(pt0 + i2);

                i1 += 1;
                i2 += 1;
            }
        }    
    }
}