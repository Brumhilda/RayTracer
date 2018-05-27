using System;
using System.Drawing;
using System.Windows.Forms;
using static Tao.OpenGl.Gl;
using static Tao.FreeGlut.Glut;
using RayTraccing;
using RayTraccing.Geometries;
using RayTraccing.Lights;
using RayTraccing.Materials;
using System.Diagnostics;


namespace RayTraccing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var time = new Stopwatch();
            time.Start();
            RayTraccing();
            time.Stop();
            MessageBox.Show(string.Format("Time of tracing: {0:00} seconds {1:00} milliseconds", time.Elapsed.Seconds, time.Elapsed.Milliseconds / 10));
        }

        void RayTraccing()
        {
            var width = pictureBox1.Width;
            var height = pictureBox1.Height;
            Scene.camera = new Camera(new Vec3(0, 5, 15), new Vec3(0, 0, -1), new Vec3(0, 1, 0), 90);
            Lighting lights = new Lighting();
            lights.Add(new LightClass(new MyColor(1,1,1), new Vec3(0.5, -1, -1)));
            Scene.lights = lights;
            Scene.figures = FigureList();
            Scene.Initialize();
            TraccedImage image = new TraccedImage(height,width);
            pictureBox1.Image = image.GetImage();
        }

        Figures FigureList()
        {
            Figures figures = new Figures();
            figures.Add(new Plane(new Vec3(0, 0, 1), -30, new SolidMaterial(new MyColor(0.2,0.2,0.2), 0.5, 0)));
            figures.Add(new Plane(new Vec3(1, 0, 0), -30, new SolidMaterial(new MyColor(0.1,0.1,0.1), 0.5, 0.2)));
            figures.Add(new Plane(new Vec3(-1, 0, 0), -30, new SolidMaterial(new MyColor(0.4, 0.4, 0.4), 0.5, 0.2)));
            figures.Add(new Plane(new Vec3(0, 1, 0), 0, new SolidMaterial(new MyColor(0.5, 0.5, 0.5), 0.5, 0.2)));
            figures.Add(new Sphere(new Vec3(-10, 10, -10), 5, new SphereMaterial(new MyColor(0, 0, 0), new MyColor(1, 0, 1), new MyColor(1, 1, 1), 16, 0.2)));
            figures.Add(new Sphere(new Vec3(-5, 23, -15), 6, new SphereMaterial(new MyColor(0, 0, 0), new MyColor(1, 1, 0), new MyColor(1, 1, 1), 16, 0.2)));
            figures.Add(new Sphere(new Vec3(10, 10, -10), 8, new SphereMaterial(new MyColor(0, 0, 0), new MyColor(0, 1, 1), new MyColor(1, 1, 1), 16, 0.6)));
            figures.Add(new Sphere(new Vec3(-15, 3, -5), 2, new SphereMaterial(new MyColor(0, 0, 0), new MyColor(0, 1, 0), new MyColor(1, 1, 1), 16, 0)));
            return figures;
        }
    }
}
