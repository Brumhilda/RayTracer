using System;
using static Tao.OpenGl.Gl;
using static Tao.FreeGlut.Glut;
using RayTraccing.Materials;

namespace RayTraccing.Geometries
{
    class Sphere : Figure
    {
        Vec3 center;
        double radius;

        public Sphere(Vec3 center, double radius, Material material = null)
            :base (material)
        {
            this.center = center;
            this.radius = radius;
        }
        public override Hit Intersect(Ray ray)
        {
            Vec3 pos = ray.Origin - center;
            double equationCircle = pos.Length()*pos.Length() - radius * radius,
                exs = ray.Direction ^ pos,
                discr = exs * exs - equationCircle;
            if (exs <= 0 && discr >= 0)
            {
                    double distance = -exs - Math.Sqrt(discr);
                    Vec3 position = ray.GetPoint(distance);
                    Vec3 normal = (position - center).Normalize();
                    Hit result = new Hit(this, distance, position, normal);
                    return result;
            }
            return null;
        }
    }
}
