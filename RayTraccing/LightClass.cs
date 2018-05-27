using RayTraccing.Geometries;

namespace RayTraccing.Lights
{
    class LightClass
    {
        Vec3 vector;
        MyColor irradiance;

        public LightClass(MyColor irradiance, Vec3 direction)
        {
            this.irradiance = irradiance;
            vector = -direction.Normalize();
        }

        public virtual Light GetColor(Figure geometry, Vec3 position)
        {
            return new Light(vector, irradiance);
        }

        public virtual void Initialize()
        {
        }
    }
}
