using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using RayTraccing.Geometries;
using RayTraccing.Lights;

namespace RayTraccing
{
    static class Scene
    {
        static public Figures figures;
        static public Lighting lights;
        static public Camera camera;

        public static void Initialize()
        {
            figures.Initialize();
            lights.Initialize();
            camera.Initialize();
        }
    }
}
