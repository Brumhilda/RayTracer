using System.Collections.Generic;
using RayTraccing.Geometries;

namespace RayTraccing.Lights
{
    class Lighting
    {
        List<LightClass> lights;

        public Lighting()
        {
            lights = new List<LightClass>();
        }
        public void Add(LightClass light)
        {
            lights.Add(light);
        }
        public void Clear()
        {
            lights.Clear();
        }
        public void Initialize()
        {
            foreach (LightClass light in lights)
                light.Initialize();
        }
        public List<Light> GetNotNullLight(Figure geometry, Vec3 position)
        {
            List<Light> list = new List<Light>();
            foreach (LightClass light in lights)
            {
                Light lightSample = light.GetColor(geometry, position);
                if (lightSample != null)
                    list.Add(lightSample);
            }
            return list;
        }

    }
}
