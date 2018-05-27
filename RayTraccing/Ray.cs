
namespace RayTraccing
{
    class Ray
    {
        Vec3 origin;

        public Vec3 Origin
        {
            get { return origin; }
        }

        Vec3 direction;

        public Vec3 Direction
        {
            get { return direction; }
        }

        public Ray(Vec3 origin, Vec3 direction)
        {
            this.origin = origin;
            this.direction = direction;
        }
        public Vec3 GetPoint(double t)
        {
            return Origin + Direction * t;
        }
    }
}
