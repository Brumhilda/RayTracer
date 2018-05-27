
namespace RayTraccing
{
    class Vec2
    {
        double x;

        public double X
        {
            get { return x; }
        }

        double y;

        public double Y
        {
            get { return y; }
        }

        public Vec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vec2 operator +(Vec2 v1, Vec2 v2)
        {
            return new Vec2(v1.x + v2.x, v1.y + v2.y);
        }

        public static Vec2 operator *(Vec2 v, double d)
        {
            return new Vec2(v.X * d, v.Y * d);
        }
    }
}
