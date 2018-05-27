using System.Drawing;

namespace RayTraccing.Lights
{
    class Light
    {
        Vec3 light;

        public Vec3 Vector
        {
            get { return light; }
        }

        MyColor irradiance;

        public MyColor Irradiance
        {
            get { return irradiance; }
        }

        public Light(Vec3 vector, MyColor irradiance)
        {
            this.light = vector;
            this.irradiance = irradiance;
        }
    }
}
