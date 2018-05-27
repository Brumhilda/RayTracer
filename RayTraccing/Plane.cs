using RayTraccing.Materials;

namespace RayTraccing.Geometries
{
    class Plane : Figure
    {
        Vec3 normal;
        double d;
        Vec3 position;

        public Plane(Vec3 normal, double d, Material material = null)
            : base(material)
        {
            this.normal = normal;
            this.d = d;
        }
        public override void Initialize()
        {
            position = normal * d;
        }
        public override Hit Intersect(Ray ray)
        {
            double a = ray.Direction ^ normal;
            if (a >= 0)
                return null;
            double b = normal ^ (ray.Origin - position);
            double distance = -b / a;
            return new Hit(this, distance, ray.GetPoint(distance), normal);
        }
    }
}
