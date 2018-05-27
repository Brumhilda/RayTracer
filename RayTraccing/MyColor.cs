using System;
using System.Drawing;

namespace RayTraccing
{
    class MyColor
    {
        double r;

        public double R
        {
            get { return r; }
        }

        double g;

        public double G
        {
            get { return g; }
        }

        double b;

        public double B
        {
            get { return b; }
        }

        public MyColor(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
        public static MyColor operator -(MyColor c)
        {
            return new MyColor(-c.r, -c.g, -c.b);
        }
        public static MyColor operator +(MyColor c1, MyColor c2)
        {
            return new MyColor(c1.r + c2.r, c1.g + c2.g, c1.b + c2.b);
        }
        public static MyColor operator *(MyColor c1, double d)
        {
            return new MyColor(c1.r * d, c1.g * d, c1.b * d);
        }
        public static MyColor operator *(MyColor c1, MyColor c2)
        {
            return new MyColor(c1.r * c2.r, c1.g * c2.g, c1.b * c2.b);
        }
        public Color GetSystemColor()
        {
            int rr = Math.Max(Math.Min((int)(r * 255), 255), 0);
            int gg = Math.Max(Math.Min((int)(g * 255), 255), 0);
            int bb = Math.Max(Math.Min((int)(b * 255), 255), 0);
            return Color.FromArgb(255, rr, gg, bb);
        }
    }
}
