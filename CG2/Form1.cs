using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using static Tao.OpenGl.Glu;
using static Tao.OpenGl.Gl;
using static Tao.FreeGlut.Glut;
using Tao.DevIl;
using Tao.Platform.Windows;
using System.IO;
using System.Drawing.Imaging;


namespace CG2
{
    public partial class myForm : Form
    {
        public static uint mGlTextureObject;
        public myForm()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            this.KeyDown += new KeyEventHandler(Translate);
        }

        private void Translate(object sender, KeyEventArgs e)
        {
            Matrix.Make();
            switch (e.KeyCode)
            {
                case Keys.NumPad8:
                    Camera.Up();
                    break;
                case Keys.NumPad2:
                    Camera.Down();
                    break;
                case Keys.NumPad6:
                    Camera.Right();
                    break;
                case Keys.NumPad4:
                    Camera.Left();
                    break;
                case Keys.X:
                    Camera.RotateX();
                    break;
                case Keys.Y:
                    Camera.RotateY();
                    break;
                case Keys.Z:
                    Camera.RotateZ();
                    break;
                case Keys.Oemplus:
                    Camera.Closer();
                    break;
                case Keys.OemMinus:
                    Camera.Farther();
                    break;
                default:
                    Camera.Update();
                    break;
            }
            glutSolidSphere(0.5, 32, 32);
            simpleOpenGlControl1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            glutInit();
            glutInitDisplayMode(GLUT_RGB | GLUT_DOUBLE | GLUT_DEPTH);
            glClearColor(0.00f, 0.00f, 0.00f, 1);
            glViewport(0, 0, simpleOpenGlControl1.Width, simpleOpenGlControl1.Height);
            Matrix.Make();
            glutSolidSphere(0.5,32,32);
            simpleOpenGlControl1.Invalidate();

        }



        public void RayTracing()
        {

        }

        //void SetTexture()
        //{
        //    var bitmap = new Bitmap("1.jpg");
        //    glEnable(GL_TEXTURE_2D);
        //    glPixelStorei(GL_UNPACK_ALIGNMENT, 1);

        //    BitmapData data;
        //    Rectangle Rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
        //    data = bitmap.LockBits(Rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppRgb);
        //    glTexImage2D(GL_TEXTURE_2D, 0, 3,
        //                 data.Width,
        //                 data.Height,
        //                 0, GL_BGRA, GL_UNSIGNED_BYTE,
        //                 data.Scan0);
        //    bitmap.UnlockBits(data);
        //    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_NEAREST);
        //    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_NEAREST);
        //}

        //void Display()
        //{
        //    Bitmap background = new Bitmap("1.jpg");
        //    byte[] bitmap_mark = { 0x10, 0x10, 0x10, 0xFF, 0x10, 0x10, 0x10 };

        //    // Ñâîéñòâà ðàñïàêîâêè
        //    glPixelStorei(GL_UNPACK_ALIGNMENT, 1);
        //    // Ïîçèöèÿ âûâîäà ðàñòðà
        //    glRasterPos2d(0, 0);
        //    glPixelZoom(1, 1);
        //    //glBitmap(background.Width, background.Height,4,7,0,0,ImageToByteArray(background));
        //    // glPixelStorei(GL_UNPACK_ALIGNMENT, 1);
        //    byte[] b = ImageToByteArray(background);
        //    BitmapData data;
        //    Rectangle Rect = new Rectangle(0, 0, background.Width, background.Height);
        //    data = background.LockBits(Rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppRgb);
        //    glDrawPixels(data.Width, data.Height, GL_BGRA, GL_UNSIGNED_BYTE, data.Scan0);
        //    background.UnlockBits(data);

        //}


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    FileStream fs = new FileStream("positions.txt", FileMode.Open);
        //    StreamWriter sw = new StreamWriter(fs);
        //    sw.WriteLine("-Position-");
        //    sw.WriteLine("X:" + Camera.x);
        //    sw.WriteLine("Y:" + Camera.y);
        //    sw.WriteLine("Z:" + Camera.z);
        //    sw.WriteLine("angleX:" + Camera.angleX);
        //    sw.WriteLine("angleY:" + Camera.angleY);
        //    sw.WriteLine("angleZ:" + Camera.angleZ);
        //    sw.WriteLine("Size:" + Camera.size);
        //    sw.Close();
        //    fs.Close();
        //}

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleOpenGlControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}