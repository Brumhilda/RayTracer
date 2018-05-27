using System;
using System.Drawing;
using RayTraccing.Lights;

namespace RayTraccing.Materials
{
    class SolidMaterial : Material
    {
        double scale;

        public SolidMaterial(MyColor col,double scale, double reflectiveness = 0)
            : base(reflectiveness)
        {
            this.scale = scale;
            materialColor = col;
        }
        public override MyColor GetColor(Ray ray, Light lightSample, Vec3 normal, Vec3 position)
        {
            return materialColor;
        }
    }
}
