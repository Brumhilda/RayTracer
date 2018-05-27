using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using RayTraccing.Geometries;
using RayTraccing.Lights;
using RayTraccing;

namespace RayTraccing
{
    public class TraccedImage
    {
        int width;
        int height;
        int reflectDeep;
        Bitmap PixelMap;
        public TraccedImage(int height, int width)
        {
            this.width = width;
            this.height = height;
            PixelMap = new Bitmap(this.width, this.height);
        }

        public Image GetImage()
        {
            reflectDeep = 5;
            TraceImage();
            return PixelMap;
        }

        void TraceImage()
        {
            double dx = 1.0 / width,
                    dy = 1.0 / height;
            double sx, sy;
            for (int y = 0; y < height; ++y)
            {
                sy = 1 - dy * y;
                for (int x = 0; x < width; x++)
                {
                    sx = dx * x;
                    PixelMap.SetPixel(x, y, rayTracing(Scene.camera.GenerateRay(sx, sy), reflectDeep).GetSystemColor());
                }
            }
        }

        MyColor rayTracing(Ray ray, int max)
        {
            MyColor color = new MyColor(0, 0, 0);
            Hit result = Scene.figures.Intersect(ray);
            if (result == null)
                return color;
            List<Light> lights = Scene.lights.GetNotNullLight(Scene.figures, result.Position);
            foreach (var light in lights)
                color += result.Geometry.Material.GetColor(ray, light, result.Normal, result.Position);
            if (result.Geometry.Material.Reflection > 0 && max > 0)
            {
                Vec3 dir = result.Normal * (result.Normal ^ ray.Direction * (-2)) + ray.Direction;
                Ray newRay = new Ray(result.Position, dir);
                color += rayTracing(newRay, max - 1) * result.Geometry.Material.Reflection;
            }
            return color;
        }
    }
}
