using System;
using System.Drawing;
using RayTraccing.Lights;

namespace RayTraccing.Materials
{
    class SphereMaterial : Material
    {
        double shininess;

        public double Shininess
        {
            get { return shininess; }
            set { shininess = value; }
        }

        double transparency;

        public double Transparency
        {
            get { return transparency; }
            set { transparency = value; }
        }

        int illumination;

        public int Illumination
        {
            get { return illumination; }
            set { illumination = value; }
        }

        MyColor ambientColor;

        public MyColor AmbientColor
        {
            get { return ambientColor; }
            set { ambientColor = value; }
        }

        MyColor specularColor;

        public MyColor SpecularColor
        {
            get { return specularColor; }
            set { specularColor = value; }
        }

        public SphereMaterial(MyColor ambientColor, MyColor diffuseColor, MyColor specularColor, double shininess, double reflectiveness = 0)
            : base(reflectiveness)
        {
            this.ambientColor = ambientColor;
            this.specularColor = specularColor;
            this.shininess = shininess;
            materialColor = diffuseColor;
        }

        public override MyColor GetColor(Ray ray, Light lightSample, Vec3 normal, Vec3 position)
        {
            double NdotL = normal ^ lightSample.Vector;
            Vec3 H = (lightSample.Vector - ray.Direction).Normalize();
            double NdotH = normal ^ H;
            MyColor ambientTerm = ambientColor;
            MyColor diffuseTerm = materialColor;
            diffuseTerm = diffuseTerm*(Math.Max(NdotL, 0));
            MyColor specularTerm = specularColor;
            specularTerm =specularColor*(Math.Pow(Math.Max(NdotH, 0), shininess));
            MyColor color = lightSample.Irradiance*(ambientTerm+diffuseTerm+specularTerm);
            return color;
        }
    }
}
