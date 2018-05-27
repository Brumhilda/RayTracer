using System.Drawing;
using RayTraccing.Lights;

namespace RayTraccing.Materials
{
    abstract class Material
    {
        double reflection;
        public MyColor materialColor;

        public double Reflection
        {
            get { return reflection; }
        }

        public Material(double reflectiveness = 0)
        {
            this.reflection = reflectiveness;
        }

        public abstract MyColor GetColor(Ray ray, Light lightSample, Vec3 normal, Vec3 position);
    }
}
