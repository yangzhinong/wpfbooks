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

namespace Gasket3D
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

        // *****************************
        // Application code starts here.
        // *****************************
        // Build the model.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboLevel.SelectedIndex = m_Level;
            BuildModel();
        }

        // Make the gasket at the new level.
        private void cboLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            m_Level = cboLevel.SelectedIndex;
            BuildModel();
        }

        #region "Model Building"

        private int m_Level = 1;

        // Build the model.
        private void BuildModel()
        {
            if (this.GasketModel == null) return;

            // Start from scratch.
            for (int i = this.GasketModel.Children.Count - 1; i >= 0; i--)
            {
                if (this.GasketModel.Children[i] is GeometryModel3D)
                {
                    this.GasketModel.Children.RemoveAt(i);
                }
            }

            // Make the material.
            BitmapImage image_source = new BitmapImage(new Uri("wood.jpg", UriKind.Relative));
            ImageBrush br = new ImageBrush(image_source);
            br.ViewportUnits = BrushMappingMode.Absolute;
            DiffuseMaterial the_material = new DiffuseMaterial(br);

            // Make the gasket.
            MakeGasket(this.GasketModel, the_material, m_Level,
                -1f, -1f, -1f,
                1f, 1f, 1f,
                0f, 0f, 0f,
                0.75f, 0.75f, 0.75f);
        }

        // Make a gasket in the indicated cube.
        private void MakeGasket(Model3DGroup model_group, Material model_material,
          int level,
          float xmin, float ymin, float zmin, float xmax, float ymax, float zmax,
          float umin, float vmin, float wmin, float umax, float vmax, float wmax)
        {
            if (level > 0)
            {
                // Recurse.
                level -= 1;
                float x1 = xmin + (xmax - xmin) / 3;
                float x2 = xmax - (xmax - xmin) / 3;
                float y1 = ymin + (ymax - ymin) / 3;
                float y2 = ymax - (ymax - ymin) / 3;
                float z1 = zmin + (zmax - zmin) / 3;
                float z2 = zmax - (zmax - zmin) / 3;
                float u1 = umin + (umax - umin) / 3;
                float u2 = umax - (umax - umin) / 3;
                float v1 = vmin + (vmax - vmin) / 3;
                float v2 = vmax - (vmax - vmin) / 3;
                float w1 = wmin + (wmax - wmin) / 3;
                float w2 = wmax - (wmax - wmin) / 3;
                // Front.
                // Front bottom.
                MakeGasket(model_group, model_material, level, xmin, ymin, zmin, x1, y1, z1, umin, vmin, wmin, u1, v1, w1);
                MakeGasket(model_group, model_material, level, x1, ymin, zmin, x2, y1, z1, u1, vmin, wmin, u2, v1, w1);
                MakeGasket(model_group, model_material, level, x2, ymin, zmin, xmax, y1, z1, u2, vmin, wmin, umax, v1, w1);

                // Front middle.
                MakeGasket(model_group, model_material, level, xmin, y1, zmin, x1, y2, z1, umin, v1, wmin, u1, v2, w1);
                MakeGasket(model_group, model_material, level, x2, y1, zmin, xmax, y2, z1, u2, v1, wmin, umax, v2, w1);

                // Front top.
                MakeGasket(model_group, model_material, level, xmin, y2, zmin, x1, ymax, z1, umin, v2, wmin, u1, vmax, w1);
                MakeGasket(model_group, model_material, level, x1, y2, zmin, x2, ymax, z1, u1, v2, wmin, u2, vmax, w1);
                MakeGasket(model_group, model_material, level, x2, y2, zmin, xmax, ymax, z1, u2, v2, wmin, umax, vmax, w1);

                // Middle.
                // Middle bottom.
                MakeGasket(model_group, model_material, level, xmin, ymin, z1, x1, y1, z2, umin, vmin, w1, u1, v1, w2);
                MakeGasket(model_group, model_material, level, x2, ymin, z1, xmax, y1, z2, u2, vmin, w1, umax, v1, w2);

                // Middle top.
                MakeGasket(model_group, model_material, level, xmin, y2, z1, x1, ymax, z2, umin, v2, w1, u1, vmax, w2);
                MakeGasket(model_group, model_material, level, x2, y2, z1, xmax, ymax, z2, u2, v2, w1, umax, vmax, w2);

                // Back.
                // Back bottom.
                MakeGasket(model_group, model_material, level, xmin, ymin, z2, x1, y1, zmax, umin, vmin, w2, u1, v1, wmax);
                MakeGasket(model_group, model_material, level, x1, ymin, z2, x2, y1, zmax, u1, vmin, w2, u2, v1, wmax);
                MakeGasket(model_group, model_material, level, x2, ymin, z2, xmax, y1, zmax, u2, vmin, w2, umax, v1, wmax);

                // Back middle.
                MakeGasket(model_group, model_material, level, xmin, y1, z2, x1, y2, zmax, umin, v1, w2, u1, v2, wmax);
                MakeGasket(model_group, model_material, level, x2, y1, z2, xmax, y2, zmax, u2, v1, w2, umax, v2, wmax);

                // Back top.
                MakeGasket(model_group, model_material, level, xmin, y2, z2, x1, ymax, zmax, umin, v2, w2, u1, vmax, wmax);
                MakeGasket(model_group, model_material, level, x1, y2, z2, x2, ymax, zmax, u1, v2, w2, u2, vmax, wmax);
                MakeGasket(model_group, model_material, level, x2, y2, z2, xmax, ymax, zmax, u2, v2, w2, umax, vmax, wmax);
            } else {
                // Draw a box here.
                MakeBox(model_group, model_material,
                    xmin, ymin, zmin, xmax, ymax, zmax,
                    umin, vmin, wmin, umax, vmax, wmax);
            }
        }

        // Make a box.
        private void MakeBox(Model3DGroup model_group, Material model_material,
          float xmin, float ymin, float zmin, float xmax, float ymax, float zmax,
          float umin, float vmin, float wmin, float umax, float vmax, float wmax)
        {
            // Top.
            MakeRectangle(model_group, model_material,
                new Point3D(xmin, ymax, zmin),
                new Point3D(xmin, ymax, zmax),
                new Point3D(xmax, ymax, zmax),
                new Point3D(xmax, ymax, zmin),
                new Point(umin, wmin),
                new Point(umin, wmax),
                new Point(umax, wmax),
                new Point(umax, wmin));
            // Bottom.
            MakeRectangle(model_group, model_material,
                new Point3D(xmax, ymin, zmin),
                new Point3D(xmax, ymin, zmax),
                new Point3D(xmin, ymin, zmax),
                new Point3D(xmin, ymin, zmin),
                new Point(umax, wmin),
                new Point(umax, wmax),
                new Point(umin, wmax),
                new Point(umin, wmin));
            // Front.
            MakeRectangle(model_group, model_material,
                new Point3D(xmin, ymin, zmin),
                new Point3D(xmin, ymax, zmin),
                new Point3D(xmax, ymax, zmin),
                new Point3D(xmax, ymin, zmin),
                new Point(umin, vmin),
                new Point(umin, vmax),
                new Point(umax, vmax),
                new Point(umax, vmin));
            // Back.
            MakeRectangle(model_group, model_material,
                new Point3D(xmax, ymin, zmax),
                new Point3D(xmax, ymax, zmax),
                new Point3D(xmin, ymax, zmax),
                new Point3D(xmin, ymin, zmax),
                new Point(umax, vmin),
                new Point(umax, vmax),
                new Point(umin, vmax),
                new Point(umin, vmin));
            // Left.
            MakeRectangle(model_group, model_material,
                new Point3D(xmin, ymin, zmax),
                new Point3D(xmin, ymax, zmax),
                new Point3D(xmin, ymax, zmin),
                new Point3D(xmin, ymin, zmin),
                new Point(wmax, vmin),
                new Point(wmax, vmax),
                new Point(wmin, vmax),
                new Point(wmin, vmin));
            // Right.
            MakeRectangle(model_group, model_material,
                new Point3D(xmax, ymin, zmin),
                new Point3D(xmax, ymax, zmin),
                new Point3D(xmax, ymax, zmax),
                new Point3D(xmax, ymin, zmax),
                new Point(wmin, vmin),
                new Point(wmin, vmax),
                new Point(wmax, vmax),
                new Point(wmax, vmin));
        }

        // Make an outwardly-oriented square with texture.
        private void MakeRectangle(Model3DGroup model_group, Material model_material,
            Point3D pt0, Point3D pt1, Point3D pt2, Point3D pt3,
            Point u0, Point u1, Point u2, Point u3)
        {
            // Define the new mesh geometry.
            MeshGeometry3D new_mesh = new MeshGeometry3D();
            // Define the corner points.
            Point3D [] pt3Ds = {
                new Point3D(pt0.X, pt0.Y, pt0.Z),
                new Point3D(pt1.X, pt1.Y, pt1.Z),
                new Point3D(pt2.X, pt2.Y, pt2.Z),
                new Point3D(pt3.X, pt3.Y, pt3.Z)
            };
            new_mesh.Positions = new Point3DCollection(pt3Ds);

            // Define which points make up the triangles.
            new_mesh.TriangleIndices = new Int32Collection();
            new_mesh.TriangleIndices.Add(0);
            new_mesh.TriangleIndices.Add(1);
            new_mesh.TriangleIndices.Add(2);

            new_mesh.TriangleIndices.Add(0);
            new_mesh.TriangleIndices.Add(2);
            new_mesh.TriangleIndices.Add(3);

            // Set the texture coordinates.
            new_mesh.TextureCoordinates = new PointCollection();
            new_mesh.TextureCoordinates.Add(u0);
            new_mesh.TextureCoordinates.Add(u1);
            new_mesh.TextureCoordinates.Add(u2);
            new_mesh.TextureCoordinates.Add(u3);

            // Set the model's material.
            GeometryModel3D new_model = new GeometryModel3D(new_mesh, model_material);

            // Add the new model to the model group.
            model_group.Children.Add(new_model);
        }
        #endregion // Model Building
    
    }
}