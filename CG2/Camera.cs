using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using static Tao.OpenGl.Glu;
using static Tao.OpenGl.Gl;

namespace CG2
{
    public static class Camera
    {
        //initial coordinates is 0,0,0.1 0,0,0 0,1,0
        public static double x = 0.00;
        public static double y = 0.00;
        public static double z = 0.00;
        public static double angleX = 0.00;
        public static double angleY = 0.00;
        public static double angleZ = 0.00;
        public static double size = 0;
        private const double increment = 0.1;
        private const double incrementForRotate = 1;
        public static void Left()
        {
            x -= increment;
            Update();
        }

        public static void Right()
        {
            x += increment;
            Update();
        }

        public static void Up()
        {
            y += increment;
            Update();
        }

        public static void Down()
        {
            y -= increment;
            Update();
        }

        public static void RotateX()
        {
            angleX += incrementForRotate;
            Update();
        }

        public static void RotateY()
        {
            angleY += incrementForRotate;
            Update();
        }

        public static void RotateZ()
        {
            angleZ += incrementForRotate;
            Update();
        }

        public static void Closer()
        {
            size+=increment;
            Update();
        }

        public static void Farther()
        {
            size -= increment;
            Update();
        }

        public static void Update()
        {
            glTranslated(x, y, z);
            glRotated(angleX, 1, 0, 0);
            glRotated(angleY, 0, 1, 0);
            glRotated(angleZ, 0, 0, 1);
        }
    }
}
